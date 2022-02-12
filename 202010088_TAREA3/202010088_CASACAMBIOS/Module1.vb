Module Module1
    Public Const TDolar = 7.69
    Public Const TPesos = 0.38
    Public Const TEuros = 8.79
    Public Const TColon = 0.012
    Public Const ComCompra = 0.025
    Public Const ComVenta = 0.03

    Public Sub_Compra = 0
    Public TCom_Compra = 0
    Public Total_Compra = 0
    Public Sub_Venta = 0
    Public TCom_Venta = 0
    Public Total_Venta = 0
    Public Total = 0

    Sub limpiar()
        Form1.TxtCompra.Clear()
        Form1.TxtVenta.Clear()
        Form1.TxtTcompra.Clear()
        Form1.TxtTventa.Clear()
        Form1.TxtTotal.Clear()
        Form1.CbCompra.Checked = False
        Form1.CbVenta.Checked = False
        Form1.Rbdolarv.Checked = False
        Form1.Rbpesosv.Checked = False
        Form1.Rbeurosv.Checked = False
        Form1.Rbcolonesv.Checked = False
        Form1.Rbdolarc.Checked = False
        Form1.Rbpesosc.Checked = False
        Form1.Rbeurosc.Checked = False
        Form1.Rbcolonesc.Checked = False

    End Sub
    Function calcularCompra(CCompra As Double, TipoCompra As Double) As Double
        If CCompra > 0 Then
            Sub_Compra = CCompra / TipoCompra
            TCom_Compra = Sub_Compra * ComCompra
            Total_Compra = Sub_Compra + TCom_Compra
        End If
        Return Math.Round(Total_Compra, 2)
    End Function

    Function calcularVenta(CVenta As Double, TipoVenta As Double) As Double
        If CVenta > 0 Then
            Sub_Venta = CVenta * TipoVenta
            TCom_Venta = Sub_Venta * ComVenta
            Total_Venta = Sub_Venta + TCom_Venta
        End If
        Return Math.Round(Total_Venta, 2)
    End Function

End Module
