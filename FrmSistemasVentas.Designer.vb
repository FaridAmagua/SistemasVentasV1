<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSistemasVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraciónToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónDeDirecctoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestorUsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarUsuerPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(814, 512)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(814, 537)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem3, Me.GestorUsuariosToolStripMenuItem1, Me.ConsultasToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraciónToolStripMenuItem3
        '
        Me.ConfiguraciónToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem3.Name = "ConfiguraciónToolStripMenuItem3"
        Me.ConfiguraciónToolStripMenuItem3.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem3.Text = "Configuración"
        '
        'SSToolStripMenuItem
        '
        Me.SSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónDeDirecctoriosToolStripMenuItem})
        Me.SSToolStripMenuItem.Name = "SSToolStripMenuItem"
        Me.SSToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SSToolStripMenuItem.Text = "Directorios"
        '
        'ConfiguraciónDeDirecctoriosToolStripMenuItem
        '
        Me.ConfiguraciónDeDirecctoriosToolStripMenuItem.Name = "ConfiguraciónDeDirecctoriosToolStripMenuItem"
        Me.ConfiguraciónDeDirecctoriosToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ConfiguraciónDeDirecctoriosToolStripMenuItem.Text = "Configuración de direcctorios"
        '
        'GestorUsuariosToolStripMenuItem1
        '
        Me.GestorUsuariosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarUsuerPasswordToolStripMenuItem})
        Me.GestorUsuariosToolStripMenuItem1.Name = "GestorUsuariosToolStripMenuItem1"
        Me.GestorUsuariosToolStripMenuItem1.Size = New System.Drawing.Size(101, 20)
        Me.GestorUsuariosToolStripMenuItem1.Text = "Gestor Usuarios"
        '
        'GenerarUsuerPasswordToolStripMenuItem
        '
        Me.GenerarUsuerPasswordToolStripMenuItem.Name = "GenerarUsuerPasswordToolStripMenuItem"
        Me.GenerarUsuerPasswordToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.GenerarUsuerPasswordToolStripMenuItem.Text = "Generar Usuer/Password"
        '
        'ConsultasToolStripMenuItem2
        '
        Me.ConsultasToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem1})
        Me.ConsultasToolStripMenuItem2.Name = "ConsultasToolStripMenuItem2"
        Me.ConsultasToolStripMenuItem2.Size = New System.Drawing.Size(115, 20)
        Me.ConsultasToolStripMenuItem2.Text = "Generar Consultas"
        '
        'ConsultasToolStripMenuItem1
        '
        Me.ConsultasToolStripMenuItem1.Name = "ConsultasToolStripMenuItem1"
        Me.ConsultasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ConsultasToolStripMenuItem1.Text = "Consultas"
        '
        'FrmSistemasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 561)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmSistemasVentas"
        Me.Text = "Sistemas Ventass"
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents ConfiguraciónToolStripMenuItem3 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónDeDirecctoriosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestorUsuariosToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarUsuerPasswordToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
End Class
