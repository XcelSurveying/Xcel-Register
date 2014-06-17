Imports System.Data.SqlClient
Public Class formNewDatabaseWizard
    Dim SQL As New SQLControl


    Private Sub cmdTestConn_Click(sender As Object, e As EventArgs) Handles cmdTestConn.Click
        Try
            Dim myConn As SqlConnection = New SqlConnection("Server=" & txtServer.Text & ";uid=" & txtUid.Text & ";pwd=" & txtPassword.Text & ";database=master")

            If txtServer.Text <> ("") OrElse txtUid.Text <> ("") Then
                myConn.Open()
                myConn.Close()

                lblMessage.Visible = True
                cmdSetupDatabase.Enabled = True
                cmdModify.Visible = True
                cmdModify.Enabled = True

                txtPassword.Enabled = False
                txtServer.Enabled = False
                txtUid.Enabled = False
                cmdTestConn.Enabled = False

            Else
                lblWarning.Text = "Warning: Server or User fields can't be blank"
                lblWarning.Visible = True
            End If

            Return
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Sub cmdSetupDatabase_Click(sender As Object, e As EventArgs) Handles cmdSetupDatabase.Click
        Dim Str As String
        Dim myConn As SqlConnection = New SqlConnection("Server=" & txtServer.Text & ";uid=" & txtUid.Text & ";pwd=" & txtPassword.Text & ";database=master")




        Str = ("CREATE DATABASE register ON PRIMARY " & vbCrLf & _
                "( NAME = register_dat, " & vbCrLf & _
                "FILENAME = 'C:\registerDatabase\registerDAT.mdf', " & vbCrLf & _
                "Size = 10, " & vbCrLf & _
                "--MAXSIZE    = 5, " & vbCrLf & _
                "FILEGROWTH = 5 ) " & vbCrLf & _
                "LOG ON" & vbCrLf & _
                "( NAME = register_log, " & vbCrLf & _
                "FILENAME = 'C:\registerDatabase\registerLOG.ldf', " & vbCrLf & _
                "SIZE = 5MB, " & vbCrLf & _
                "--MAXSIZE = 25MB, " & vbCrLf & _
                "FILEGROWTH = 5MB ) ; ")

        Dim createDBCommand As SqlCommand = New SqlCommand(Str, myConn)

        Try
            myConn.Open()
            createDBCommand.ExecuteNonQuery()
            MessageBox.Show("Database is created successfully", _
                        "MyProgram", MessageBoxButtons.OK, _
                         MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
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
                        ",[Calc'd by] nvarchar(5) " & vbCrLf & _
                        ",[Calc'd date] date " & vbCrLf & _
                        ",[Checked by] nvarchar(5) " & vbCrLf & _
                        ",[Checked date] date " & vbCrLf & _
                        ",Comments nvarchar(255) " & vbCrLf & _
                        ",Created datetime2(7) " & vbCrLf & _
                        ",Modified datetime2(7) " & vbCrLf & _
                        ",Primary Key(ID) " & vbCrLf & _
                        ") " & vbCrLf & _
                        "; " & vbCrLf & _
                        "INSERT INTO AreaCalcChecklist(Created, Modified) VALUES (GETDATE(), GETDATE());")

        SQL.DataUpdate("USE register " & vbCrLf & _
                        "CREATE TABLE FieldDataRegister " & vbCrLf & _
                        "( " & vbCrLf & _
                        "ID int NOT NULL IDENTITY (1,1) " & vbCrLf & _
                        ",[Job Ref Number] nvarchar(15) " & vbCrLf & _
                        ",[Date] date " & vbCrLf & _
                        ",[Surveyor] nvarchar(50) " & vbCrLf & _
                        ",[Area] nvarchar(30) " & vbCrLf & _
                        ",[Job Type] nvarchar(20) " & vbCrLf & _
                        ",[job Description] nvarchar(150) " & vbCrLf & _
                        ",[FLD-BK/PG] nvarchar(10) " & vbCrLf & _
                        ",[Instrument A] nvarchar(20) " & vbCrLf & _
                        ",Comments nvarchar(255) " & vbCrLf & _
                        ",Created datetime2(7) " & vbCrLf & _
                        ",Modified datetime2(7) " & vbCrLf & _
                        ",Primary Key(ID) " & vbCrLf & _
                        ") " & vbCrLf & _
                        "; " & vbCrLf & _
                        "INSERT INTO FieldDataRegister(Created, Modified) VALUES (GETDATE(), GETDATE());")

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
                        "INSERT INTO SurveyReportRegister(Created, Modified) VALUES (GETDATE(), GETDATE());")

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
                        "INSERT INTO TQRFIRegister(Created, Modified) VALUES (GETDATE(), GETDATE());")
    End Sub

    
    Private Sub cmdModify_Click(sender As Object, e As EventArgs) Handles cmdModify.Click
        txtPassword.Enabled = True
        txtServer.Enabled = True
        txtUid.Enabled = True
        cmdTestConn.Enabled = True

        cmdSetupDatabase.Enabled = False
        lblMessage.Visible = False
        cmdModify.Enabled = False

    End Sub

    'CLEARS THE WARNING MESSAGE ONCE TEXT IS TYPED INTO THE TEXTBOX'S
    Private Sub allDatabaseTextFields_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServer.KeyPress, txtPassword.KeyPress, txtUid.KeyPress
        lblWarning.Visible = False
    End Sub

    Private Sub formNewDatabaseWizard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.settingsDbServerName = txtServer.Text
        My.Settings.settingDbUserId = txtUid.Text
        My.Settings.settingsDbPassword = txtPassword.Text


        My.Settings.settingsIsActiveModify = cmdModify.Visible.ToString
        My.Settings.settingsIsActiveSetup = cmdSetupDatabase.Enabled.ToString
        My.Settings.settingsIsActiveTest = cmdTestConn.Enabled.ToString
        My.Settings.settingsIsActivePass = txtPassword.Enabled.ToString
        My.Settings.settingsIsActiveServer = txtServer.Enabled.ToString
        My.Settings.settingsIsActiveUser = txtUid.Enabled.ToString
        My.Settings.settingsIsActiveWarning = lblWarning.Visible.ToString
        My.Settings.settingsIsActiveMessage = lblMessage.Visible.ToString


    End Sub

    Private Sub formNewDatabaseWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.settingsDbServerName
        txtUid.Text = My.Settings.settingDbUserId
        txtPassword.Text = My.Settings.settingsDbPassword
        cmdModify.Visible = My.Settings.settingsIsActiveModify
        cmdSetupDatabase.Enabled = My.Settings.settingsIsActiveSetup
        cmdTestConn.Enabled = My.Settings.settingsIsActiveTest
        txtPassword.Enabled = My.Settings.settingsIsActivePass
        txtServer.Enabled = My.Settings.settingsIsActiveServer
        txtUid.Enabled = My.Settings.settingsIsActiveUser
        lblWarning.Visible = My.Settings.settingsIsActiveWarning
        lblMessage.Visible = My.Settings.settingsIsActiveMessage

    End Sub
End Class