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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtcostotv = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Cbxtv = New System.Windows.Forms.CheckBox()
        Me.Cbxtel = New System.Windows.Forms.CheckBox()
        Me.CbxLap = New System.Windows.Forms.CheckBox()
        Me.Cbxrefri = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.Txtcui = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txtcostorefri = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtcostolap = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtcostotel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cui = New System.Windows.Forms.ListBox()
        Me.Dirección = New System.Windows.Forms.ListBox()
        Me.Plazo = New System.Windows.Forms.ListBox()
        Me.Tv = New System.Windows.Forms.ListBox()
        Me.CostoTv = New System.Windows.Forms.ListBox()
        Me.Parcial = New System.Windows.Forms.ListBox()
        Me.Descuento = New System.Windows.Forms.ListBox()
        Me.Final = New System.Windows.Forms.ListBox()
        Me.Teléfono = New System.Windows.Forms.ListBox()
        Me.Laptop = New System.Windows.Forms.ListBox()
        Me.Refrigeradora = New System.Windows.Forms.ListBox()
        Me.CostoTel = New System.Windows.Forms.ListBox()
        Me.CostoLap = New System.Windows.Forms.ListBox()
        Me.CostoRefri = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plazo:"
        '
        'Txtcostotv
        '
        Me.Txtcostotv.Location = New System.Drawing.Point(219, 26)
        Me.Txtcostotv.Name = "Txtcostotv"
        Me.Txtcostotv.Size = New System.Drawing.Size(125, 27)
        Me.Txtcostotv.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.FormattingEnabled = True
        Me.Nombre.ItemHeight = 20
        Me.Nombre.Location = New System.Drawing.Point(28, 266)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(168, 124)
        Me.Nombre.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Corto", "Largo "})
        Me.ComboBox1.Location = New System.Drawing.Point(133, 204)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 28)
        Me.ComboBox1.TabIndex = 5
        '
        'Cbxtv
        '
        Me.Cbxtv.AutoSize = True
        Me.Cbxtv.Location = New System.Drawing.Point(19, 26)
        Me.Cbxtv.Name = "Cbxtv"
        Me.Cbxtv.Size = New System.Drawing.Size(48, 24)
        Me.Cbxtv.TabIndex = 6
        Me.Cbxtv.Text = "TV"
        Me.Cbxtv.UseVisualStyleBackColor = True
        '
        'Cbxtel
        '
        Me.Cbxtel.AutoSize = True
        Me.Cbxtel.Location = New System.Drawing.Point(19, 56)
        Me.Cbxtel.Name = "Cbxtel"
        Me.Cbxtel.Size = New System.Drawing.Size(89, 24)
        Me.Cbxtel.TabIndex = 7
        Me.Cbxtel.Text = "Teléfono"
        Me.Cbxtel.UseVisualStyleBackColor = True
        '
        'CbxLap
        '
        Me.CbxLap.AutoSize = True
        Me.CbxLap.Location = New System.Drawing.Point(19, 86)
        Me.CbxLap.Name = "CbxLap"
        Me.CbxLap.Size = New System.Drawing.Size(78, 24)
        Me.CbxLap.TabIndex = 8
        Me.CbxLap.Text = "Laptop"
        Me.CbxLap.UseVisualStyleBackColor = True
        '
        'Cbxrefri
        '
        Me.Cbxrefri.AutoSize = True
        Me.Cbxrefri.Location = New System.Drawing.Point(19, 123)
        Me.Cbxrefri.Name = "Cbxrefri"
        Me.Cbxrefri.Size = New System.Drawing.Size(123, 24)
        Me.Cbxrefri.TabIndex = 9
        Me.Cbxrefri.Text = "Refrigeradora"
        Me.Cbxrefri.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Costo: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Txtcui)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txtnombre)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 119)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Dirección:"
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Location = New System.Drawing.Point(83, 71)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(372, 27)
        Me.Txtdireccion.TabIndex = 16
        '
        'Txtcui
        '
        Me.Txtcui.Location = New System.Drawing.Point(407, 26)
        Me.Txtcui.Name = "Txtcui"
        Me.Txtcui.Size = New System.Drawing.Size(154, 27)
        Me.Txtcui.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cui: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nombre: "
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(83, 26)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(257, 27)
        Me.Txtnombre.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txtcostorefri)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Txtcostolap)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txtcostotel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Cbxtv)
        Me.GroupBox2.Controls.Add(Me.Cbxtel)
        Me.GroupBox2.Controls.Add(Me.CbxLap)
        Me.GroupBox2.Controls.Add(Me.Cbxrefri)
        Me.GroupBox2.Controls.Add(Me.Txtcostotv)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(637, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 167)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipos de aparatos"
        '
        'Txtcostorefri
        '
        Me.Txtcostorefri.Location = New System.Drawing.Point(219, 124)
        Me.Txtcostorefri.Name = "Txtcostorefri"
        Me.Txtcostorefri.Size = New System.Drawing.Size(125, 27)
        Me.Txtcostorefri.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(165, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Costo: "
        '
        'Txtcostolap
        '
        Me.Txtcostolap.Location = New System.Drawing.Point(219, 92)
        Me.Txtcostolap.Name = "Txtcostolap"
        Me.Txtcostolap.Size = New System.Drawing.Size(125, 27)
        Me.Txtcostolap.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Costo: "
        '
        'Txtcostotel
        '
        Me.Txtcostotel.Location = New System.Drawing.Point(219, 59)
        Me.Txtcostotel.Name = "Txtcostotel"
        Me.Txtcostotel.Size = New System.Drawing.Size(125, 27)
        Me.Txtcostotel.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Costo: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.LimpiarListboxToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'LimpiarListboxToolStripMenuItem
        '
        Me.LimpiarListboxToolStripMenuItem.Name = "LimpiarListboxToolStripMenuItem"
        Me.LimpiarListboxToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.LimpiarListboxToolStripMenuItem.Text = "Limpiar Listbox"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Cui
        '
        Me.Cui.FormattingEnabled = True
        Me.Cui.ItemHeight = 20
        Me.Cui.Location = New System.Drawing.Point(205, 266)
        Me.Cui.Name = "Cui"
        Me.Cui.Size = New System.Drawing.Size(119, 124)
        Me.Cui.TabIndex = 16
        '
        'Dirección
        '
        Me.Dirección.FormattingEnabled = True
        Me.Dirección.ItemHeight = 20
        Me.Dirección.Location = New System.Drawing.Point(339, 266)
        Me.Dirección.Name = "Dirección"
        Me.Dirección.Size = New System.Drawing.Size(183, 124)
        Me.Dirección.TabIndex = 17
        '
        'Plazo
        '
        Me.Plazo.FormattingEnabled = True
        Me.Plazo.ItemHeight = 20
        Me.Plazo.Location = New System.Drawing.Point(528, 266)
        Me.Plazo.Name = "Plazo"
        Me.Plazo.Size = New System.Drawing.Size(144, 124)
        Me.Plazo.TabIndex = 18
        '
        'Tv
        '
        Me.Tv.FormattingEnabled = True
        Me.Tv.ItemHeight = 20
        Me.Tv.Location = New System.Drawing.Point(687, 266)
        Me.Tv.Name = "Tv"
        Me.Tv.Size = New System.Drawing.Size(57, 124)
        Me.Tv.TabIndex = 19
        '
        'CostoTv
        '
        Me.CostoTv.FormattingEnabled = True
        Me.CostoTv.ItemHeight = 20
        Me.CostoTv.Location = New System.Drawing.Point(34, 438)
        Me.CostoTv.Name = "CostoTv"
        Me.CostoTv.Size = New System.Drawing.Size(119, 124)
        Me.CostoTv.TabIndex = 20
        '
        'Parcial
        '
        Me.Parcial.FormattingEnabled = True
        Me.Parcial.ItemHeight = 20
        Me.Parcial.Location = New System.Drawing.Point(568, 438)
        Me.Parcial.Name = "Parcial"
        Me.Parcial.Size = New System.Drawing.Size(119, 124)
        Me.Parcial.TabIndex = 21
        '
        'Descuento
        '
        Me.Descuento.FormattingEnabled = True
        Me.Descuento.ItemHeight = 20
        Me.Descuento.Location = New System.Drawing.Point(722, 438)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(119, 124)
        Me.Descuento.TabIndex = 22
        '
        'Final
        '
        Me.Final.FormattingEnabled = True
        Me.Final.ItemHeight = 20
        Me.Final.Location = New System.Drawing.Point(871, 438)
        Me.Final.Name = "Final"
        Me.Final.Size = New System.Drawing.Size(119, 124)
        Me.Final.TabIndex = 23
        '
        'Teléfono
        '
        Me.Teléfono.FormattingEnabled = True
        Me.Teléfono.ItemHeight = 20
        Me.Teléfono.Location = New System.Drawing.Point(750, 266)
        Me.Teléfono.Name = "Teléfono"
        Me.Teléfono.Size = New System.Drawing.Size(70, 124)
        Me.Teléfono.TabIndex = 24
        '
        'Laptop
        '
        Me.Laptop.FormattingEnabled = True
        Me.Laptop.ItemHeight = 20
        Me.Laptop.Location = New System.Drawing.Point(826, 266)
        Me.Laptop.Name = "Laptop"
        Me.Laptop.Size = New System.Drawing.Size(57, 124)
        Me.Laptop.TabIndex = 25
        '
        'Refrigeradora
        '
        Me.Refrigeradora.FormattingEnabled = True
        Me.Refrigeradora.ItemHeight = 20
        Me.Refrigeradora.Location = New System.Drawing.Point(889, 266)
        Me.Refrigeradora.Name = "Refrigeradora"
        Me.Refrigeradora.Size = New System.Drawing.Size(105, 124)
        Me.Refrigeradora.TabIndex = 26
        '
        'CostoTel
        '
        Me.CostoTel.FormattingEnabled = True
        Me.CostoTel.ItemHeight = 20
        Me.CostoTel.Location = New System.Drawing.Point(171, 438)
        Me.CostoTel.Name = "CostoTel"
        Me.CostoTel.Size = New System.Drawing.Size(119, 124)
        Me.CostoTel.TabIndex = 27
        '
        'CostoLap
        '
        Me.CostoLap.FormattingEnabled = True
        Me.CostoLap.ItemHeight = 20
        Me.CostoLap.Location = New System.Drawing.Point(306, 438)
        Me.CostoLap.Name = "CostoLap"
        Me.CostoLap.Size = New System.Drawing.Size(119, 124)
        Me.CostoLap.TabIndex = 28
        '
        'CostoRefri
        '
        Me.CostoRefri.FormattingEnabled = True
        Me.CostoRefri.ItemHeight = 20
        Me.CostoRefri.Location = New System.Drawing.Point(431, 438)
        Me.CostoRefri.Name = "CostoRefri"
        Me.CostoRefri.Size = New System.Drawing.Size(119, 124)
        Me.CostoRefri.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(205, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Cui:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(339, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Dirección:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(528, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 20)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Plazo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(687, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 20)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Tv:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(750, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 20)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Teléfono:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(826, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Laptop:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(891, 243)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Refrigeradora:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(38, 415)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 20)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Costo Tv:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(171, 415)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 20)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Costo Tel.:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(306, 415)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 20)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Costo laptop:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(431, 415)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 20)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Costo Refri.:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(568, 415)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 20)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Parcial:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(722, 415)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 20)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Descuento:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(871, 415)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 20)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Final:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1067, 574)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CostoRefri)
        Me.Controls.Add(Me.CostoLap)
        Me.Controls.Add(Me.CostoTel)
        Me.Controls.Add(Me.Refrigeradora)
        Me.Controls.Add(Me.Laptop)
        Me.Controls.Add(Me.Teléfono)
        Me.Controls.Add(Me.Final)
        Me.Controls.Add(Me.Descuento)
        Me.Controls.Add(Me.Parcial)
        Me.Controls.Add(Me.CostoTv)
        Me.Controls.Add(Me.Tv)
        Me.Controls.Add(Me.Plazo)
        Me.Controls.Add(Me.Dirección)
        Me.Controls.Add(Me.Cui)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txtcostotv As TextBox
    Friend WithEvents Nombre As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Cbxtv As CheckBox
    Friend WithEvents Cbxtel As CheckBox
    Friend WithEvents CbxLap As CheckBox
    Friend WithEvents Cbxrefri As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtdireccion As TextBox
    Friend WithEvents Txtcui As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cui As ListBox
    Friend WithEvents Dirección As ListBox
    Friend WithEvents Plazo As ListBox
    Friend WithEvents Tv As ListBox
    Friend WithEvents CostoTv As ListBox
    Friend WithEvents Parcial As ListBox
    Friend WithEvents Descuento As ListBox
    Friend WithEvents Final As ListBox
    Friend WithEvents Teléfono As ListBox
    Friend WithEvents Laptop As ListBox
    Friend WithEvents Refrigeradora As ListBox
    Friend WithEvents CostoTel As ListBox
    Friend WithEvents CostoLap As ListBox
    Friend WithEvents CostoRefri As ListBox
    Friend WithEvents Txtcostorefri As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txtcostolap As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtcostotel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
End Class
