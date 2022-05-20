Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub DatosEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosEntradaToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub

    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        If (Buscar_repetido()) Then


            If (posicion <= 5) Then
                Ncliente(posicion) = Val(TextBox1.Text)
                Tcabina(posicion) = ComboBox1.Text
                Npersonas(posicion) = Val(TextBox3.Text)
                Cantidad_individual()

                Total(posicion) = Round((Npersonas(posicion) * Pindividual(posicion)), 2)
                posicion = posicion + 1
                limpiar_entradas()
            End If

        Else
            MsgBox("Número de NIT repetido no se puede ingresar el dato")
            TextBox1.Focus()
            limpiar_entradas()
        End If


        If (posicion = 6) Then
            MsgBox("vectores llenos")
        End If
    End Sub


    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False

        N = 0

        While (N <= 5) And Not (existe)

            If (Ncliente(N) = Val(TextBox4.Text)) Then
                existe = True
            Else
                N = N + 1
            End If
        End While

        If (existe) Then
            MsgBox("Se encontro exitosamente el registro")

            TextBox1.Text = Str(Ncliente(N))
            TextBox3.Text = Str(Npersonas(N))
            ComboBox1.Text = Tcabina(N)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Ncliente(N)), Tcabina(N), Str(Npersonas(N)), Pindividual(N), Str(Total(N)))

            posicion = N
        Else
            MsgBox("Lastimosamente no se encontró el registro ingresado, intentalo de nuevo.")
            TextBox4.Focus()
        End If
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer


        For i = 0 To 4
            For j = i + 1 To 5


                If (Ncliente(i) < Ncliente(j)) Then
                    temp1 = Ncliente(i)
                    Ncliente(i) = Ncliente(j)
                    Ncliente(j) = temp1
                End If

            Next j
        Next i
    End Sub

End Class
