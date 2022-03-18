Public Class Form1

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If (Rbtcuero.Checked = True) Then
            Preciotela = 75
        ElseIf (Rbtcuerina.Checked = True) Then
            Preciotela = 45.99
        End If

        If (Cbxtamaños.SelectedIndex = 0) Then
            yardastela = 8
            Manoobra = 250.99
        ElseIf (Cbxtamaños.SelectedIndex = 1) Then
            yardastela = 3.5
            Manoobra = 150.99
        ElseIf (Cbxtamaños.SelectedIndex = 2) Then
            yardastela = 6
            Manoobra = 200.99
        Else
            MsgBox("ERROR, NO SELECCIONÓ TAMAÑO", vbExclamation, "ADVERTENCIA")
            Exit Sub
        End If



        If (INDICE <= 7) Then
            'SE PROCEDE A GUARDAR LOS DATOS RESPECTIVOS EN CADA VECTOR
            No_venta(INDICE) = Val(Txt_venta.Text)
            'al ingresar las notas se les aplica el val para almacenarlas en los vectores
            'numéricos respectivos
            Cantidad(INDICE) = Val(Txtcantidad.Text)
            Tamaño(INDICE) = Cbxtamaños.Text
            Tipo_tela()
            costo(INDICE) = (System.Math.Round(Val(Txtcantidad.Text) * (Manoobra + (yardastela * Preciotela)), 2))
            precio(INDICE) = (System.Math.Round(costo(INDICE) * 1.65, 2))
            'SE HACE EL CÁLCULO DEL PROMEDIO UTILIZANDO LOS DATOS ALMACENADOS EN LOS VECTORES DE LAS NOTAS
            mostrar_datos()
            INDICE = INDICE + 1
        End If
        If (INDICE = 8) Then
            MsgBox("VECTORES LLENOS")
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
            LIMPIAR_GRID()
        End If

    End Sub

    Private Sub LimpiarGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarGridToolStripMenuItem.Click
        LIMPIAR_GRID()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class
