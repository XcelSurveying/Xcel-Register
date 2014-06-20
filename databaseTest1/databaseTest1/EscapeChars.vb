Imports System.Text.RegularExpressions

Public Class EscapeChars

    Public Sub Include(e As KeyPressEventArgs, allowNumbers As Boolean, allowLetters As Boolean, Optional removeSpace As Boolean = False, Optional includeHyphen As Boolean = False)
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

            ' REMOVE SPACE
            If removeSpace = True Then
                'Remove space
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 32) Then
                    e.Handled = True
                End If
            End If

            ' ADD HYPHEN
            If includeHyphen = True Then
                'Include Hyphen
                If (Microsoft.VisualBasic.Asc(e.KeyChar) = 45) Then
                    e.Handled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function cleanString(strIn As String) As String
        Try
            Return Regex.Replace(strIn, "[^\w\s\-]", "") 'regular expression code for all word chars, space and hyphen
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function cleanString_NoHyphen(strIn As String) As String
        Try
            Return Regex.Replace(strIn, "[^\w\s]", "") 'regular expression code for all word chars and space
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function cleanString_NoHyphen_NoSpace(strIn As String) As String
        Try
            Return Regex.Replace(strIn, "[^\w]", "") 'regular expression code for all word chars and space
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

End Class
