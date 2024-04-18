Imports Microsoft.VisualBasic.ApplicationServices

Public Class frm_Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "" Then
            MsgBox("Ingrese un usuario")
        Else
            wuser = txtuser.Text

            If txtpsw.Text = "admin" Then
                frm_Main.Show()
                Me.Close()
            Else
                MsgBox("Contraseña incorrectos")

            End If
        End If
    End Sub


End Class