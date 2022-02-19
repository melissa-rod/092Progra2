Module Module1
    Public Pcosto As Double = 0
    Public Tcosto As Double = 0
    Public Pventa As Double = 0

    Public Const MOS = 65.5
    Public Const MOM = 85.99
    Public Const MOL = 99.99

    Public Const MatA = 15.0
    Public Const MatS = 23.99
    Public Const MatL = 30.99

    Public Const YS = 2
    Public Const YM = 2.5
    Public Const YL = 3

    Sub LIMPIAR()

        Form1.Txtcantidad.Clear()
        Form1.RBsmall.Checked = False
        Form1.RBmedium.Checked = False
        Form1.RBlarge.Checked = False
        Form1.RBlona.Checked = False
        Form1.RBseda.Checked = False
        Form1.RBalgodon.Checked = False

        Form1.Txtcantidad.Focus()
    End Sub

    Public Sub Calcular(tamaño As String, material As String, cantidad As Double)
        Select Case tamaño
            Case "Small"
                Select Case material
                    Case "Algodon"
                        Tcosto = System.Math.Round((cantidad * MOS + cantidad * MatA * YS), 2)
                    Case "Seda"
                        Tcosto = System.Math.Round((cantidad * MOS + cantidad * MatS * YS), 2)
                    Case "Lona"
                        Tcosto = System.Math.Round((cantidad * MOS + cantidad * MatL * YS), 2)
                End Select
            Case "Medium"
                Select Case material
                    Case "Algodon"
                        Tcosto = System.Math.Round((cantidad * MOM + cantidad * MatA * YM), 2)
                    Case "Seda"
                        Tcosto = System.Math.Round((cantidad * MOM + cantidad * MatS * YM), 2)
                    Case "Lona"
                        Tcosto = System.Math.Round((cantidad * MOM + cantidad * MatL * YM), 2)
                End Select
            Case "Large"
                Select Case material
                    Case "Algodon"
                        Tcosto = System.Math.Round((cantidad * MOL + cantidad * MatA * YL), 2)
                    Case "Seda"
                        Tcosto = System.Math.Round((cantidad * MOL + cantidad * MatS * YL), 2)
                    Case "Lona"
                        Tcosto = System.Math.Round((cantidad * MOL + cantidad * MatL * YL), 2)
                End Select
        End Select

        Pventa = System.Math.Round((Tcosto * 1.65 / cantidad), 2)
        Pcosto = System.Math.Round((Tcosto / cantidad), 2)

    End Sub

End Module
