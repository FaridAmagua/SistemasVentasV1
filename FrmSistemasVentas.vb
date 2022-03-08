Imports System.IO

Public Class FrmSistemasVentas


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Public Sub ConfiguraciónDeDirecctoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónDeDirecctoriosToolStripMenuItem.Click
        Dim frmDirectorios As New FrmDirectorios
        frmDirectorios.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmDirectorios)
        frmDirectorios.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem1.Click
        Dim frmConsultas As New FrmConsultas
        frmConsultas.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmConsultas)
        frmConsultas.Show()


    End Sub

    Private Sub GenerarUsuerPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarUsuerPasswordToolStripMenuItem.Click
        Dim frmGenerarUsuario As New FrmGenerar
        frmGenerarUsuario.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmGenerarUsuario)
        frmGenerarUsuario.Show()
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim frmLogin As New FrmLogin
        frmLogin.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmLogin)
        frmLogin.Show()
        GestorUsuariosToolStripMenuItem1.Visible = False
        ConsultasToolStripMenuItem2.Visible = False



    End Sub


End Class