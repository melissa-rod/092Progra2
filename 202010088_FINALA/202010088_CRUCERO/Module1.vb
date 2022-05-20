Module Module1
    Public Ncliente(6) As Integer
    Public Tcabina(6) As String
    Public Npersonas(6) As Integer
    Public Pindividual(6) As Double
    Public Total(6) As Double

    Public posicion As Byte = 0

    Public N As Byte

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.Rb1.Checked = False
        Form1.Rb2.Checked = False
        Form1.TextBox1.Focus()
    End Sub

    Sub salir()
        If MsgBox("¿Esta seguro que desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
        End If
    End Sub

    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For N = 0 To 5
            If (Ncliente(N) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Ncliente(N)), Tcabina(N), Str(Npersonas(N)), Pindividual(N), Str(Total(N)))
            Else
                Exit For
            End If
        Next N

    End Sub

    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        posicion = 0

        For N = 0 To 5

            Ncliente(N) = Nothing
            Tcabina(N) = Nothing
            Npersonas(N) = Nothing
            Pindividual(N) = Nothing
            Total(N) = Nothing

        Next N

    End Sub

    Sub Cantidad_individual()


        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                If Form1.Rb1.Checked Then
                    Pindividual(posicion) = 400

                ElseIf Form1.Rb2.Checked Then
                    Pindividual(posicion) = 375

                End If

            Case 1
                If Form1.Rb1.Checked Then
                    Pindividual(posicion) = 700

                ElseIf Form1.Rb2.Checked Then
                    Pindividual(posicion) = 600

                End If
            Case 2
                If Form1.Rb1.Checked Then
                    Pindividual(posicion) = 350

                ElseIf Form1.Rb2.Checked Then
                    Pindividual(posicion) = 300

                End If
            Case Else
                MsgBox("ERROR, No seleccionó tipo de cabina")
                Exit Sub

        End Select
    End Sub


    Function Buscar_repetido() As Boolean
        Dim match As Boolean = True

        N = 0
        Buscar_repetido = True
        While (N <= 6) And (match)

            If (Ncliente(N) <> Nothing) Then

                If (Ncliente(N) = Val(Form1.TextBox1.Text)) Then
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

End Module
