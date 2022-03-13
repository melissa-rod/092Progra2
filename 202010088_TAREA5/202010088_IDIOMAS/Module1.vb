Module Module1
    Public matriz(11, 7)
    Public Indice = 0

    Public Parcial As Double = 0
    Public Desc1 As Double = 0
    Public Desc2 As Double = 0
    Public Total As Double = 0
    Public HORAS As Byte

    Public Const Des1C = 0.015
    Public Const Des1E = 0.02
    Public Const Des2d = 0.05

    Sub LIMPIAR()

        Form1.Txtcarne.Clear()
        Form1.Txthoras.Clear()
        Form1.Txtnombre.Clear()
        Form1.Rbcheque.Checked = False
        Form1.Rbefectivo.Checked = False
        Form1.Cbcurso.Text = ("")
        Form1.Cbxviernes.Checked = False
        Form1.Cbxsabado.Checked = False
        Form1.DataGridView1.Rows.Clear()
    End Sub


End Module
