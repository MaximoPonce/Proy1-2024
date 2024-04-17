Public Class frm_Concatenar

    Private Sub frm_Concatenar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_user.Text &= wuser
    End Sub
    Private Sub btn_Concatenar_Click(sender As Object, e As EventArgs) Handles btn_Concatenar.Click
        If txt_Concatenar.Text = "" Then
            MsgBox("Ingrese su apellido")
        Else
            lbl_Concatenar.Text = wuser
            lbl_Concatenar.Text &= " "
            lbl_Concatenar.Text &= txt_Concatenar.Text
        End If
    End Sub
End Class