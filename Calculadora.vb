Public Class frm_Calculadora

    Private Sub frm_Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_User.Text &= wuser

    End Sub

    Private Sub btn_Suma_Click(sender As Object, e As EventArgs) Handles btn_Suma.Click
        Try
            Dim number1 As Double = txt_nmr1.Text
            Dim number2 As Double = txt_nmr2.Text

            If txt_nmr1.Text = "" Then
                MsgBox("Ingrese el 1er numero")

            Else
                If txt_nmr2.Text = "" Then
                    MsgBox("Ingrese el 2do numero")
                Else
                    lbl_Resultado.Text = number1 + number2

                End If
            End If
        Catch ex As InvalidCastException
            MsgBox("Ingrese solo numeros")
        End Try
    End Sub

    Private Sub btn_Resta_Click(sender As Object, e As EventArgs) Handles btn_Resta.Click
        Try
            Dim number1 As Double = txt_nmr1.Text
            Dim number2 As Double = txt_nmr2.Text

            If txt_nmr1.Text = "" Then
                MsgBox("Ingrese el 1er numero")

            Else
                If txt_nmr2.Text = "" Then
                    MsgBox("Ingrese el 2do numero")
                Else
                    lbl_Resultado.Text = number1 - number2

                End If
            End If
        Catch ex As InvalidCastException
            MsgBox("Ingrese solo numeros")
        End Try
    End Sub

    Private Sub btn_Dividir_Click(sender As Object, e As EventArgs) Handles btn_Dividir.Click
        Try
            Dim number1 As Double = txt_nmr1.Text
            Dim number2 As Double = txt_nmr2.Text

            If txt_nmr1.Text = "" Then
                MsgBox("Ingrese el 1er numero")

            Else
                If txt_nmr2.Text = "" Then
                    MsgBox("Ingrese el 2do numero")
                Else
                    If txt_nmr2.Text = "0" Then
                        MsgBox("el denominador no puede ser igual a cero")
                    Else
                        lbl_Resultado.Text = number1 / number2
                    End If
                End If
            End If
        Catch ex As InvalidCastException
            MsgBox("Ingrese solo numeros")
        End Try
    End Sub

    Private Sub btn_Multiplicar_Click(sender As Object, e As EventArgs) Handles btn_Multiplicar.Click
        Try
            Dim number1 As Double = txt_nmr1.Text
            Dim number2 As Double = txt_nmr2.Text

            If txt_nmr1.Text = "" Then
                MsgBox("Ingrese el 1er numero")

            Else
                If txt_nmr2.Text = "" Then
                    MsgBox("Ingrese el 2do numero")
                Else
                    lbl_Resultado.Text = number1 * number2

                End If
            End If
        Catch ex As InvalidCastException
            MsgBox("Ingrese solo numeros")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        Me.txt_nmr1.Clear()
        Me.txt_nmr2.Clear()
        Me.lbl_Resultado.ResetText()
    End Sub
End Class