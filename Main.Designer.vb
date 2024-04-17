<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnu_main = New System.Windows.Forms.MenuStrip()
        Me.nav_calculadora = New System.Windows.Forms.ToolStripMenuItem()
        Me.nav_Concatenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.mnu_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_main
        '
        Me.mnu_main.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnu_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nav_calculadora, Me.nav_Concatenar})
        Me.mnu_main.Location = New System.Drawing.Point(0, 0)
        Me.mnu_main.Name = "mnu_main"
        Me.mnu_main.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnu_main.Size = New System.Drawing.Size(88, 726)
        Me.mnu_main.TabIndex = 0
        Me.mnu_main.Text = "mnu_main"
        '
        'nav_calculadora
        '
        Me.nav_calculadora.Name = "nav_calculadora"
        Me.nav_calculadora.Size = New System.Drawing.Size(75, 19)
        Me.nav_calculadora.Text = "Calculadora"
        '
        'nav_Concatenar
        '
        Me.nav_Concatenar.Name = "nav_Concatenar"
        Me.nav_Concatenar.Size = New System.Drawing.Size(75, 19)
        Me.nav_Concatenar.Text = "Concatenar"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(1178, 9)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(36, 15)
        Me.lbluser.TabIndex = 1
        Me.lbluser.Text = "User: "
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Info
        Me.btn_Salir.Location = New System.Drawing.Point(988, 632)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(255, 56)
        Me.btn_Salir.TabIndex = 2
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1278, 726)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.mnu_main)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.mnu_main
        Me.Name = "frm_Main"
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnu_main.ResumeLayout(False)
        Me.mnu_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_main As MenuStrip
    Friend WithEvents lbluser As Label
    Friend WithEvents nav_calculadora As ToolStripMenuItem
    Friend WithEvents nav_Concatenar As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btn_Salir As Button
End Class
