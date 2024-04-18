<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Concatenar
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
        Me.btn_Concatenar = New System.Windows.Forms.Button()
        Me.txt_Concatenar = New System.Windows.Forms.TextBox()
        Me.lbl_Concatenar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Concatenar
        '
        Me.btn_Concatenar.Location = New System.Drawing.Point(40, 194)
        Me.btn_Concatenar.Name = "btn_Concatenar"
        Me.btn_Concatenar.Size = New System.Drawing.Size(100, 23)
        Me.btn_Concatenar.TabIndex = 1
        Me.btn_Concatenar.Text = "Concatenar"
        Me.btn_Concatenar.UseVisualStyleBackColor = True
        '
        'txt_Concatenar
        '
        Me.txt_Concatenar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Concatenar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Concatenar.Location = New System.Drawing.Point(40, 90)
        Me.txt_Concatenar.Name = "txt_Concatenar"
        Me.txt_Concatenar.Size = New System.Drawing.Size(100, 23)
        Me.txt_Concatenar.TabIndex = 0
        '
        'lbl_Concatenar
        '
        Me.lbl_Concatenar.AutoSize = True
        Me.lbl_Concatenar.Location = New System.Drawing.Point(234, 141)
        Me.lbl_Concatenar.Name = "lbl_Concatenar"
        Me.lbl_Concatenar.Size = New System.Drawing.Size(0, 15)
        Me.lbl_Concatenar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese su apellido"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(374, 9)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(36, 15)
        Me.lbl_user.TabIndex = 4
        Me.lbl_user.Text = "User: "
        '
        'frm_Concatenar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(458, 335)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Concatenar)
        Me.Controls.Add(Me.txt_Concatenar)
        Me.Controls.Add(Me.btn_Concatenar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Concatenar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concatenar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Concatenar As Button
    Friend WithEvents txt_Concatenar As TextBox
    Friend WithEvents lbl_Concatenar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_user As Label
End Class
