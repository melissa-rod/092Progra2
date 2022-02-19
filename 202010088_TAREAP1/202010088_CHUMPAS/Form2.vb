Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txttcosto.Text = "Q." & Tcosto
        Txtpventa.Text = "Q." & Pventa
        Txtpcosto.Text = "Q." & Pcosto
    End Sub
    Private Sub Btregreso_Click(sender As Object, e As EventArgs) Handles Btregreso.Click
        If (MsgBox("ESTA SEGURO QUE DESEA REGRESAR?", vbQuestion + vbYesNo, "MENSAJE SALIDA") = vbYes) Then
            Form1.Show()
            Me.Hide()
        End If

    End Sub

End Class