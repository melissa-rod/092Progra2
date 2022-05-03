Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        If (Buscar_repetido()) Then




            If (posicion <= 11) Then
                Netapa(posicion) = Val(TextBox1.Text)
                Krecorrido(posicion) = Val(TextBox2.Text)
                TiempoMin(posicion) = Val(TextBox3.Text)
                Nequipo(posicion) = ComboBox1.Text
                Nacio(posicion) = ComboBox2.Text

                Penalizacionfinal()
                Reduccionfinal()

                Tfinal(posicion) = Round((TiempoMin(posicion) + Tpenali(posicion) - Treduc(posicion)), 2)
                posicion = posicion + 1
                limpiar_entradas()
            End If

        Else
            MsgBox("No. de etapa repetido no se puede ingresar el dato")
            TextBox1.Focus()
            limpiar_entradas()
        End If


        If (posicion = 12) Then
            MsgBox("vectores llenos")
        End If

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False

        N = 0

        While (N <= 11) And Not (existe)

            If (Netapa(N) = Val(TextBox4.Text)) Then
                existe = True
            Else
                N = N + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = Str(Netapa(N))
            TextBox2.Text = Str(Krecorrido(N))
            TextBox3.Text = Str(TiempoMin(N))
            ComboBox1.Text = Nequipo(N)
            ComboBox2.Text = Nacio(N)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Netapa(N)), Str(Krecorrido(N)), Str(TiempoMin(N)), Nequipo(N), Nacio(N), Str(Tpenali(N)), Str(Treduc(N)), Str(Tfinal(N)))

            posicion = N
        Else
            MsgBox("Etapa no encontrada")
            TextBox4.Focus()
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click

        Netapa(posicion) = Val(TextBox1.Text)
        Krecorrido(posicion) = Val(TextBox2.Text)
        TiempoMin(posicion) = Val(TextBox3.Text)
        Nequipo(posicion) = ComboBox1.Text
        Nacio(posicion) = ComboBox2.Text

        Penalizacionfinal()
        Reduccionfinal()

        Tfinal(posicion) = Round((TiempoMin(posicion) + Tpenali(posicion) - Treduc(posicion)), 2)

        MsgBox("Registro actualizado correctamente en los vectores")

        posicion = 11
    End Sub

    Private Sub OrdenarAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendenteToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer
        Dim temp2 As Double
        Dim temp3 As Double
        Dim temp4 As String
        Dim temp5 As String
        Dim temp6 As Double
        Dim temp7 As Double
        Dim temp8 As Double

        For i = 0 To 10
            For j = i + 1 To 11

                If (Netapa(j) <> Nothing) Then
                    If (Netapa(i) > Netapa(j)) Then

                        temp1 = Netapa(i)
                        Netapa(i) = Netapa(j)
                        Netapa(j) = temp1

                        temp2 = Krecorrido(i)
                        Krecorrido(i) = Krecorrido(j)
                        Krecorrido(j) = temp2

                        temp3 = TiempoMin(i)
                        TiempoMin(i) = TiempoMin(j)
                        TiempoMin(j) = temp3

                        temp4 = Nequipo(i)
                        Nequipo(i) = Nequipo(j)
                        Nequipo(j) = temp4

                        temp5 = Nacio(i)
                        Nacio(i) = Nacio(j)
                        Nacio(j) = temp5

                        temp6 = Tpenali(i)
                        Tpenali(i) = Tpenali(j)
                        Tpenali(j) = temp6

                        temp7 = Treduc(i)
                        Treduc(i) = Treduc(j)
                        Treduc(j) = temp7

                        temp8 = Tfinal(i)
                        Tfinal(i) = Tfinal(j)
                        Tfinal(j) = temp8
                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub
End Class
