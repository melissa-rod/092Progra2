Public Class Form1
    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            Limpiar()
            LimpiarVectores()
        End If

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click

        If (Txtpeso.Text < 5) Then
            CPESO = Val(Txtpeso.Text)
        Else
            MsgBox("Peso superior a 5 kg")
            CPESO = 0
        End If

        CalculoParcial()
        Calculoimpuesto()
    End Sub

    Private Sub MostrarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarVectoresToolStripMenuItem.Click


        If (posicion <= 9) Then
            If (Txtcliente.Text <> "") Then
                Nombre(posicion) = Txtcliente.Text

            Else
                MsgBox("ERROR, Ingresa nombre de cliente")
                Txtcliente.Focus()
                Exit Sub
            End If

            If (Cbtipo.SelectedIndex > -1) Then
                paquete(posicion) = Cbtipo.Text
            Else
                MsgBox("ERROR, Ingrese tipo de envio")
                Cbtipo.Focus()
                Exit Sub
            End If

            If (Txtvalor.Text <> "") Then
                valor(posicion) = "Q." + Str(Txtvalor.Text)

            Else
                MsgBox("ERROR, Ingrese valor del paquete ")
                Txtcliente.Focus()
                Exit Sub
            End If

            parcial(posicion) = CPARCIAL
            Impuesto(posicion) = ImpuestoIVA
            total(posicion) = CTOTAL

            MostrarVectores()
            posicion = posicion + 1
        End If

        If posicion = 10 Then
            MsgBox("VECTORES LLENOS")
            Limpiar()
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LimpiarVectores()
    End Sub

    Private Sub Btcalcular_Click(sender As Object, e As EventArgs) Handles Btcalcular.Click
        Dim tot1 As Double = 0
        Dim tot2 As Byte = 0
        Dim tot3 As Double = 0
        Dim tot4 As Double = 0
        I = 0
        While (I <= 9)
            If (Nombre(I) <> Nothing) Then
                If (paquete(I) = "Lociones") Then
                    tot1 = tot1 + Val(total(I))
                End If

                If (paquete(I) = "Artículos de plástico") Then
                    tot2 = tot2 + 1
                End If

                If (paquete(I) = "Documentos") Then
                    tot3 = tot3 + Val(total(I))
                End If

                If (paquete(I) = "Ropa") Then
                    tot4 = tot4 + Val(total(I))
                End If
                I = I + 1
            Else
                Exit While
            End If
        End While

        Txtloc.Text = "Q." + Str(tot1)
        Txtpla.Text = Str(tot2)
        Txtdoc.Text = "Q." + Str(tot3)
        Txtrop.Text = "Q." + Str(tot4)
    End Sub
End Class

