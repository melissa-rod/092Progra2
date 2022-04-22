Module Declaraciones
    Public NIT_h(7) As Integer
    Public Nombre_h(7) As String
    Public Ndias(7) As Integer
    Public Thabitacion(7) As String
    Public Tpago(7) As String
    Public Impuesto(7) As String
    Public Subtotal(7) As Double
    Public Descuntos(7) As Double
    Public Totalfinal(7) As Double

    Public fila As Byte = 0

    Public I As Byte

    Sub Totalhabitacion()
        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                Subtotal(fila) = Val(Form1.TextBox3.Text) * 250

            Case 1
                Subtotal(fila) = Val(Form1.TextBox3.Text) * 400

            Case 2
                Subtotal(fila) = Val(Form1.TextBox3.Text) * 650

            Case Else
                MsgBox("ERROR, NO SELECCIONO tipo de habitación")
                Exit Sub
        End Select
    End Sub


    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6

            If (NIT_h(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(NIT_h(I)), Nombre_h(I), Str(Tpago(I)), Str(Impuesto(I)), Str(Subtotal(I)), Str(Descuntos(I)), Str(Totalfinal(I)))
            Else

                Exit For
            End If
        Next I

    End Sub
    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        fila = 0

        For I = 0 To 6

            NIT_h(I) = Nothing
            Nombre_h(I) = Nothing
            Ndias(I) = Nothing
            Thabitacion(I) = Nothing
            Tpago(I) = Nothing
            Impuesto(I) = Nothing
            Subtotal(I) = Nothing
            Descuntos(I) = Nothing
            Totalfinal(I) = Nothing

        Next I

    End Sub

End Module
