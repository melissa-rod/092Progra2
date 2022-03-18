Module Module1
    Public Preciotela As Double
    Public yardastela As Double
    Public Manoobra As Double

    Public INDICE As Byte = 0
    Public No_venta(8) As Integer
    Public Cantidad(8) As Integer
    Public Tamaño(8) As String
    Public Tipotela(8) As String
    Public costo(8) As Double
    Public precio(8) As Double


    Sub Tipo_tela()
        If Form1.Rbtcuerina.Checked Then
            Tipotela(INDICE) = "Cuerina"
        ElseIf Form1.Rbtcuero.Checked Then
            Tipotela(INDICE) = "Cuero"
        Else MsgBox("ERROR, NO SELECCIONÓ TIPO DE TELA")
        End If
    End Sub

    Sub mostrar_datos()
        Form1.DataGridView1.Rows.Add(No_venta(INDICE), Str(Cantidad(INDICE)), Tamaño(INDICE), Tipotela(INDICE), Str(costo(INDICE)), Str(precio(INDICE)))
    End Sub


    Sub LIMPIAR_ENTRADAS()
        Form1.Txt_venta.Clear()
        Form1.Txtcantidad.Clear()
        Form1.Cbxtamaños.SelectedIndex = -1
        Form1.Rbtcuero.Checked = 0
        Form1.Rbtcuerina.Checked = 0
        Form1.Txt_venta.Focus()
    End Sub
    Sub LIMPIAR_GRID()
        Form1.DataGridView1.Rows.Clear()
    End Sub

End Module
