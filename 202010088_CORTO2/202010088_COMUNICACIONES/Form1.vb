Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            LIMPIAR_VECTORES()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click

        If (Val(TextBox2.Text) <= 2000) Then
            BONO1 = Str(Val(TextBox2.Text) * 0.03)
        ElseIf (Val(TextBox2.Text) > 2000) And (Val(TextBox2.Text) <= 5000) Then
            BONO1 = Val(TextBox2.Text) * 0.04

        ElseIf (Val(TextBox2.Text) > 5000) Then
            BONO1 = Val(TextBox2.Text) * 0.05
        End If

        If (posicion <= 6) Then

            Empleado(posicion) = TextBox1.Text
            Valorbruto(posicion) = TextBox2.Text


            If (RadioButton1.Checked = True) Then
                Articulo(posicion) = "Tablet"
                COMISION1 = 375 * 0.055
            ElseIf (RadioButton2.Checked = True) Then
                Articulo(posicion) = "Drone"
                COMISION1 = 560 * 0.055
            ElseIf (RadioButton3.Checked = True) Then
                Articulo(posicion) = "Celular"
                COMISION1 = 1450 * 0.055
            ElseIf (RadioButton4.Checked = True) Then
                Articulo(posicion) = "Televisor"
                COMISION1 = 3250 * 0.055
            Else
                MsgBox("ERROR, NO SELECCIONÓ ARTÍCULO")
                Exit Sub
            End If

            Comision(posicion) = COMISION1

            Bono(posicion) = BONO1

            Final(posicion) = Str(System.Math.Round(Val(TextBox2.Text) + COMISION1 + BONO1, 2))


            muestre_totales()
                posicion = posicion + 1
            End If
            If posicion = 7 Then
            MsgBox("VECTORES LLENOS")
            limpiar_entradas()
        End If


    End Sub

    Private Sub Btnclimpiarv_Click(sender As Object, e As EventArgs) Handles Btnclimpiarv.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub Btnclimpiare_Click(sender As Object, e As EventArgs) Handles Btnclimpiare.Click
        limpiar_entradas()
    End Sub
End Class
