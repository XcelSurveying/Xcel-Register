Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class formNewDatabaseWizard
    Dim SQL As New SQLControl
    Dim MainFormButtons As New MainFormButtons
    'Dim testConnectionString As String

    Private Sub formNewDatabaseWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form Settings
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.TopMost = False

        ' Disable modification of username and passsword, It is now going to be fixed as (sa, XcelSurveying)
        txtPassword.Enabled = False
        txtUid.Enabled = False

        txtServerIP.Text = My.Settings.settingsDbServerName
        'txtServerPort.Text = My.Settings.settingsDbServerPort
        'txtUid.Text = My.Settings.settingDbUserId
        'txtPassword.Text = My.Settings.settingsDbPassword
        cmdModify.Visible = My.Settings.settingsIsActiveModify
        cmdSetupDatabase.Enabled = My.Settings.settingsIsActiveSetup
        cmd_CreateTables.Enabled = My.Settings.settingsIsActiveCreateTables
        cmdTestConn.Enabled = My.Settings.settingsIsActiveTest
        'txtUid.Enabled = My.Settings.settingsIsActiveUser
        'txtPassword.Enabled = My.Settings.settingsIsActivePass
        txtServerIP.Enabled = My.Settings.settingsIsActiveServer
        dgvSQLServers.Enabled = My.Settings.settingsIsActiveServer
        cmdSearch.Enabled = My.Settings.settingsIsActiveServer
        'txtServerPort.Enabled = My.Settings.settingsIsActiveServer
        lblWarning.Visible = My.Settings.settingsIsActiveWarning
        lblMessage.Visible = My.Settings.settingsIsActiveMessage

    End Sub

    Private Sub cmdSearch_click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Try
            Me.Cursor = Cursors.AppStarting 'Activates Wait cursor
            Dim dataTable As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()
            dgvSQLServers.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub


    Private Sub cmdTestConn_Click(sender As Object, e As EventArgs) Handles cmdTestConn.Click
        Try
            Me.Cursor = Cursors.AppStarting
            MainFormButtons.Disable() 'Disable buttons in main form while testing connection

            'testConnectionString = ("Server=" & txtServer.Text & ";uid=" & txtUid.Text & ";pwd=" & txtPassword.Text & ";database=master")
            'Dim myConn As SqlConnection = New SqlConnection(SQL.connectionString)

            If txtServerIP.Text <> ("") Then

                'SQL.connectionString = ("server=" & txtServer.Text & ";Database=register;user=" & txtUid.Text & ";Pwd=" & txtPassword.Text & ";")
                SQL.connectionString = ("Data Source=" & txtServerIP.Text & ",1433;Network Library=DBMSSOCN;Initial Catalog=register;User ID=sa;Password=XcelSurveying;")

                'Tries to open and close a connection to the database server using the connection string variables from the textboxes
                SQL.SQLCon = New SqlConnection(SQL.connectionString)
                SQL.SQLCon.Open()
                SQL.SQLCon.Close()

                'Once connected makes the create tables button active and shows the connected label
                lblMessage.Visible = True
                cmd_CreateTables.Enabled = True
                cmdModify.Visible = True
                cmdModify.Enabled = True

                cmdSetupDatabase.Enabled = False 'once connected, that means that the database has already been created
                txtPassword.Enabled = False
                txtServerIP.Enabled = False
                dgvSQLServers.Enabled = False
                cmdSearch.Enabled = False
                'txtServerPort.Enabled = False
                txtUid.Enabled = False
                cmdTestConn.Enabled = False

                My.Settings.settingsDbServerName = txtServerIP.Text
                'My.Settings.settingsDbServerPort = txtServerPort.Text
                My.Settings.settingDbUserId = txtUid.Text
                My.Settings.settingsDbPassword = txtPassword.Text
                My.Settings.Save()

                'updates the connection string label on the main window (bottom right)
                formMain.lblConnectionString.Text = SQL.connectionString

            Else
                lblWarning.Text = "Warning: Server or User fields can't be blank"
                lblWarning.Visible = True
            End If

            'Positive Connection established, re-enable the main form buttons
            MainFormButtons.Enable()

            Return
        Catch ex As Exception
            Try
                'On error saves the new textbox.text settings and updates the connection string label in the main window.
                My.Settings.settingsDbServerName = txtServerIP.Text
                'My.Settings.settingsDbServerPort = txtServerPort.Text
                My.Settings.settingDbUserId = txtUid.Text
                My.Settings.settingsDbPassword = txtPassword.Text
                My.Settings.Save()
                formMain.lblConnectionString.Text = SQL.connectionString

                'MessageBox.Show(ex.ToString.Substring(0, 100))
                'Read's the error message string. 
                Select Case ex.ToString.Substring(0, 100)
                    'Username is correct but No database found ---> database is setup and the tables are created.
                    Case "System.Data.SqlClient.SqlException (0x80131904): Cannot open database ""register"" requested by the lo"
                        MessageBox.Show("""register"" database not found. It will be created now.")
                        'Runs the database setup
                        cmdSetupDatabase_Click(AcceptButton, AcceptButton)
                        'Wait 5 seconds after the database has been created to start adding tables
                        System.Threading.Thread.Sleep(5000)
                        'Runs the tables setup
                        cmd_CreateTables_Click(AcceptButton, AcceptButton)
                    Case Else
                        'Shows error message
                        MessageBox.Show(ex.Message)
                End Select
            Catch ex1 As Exception
                MessageBox.Show(ex.Message)
            End Try
        Finally
            Me.Cursor = Cursors.Default 'Restore default sursor
        End Try

    End Sub


    Private Sub cmdSetupDatabase_Click(sender As Object, e As EventArgs) Handles cmdSetupDatabase.Click

        Dim queryString As String
        Dim myConn As SqlConnection
        'myConn = New SqlConnection("Server=" & My.Settings.settingsDbServerName & ";uid=" & My.Settings.settingDbUserId & ";pwd=" & My.Settings.settingsDbPassword & ";database=master")

        myConn = New SqlConnection("Data Source=" & My.Settings.settingsDbServerName & ",1433;Network Library=DBMSSOCN;database=master;User ID=sa;Password=XcelSurveying;")

        Try
            '(INSERT HERE) <-- test for same computer that is running SQL server, then install if is server else skip

            queryString = ("CREATE DATABASE register ON PRIMARY " & vbCrLf & _
                           "( NAME = register_dat, " & vbCrLf & _
                           "FILENAME = 'C:\XCELregister\registerDAT.mdf', " & vbCrLf & _
                           "Size = 10, " & vbCrLf & _
                           "--MAXSIZE    = 5, " & vbCrLf & _
                           "FILEGROWTH = 5 ) " & vbCrLf & _
                           "LOG ON" & vbCrLf & _
                           "( NAME = register_log, " & vbCrLf & _
                           "FILENAME = 'C:\XCELregister\registerLOG.ldf', " & vbCrLf & _
                           "SIZE = 5MB, " & vbCrLf & _
                           "--MAXSIZE = 25MB, " & vbCrLf & _
                           "FILEGROWTH = 5MB ) ; ")

            Dim createDB As SqlCommand = New SqlCommand(queryString, myConn)



            myConn.Open()
            createDB.ExecuteNonQuery()
            MessageBox.Show("Database is created successfully", _
                        "MyProgram", MessageBoxButtons.OK, _
                         MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            MessageBox.Show("Database creation failed", _
                        "MyProgram", MessageBoxButtons.OK, _
                         MessageBoxIcon.Error)
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try

    End Sub

    Private Sub cmd_CreateTables_Click(sender As Object, e As EventArgs) Handles cmd_CreateTables.Click

        SQL.DataUpdate("USE register " & vbCrLf & _
                        "CREATE TABLE AreaCalcChecklist " & vbCrLf & _
                        "( " & vbCrLf & _
                        "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                        ",[Model/Layer] nvarchar(30) " & vbCrLf & _
                        ",[Drawing Number] nvarchar(30) " & vbCrLf & _
                        ",[TQ/RFI] nvarchar(10) " & vbCrLf & _
                        ",[Calc'd by] nvarchar(50) " & vbCrLf & _
                        ",[Calc'd date] date " & vbCrLf & _
                        ",[Checked by] nvarchar(50) " & vbCrLf & _
                        ",[Checked date] date " & vbCrLf & _
                        ",Comments nvarchar(255) " & vbCrLf & _
                        ",Created datetime2(7) " & vbCrLf & _
                        ",Modified datetime2(7) " & vbCrLf & _
                        ",Primary Key(ID) " & vbCrLf & _
                        ") " & vbCrLf & _
                        "; " & vbCrLf & _
                        "INSERT INTO AreaCalcChecklist(Comments, Created, Modified) VALUES ('Table Created', GETDATE(), GETDATE());")

        SQL.DataUpdate("USE register " & vbCrLf & _
                        "CREATE TABLE FieldDataRegister " & vbCrLf & _
                        "( " & vbCrLf & _
                        "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                        ",[Job Ref Number] nvarchar(15) " & vbCrLf & _
                        ",[Date] date " & vbCrLf & _
                        ",[Surveyor] nvarchar(50) " & vbCrLf & _
                        ",[Area] nvarchar(30) " & vbCrLf & _
                        ",[Job Type] nvarchar(20) " & vbCrLf & _
                        ",[Job Description] nvarchar(150) " & vbCrLf & _
                        ",[FLD-BK/PG] nvarchar(20) " & vbCrLf & _
                        ",[Instrument A] nvarchar(20) " & vbCrLf & _
                        ",Comments nvarchar(255) " & vbCrLf & _
                        ",Created datetime2(7) " & vbCrLf & _
                        ",Modified datetime2(7) " & vbCrLf & _
                        ",Primary Key(ID) " & vbCrLf & _
                        ") " & vbCrLf & _
                        "; " & vbCrLf & _
                        "INSERT INTO FieldDataRegister(Comments, Created, Modified) VALUES ('Table Created', GETDATE(), GETDATE());")

        SQL.DataUpdate("USE register " & vbCrLf & _
                        "CREATE TABLE SurveyReportRegister " & vbCrLf & _
                        "( " & vbCrLf & _
                        "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                        ",[Date] date " & vbCrLf & _
                        ",[Document Name] nvarchar(15) " & vbCrLf & _
                        ",[Rev] int " & vbCrLf & _
                        ",[Title] nvarchar(255) " & vbCrLf & _
                        ",[Area] nvarchar(30) " & vbCrLf & _
                        ",[Description] nvarchar(30) " & vbCrLf & _
                        ",[Surveyor] nvarchar(50) " & vbCrLf & _
                        ",Comments nvarchar(255) " & vbCrLf & _
                        ",PDFLink nvarchar(1023) " & vbCrLf & _
                        ",Created datetime2(7) " & vbCrLf & _
                        ",Modified datetime2(7) " & vbCrLf & _
                        ",Primary Key(ID) " & vbCrLf & _
                        ") " & vbCrLf & _
                        "; " & vbCrLf & _
                        "INSERT INTO SurveyReportRegister(Comments, Created, Modified) VALUES ('Table Created', GETDATE(), GETDATE());")

        SQL.DataUpdate("USE register " & vbCrLf & _
                        "CREATE TABLE TQRFIRegister " & vbCrLf & _
                        "( " & vbCrLf & _
                        "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                        ",[Drawing Number] nvarchar(30) " & vbCrLf & _
                        ",[TQ / RFI] nvarchar(30) " & vbCrLf & _
                        ",[Date Reieved] date " & vbCrLf & _
                        ",[Surveyor] nvarchar(50) " & vbCrLf & _
                        ",[Area] nvarchar(30)  " & vbCrLf & _
                        ",[Description] nvarchar(255) " & vbCrLf & _
                        ",Created datetime2(7) " & vbCrLf & _
                        ",Modified datetime2(7) " & vbCrLf & _
                        ",Primary Key(ID) " & vbCrLf & _
                        ") " & vbCrLf & _
                        "; " & vbCrLf & _
                        "INSERT INTO TQRFIRegister(Description, Created, Modified) VALUES ('Table Created', GETDATE(), GETDATE());")

        ' CREATE TABLES FOR SITE SETTINGS
        SQL.DataUpdate("USE register " & vbCrLf & _
                        "CREATE TABLE settingsCommonSurveyors " & vbCrLf & _
                        "( " & vbCrLf & _
                        "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                        ",data nvarchar(50)" & vbCrLf & _
                        ",Primary Key(ID) " & vbCrLf & _
                        ") " & vbCrLf & _
                        "; ")
        SQL.DataUpdate("USE register " & vbCrLf & _
                       "CREATE TABLE settingsTqrfiArea " & vbCrLf & _
                       "( " & vbCrLf & _
                       "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                       ",data nvarchar(50)" & vbCrLf & _
                       ",Primary Key(ID) " & vbCrLf & _
                       ") " & vbCrLf & _
                       "; ")
        SQL.DataUpdate("USE register " & vbCrLf & _
                       "CREATE TABLE settingsFieldDataArea " & vbCrLf & _
                       "( " & vbCrLf & _
                       "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                       ",data nvarchar(50)" & vbCrLf & _
                       ",Primary Key(ID) " & vbCrLf & _
                       ") " & vbCrLf & _
                       "; ")
        SQL.DataUpdate("USE register " & vbCrLf & _
                       "CREATE TABLE settingsFieldDataJobtype " & vbCrLf & _
                       "( " & vbCrLf & _
                       "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                       ",data nvarchar(50)" & vbCrLf & _
                       ",Primary Key(ID) " & vbCrLf & _
                       ") " & vbCrLf & _
                       "; ")
        SQL.DataUpdate("USE register " & vbCrLf & _
                       "CREATE TABLE settingsFieldDataInstrumentA " & vbCrLf & _
                       "( " & vbCrLf & _
                       "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                       ",data nvarchar(50)" & vbCrLf & _
                       ",Primary Key(ID) " & vbCrLf & _
                       ") " & vbCrLf & _
                       "; ")
        SQL.DataUpdate("USE register " & vbCrLf & _
                       "CREATE TABLE settingsSurveyReportArea " & vbCrLf & _
                       "( " & vbCrLf & _
                       "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                       ",data nvarchar(50)" & vbCrLf & _
                       ",Primary Key(ID) " & vbCrLf & _
                       ") " & vbCrLf & _
                       "; ")
        SQL.DataUpdate("USE register " & vbCrLf & _
                       "CREATE TABLE settingsSurveyReportDescription " & vbCrLf & _
                       "( " & vbCrLf & _
                       "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                       ",data nvarchar(50)" & vbCrLf & _
                       ",Primary Key(ID) " & vbCrLf & _
                       ") " & vbCrLf & _
                       "; ")
        SQL.DataUpdate("USE register " & vbCrLf & _
                       "CREATE TABLE settingsProjectFolder " & vbCrLf & _
                       "( " & vbCrLf & _
                       "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                       ",data nvarchar(255)" & vbCrLf & _
                       ",Primary Key(ID) " & vbCrLf & _
                       ") " & vbCrLf & _
                       "; ")


    End Sub


    Private Sub cmdModify_Click(sender As Object, e As EventArgs) Handles cmdModify.Click
        'txtUid.Enabled = True
        'txtPassword.Enabled = True
        txtServerIP.Enabled = True
        dgvSQLServers.Enabled = True
        cmdSearch.Enabled = True
        'txtServerPort.Enabled = True
        cmdTestConn.Enabled = True

        cmdSetupDatabase.Enabled = False
        cmd_CreateTables.Enabled = False
        lblMessage.Visible = False
        cmdModify.Enabled = False

    End Sub

    'CLEARS THE WARNING MESSAGE ONCE TEXT IS TYPED INTO THE TEXTBOX'S
    Private Sub allDatabaseTextFields_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServerIP.KeyPress, txtPassword.KeyPress, txtUid.KeyPress
        lblWarning.Visible = False
    End Sub

    Private Sub formNewDatabaseWizard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.settingsDbServerName = txtServerIP.Text
        'My.Settings.settingsDbServerPort = txtServerPort.Text
        My.Settings.settingDbUserId = txtUid.Text
        My.Settings.settingsDbPassword = txtPassword.Text


        My.Settings.settingsIsActiveModify = cmdModify.Visible.ToString
        My.Settings.settingsIsActiveSetup = cmdSetupDatabase.Enabled.ToString
        My.Settings.settingsIsActiveCreateTables = cmd_CreateTables.Enabled.ToString
        My.Settings.settingsIsActiveTest = cmdTestConn.Enabled.ToString
        My.Settings.settingsIsActivePass = txtPassword.Enabled.ToString
        My.Settings.settingsIsActiveServer = txtServerIP.Enabled.ToString
        My.Settings.settingsIsActiveUser = txtUid.Enabled.ToString
        My.Settings.settingsIsActiveWarning = lblWarning.Visible.ToString
        My.Settings.settingsIsActiveMessage = lblMessage.Visible.ToString

        My.Settings.Save()

        If SQL.HasConnection() = False Then
            Me.Show()
        End If

        formMain.Enabled() = True

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    
    Private Sub dgvSQLServers_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSQLServers.CellContentDoubleClick
        txtServerIP.Text = dgvSQLServers.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub
End Class