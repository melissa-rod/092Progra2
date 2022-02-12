Public Class Form1

    Private Sub CbVenta_CheckedChanged(sender As Object, e As EventArgs) Handles CbVenta.CheckedChanged
        If CbVenta.Checked = True Then
            TxtVenta.Enabled = True
        Else
            TxtVenta.Enabled = False
        End If

        If CbVenta.Checked = True Then
            GroupVenta.Visible = True
        End If
    End Sub

    Private Sub CbCompra_CheckedChanged(sender As Object, e As EventArgs) Handles CbCompra.CheckedChanged
        If CbCompra.Checked = True Then
            TxtCompra.Enabled = True
        Else
            TxtCompra.Enabled = False
        End If
        If CbCompra.Checked = True Then
            GroupCompra.Visible = True
        End If
    End Sub
    Private Sub BtCalcular_Click(sender As Object, e As EventArgs) Handles BtCalcular.Click
        If Rbdolarv.Checked Then
            TxtTventa.Text = Str(calcularVenta(TxtVenta.Text, TDolar))
        ElseIf Rbpesosv.Checked Then
            TxtTventa.Text = Str(calcularVenta(TxtVenta.Text, TPesos))
        ElseIf Rbeurosv.Checked Then
            TxtTventa.Text = Str(calcularVenta(TxtVenta.Text, TEuros))
        ElseIf Rbcolonesv.Checked Then
            TxtTventa.Text = Str(calcularVenta(TxtVenta.Text, TColon))
        Else MsgBox("Error, no seleccionó moneda de venta")
        End If

        If Rbdolarc.Checked Then
            TxtTcompra.Text = Str(calcularCompra(TxtCompra.Text, TDolar))
        ElseIf Rbpesosc.Checked Then
            TxtTcompra.Text = Str(calcularCompra(TxtCompra.Text, TPesos))
        ElseIf Rbeurosc.Checked Then
            TxtTcompra.Text = Str(calcularCompra(TxtCompra.Text, TEuros))
        ElseIf Rbcolonesc.Checked Then
            TxtTcompra.Text = Str(calcularCompra(TxtCompra.Text, TColon))
        Else MsgBox("Error, no seleccionó moneda de compra")
        End If

        TxtTotal.Text = Math.Round(Total_Compra + TCom_Venta - Sub_Venta, 2)
        'En el caso de que compran el cliente paga el total en Q más la comisión.
        'Si venden el cliente tendra que paga unicamente la comisión. 
        'La diferencia es la cantidad que se le debe dar al cliente, si en dado caso aplica. 
    End Sub
    Private Sub BtLimpiar_Click(sender As Object, e As EventArgs) Handles BtLimpiar.Click
        limpiar()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub TxtVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVenta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar números naturales")
        End If
    End Sub

    Private Sub TxtCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCompra.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar números naturales")
        End If
    End Sub
End Class

