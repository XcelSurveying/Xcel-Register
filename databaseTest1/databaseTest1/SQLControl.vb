Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet
    Public SQLCon As SqlConnection
    'Public SQLCon As New SqlConnection With {.ConnectionString = "server=" & My.Settings.settingsDbServerName & ";Database=register;user=" & My.Settings.settingDbUserId & ";Pwd=" & My.Settings.settingsDbPassword & ";"}

    Public connectionString As String = ("server=" & My.Settings.settingsDbServerName & ";Database=register;user=" & My.Settings.settingDbUserId & ";Pwd=" & My.Settings.settingsDbPassword & ";")


    Public Function HasConnection() As Boolean
        Try
            connectionString = ("server=" & My.Settings.settingsDbServerName & ";Database=register;user=" & My.Settings.settingDbUserId & ";Pwd=" & My.Settings.settingsDbPassword & ";")
            SQLCon = New SqlConnection(connectionString)
            If My.Settings.settingsIsActiveMessage = True Then
                SQLCon.Open()
                SQLCon.Close()
                Return True
            Else
                SQLCon.Dispose()
                formNewDatabaseWizard.Show()
                formNewDatabaseWizard.TopMost = True
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SQL Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SQLCon.Dispose()
            formNewDatabaseWizard.Show()
            formNewDatabaseWizard.TopMost = True
            Return False
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

            MessageBox.Show(ex.Message, "SQL Run Query", MessageBoxButtons.OK, MessageBoxIcon.Error)

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



End Class
