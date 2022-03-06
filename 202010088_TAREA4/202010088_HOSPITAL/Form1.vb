Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim temp1 As Double = 0

        If (posicion <= 5) Then
            If (TextBox1.Text <> "") Then
                Nombre(posicion) = TextBox1.Text

            Else
                MsgBox("ERROR, NOMBRE PARTICIPANTE INCORRECTO")
                TextBox1.Focus()
                Exit Sub
            End If

            If (TextBox2.Text <> "") Then
                Nit(posicion) = TextBox2.Text
            Else
                MsgBox("ERROR, NIT PARTICIPANTE INCORRECTO")
                TextBox2.Focus()
                Exit Sub
            End If

            If (TextBox3.Text <> "") Then
                No(posicion) = TextBox3.Text
            Else
                MsgBox("ERROR, NO. DE DIAS INCORRECTO")
                TextBox3.Focus()
                Exit Sub
            End If

            If (TextBox4.Text <> "") Then
                Honorarios(posicion) = TextBox4.Text
            Else
                MsgBox("ERROR, HONORARIOS INCORRECTO")
                TextBox3.Focus()
                Exit Sub
            End If

            If (ComboBox1.SelectedIndex > -1) Then
                Thabitacion(posicion) = ComboBox1.Text
            Else
                MsgBox("ERROR, NO SELECCIONÓ SERVICIO")
                ComboBox1.Focus()
                Exit Sub
            End If
            'SE INICIALIZA EL VECTOR DE PARCIAL PARA CALCULARLO POR CADA INGRESO QUE SE HAGA
            Parcial(posicion) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : Privada()
                Case 1 : Semiprivada()
                Case 1 : Noprivada()
            End Select

            Descuento(posicion) = calculardescuentorecargo()

            Total(posicion) = totalfinal()
            muestre_totales()
            posicion = posicion + 1
        End If
        If posicion = 6 Then
            MsgBox("VECTORES LLENOS")
            limpiar_entradas()
        End If

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Call Salir()
    End Sub

    Private Sub LiatasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiatasToolStripMenuItem.Click
        Call LIMPIAR_VECTORES()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        Call limpiar_entradas()
    End Sub
End Class
