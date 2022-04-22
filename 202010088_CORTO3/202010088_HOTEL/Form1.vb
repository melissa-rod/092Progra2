Imports System.Math
Public Class Form1
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub

    Private Sub CálculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoToolStripMenuItem.Click
        If (fila <= 6) Then
            NIT_h(fila) = (TextBox2.Text)
            Nombre_h(fila) = TextBox1.Text
            Ndias(fila) = Val(TextBox3.Text)
            Thabitacion(fila) = ComboBox1.Text
            Tpago(fila) = ComboBox2.Text
            Impuesto(fila) = Val(TextBox4.Text)
            Subtotal(fila) = Totalhabitacion()
            Descuntos(fila) =
            Totalfinal(fila) = Round((Subtotal(fila) + Impuesto(fila) + Descuntos(fila)), 2)

            fila = fila + 1

        End If
        If (fila = 7) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False


        I = 0


        While (I <= 6) And Not (existe)

            If (NIT_h(I) = Val(TextBox5.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While


        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = Nombre_h(I)
            TextBox2.Text = Str(NIT_h(I))
            TextBox3.Text = Str(Ndias(I))
            TextBox4.Text = Str(Impuesto(I))
            ComboBox1.Text = Thabitacion(I)
            ComboBox2.Text = Tpago(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(NIT_h(I)), Nombre_h(I), Str(Tpago(I)), Str(Impuesto(I)), Str(Subtotal(I)), Str(Descuntos(I)), Str(Totalfinal(I)))

            fila = I
        Else
            MsgBox("Nit no encontrado")
            TextBox4.Focus()
        End If

    End Sub
End Class
