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


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnCerrarsesion_Click(sender As Object, e As EventArgs) Handles btnCerrarsesion.Click
        Dim frm As New frm_Login
        frm.Show()
        Me.Close()


    End Sub
End Class