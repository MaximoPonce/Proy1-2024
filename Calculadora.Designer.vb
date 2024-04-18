<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Calculadora
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
        Me.lbl_User = New System.Windows.Forms.Label()
        Me.txt_nmr1 = New System.Windows.Forms.TextBox()
        Me.txt_nmr2 = New System.Windows.Forms.TextBox()
        Me.lbl_nrm = New System.Windows.Forms.Label()
        Me.btn_Suma = New System.Windows.Forms.Button()
        Me.btn_Resta = New System.Windows.Forms.Button()
        Me.btn_Dividir = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_Multiplicar = New System.Windows.Forms.Button()
        Me.lbl_Resultado = New System.Windows.Forms.Label()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_User
        '
        Me.lbl_User.AutoSize = True
        Me.lbl_User.Location = New System.Drawing.Point(385, 9)
        Me.lbl_User.Name = "lbl_User"
        Me.lbl_User.Size = New System.Drawing.Size(36, 15)
        Me.lbl_User.TabIndex = 2
        Me.lbl_User.Text = "User: "
        '
        'txt_nmr1
        '
        Me.txt_nmr1.Location = New System.Drawing.Point(181, 58)
        Me.txt_nmr1.Name = "txt_nmr1"
        Me.txt_nmr1.Size = New System.Drawing.Size(100, 23)
        Me.txt_nmr1.TabIndex = 0
        '
        'txt_nmr2
        '
        Me.txt_nmr2.Location = New System.Drawing.Point(181, 108)
        Me.txt_nmr2.Name = "txt_nmr2"
        Me.txt_nmr2.Size = New System.Drawing.Size(100, 23)
        Me.txt_nmr2.TabIndex = 1
        '
        'lbl_nrm
        '
        Me.lbl_nrm.AutoSize = True
        Me.lbl_nrm.Location = New System.Drawing.Point(206, 22)
        Me.lbl_nrm.Name = "lbl_nrm"
        Me.lbl_nrm.Size = New System.Drawing.Size(56, 15)
        Me.lbl_nrm.TabIndex = 1
        Me.lbl_nrm.Text = "Numeros"
        '
        'btn_Suma
        '
        Me.btn_Suma.Location = New System.Drawing.Point(32, 232)
        Me.btn_Suma.Name = "btn_Suma"
        Me.btn_Suma.Size = New System.Drawing.Size(75, 23)
        Me.btn_Suma.TabIndex = 2
        Me.btn_Suma.Text = "+"
        Me.btn_Suma.UseVisualStyleBackColor = True
        '
        'btn_Resta
        '
        Me.btn_Resta.Location = New System.Drawing.Point(143, 232)
        Me.btn_Resta.Name = "btn_Resta"
        Me.btn_Resta.Size = New System.Drawing.Size(75, 23)
        Me.btn_Resta.TabIndex = 3
        Me.btn_Resta.Text = "-"
        Me.btn_Resta.UseVisualStyleBackColor = True
        '
        'btn_Dividir
        '
        Me.btn_Dividir.Location = New System.Drawing.Point(272, 232)
        Me.btn_Dividir.Name = "btn_Dividir"
        Me.btn_Dividir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Dividir.TabIndex = 4
        Me.btn_Dividir.Text = "%"
        Me.btn_Dividir.UseVisualStyleBackColor = True
        '
        'btn_Multiplicar
        '
        Me.btn_Multiplicar.Location = New System.Drawing.Point(381, 232)
        Me.btn_Multiplicar.Name = "btn_Multiplicar"
        Me.btn_Multiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Multiplicar.TabIndex = 5
        Me.btn_Multiplicar.Text = "X"
        Me.btn_Multiplicar.UseVisualStyleBackColor = True
        '
        'lbl_Resultado
        '
        Me.lbl_Resultado.AutoSize = True
        Me.lbl_Resultado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Resultado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Resultado.Location = New System.Drawing.Point(218, 165)
        Me.lbl_Resultado.Name = "lbl_Resultado"
        Me.lbl_Resultado.Size = New System.Drawing.Size(0, 21)
        Me.lbl_Resultado.TabIndex = 0
        Me.lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltext.Location = New System.Drawing.Point(181, 134)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(90, 21)
        Me.lbltext.TabIndex = 0
        Me.lbltext.Text = "Resultado:"
        Me.lbltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(196, 305)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frm_Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(468, 366)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.lbl_Resultado)
        Me.Controls.Add(Me.btn_Multiplicar)
        Me.Controls.Add(Me.btn_Dividir)
        Me.Controls.Add(Me.btn_Resta)
        Me.Controls.Add(Me.btn_Suma)
        Me.Controls.Add(Me.lbl_nrm)
        Me.Controls.Add(Me.txt_nmr2)
        Me.Controls.Add(Me.txt_nmr1)
        Me.Controls.Add(Me.lbl_User)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_User As Label
    Friend WithEvents txt_nmr1 As TextBox
    Friend WithEvents txt_nmr2 As TextBox
    Friend WithEvents lbl_nrm As Label
    Friend WithEvents btn_Suma As Button
    Friend WithEvents btn_Resta As Button
    Friend WithEvents btn_Dividir As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Multiplicar As Button
    Friend WithEvents lbl_Resultado As Label
    Friend WithEvents lbltext As Label
    Friend WithEvents btnLimpiar As Button
End Class
