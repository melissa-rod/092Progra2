Module Module1
    Public I As Byte
    Public posicion As Byte = 0

    Public Nombre(10) As String
    Public paquete(10) As String
    Public valor(10) As String
    Public parcial(10) As Double
    Public Impuesto(10) As Double
    Public total(10) As Double

    Public CPARCIAL As Double
    Public ImpuestoIVA As Double
    Public CTOTAL As Double
    Public CPESO As Double

    Public Const Pdoc = 0.015
    Public Const Prop = 0.06
    Public Const Ppede = 0.055
    Public Const Pplast = 0.045
    Public Const Plocio = 0.02


    Sub Limpiar()
        Form1.Txtcliente.Clear()
        Form1.Txtpeso.Clear()
        Form1.Txtvalor.Clear()
        Form1.Cbtipo.SelectedIndex = -1
        Form1.Cbenvio.SelectedIndex = -1

        Form1.Txtcliente.Focus()
    End Sub
    Sub LimpiarVectores()
        posicion = 0

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
    End Sub

    Sub MostrarVectores()
        Form1.ListBox1.Items.Add(Nombre(posicion))
        Form1.ListBox2.Items.Add(paquete(posicion))
        Form1.ListBox3.Items.Add(valor(posicion))
        Form1.ListBox4.Items.Add("Q." + Str(parcial(posicion)))
        Form1.ListBox5.Items.Add("Q." + Str(Impuesto(posicion)))
        Form1.ListBox6.Items.Add("Q." + Str(total(posicion)))

    End Sub

    Sub CalculoParcial()
        Select Case (Form1.Cbtipo.SelectedIndex)
            Case 0
                CPARCIAL = System.Math.Round((CPESO * Pdoc), 2)
            Case 1
                CPARCIAL = System.Math.Round((CPESO * Prop), 2)
            Case 2
                CPARCIAL = System.Math.Round((CPESO * Ppede), 2)
            Case 3
                CPARCIAL = System.Math.Round((CPESO * Pplast), 2)
            Case 4
                CPARCIAL = System.Math.Round((CPESO * Plocio), 2)
            Case Else
                MsgBox("ERROR, NO SELECCIONÓ TIPO DE ENVIO")
                Exit Sub
        End Select

    End Sub


    Sub Calculoimpuesto()
        Select Case (Form1.Cbenvio.SelectedIndex)
            Case 0
                ImpuestoIVA = System.Math.Round((CPARCIAL + 50) * 0.12, 2)
                CTOTAL = System.Math.Round((ImpuestoIVA + CPARCIAL + 50), 2)

            Case 1
                ImpuestoIVA = System.Math.Round((CPARCIAL + 15) * 0.12, 2)
                CTOTAL = System.Math.Round((ImpuestoIVA + CPARCIAL + 15), 2)
            Case Else
                MsgBox("ERROR, NO SELECCIONÓ FORMA DE ENVIO")
                Exit Sub
        End Select
    End Sub
End Module
