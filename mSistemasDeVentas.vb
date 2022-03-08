Imports System.Windows.Forms



Public Module mSistemasDeVentas
    Public frmVentas As New FrmSistemasVentas

    Sub Main()

        Application.Run(frmVentas)



    End Sub



    Public Class Usuario

        'Public ruta As String
        'Public Usuario As String
        'Public Contrasena As String
        'Public Checkbox As String 'USUARIO 1 == 0 CLIENTE  USUARIO 2 == 1 USUARIO 3 == 2'

        Public rutaAPP As String
        Public nombreAPP As String
        Public contrasenaAPP As String
        Public CheckboxAPP As String

        Public Property DirectorioAplicacion As String
            Get
                Return rutaAPP
            End Get
            Set(value As String)
                rutaAPP = value
            End Set
        End Property

        Public Property UsuarioAplicacion As String
            Get
                Return nombreAPP
            End Get
            Set(value As String)
                nombreAPP = value
            End Set
        End Property


        Public Property ContrasenaAplicacion As String
            Get
                Return contrasenaAPP
            End Get
            Set(value As String)
                contrasenaAPP = value
            End Set
        End Property




        ' CONTRUCTOR'

        Public Sub New()
            ComprobarContrasena()
        End Sub

        ''Public Sub New(usuario As String, contrasena As String, checkbox As String, ruta As String)

        ''    EstablecerDirectorio(ruta)




        'End Sub
        Public Sub ComprobarContrasena()

        End Sub


        'Public Sub EstablecerDirectorio(Directorio As String)
        '    ruta = Directorio
        '    DirectorioAplicacion = ruta

        'End Sub


    End Class


End Module
