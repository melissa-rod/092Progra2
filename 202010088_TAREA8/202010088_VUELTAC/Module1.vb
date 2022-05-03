Module Module1
    Public Netapa(12) As Integer
    Public Krecorrido(12) As Double
    Public TiempoMin(12) As Double
    Public Nequipo(12) As String
    Public Nacio(12) As String
    Public Tpenali(12) As Double
    Public Treduc(12) As Double
    Public Tfinal(12) As Double

    Public posicion As Byte = 0

    Public N As Byte

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()
    End Sub

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
        End If
    End Sub
    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For N = 0 To 11
            If (Netapa(N) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Netapa(N)), Str(Krecorrido(N)), Str(TiempoMin(N)), Nequipo(N), Nacio(N), Str(Tpenali(N)), Str(Treduc(N)), Str(Tfinal(N)))
            Else
                Exit For
            End If
        Next N

    End Sub

    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        posicion = 0

        For N = 0 To 11

            Netapa(N) = Nothing
            Krecorrido(N) = Nothing
            TiempoMin(N) = Nothing
            Nequipo(N) = Nothing
            Nacio(N) = Nothing
            Tpenali(N) = Nothing
            Treduc(N) = Nothing
            Tfinal(N) = Nothing

        Next N

    End Sub

    Function Buscar_repetido() As Boolean
        Dim match As Boolean = True

        N = 0
        Buscar_repetido = True
        While (N <= 11) And (match)

            If (Netapa(N) <> Nothing) Then

                If (Netapa(N) = Val(Form1.TextBox1.Text)) Then
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

    Sub Reduccionfinal()
        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                Treduc(posicion) = 0

            Case 1
                If Val(Form1.TextBox3.Text) < 85 Then
                    Treduc(posicion) = 15
                End If

            Case 2
                Treduc(posicion) = 0

            Case 3
                Treduc(posicion) = 10

            Case Else
                MsgBox("ERROR, NO SELECCIONO equipo")
                Exit Sub
        End Select

    End Sub

    Sub Penalizacionfinal()
        If (120 < Val(Form1.TextBox3.Text) <= 140) Then
            Tpenali(posicion) = 30
        Else Tpenali(posicion) = 0
        End If

        If (140 < Val(Form1.TextBox3.Text) <= 160) Then
            Tpenali(posicion) = 40
        Else Tpenali(posicion) = 0
        End If

        If (160 < Val(Form1.TextBox3.Text)) Then
            Tpenali(posicion) = 50
        Else Tpenali(posicion) = 0
        End If


    End Sub

End Module
