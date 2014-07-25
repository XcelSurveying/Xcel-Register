
' Visual Basic
'Imports System
'Imports System.Windows.Forms
'Imports System.Reflection


Public Class AboutDialog
    Inherits Form

    Public Sub version()
        ' Display the assembly information in a Label.
        MessageBox.Show(Me.CompanyName + vbCrLf + _
          Me.ProductName + "  Version: " + _
          Me.ProductVersion + vbCrLf + _
          "Developed by: Matt Seneque (matts@xcelsurveying.com.au)", "About", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub
End Class

