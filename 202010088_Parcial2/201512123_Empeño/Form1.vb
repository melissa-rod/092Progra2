Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
            LIMPIAR_LIST()
            LIMPIAR_MATRIZ()
        End If

    End Sub

    Private Sub LimpiarListboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListboxToolStripMenuItem.Click
        LIMPIAR_LIST()
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        LIMPIAR_MATRIZ()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If (ComboBox1.SelectedIndex = 0) And Cbxrefri.Checked Then
            PAR1 = REFCORTO
        Else
            PAR1 = 0
        End If

        If (ComboBox1.SelectedIndex = 0) And Cbxtv.Checked Then
            PAR2 = TVCORTO
        Else
            PAR2 = 0
        End If

        If (ComboBox1.SelectedIndex = 1) And Cbxrefri.Checked Then
            PAR3 = REFLARGO
        Else
            PAR3 = 0
        End If

        If (ComboBox1.SelectedIndex = 1) And Cbxtv.Checked Then
            PAR4 = TVLARGO
        Else
            PAR4 = 0
        End If

        If (ComboBox1.SelectedIndex = 0) And Cbxtel.Checked Then
            PAR5 = TELCORTO
        Else
            PAR5 = 0
        End If

        If (ComboBox1.SelectedIndex = 0) And CbxLap.Checked Then
            PAR6 = LAPCORTO
        Else
            PAR6 = 0
        End If

        If (ComboBox1.SelectedIndex = 1) And Cbxtel.Checked Then
            PAR7 = TELLARGO
        Else
            PAR7 = 0
        End If

        If (ComboBox1.SelectedIndex = 1) And CbxLap.Checked Then
            PAR8 = LAPLARGO
        Else
            PAR8 = 0
        End If


        VPARCIAL = PAR1 + PAR2 + PAR3 + PAR4 + PAR5 + PAR6 + PAR7 + PAR8

        If (ComboBox1.SelectedIndex = 0) And Cbxrefri.Checked Then
            DESC1 = REFCORTO * 0.15
        Else
            DESC1 = 0
        End If

        If (ComboBox1.SelectedIndex = 0) And Cbxtv.Checked Then
            DESC2 = TVCORTO * 0.15
        Else
            DESC2 = 0
        End If

        If (ComboBox1.SelectedIndex = 1) And Cbxrefri.Checked Then
            DESC3 = REFLARGO * 0.05
        Else
            DESC3 = 0
        End If

        If (ComboBox1.SelectedIndex = 1) And Cbxtv.Checked Then
            DESC4 = TVLARGO * 0.05
        Else
            DESC4 = 0
        End If

        If (ComboBox1.SelectedIndex = 0) And Cbxtel.Checked Then
            DESC5 = TELCORTO * 0.05
        Else
            DESC5 = 0
        End If

        If (ComboBox1.SelectedIndex = 0) And CbxLap.Checked Then
            DESC6 = LAPCORTO * 0.05
        Else
            DESC6 = 0
        End If

        If (ComboBox1.SelectedIndex = 1) And Cbxtel.Checked Then
            DESC7 = TELLARGO * 0.1
        Else
            DESC7 = 0
        End If

        If (ComboBox1.SelectedIndex = 1) And CbxLap.Checked Then
            DESC8 = LAPLARGO * 0.1
        Else
            DESC8 = 0
        End If

        DESCTOTAL = DESC1 + DESC2 + DESC3 + DESC4 + DESC5 + DESC6 + DESC7 + DESC8

        If contador < 6 Then
            matriz(contador, 0) = Txtnombre.Text
            matriz(contador, 1) = Txtcui.Text
            matriz(contador, 2) = Txtdireccion.Text
            matriz(contador, 3) = ComboBox1.Text

            If Cbxtv.Checked Then
                matriz(contador, 4) = "1"
            Else
                matriz(contador, 4) = "0"
            End If

            If Cbxtel.Checked Then
                matriz(contador, 5) = "1"
            Else
                matriz(contador, 5) = "0"
            End If

            If CbxLap.Checked Then
                matriz(contador, 6) = "1"
            Else
                matriz(contador, 6) = "0"
            End If

            If Cbxrefri.Checked Then
                matriz(contador, 7) = "1"
            Else
                matriz(contador, 7) = "0"
            End If

            matriz(contador, 8) = Txtcostotv.Text
            matriz(contador, 9) = Txtcostotel.Text
            matriz(contador, 10) = Txtcostolap.Text
            matriz(contador, 11) = Txtcostorefri.Text
            matriz(contador, 12) = (System.Math.Round(VPARCIAL, 2))
            matriz(contador, 13) = (System.Math.Round(DESCTOTAL, 2))
            matriz(contador, 14) = (System.Math.Round(VPARCIAL - DESCTOTAL, 2))


            MOSTRAR_DATOS()
            contador = contador + 1
        Else
            MessageBox.Show("se llegó al límite")

        End If

    End Sub
End Class
