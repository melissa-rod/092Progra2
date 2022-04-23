Module Module1
    Public Tcarro(7) As String
    Public Nplaca(7) As Integer
    Public Cbase(7) As Double
    Public Kinicial(7) As Integer
    Public Kfinal(7) As Integer
    Public Pfinal(7) As Double

    Public posicion As Byte = 0
    Public kilometraje As Double
    Public Cextra As Double


    Public N As Byte

    Function Buscar_repetido() As Boolean
        Dim match As Boolean = True

        N = 0
        Buscar_repetido = True
        While (N <= 6) And (match)

            If (Nplaca(N) <> Nothing) Then

                If (Nplaca(N) = Val(Form1.TextBox1.Text)) Then
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
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.TextBox1.Focus()
    End Sub


    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For N = 0 To 6
            If (Nplaca(N) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Nplaca(N)), Tcarro(N), Str(Cbase(N)), Str(Kinicial(N)), Str(Kfinal(N)), Str(Pfinal(N)))
            Else
                Exit For
            End If
        Next N

    End Sub

    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        posicion = 0

        For N = 0 To 6

            Nplaca(N) = Nothing
            Tcarro(N) = Nothing
            Cbase(N) = Nothing
            Kinicial(N) = Nothing
            Kfinal(N) = Nothing
            Pfinal(N) = Nothing

        Next N

    End Sub



    Sub montobase()
        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                Cbase(posicion) = 500

            Case 1
                Cbase(posicion) = 400

            Case 2
                Cbase(posicion) = 300

            Case 3
                Cbase(posicion) = 200

            Case Else
                MsgBox("ERROR, NO SELECCIONO TIPO DE CARRO")
                Exit Sub
        End Select

    End Sub

End Module
