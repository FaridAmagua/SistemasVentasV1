Imports System.IO
Imports System.Windows.Forms

Public Class FrmDirectorios

    Inherits System.Windows.Forms.Form


    Dim Directorios As String

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txt1.Text = FolderBrowserDialog1.SelectedPath
        End If

        Directorios = FolderBrowserDialog1.SelectedPath


    End Sub

    Private Sub EstablecerDirectorio(directorios As String)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

        'Dim dir, , filenameV3, fullpath As String
        'dir = Path.GetDirectoryName(OpenFileDialog1, FileName)
        'filename = Path.GetFileName(OpenFileDialog1, FileName)
        'fullpath = dir & "/" & +filename
        'tbx1 = fullpath




    End Sub
End Class