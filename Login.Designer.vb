<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lblpsw = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtpsw = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(132, 247)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(66, 25)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Aceptar"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'lblpsw
        '
        Me.lblpsw.AutoSize = True
        Me.lblpsw.Location = New System.Drawing.Point(12, 208)
        Me.lblpsw.Name = "lblpsw"
        Me.lblpsw.Size = New System.Drawing.Size(67, 15)
        Me.lblpsw.TabIndex = 1
        Me.lblpsw.Text = "Contraseña"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(21, 150)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(47, 15)
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "Usuario"
        '
        'txtpsw
        '
        Me.txtpsw.Location = New System.Drawing.Point(115, 205)
        Me.txtpsw.Name = "txtpsw"
        Me.txtpsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpsw.Size = New System.Drawing.Size(100, 23)
        Me.txtpsw.TabIndex = 1
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(115, 147)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 23)
        Me.txtuser.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.proy1_2024.My.Resources.Resources.graduado
        Me.PictureBox1.Image = Global.proy1_2024.My.Resources.Resources.graduado
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(69, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(304, 323)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtpsw)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lblpsw)
        Me.Controls.Add(Me.btnlogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlogin As Button
    Friend WithEvents lblpsw As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents txtpsw As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
