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

            kilometraje = Val(TextBox3.Text) - Val(TextBox2.Text)


            If (kilometraje < 51) Then
                Cextra = kilometraje * 3

            ElseIf (50 < kilometraje < 71) Then
                Cextra = kilometraje * 4

            ElseIf (kilometraje > 70) Then
                Cextra = kilometraje * 5

            Else
                MsgBox("ERROR, NO INGRESO KILOMETRAJE", vbExclamation, "ADVERTENCIA")
                Exit Sub
            End If


            If (posicion <= 6) Then
                Tcarro(posicion) = ComboBox1.Text
                Nplaca(posicion) = Val(TextBox1.Text)
                Kinicial(posicion) = Val(TextBox2.Text)
                Kfinal(posicion) = Val(TextBox3.Text)
                montobase()
                Pfinal(posicion) = Round((Cbase(posicion) + Cextra), 2)
                posicion = posicion + 1
                limpiar_entradas()
            End If

        Else
            MsgBox("No. de placa repetido no se puede ingresar el dato")
            TextBox1.Focus()
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

            If (Nplaca(N) = Val(TextBox4.Text)) Then
                existe = True
            Else
                N = N + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = Str(Nplaca(N))
            TextBox2.Text = Str(Kinicial(N))
            TextBox3.Text = Str(Kfinal(N))
            ComboBox1.Text = Tcarro(N)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Nplaca(N)), Tcarro(N), Str(Cbase(N)), Str(Kinicial(N)), Str(Kfinal(N)), Str(Pfinal(N)))

            posicion = N
        Else
            MsgBox("Placa no encontrada")
            TextBox4.Focus()
        End If

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        kilometraje = Val(TextBox3.Text) - Val(TextBox2.Text)


        If (kilometraje < 51) Then
            Cextra = kilometraje * 3

        ElseIf (50 < kilometraje < 71) Then
            Cextra = kilometraje * 4

        ElseIf (70 < kilometraje) Then
            Cextra = kilometraje * 5

        Else
            MsgBox("ERROR, NO INGRESO KILOMETRAJE", vbExclamation, "ADVERTENCIA")
            Exit Sub
        End If

        Nplaca(posicion) = Val(TextBox1.Text)
        Kinicial(posicion) = TextBox2.Text
        Kfinal(posicion) = Val(TextBox3.Text)
        montobase()
        Pfinal(posicion) = Round((Cbase(posicion) + Cextra), 2)

        MsgBox("Registro actualizado correctamente en los vectores")

        posicion = 6
    End Sub


    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        Tcarro(posicion) = Nothing
        Nplaca(posicion) = Nothing
        Cbase(posicion) = Nothing
        Kinicial(posicion) = Nothing
        Kfinal(posicion) = Nothing
        Pfinal(posicion) = Nothing


        For N = posicion To 5

            Nplaca(N) = Nplaca(N + 1)
            Tcarro(N) = Tcarro(N + 1)
            Cbase(N) = Cbase(N + 1)
            Kinicial(N) = Kinicial(N + 1)
            Kfinal(N) = Kfinal(N + 1)
            Pfinal(N) = Pfinal(N + 1)

        Next N
        MsgBox("Registro Eliminado exitosamente")

        Tcarro(N) = Nothing
        Nplaca(N) = Nothing
        Cbase(N) = Nothing
        Kinicial(N) = Nothing
        Kfinal(N) = Nothing
        Pfinal(N) = Nothing

        posicion = N
        limpiar_entradas()
        DataGridView1.Rows.Clear()

    End Sub
End Class
