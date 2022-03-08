Imports System.IO
Imports System.Windows.Forms

Public Class FrmGenerar

    Dim NombreFpassword As String
    Dim Password As String = "joyfe"
    Dim cipherText As String
    Dim Escribir As StreamWriter
    Dim Lector As StreamReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim path As String

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            path = FolderBrowserDialog1.SelectedPath
        End If


        Dim fs As 


    End Sub
End Class