Module Module1
    Public COMISION1 As Double
    Public BONO1 As Double

    Public posicion As Byte = 0
    Public Empleado(7) As String
    Public Valorbruto(7) As Double
    Public Articulo(7) As String
    Public Comision(7) As Double
    Public Bono(7) As Double
    Public Final(7) As Double


    Sub muestre_totales()
        Form1.Nombre.Items.Add(Empleado(posicion))
        Form1.Sueldo.Items.Add(Str(Valorbruto(posicion)))
        Form1.Artículo.Items.Add(Articulo(posicion))
        Form1.Comisión.Items.Add(Str(Comision(posicion)))
        Form1.Bono.Items.Add(Str(Bono(posicion)))
        Form1.Final.Items.Add(Str(Final(posicion)))
    End Sub

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.RadioButton1.Checked = 0
        Form1.RadioButton2.Checked = 0
        Form1.RadioButton3.Checked = 0
        Form1.RadioButton4.Checked = 0
        Form1.TextBox1.Focus()


    End Sub

    Sub LIMPIAR_VECTORES()
        posicion = 0

        Form1.Nombre.Items.Clear()
        Form1.Sueldo.Items.Clear()
        Form1.Artículo.Items.Clear()
        Form1.Comisión.Items.Clear()
        Form1.Bono.Items.Clear()
        Form1.Final.Items.Clear()


    End Sub


End Module
