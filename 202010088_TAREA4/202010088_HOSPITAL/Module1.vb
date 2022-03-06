Module Module1

    Public posicion As Byte = 0
    Public ServiciosM(6) As Double
    Public ServiciosO(6) As Double
    Public ServiciosE(6) As Double

    Public Nombre(6) As String
    Public Nit(6) As String
    Public No(6) As Double
    Public Honorarios(6) As Double
    Public Thabitacion(6) As String
    Public Fpago(6) As String
    Public Parcial(6) As Double
    Public Descuento(6) As Double
    Public Total(6) As Double

    Public Const efectivo = 0.15
    Public Const cheque = 0.15
    Public Const tarjetad = 0.08
    Public Const tarjetac = 0.05 'Recargo

    Public Const EncamamientoP = 350.0
    Public Const EncamamientoSP = 250.0
    Public Const EncamamientoNP = 150.0

    Public Const OperacionP = 550.0
    Public Const OperacionSP = 400.0
    Public Const OperacionNP = 300.0

    Public Const MaternidadP = 450.0
    Public Const MaternidadSP = 350.0
    Public Const MaternidadNP = 250.0

    'procedimiento que calcula el parcial si se eligió habitación privada
    Sub Privada()
        If (Form1.CheckBox1.Checked) Or (Form1.CheckBox2.Checked) Or (Form1.CheckBox3.Checked) Then
            If Form1.CheckBox1.Checked Then
                ServiciosE(posicion) = EncamamientoP
            Else
                ServiciosE(posicion) = 0
            End If
            If Form1.CheckBox2.Checked Then
                ServiciosO(posicion) = OperacionP
            Else
                ServiciosO(posicion) = 0
            End If
            If Form1.CheckBox3.Checked Then
                ServiciosM(posicion) = MaternidadP
            Else
                ServiciosM(posicion) = 0
            End If
            Parcial(posicion) = ServiciosE(posicion) + ServiciosO(posicion) + ServiciosM(posicion)
        Else
            MsgBox("ERROR, NO SELECCIONÓ SERVICIO(S)")
            Exit Sub
        End If
    End Sub

    Sub Semiprivada()
        If (Form1.CheckBox1.Checked) Or (Form1.CheckBox2.Checked) Or (Form1.CheckBox3.Checked) Then
            If Form1.CheckBox1.Checked Then
                ServiciosE(posicion) = EncamamientoSP
            Else
                ServiciosE(posicion) = 0
            End If
            If Form1.CheckBox2.Checked Then
                ServiciosO(posicion) = OperacionSP
            Else
                ServiciosO(posicion) = 0
            End If
            If Form1.CheckBox3.Checked Then
                ServiciosM(posicion) = MaternidadSP
            Else
                ServiciosM(posicion) = 0
            End If
            Parcial(posicion) = ServiciosE(posicion) + ServiciosO(posicion) + ServiciosM(posicion)
        Else
            MsgBox("ERROR, NO SELECCIONÓ SERVICIO(S)")
            Exit Sub
        End If
    End Sub

    Sub Noprivada()
        If (Form1.CheckBox1.Checked) Or (Form1.CheckBox2.Checked) Or (Form1.CheckBox3.Checked) Then
            If Form1.CheckBox1.Checked Then
                ServiciosE(posicion) = EncamamientoNP
            Else
                ServiciosE(posicion) = 0
            End If
            If Form1.CheckBox2.Checked Then
                ServiciosO(posicion) = OperacionNP
            Else
                ServiciosO(posicion) = 0
            End If
            If Form1.CheckBox3.Checked Then
                ServiciosM(posicion) = MaternidadNP
            Else
                ServiciosM(posicion) = 0
            End If
            Parcial(posicion) = ServiciosE(posicion) + ServiciosO(posicion) + ServiciosM(posicion)
        Else
            MsgBox("ERROR, NO SELECCIONÓ SERVICIO(S)")
            Exit Sub
        End If
    End Sub


    Function calculardescuentorecargo() As Double
        Dim desc As Double
        Dim recargo As Double

        If (Form1.RadioButton1.Checked) Then
            Fpago(posicion) = Form1.RadioButton1.Text
            desc = Parcial(posicion) * efectivo
            Return desc * -1
        ElseIf (Form1.RadioButton2.Checked) Then
            Fpago(posicion) = Form1.RadioButton2.Text
            recargo = Parcial(posicion) * tarjetac
            Return recargo
        ElseIf (Form1.RadioButton3.Checked) Then
            Fpago(posicion) = Form1.RadioButton3.Text
            desc = Parcial(posicion) * tarjetad
            Return desc * -1
        ElseIf (Form1.RadioButton4.Checked) Then
            Fpago(posicion) = Form1.RadioButton4.Text
            desc = Parcial(posicion) * cheque
            Return desc * -1
        End If
        Return Nothing
    End Function

    Function totalfinal() As Double

        totalfinal = Str(System.Math.Round(Parcial(posicion) + Descuento(posicion), 2))
        Return totalfinal
    End Function

    Sub muestre_totales()
        Form1.ListBox1.Items.Add(Nombre(posicion))
        Form1.ListBox2.Items.Add(Nit(posicion))
        Form1.ListBox4.Items.Add(Str(No(posicion)))
        Form1.ListBox3.Items.Add(Str(Honorarios(posicion)))
        Form1.ListBox5.Items.Add(Thabitacion(posicion))
        Form1.ListBox6.Items.Add(Str(Total(posicion)))
        Form1.ListBox7.Items.Add(Str(Descuento(posicion)))
        Form1.ListBox8.Items.Add(Str(Parcial(posicion)))
        Form1.ListBox9.Items.Add(Fpago(posicion))
    End Sub


    Sub salir()
        If (MsgBox("¿Esta seguro que desea SALIR?", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            LIMPIAR_VECTORES()
        End If
    End Sub

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = 0
        Form1.CheckBox3.Checked = 0
        Form1.RadioButton1.Checked = 0
        Form1.RadioButton2.Checked = 0
        Form1.RadioButton3.Checked = 0
        Form1.RadioButton4.Checked = 0
        Form1.TextBox1.Focus()


    End Sub

    Sub LIMPIAR_VECTORES()
        posicion = 0

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()

    End Sub


End Module
