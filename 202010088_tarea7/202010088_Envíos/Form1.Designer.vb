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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbenvio = New System.Windows.Forms.ComboBox()
        Me.Cbtipo = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Txtcliente = New System.Windows.Forms.TextBox()
        Me.Txtvalor = New System.Windows.Forms.TextBox()
        Me.Txtpeso = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtloc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txtpla = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txtrop = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txtdoc = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Btcalcular = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor del paquete: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peso del paquete: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo del paquete: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(436, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Forma de envío: "
        '
        'Cbenvio
        '
        Me.Cbenvio.FormattingEnabled = True
        Me.Cbenvio.Items.AddRange(New Object() {"Camión", "Motocicleta"})
        Me.Cbenvio.Location = New System.Drawing.Point(561, 181)
        Me.Cbenvio.Name = "Cbenvio"
        Me.Cbenvio.Size = New System.Drawing.Size(166, 28)
        Me.Cbenvio.TabIndex = 5
        '
        'Cbtipo
        '
        Me.Cbtipo.FormattingEnabled = True
        Me.Cbtipo.Items.AddRange(New Object() {"Documentos", "Ropa", "Artículos pedecederos", "Artículos de plástico", "Lociones"})
        Me.Cbtipo.Location = New System.Drawing.Point(182, 181)
        Me.Cbtipo.Name = "Cbtipo"
        Me.Cbtipo.Size = New System.Drawing.Size(217, 28)
        Me.Cbtipo.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.MostrarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(791, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar vectores"
        '
        'MostrarVectoresToolStripMenuItem
        '
        Me.MostrarVectoresToolStripMenuItem.Name = "MostrarVectoresToolStripMenuItem"
        Me.MostrarVectoresToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.MostrarVectoresToolStripMenuItem.Text = "Mostrar vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 253)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(199, 204)
        Me.ListBox1.TabIndex = 8
        '
        'Txtcliente
        '
        Me.Txtcliente.Location = New System.Drawing.Point(167, 88)
        Me.Txtcliente.Name = "Txtcliente"
        Me.Txtcliente.Size = New System.Drawing.Size(388, 27)
        Me.Txtcliente.TabIndex = 9
        '
        'Txtvalor
        '
        Me.Txtvalor.Location = New System.Drawing.Point(182, 135)
        Me.Txtvalor.Name = "Txtvalor"
        Me.Txtvalor.Size = New System.Drawing.Size(153, 27)
        Me.Txtvalor.TabIndex = 10
        '
        'Txtpeso
        '
        Me.Txtpeso.Location = New System.Drawing.Point(528, 135)
        Me.Txtpeso.Name = "Txtpeso"
        Me.Txtpeso.Size = New System.Drawing.Size(153, 27)
        Me.Txtpeso.TabIndex = 11
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(217, 253)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(138, 204)
        Me.ListBox2.TabIndex = 12
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(361, 253)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(100, 204)
        Me.ListBox3.TabIndex = 13
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(467, 253)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(100, 204)
        Me.ListBox4.TabIndex = 14
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(574, 253)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(91, 204)
        Me.ListBox5.TabIndex = 15
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 20
        Me.ListBox6.Location = New System.Drawing.Point(671, 253)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(100, 204)
        Me.ListBox6.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SimSun-ExtB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(246, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(321, 33)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Control de pedidos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nombre cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tipo del paquete: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(388, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Valor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(467, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Pago parcial:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(574, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Impuesto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(671, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Pago total: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(687, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "kg."
        '
        'Txtloc
        '
        Me.Txtloc.Location = New System.Drawing.Point(433, 486)
        Me.Txtloc.Name = "Txtloc"
        Me.Txtloc.Size = New System.Drawing.Size(222, 27)
        Me.Txtloc.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(41, 489)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(362, 20)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Total de lo que se envió de los paquetes de Lociones:"
        '
        'Txtpla
        '
        Me.Txtpla.Location = New System.Drawing.Point(433, 524)
        Me.Txtpla.Name = "Txtpla"
        Me.Txtpla.Size = New System.Drawing.Size(222, 27)
        Me.Txtpla.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(41, 527)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(367, 20)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Cuántos paquetes de artículos de plástico se enviaron:"
        '
        'Txtrop
        '
        Me.Txtrop.Location = New System.Drawing.Point(433, 601)
        Me.Txtrop.Name = "Txtrop"
        Me.Txtrop.Size = New System.Drawing.Size(222, 27)
        Me.Txtrop.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(41, 604)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(295, 20)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Total de paquetes de ropa que se enviaron:"
        '
        'Txtdoc
        '
        Me.Txtdoc.Location = New System.Drawing.Point(433, 563)
        Me.Txtdoc.Name = "Txtdoc"
        Me.Txtdoc.Size = New System.Drawing.Size(222, 27)
        Me.Txtdoc.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(41, 566)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(386, 20)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Total de lo que se envió de los paquetes de documentos:"
        '
        'Btcalcular
        '
        Me.Btcalcular.Location = New System.Drawing.Point(674, 550)
        Me.Btcalcular.Name = "Btcalcular"
        Me.Btcalcular.Size = New System.Drawing.Size(81, 27)
        Me.Btcalcular.TabIndex = 33
        Me.Btcalcular.Text = "Calcular"
        Me.Btcalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(791, 657)
        Me.Controls.Add(Me.Btcalcular)
        Me.Controls.Add(Me.Txtrop)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Txtdoc)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Txtpla)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Txtloc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Txtpeso)
        Me.Controls.Add(Me.Txtvalor)
        Me.Controls.Add(Me.Txtcliente)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Cbtipo)
        Me.Controls.Add(Me.Cbenvio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cbenvio As ComboBox
    Friend WithEvents Cbtipo As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Txtcliente As TextBox
    Friend WithEvents Txtvalor As TextBox
    Friend WithEvents Txtpeso As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Txtloc As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Txtpla As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Txtrop As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Txtdoc As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Btcalcular As Button
End Class
