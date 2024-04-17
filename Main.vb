Public Class frm_Main
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbluser.Text &= wuser
    End Sub

    Private Sub nav_Calculadora_Click(sender As Object, e As EventArgs) Handles nav_calculadora.Click
        frm_Calculadora.ShowDialog()
    End Sub

    Private Sub nav_Concatenar_Click(sender As Object, e As EventArgs) Handles nav_Concatenar.Click
        frm_Concatenar.ShowDialog()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()

    End Sub
End Class