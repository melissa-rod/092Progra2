Public Class Form1

    Const PrecioArroz As Double = 2.0
    Const PrecioFrijol As Double = 1.75
    Const PrecioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim PagoSinIva As Double = 0
    Dim ValorIVA As Double = 0
    Dim PagoConIVA As Double = 0
    Dim Descuento As Double = 0
    Dim PagoFinal As Double = 0

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        'Código relacionado a los cálculos de los pagos.
        PagoSinIva = (Val(TxtArroz.Text) * PrecioArroz) + (Val(TxtFrijol.Text) * PrecioFrijol) + (Val(TxtAzucar.Text) * PrecioAzucar)
        ValorIVA = Format(PagoSinIva * IVA, "0.00")
        PagoConIVA = Format(PagoSinIva + ValorIVA, "0.00")
        Descuento = Format(PagoConIVA * 0.025, "0.00")
        PagoFinal = Format(PagoConIVA - Descuento, "0.00")

        LabelR1.Text = PagoSinIva
        LabelR2.Text = ValorIVA
        LabelR3.Text = PagoConIVA
        LabelR4.Text = Descuento
        LabelR5.Text = PagoFinal

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'Código relacionado a limpiar todas las variables.
        If (TypeOf LabelR1 Is Label) Then
            LabelR1.Text = ""
        End If
        If (TypeOf LabelR2 Is Label) Then
            LabelR2.Text = ""
        End If
        If (TypeOf LabelR3 Is Label) Then
            LabelR3.Text = ""
        End If
        If (TypeOf LabelR4 Is Label) Then
            LabelR4.Text = ""
        End If
        If (TypeOf LabelR5 Is Label) Then
            LabelR5.Text = ""
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'Código que confirma se desea cerrar el programa.
        End
    End Sub

    Private Sub TxtArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArroz.KeyPress
        'Código que permite ingresar unicamente numeros.
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFrijol.KeyPress
        'Código que permite ingresar unicamente numeros.
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAzucar.KeyPress
        'Código que permite ingresar unicamente numeros.
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
