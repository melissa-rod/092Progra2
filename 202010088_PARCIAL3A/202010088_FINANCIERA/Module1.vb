Module Module1
    Public Idcliente(7) As Integer
    Public Tviaje(7) As String
    Public No_dias(7) As Integer
    Public No_personas(7) As Integer
    Public Tpagar(7) As Double

    Public posicion As Byte = 0

    Public monto As Double


    Public N As Byte

    Function Buscar_repetido() As Boolean
        Dim match As Boolean = True

        N = 0
        Buscar_repetido = True
        While (N <= 6) And (match)

            If (Idcliente(N) <> Nothing) Then

                If (Idcliente(N) = Val(Form1.Txtid.Text)) Then
                    Buscar_repetido = match = False
                    Return Buscar_repetido
                Else
                    N = N + 1
                End If
            Else
                Exit While
            End If
        End While

        If (match) Then
            Return Buscar_repetido
        End If
    End Function

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
        End If
    End Sub

    Sub limpiar_entradas()
        Form1.Txtid.Clear()
        Form1.Txt_dias.Clear()
        Form1.Txt_cpersonas.Clear()
        Form1.Cb_TipoV.Text = ""
        Form1.Txtid.Focus()
    End Sub


    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For N = 0 To 6
            If (Idcliente(N) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Idcliente(N)), Tviaje(N), Str(No_dias(N)), Str(No_personas(N)), "Q." + Str(Tpagar(N)))
            Else
                Exit For
            End If
        Next N

    End Sub

    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        posicion = 0

        For N = 0 To 6

            Idcliente(N) = Nothing
            Tviaje(N) = Nothing
            No_dias(N) = Nothing
            No_personas(N) = Nothing
            Tpagar(N) = Nothing

        Next N

        MsgBox("Se han limpiado los vectores correctamente")

    End Sub



    Sub Tipomonto()
        Select Case (Form1.Cb_TipoV.SelectedIndex)
            Case 0
                monto = 440
            Case 1
                monto = 1190
            Case 2
                monto = 255
            Case Else
                MsgBox("ERROR, Seleccione un tipo de viaje")
                Exit Sub
        End Select

    End Sub

End Module
