Public Class Form1
    Private Sub Btlimpiar_Click(sender As Object, e As EventArgs) Handles Btlimpiar.Click
        LIMPIAR()
    End Sub
    Private Sub Btsalir_Click(sender As Object, e As EventArgs) Handles Btsalir.Click
        If (MsgBox("ESTA SEGURO QUE DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE SALIDA") = vbYes) Then
            End
        End If
    End Sub

    Private Sub Txtcantidad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Txtcantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar números naturales")
        End If
    End Sub

    Private Sub Btcalcular_Click(sender As Object, e As EventArgs) Handles Btcalcular.Click


        Dim tamaño As String
        Dim material As String
        If RBsmall.Checked Then
            tamaño = "Small"
        ElseIf RBmedium.Checked Then
            tamaño = "Medium"
        ElseIf RBlarge.Checked Then
            tamaño = "Large"
        Else
            MsgBox("ERROR, NO SELECCIONÓ TAMAÑO", vbExclamation, "ADVERTENCIA")
            Exit Sub
        End If

        If RBalgodon.Checked Then
            material = "Algodon"
        ElseIf RBseda.Checked Then
            material = "Seda"
        ElseIf RBlona.Checked Then
            material = "Lona"
        Else
            MsgBox("ERROR, NO SELECCIONÓ MATERIAL", vbExclamation, "ADVERTENCIA")
            Exit Sub
        End If

        Calcular(tamaño, material, Val(Txtcantidad.Text))
        Form2.Show()
    End Sub

End Class
