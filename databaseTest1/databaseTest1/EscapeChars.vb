Public Class EscapeChars

    Public Sub Include(e As KeyPressEventArgs, allowNumbers As Boolean, allowLetters As Boolean)
        Try
            '-------BLOCK ALL TEXT ENTERED ------
            e.Handled = True

            '-------ADD EXCEPTIONS TO WHATS BLOCKED-------
            'ALLOW BACKSPACE & SPACEBAR
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 32) Then
                e.Handled = False
            End If

            ' ALLOW NUMBERS
            If allowNumbers = True Then
                'numbers 0-9
                If (Microsoft.VisualBasic.Asc(e.KeyChar) >= 48) And (Microsoft.VisualBasic.Asc(e.KeyChar) <= 57) Then
                    e.Handled = False
                End If
            End If

            ' ALLOW LETTERS
            If allowLetters = True Then
                'Lower Case
                If (Microsoft.VisualBasic.Asc(e.KeyChar) >= 65) And (Microsoft.VisualBasic.Asc(e.KeyChar) <= 90) Then
                    e.Handled = False
                End If
                'Upper case
                If (Microsoft.VisualBasic.Asc(e.KeyChar) >= 97) And (Microsoft.VisualBasic.Asc(e.KeyChar) <= 122) Then
                    e.Handled = False
                End If
                'Allowed Symbols
                If (Microsoft.VisualBasic.Asc(e.KeyChar) >= 40) And (Microsoft.VisualBasic.Asc(e.KeyChar) <= 47) Then
                    e.Handled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
