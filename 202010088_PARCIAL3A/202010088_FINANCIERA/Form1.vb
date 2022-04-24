Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_entradas()
        limpiar_vectores()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (Buscar_repetido()) Then

            If (posicion <= 6) Then
                Idcliente(posicion) = Val(Txtid.Text)
                Tviaje(posicion) = Cb_TipoV.Text
                No_dias(posicion) = Val(Txt_dias.Text)
                No_personas(posicion) = Val(Txt_cpersonas.Text)
                Tipomonto()
                Tpagar(posicion) = Round((monto * Val(Txt_dias.Text) * Val(Txt_cpersonas.Text)), 2)
                posicion = posicion + 1
                limpiar_entradas()
            End If

        Else
            MsgBox("No. de identificación repetido, no se puede ingresar el dato")
            Txtid.Focus()
            limpiar_entradas()

        End If

        If (posicion = 7) Then
            MsgBox("vectores llenos")
        End If

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

        Dim existe As Boolean = False

        N = 0

        While (N <= 6) And Not (existe)

            If (Idcliente(N) = Val(Txt_consulta.Text)) Then
                existe = True
            Else
                N = N + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            Txtid.Text = Str(Idcliente(N))
            Txt_dias.Text = Str(No_dias(N))
            Txt_cpersonas.Text = Str(No_personas(N))
            Cb_TipoV.Text = Tviaje(N)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Idcliente(N)), Tviaje(N), Str(No_dias(N)), Str(No_personas(N)), "Q." + Str(Tpagar(N)))

            posicion = N
        Else
            MsgBox("Identificación no encontrada")
            Txt_consulta.Focus()
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        Idcliente(posicion) = Nothing
        Tviaje(posicion) = Nothing
        No_dias(posicion) = Nothing
        No_personas(posicion) = Nothing
        Tpagar(posicion) = Nothing


        For N = posicion To 5

            Idcliente(N) = Idcliente(N + 1)
            Tviaje(N) = Tviaje(N + 1)
            No_dias(N) = No_dias(N + 1)
            No_personas(N) = No_personas(N + 1)
            Tpagar(N) = Tpagar(N + 1)

        Next N
        MsgBox("Registro Eliminado exitosamente")

        Idcliente(N) = Nothing
        Tviaje(N) = Nothing
        No_dias(N) = Nothing
        No_personas(N) = Nothing
        Tpagar(N) = Nothing

        posicion = N
        limpiar_entradas()
        Txt_consulta.Clear()
        DataGridView1.Rows.Clear()

    End Sub
End Class
