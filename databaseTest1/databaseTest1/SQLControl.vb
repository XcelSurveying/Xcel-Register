Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
    Implements IDisposable

    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet
    Public SQLCon As SqlConnection
    Dim Cursor As Cursor

    'Public SQLCon As New SqlConnection With {.ConnectionString = "server=" & My.Settings.settingsDbServerName & ";Database=register;user=" & My.Settings.settingDbUserId & ";Pwd=" & My.Settings.settingsDbPassword & ";"}

    '("server=" & My.Settings.settingsDbServerName & ";Database=register;user=" & My.Settings.settingDbUserId & ";Pwd=" & My.Settings.settingsDbPassword & ";")
    Public connectionString As String = ("Data Source=" & My.Settings.settingsDbServerName & "," & My.Settings.settingsDbServerPort & ";Network Library=DBMSSOCN;Initial Catalog=register;User ID=" & My.Settings.settingDbUserId & ";Password=" & My.Settings.settingsDbPassword & ";")


    Public Function HasConnection() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            connectionString = ("Data Source=" & My.Settings.settingsDbServerName & "," & My.Settings.settingsDbServerPort & ";Network Library=DBMSSOCN;Initial Catalog=register;User ID=" & My.Settings.settingDbUserId & ";Password=" & My.Settings.settingsDbPassword & ";")
            SQLCon = New SqlConnection(connectionString)
            If My.Settings.settingsIsActiveMessage = True Then
                SQLCon.Open()
                SQLCon.Close()
                Return True
            Else
                SQLCon.Dispose()
                formNewDatabaseWizard.Show()
                Return False
            End If

        Catch ex As Exception
            SQLCon.Dispose()
            MessageBox.Show(ex.ToString.Substring(0, 100))
            'Read's the error message string. 
            Try
                Select Case ex.ToString.Substring(0, 100)
                    'Username is correct but No database found ---> database is setup and the tables are created.
                    Case "System.Data.SqlClient.SqlException (0x80131904): Cannot open database ""register"" requested by the lo"
                        MessageBox.Show("Can't connect to a the 'register' database. Please run the Database Setup.", "SQL Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Case "A network-related or instance-specific error occurred while establishing a connection to SQL Server."
                        MessageBox.Show("Can't connect to a the SQL Server. Please run the Database Setup and change the 'Database Server Path' to point to the correct server.", "SQL Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case Else
                        'Shows error message
                        MessageBox.Show(ex.Message, "SQL Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            Catch ex1 As Exception
            End Try
            formNewDatabaseWizard.Show()
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLCon = New SqlConnection(connectionString)
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)

            ' LOAD SQL RECORDS FOR DATAGRID
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataset = New DataSet
            SQLDA.Fill(SQLDataset)

            SQLCon.Close()
        Catch ex As Exception

            MessageBox.Show(ex.ToString, "SQL Run Query", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If

        End Try
    End Sub

    Public Sub DataUpdate(command As String)
        Try
            SQLCon = New SqlConnection(connectionString)
            SQLCon.Open()
            SQLCmd = New SqlCommand(command, SQLCon)

            Dim ChangeCount As Integer = SQLCmd.ExecuteNonQuery 'Returns integer value of the records changed 

            SQLCon.Close()

            ' REPORT RESULTS
            If ChangeCount = 0 Then
                MessageBox.Show("The item you wanted to update could not be found", "SQL Update Database", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show(ChangeCount & " records updated", "SQL Update Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SQL Update Database", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If HasConnection() = False Then
                SQLCon.Close()
                'MessageBox.Show("Recovered: Connection Closed successfully", "SQL Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Try
    End Sub



#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
