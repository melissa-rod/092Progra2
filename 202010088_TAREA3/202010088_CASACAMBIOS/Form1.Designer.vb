<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbCompra = New System.Windows.Forms.CheckBox()
        Me.CbVenta = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCompra = New System.Windows.Forms.TextBox()
        Me.TxtVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.BtLimpiar = New System.Windows.Forms.Button()
        Me.BtCalcular = New System.Windows.Forms.Button()
        Me.GroupVenta = New System.Windows.Forms.GroupBox()
        Me.Rbcolonesv = New System.Windows.Forms.RadioButton()
        Me.Rbeurosv = New System.Windows.Forms.RadioButton()
        Me.Rbpesosv = New System.Windows.Forms.RadioButton()
        Me.Rbdolarv = New System.Windows.Forms.RadioButton()
        Me.GroupCompra = New System.Windows.Forms.GroupBox()
        Me.Rbcolonesc = New System.Windows.Forms.RadioButton()
        Me.Rbeurosc = New System.Windows.Forms.RadioButton()
        Me.Rbdolarc = New System.Windows.Forms.RadioButton()
        Me.Rbpesosc = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtTcompra = New System.Windows.Forms.TextBox()
        Me.TxtTventa = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupVenta.SuspendLayout()
        Me.GroupCompra.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbCompra)
        Me.GroupBox1.Controls.Add(Me.CbVenta)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transacción"
        '
        'CbCompra
        '
        Me.CbCompra.AutoSize = True
        Me.CbCompra.Location = New System.Drawing.Point(16, 69)
        Me.CbCompra.Name = "CbCompra"
        Me.CbCompra.Size = New System.Drawing.Size(84, 24)
        Me.CbCompra.TabIndex = 1
        Me.CbCompra.Text = "Compra"
        Me.CbCompra.UseVisualStyleBackColor = True
        '
        'CbVenta
        '
        Me.CbVenta.AutoSize = True
        Me.CbVenta.Location = New System.Drawing.Point(16, 26)
        Me.CbVenta.Name = "CbVenta"
        Me.CbVenta.Size = New System.Drawing.Size(68, 24)
        Me.CbVenta.TabIndex = 0
        Me.CbVenta.Text = "Venta"
        Me.CbVenta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCompra)
        Me.GroupBox2.Controls.Add(Me.TxtVenta)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(136, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(196, 120)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cantidades"
        '
        'TxtCompra
        '
        Me.TxtCompra.Enabled = False
        Me.TxtCompra.Location = New System.Drawing.Point(63, 67)
        Me.TxtCompra.Name = "TxtCompra"
        Me.TxtCompra.Size = New System.Drawing.Size(125, 27)
        Me.TxtCompra.TabIndex = 3
        '
        'TxtVenta
        '
        Me.TxtVenta.Enabled = False
        Me.TxtVenta.Location = New System.Drawing.Point(63, 24)
        Me.TxtVenta.Name = "TxtVenta"
        Me.TxtVenta.Size = New System.Drawing.Size(125, 27)
        Me.TxtVenta.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtSalir)
        Me.GroupBox3.Controls.Add(Me.BtLimpiar)
        Me.GroupBox3.Controls.Add(Me.BtCalcular)
        Me.GroupBox3.Location = New System.Drawing.Point(338, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(119, 142)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(6, 100)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(94, 29)
        Me.BtSalir.TabIndex = 2
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'BtLimpiar
        '
        Me.BtLimpiar.Location = New System.Drawing.Point(6, 65)
        Me.BtLimpiar.Name = "BtLimpiar"
        Me.BtLimpiar.Size = New System.Drawing.Size(94, 29)
        Me.BtLimpiar.TabIndex = 1
        Me.BtLimpiar.Text = "Limpiar"
        Me.BtLimpiar.UseVisualStyleBackColor = True
        '
        'BtCalcular
        '
        Me.BtCalcular.Location = New System.Drawing.Point(6, 27)
        Me.BtCalcular.Name = "BtCalcular"
        Me.BtCalcular.Size = New System.Drawing.Size(94, 29)
        Me.BtCalcular.TabIndex = 0
        Me.BtCalcular.Text = "Calcular"
        Me.BtCalcular.UseVisualStyleBackColor = True
        '
        'GroupVenta
        '
        Me.GroupVenta.Controls.Add(Me.Rbcolonesv)
        Me.GroupVenta.Controls.Add(Me.Rbeurosv)
        Me.GroupVenta.Controls.Add(Me.Rbpesosv)
        Me.GroupVenta.Controls.Add(Me.Rbdolarv)
        Me.GroupVenta.Location = New System.Drawing.Point(44, 182)
        Me.GroupVenta.Name = "GroupVenta"
        Me.GroupVenta.Size = New System.Drawing.Size(173, 155)
        Me.GroupVenta.TabIndex = 3
        Me.GroupVenta.TabStop = False
        Me.GroupVenta.Text = "Moneda (Venta)"
        Me.GroupVenta.Visible = False
        '
        'Rbcolonesv
        '
        Me.Rbcolonesv.AutoSize = True
        Me.Rbcolonesv.Location = New System.Drawing.Point(12, 119)
        Me.Rbcolonesv.Name = "Rbcolonesv"
        Me.Rbcolonesv.Size = New System.Drawing.Size(161, 24)
        Me.Rbcolonesv.TabIndex = 3
        Me.Rbcolonesv.TabStop = True
        Me.Rbcolonesv.Text = "Colon Costarricense"
        Me.Rbcolonesv.UseVisualStyleBackColor = True
        '
        'Rbeurosv
        '
        Me.Rbeurosv.AutoSize = True
        Me.Rbeurosv.Location = New System.Drawing.Point(12, 93)
        Me.Rbeurosv.Name = "Rbeurosv"
        Me.Rbeurosv.Size = New System.Drawing.Size(60, 24)
        Me.Rbeurosv.TabIndex = 2
        Me.Rbeurosv.TabStop = True
        Me.Rbeurosv.Text = "Euro"
        Me.Rbeurosv.UseVisualStyleBackColor = True
        '
        'Rbpesosv
        '
        Me.Rbpesosv.AutoSize = True
        Me.Rbpesosv.Location = New System.Drawing.Point(12, 63)
        Me.Rbpesosv.Name = "Rbpesosv"
        Me.Rbpesosv.Size = New System.Drawing.Size(128, 24)
        Me.Rbpesosv.TabIndex = 1
        Me.Rbpesosv.TabStop = True
        Me.Rbpesosv.Text = "Peso mexicano"
        Me.Rbpesosv.UseVisualStyleBackColor = True
        '
        'Rbdolarv
        '
        Me.Rbdolarv.AutoSize = True
        Me.Rbdolarv.Location = New System.Drawing.Point(12, 33)
        Me.Rbdolarv.Name = "Rbdolarv"
        Me.Rbdolarv.Size = New System.Drawing.Size(67, 24)
        Me.Rbdolarv.TabIndex = 0
        Me.Rbdolarv.TabStop = True
        Me.Rbdolarv.Text = "Dolar"
        Me.Rbdolarv.UseVisualStyleBackColor = True
        '
        'GroupCompra
        '
        Me.GroupCompra.Controls.Add(Me.Rbcolonesc)
        Me.GroupCompra.Controls.Add(Me.Rbeurosc)
        Me.GroupCompra.Controls.Add(Me.Rbdolarc)
        Me.GroupCompra.Controls.Add(Me.Rbpesosc)
        Me.GroupCompra.Location = New System.Drawing.Point(262, 182)
        Me.GroupCompra.Name = "GroupCompra"
        Me.GroupCompra.Size = New System.Drawing.Size(168, 155)
        Me.GroupCompra.TabIndex = 4
        Me.GroupCompra.TabStop = False
        Me.GroupCompra.Text = "Moneda (Compra)"
        Me.GroupCompra.Visible = False
        '
        'Rbcolonesc
        '
        Me.Rbcolonesc.AutoSize = True
        Me.Rbcolonesc.Location = New System.Drawing.Point(6, 119)
        Me.Rbcolonesc.Name = "Rbcolonesc"
        Me.Rbcolonesc.Size = New System.Drawing.Size(161, 24)
        Me.Rbcolonesc.TabIndex = 7
        Me.Rbcolonesc.TabStop = True
        Me.Rbcolonesc.Text = "Colon Costarricense"
        Me.Rbcolonesc.UseVisualStyleBackColor = True
        '
        'Rbeurosc
        '
        Me.Rbeurosc.AutoSize = True
        Me.Rbeurosc.Location = New System.Drawing.Point(6, 89)
        Me.Rbeurosc.Name = "Rbeurosc"
        Me.Rbeurosc.Size = New System.Drawing.Size(60, 24)
        Me.Rbeurosc.TabIndex = 6
        Me.Rbeurosc.TabStop = True
        Me.Rbeurosc.Text = "Euro"
        Me.Rbeurosc.UseVisualStyleBackColor = True
        '
        'Rbdolarc
        '
        Me.Rbdolarc.AutoSize = True
        Me.Rbdolarc.Location = New System.Drawing.Point(6, 29)
        Me.Rbdolarc.Name = "Rbdolarc"
        Me.Rbdolarc.Size = New System.Drawing.Size(67, 24)
        Me.Rbdolarc.TabIndex = 4
        Me.Rbdolarc.TabStop = True
        Me.Rbdolarc.Text = "Dolar"
        Me.Rbdolarc.UseVisualStyleBackColor = True
        '
        'Rbpesosc
        '
        Me.Rbpesosc.AutoSize = True
        Me.Rbpesosc.Location = New System.Drawing.Point(6, 59)
        Me.Rbpesosc.Name = "Rbpesosc"
        Me.Rbpesosc.Size = New System.Drawing.Size(128, 24)
        Me.Rbpesosc.TabIndex = 5
        Me.Rbpesosc.TabStop = True
        Me.Rbpesosc.Text = "Peso mexicano"
        Me.Rbpesosc.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.TxtTotal)
        Me.GroupBox6.Controls.Add(Me.TxtTcompra)
        Me.GroupBox6.Controls.Add(Me.TxtTventa)
        Me.GroupBox6.Location = New System.Drawing.Point(25, 343)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(456, 81)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Totales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Pago total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total venta:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(325, 48)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(125, 27)
        Me.TxtTotal.TabIndex = 2
        '
        'TxtTcompra
        '
        Me.TxtTcompra.Location = New System.Drawing.Point(174, 48)
        Me.TxtTcompra.Name = "TxtTcompra"
        Me.TxtTcompra.Size = New System.Drawing.Size(125, 27)
        Me.TxtTcompra.TabIndex = 1
        '
        'TxtTventa
        '
        Me.TxtTventa.Location = New System.Drawing.Point(15, 48)
        Me.TxtTventa.Name = "TxtTventa"
        Me.TxtTventa.Size = New System.Drawing.Size(125, 27)
        Me.TxtTventa.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(491, 450)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupCompra)
        Me.Controls.Add(Me.GroupVenta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupVenta.ResumeLayout(False)
        Me.GroupVenta.PerformLayout()
        Me.GroupCompra.ResumeLayout(False)
        Me.GroupCompra.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbCompra As CheckBox
    Friend WithEvents CbVenta As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCompra As TextBox
    Friend WithEvents TxtVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtSalir As Button
    Friend WithEvents BtLimpiar As Button
    Friend WithEvents BtCalcular As Button
    Friend WithEvents GroupVenta As GroupBox
    Friend WithEvents Rbcolonesv As RadioButton
    Friend WithEvents Rbeurosv As RadioButton
    Friend WithEvents Rbpesosv As RadioButton
    Friend WithEvents Rbdolarv As RadioButton
    Friend WithEvents GroupCompra As GroupBox
    Friend WithEvents Rbcolonesc As RadioButton
    Friend WithEvents Rbeurosc As RadioButton
    Friend WithEvents Rbdolarc As RadioButton
    Friend WithEvents Rbpesosc As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtTcompra As TextBox
    Friend WithEvents TxtTventa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
