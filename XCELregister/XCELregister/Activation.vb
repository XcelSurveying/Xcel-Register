Imports System.Management

Public Class Activation

    Public Function WaitForActivation() As Boolean
        'DISABLE ALL BUTTONS UNTILL ACTIVATION IS PASSED
        formMain.cmdDeleteRow.Enabled = False
        formMain.cmdModifySelectedRow.Enabled = False
        formMain.cmdNewEntry.Enabled = False
        formMain.rbAreaCalcChecklist.Enabled = False
        formMain.rbFieldDataRegister.Enabled = False
        formMain.rbSurveyReportRegister.Enabled = False
        formMain.rbTqRfiRegister.Enabled = False
        Try
            Dim serial As Long = GetSerial()

            If CheckKeyFromSettings() = True Then
                ' Enable disabled buttons Activation passes
                formMain.cmdDeleteRow.Enabled = True
                formMain.cmdModifySelectedRow.Enabled = True
                formMain.cmdNewEntry.Enabled = True
                formMain.rbAreaCalcChecklist.Enabled = True
                formMain.rbFieldDataRegister.Enabled = True
                formMain.rbSurveyReportRegister.Enabled = True
                formMain.rbTqRfiRegister.Enabled = True

                Return True
            End If

            Dim inputKey As Long = InputBox("Enter the Activation key for Serial: " & serial, "Activate")
            If CheckKey(inputKey) = True Then
                MessageBox.Show("Activation Sucessful!")

                formMain.cmdDeleteRow.Enabled = True
                formMain.cmdModifySelectedRow.Enabled = True
                formMain.cmdNewEntry.Enabled = True
                formMain.rbAreaCalcChecklist.Enabled = True
                formMain.rbFieldDataRegister.Enabled = True
                formMain.rbSurveyReportRegister.Enabled = True
                formMain.rbTqRfiRegister.Enabled = True


                My.Settings.activationKey = inputKey
                My.Settings.Save()
                Return True
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
        
    End Function

    Public Function GetSerial() As Long
        Try
            Dim mc As New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim mac As String = ""
            'Getting network adapters collection
            Dim moc As ManagementObjectCollection = mc.GetInstances

            'Here we iterate over available network adapters, 
            'picking the first possible one
            For Each mo As ManagementObject In moc
                If mo.Item("IPEnabled") Then
                    mac = mo.Item("MacAddress").ToString
                    Exit For
                End If
            Next

            mc.Dispose()

            'This is a simple function that we use to get a serial out
            'of our MAC address. Say that x is the MAC and y is the serial,
            'the function would be y += x[i] + (i * 2) where i is the index
            'of MAC address element.
            Dim sum As Long = 0
            Dim index As Integer = 1
            For Each ch As Char In mac
                If Char.IsDigit(ch) Then
                    sum += sum + Integer.Parse(ch) * (index * 2)
                ElseIf Char.IsLetter(ch) Then
                    Select Case ch.ToString.ToUpper
                        Case "A"
                            sum += sum + 10 * (index * 2)
                        Case "B"
                            sum += sum + 11 * (index * 2)
                        Case "C"
                            sum += sum + 12 * (index * 2)
                        Case "D"
                            sum += sum + 13 * (index * 2)
                        Case "E"
                            sum += sum + 14 * (index * 2)
                        Case "F"
                            sum += sum + 15 * (index * 2)
                    End Select
                End If

                index += 1
            Next

            Return sum
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function

    Public Function CheckKey(ByVal key As Long) As Boolean
        Try
            Dim x As Long = GetSerial()
            Dim y As Long = x * x + 53 / x + 113 * (x / 4)
            Return y = key
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function CheckKeyFromSettings() As Boolean
        Try
            Dim key As Long = My.Settings.activationKey
            Dim x As Long = GetSerial()
            Dim y As Long = x * x + 53 / x + 113 * (x / 4)
            Return y = key
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
End Class
