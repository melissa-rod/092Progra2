Public Class Form1

    Private Sub Txtcarne_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Txtcarne.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar números naturales")
        End If
    End Sub

    Private Sub Txthoras_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Txthoras.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar números naturales")
        End If
    End Sub

    Private Sub Btcalcular_Click(sender As Object, e As EventArgs) Handles Btcalcular.Click

        If Txtcarne.Text = "" Then
            MsgBox("Ingrese un número de carné.")
            Exit Sub
        End If

        If Txtnombre.Text = "" Then
            MsgBox("Ingrese un nombre.")
            Exit Sub
        End If

        If Txthoras.Text = "" Then
            MsgBox("Ingrese un número de horas.")
            Exit Sub
        End If

        If Cbcurso.SelectedIndex = -1 Then
            MsgBox("Seleccione un curso.")
            Exit Sub
        End If

        If Cbxsabado.Checked = False And Cbxviernes.Checked = False Then
            MsgBox("Seleccione un día.")
            Exit Sub
        End If

        If Indice < 8 Then
            matriz(0, Indice) = Txtcarne.Text
            matriz(1, Indice) = Txtnombre.Text
            matriz(2, Indice) = Cbcurso.SelectedItem
            matriz(3, Indice) = Txthoras.Text
            matriz(4, Indice) = Dtpdate.Value

            If Cbxviernes.Checked Then
                matriz(5, Indice) = Cbxviernes.Text
            ElseIf Cbxsabado.Checked Then
                matriz(5, Indice) = Cbxsabado.Text
            End If

            If Cbxviernes.Checked = True AndAlso Cbxsabado.Checked = True Then
                matriz(5, Indice) = "Viernes/Sábado"
            End If

            If Rbcheque.Checked Then
                    matriz(6, Indice) = Rbcheque.Text
                Else matriz(6, Indice) = Rbefectivo.Text
            End If

            HORAS = (Txthoras.Text)
            If Cbcurso.SelectedIndex = 0 Then
                Parcial = 150 * HORAS
            ElseIf Cbcurso.SelectedIndex = 1 Then
                Parcial = 80 * HORAS
            ElseIf Cbcurso.SelectedIndex = 2 Then
                Parcial = 125 * HORAS
            End If

            matriz(7, Indice) = "Q." & System.Math.Round(Parcial, 2)

            If Rbcheque.Checked Then
                Desc1 = Des1C * Parcial
            ElseIf Rbefectivo.Checked Then
                Desc1 = Des1E * Parcial
            Else
                MsgBox("Seleccione un método de pago.")
                Exit Sub
            End If

            matriz(8, Indice) = "Q." & System.Math.Round(Desc1, 2)

            If Cbxsabado.Checked = True AndAlso Cbxviernes.Checked = True Then
                Desc2 = Des2d * Parcial
            Else
                Desc2 = 0
            End If

            matriz(9, Indice) = "Q." & System.Math.Round(Desc2, 2)

            matriz(10, Indice) = "Q." & System.Math.Round(Parcial - Desc1 - Desc2, 2)


            DataGridView1.Rows.Add(Indice + 1, matriz(0, Indice), matriz(1, Indice), matriz(2, Indice), matriz(3, Indice), matriz(4, Indice), matriz(5, Indice), matriz(6, Indice), matriz(7, Indice), matriz(8, Indice), matriz(9, Indice), matriz(10, Indice))
            Indice = Indice + 1
            Else
                MessageBox.Show("Ya se llegó al límite.")
        End If
    End Sub

    Private Sub Btsalir_Click(sender As Object, e As EventArgs) Handles Btsalir.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        End If

    End Sub

    Private Sub Btlimpiar_Click(sender As Object, e As EventArgs) Handles Btlimpiar.Click
        LIMPIAR()
    End Sub

    Private Sub Btnlimpiarm_Click(sender As Object, e As EventArgs) Handles Btnlimpiarm.Click
        DataGridView1.Rows.Clear()
    End Sub
End Class
