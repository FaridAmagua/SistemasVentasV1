Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography

Imports System.Windows.Forms

Public Class FrmLogin

    Dim User As String
    Dim Contrasena As String
    Dim Checkbox As String
    Dim Directorio As String


    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim lector As OleDbDataAdapter
    Dim consulta As String
    Dim cat As New ADOX.Catalog
    Dim Cn As ADODB.Connection
    Dim da As New OleDb.OleDbDataAdapter

    Dim Usuario1 As New Usuario






    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        User = tbxUsuario.Text
        Contrasena = tbxContraseña.Text

        If CheckBox1.Checked Then
            Checkbox = 1
        ElseIf CheckBox2.Checked Then
            Checkbox = 2
        Else
            Checkbox = 0
        End If

        MessageBox.Show("" + User + Contrasena + Checkbox)

        If CheckBox1.Checked Then




        End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try


            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= DatosPer.mdb"
            conexion.Open()
            MessageBox.Show("Conectado")
            conexion.Close()

        Catch ex As Exception

            MessageBox.Show("No se ha podido abrir la base de datos")
            Ruta()
            Conectar()

        End Try

    End Sub

    Private Sub Conectar()
        Try

            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Directorio
            conexion.Open()
            MessageBox.Show("Conectado")
            'Dim User1 As New Usuario(User, Contrasena, Checkbox, Directorio)
            'User1.EstablecerDirectorio("" + Directorio)
            Usuario1.nombreAPP = User
            Usuario1.contrasenaAPP = Contrasena
            Usuario1.CheckboxAPP = Checkbox
        Catch ex As Exception

            MessageBox.Show("No se ha podido abrir la base de datos")
            Ruta()
            Conectar()
        End Try

    End Sub



    Private Sub Ruta()


        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Directorio = OpenFileDialog1.FileName
            MessageBox.Show("El direcctorio es actual es : " + Directorio)
            Usuario1.rutaAPP = Directorio

        End If

    End Sub




End Class
