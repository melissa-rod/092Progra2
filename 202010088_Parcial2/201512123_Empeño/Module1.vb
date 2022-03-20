Module Module1
    Public DESC1 As Double
    Public DESC2 As Double
    Public DESC3 As Double
    Public DESC4 As Double
    Public DESC5 As Double
    Public DESC6 As Double
    Public DESC7 As Double
    Public DESC8 As Double
    Public DESCTOTAL As Double
    Public PAR1 As Double
    Public PAR2 As Double
    Public PAR3 As Double
    Public PAR4 As Double
    Public PAR5 As Double
    Public PAR6 As Double
    Public PAR7 As Double
    Public PAR8 As Double
    Public VPARCIAL As Double


    Public Const TVLARGO = 300
    Public Const TVCORTO = 250
    Public Const TELLARGO = 600
    Public Const TELCORTO = 550
    Public Const LAPLARGO = 800
    Public Const LAPCORTO = 770
    Public Const REFLARGO = 1200
    Public Const REFCORTO = 1000

    Public matriz(6, 15)
    Public contador = 0

    Sub LIMPIAR_MATRIZ()
        ReDim matriz(6, 9)
    End Sub

    Sub LIMPIAR_LIST()
        Form1.Nombre.Items.Clear()
        Form1.Cui.Items.Clear()
        Form1.Dirección.Items.Clear()
        Form1.Plazo.Items.Clear()
        Form1.Tv.Items.Clear()
        Form1.Refrigeradora.Items.Clear()
        Form1.Teléfono.Items.Clear()
        Form1.Laptop.Items.Clear()
        Form1.CostoTv.Items.Clear()
        Form1.CostoLap.Items.Clear()
        Form1.CostoTel.Items.Clear()
        Form1.CostoRefri.Items.Clear()
        Form1.Parcial.Items.Clear()
        Form1.Descuento.Items.Clear()
        Form1.Final.Items.Clear()

    End Sub

    Sub LIMPIAR_ENTRADAS()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.Cbxtel.Checked = 0
        Form1.Cbxrefri.Checked = 0
        Form1.Cbxtv.Checked = 0
        Form1.CbxLap.Checked = 0
        Form1.Txtcostotv.Clear()
        Form1.Txtcostolap.Clear()
        Form1.Txtcostorefri.Clear()
        Form1.Txtcostotel.Clear()
        Form1.Txtnombre.Clear()
        Form1.Txtcui.Clear()
        Form1.Txtdireccion.Clear()

        Form1.Txtnombre.Focus()

    End Sub
    Sub MOSTRAR_DATOS()
        Form1.Nombre.Items.Add(matriz(contador, 0))
        Form1.Cui.Items.Add(matriz(contador, 1))
        Form1.Dirección.Items.Add(matriz(contador, 2))
        Form1.Plazo.Items.Add(matriz(contador, 3))

        Form1.Tv.Items.Add(matriz(contador, 4))
        Form1.Teléfono.Items.Add(matriz(contador, 5))
        Form1.Laptop.Items.Add(matriz(contador, 6))
        Form1.Refrigeradora.Items.Add(matriz(contador, 7))

        Form1.CostoTv.Items.Add(matriz(contador, 8))
        Form1.CostoTel.Items.Add(matriz(contador, 9))
        Form1.CostoLap.Items.Add(matriz(contador, 10))
        Form1.CostoRefri.Items.Add(matriz(contador, 11))


        Form1.Parcial.Items.Add(matriz(contador, 12))
        Form1.Descuento.Items.Add(matriz(contador, 13))
        Form1.Final.Items.Add(matriz(contador, 14))

    End Sub
End Module
