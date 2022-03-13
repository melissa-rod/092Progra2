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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtcarne = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cbcurso = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rbefectivo = New System.Windows.Forms.RadioButton()
        Me.Rbcheque = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cbxviernes = New System.Windows.Forms.CheckBox()
        Me.Cbxsabado = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Txthoras = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btnlimpiarm = New System.Windows.Forms.Button()
        Me.Btsalir = New System.Windows.Forms.Button()
        Me.Btlimpiar = New System.Windows.Forms.Button()
        Me.Btcalcular = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(445, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carné:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txtcarne)
        Me.GroupBox1.Controls.Add(Me.Txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 77)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos generales"
        '
        'Txtcarne
        '
        Me.Txtcarne.Location = New System.Drawing.Point(501, 35)
        Me.Txtcarne.Name = "Txtcarne"
        Me.Txtcarne.Size = New System.Drawing.Size(152, 27)
        Me.Txtcarne.TabIndex = 3
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(79, 35)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(351, 27)
        Me.Txtnombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Curso:"
        '
        'Cbcurso
        '
        Me.Cbcurso.FormattingEnabled = True
        Me.Cbcurso.Items.AddRange(New Object() {"Inglés", "Portugués", "Francés"})
        Me.Cbcurso.Location = New System.Drawing.Point(91, 31)
        Me.Cbcurso.Name = "Cbcurso"
        Me.Cbcurso.Size = New System.Drawing.Size(151, 28)
        Me.Cbcurso.TabIndex = 5
        Me.Cbcurso.Text = "Selecciona uno"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rbefectivo)
        Me.GroupBox2.Controls.Add(Me.Rbcheque)
        Me.GroupBox2.Location = New System.Drawing.Point(610, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 115)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Método pago"
        '
        'Rbefectivo
        '
        Me.Rbefectivo.AutoSize = True
        Me.Rbefectivo.Location = New System.Drawing.Point(20, 77)
        Me.Rbefectivo.Name = "Rbefectivo"
        Me.Rbefectivo.Size = New System.Drawing.Size(83, 24)
        Me.Rbefectivo.TabIndex = 1
        Me.Rbefectivo.TabStop = True
        Me.Rbefectivo.Text = "Efectivo"
        Me.Rbefectivo.UseVisualStyleBackColor = True
        '
        'Rbcheque
        '
        Me.Rbcheque.AutoSize = True
        Me.Rbcheque.Location = New System.Drawing.Point(20, 44)
        Me.Rbcheque.Name = "Rbcheque"
        Me.Rbcheque.Size = New System.Drawing.Size(80, 24)
        Me.Rbcheque.TabIndex = 0
        Me.Rbcheque.TabStop = True
        Me.Rbcheque.Text = "Cheque"
        Me.Rbcheque.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cbxviernes)
        Me.GroupBox3.Controls.Add(Me.Cbxsabado)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Dtpdate)
        Me.GroupBox3.Controls.Add(Me.Txthoras)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Cbcurso)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(573, 122)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información curso"
        '
        'Cbxviernes
        '
        Me.Cbxviernes.AutoSize = True
        Me.Cbxviernes.Location = New System.Drawing.Point(467, 45)
        Me.Cbxviernes.Name = "Cbxviernes"
        Me.Cbxviernes.Size = New System.Drawing.Size(79, 24)
        Me.Cbxviernes.TabIndex = 14
        Me.Cbxviernes.Text = "Viernes"
        Me.Cbxviernes.UseVisualStyleBackColor = True
        '
        'Cbxsabado
        '
        Me.Cbxsabado.AutoSize = True
        Me.Cbxsabado.Location = New System.Drawing.Point(467, 74)
        Me.Cbxsabado.Name = "Cbxsabado"
        Me.Cbxsabado.Size = New System.Drawing.Size(82, 24)
        Me.Cbxsabado.TabIndex = 13
        Me.Cbxsabado.Text = "Sábado"
        Me.Cbxsabado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha de inscripción:"
        '
        'Dtpdate
        '
        Me.Dtpdate.Location = New System.Drawing.Point(158, 75)
        Me.Dtpdate.Name = "Dtpdate"
        Me.Dtpdate.Size = New System.Drawing.Size(271, 27)
        Me.Dtpdate.TabIndex = 10
        '
        'Txthoras
        '
        Me.Txthoras.Location = New System.Drawing.Point(327, 30)
        Me.Txthoras.Name = "Txthoras"
        Me.Txthoras.Size = New System.Drawing.Size(63, 27)
        Me.Txthoras.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Horas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(419, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Día:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 250)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(902, 188)
        Me.DataGridView1.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btnlimpiarm)
        Me.GroupBox4.Controls.Add(Me.Btsalir)
        Me.GroupBox4.Controls.Add(Me.Btlimpiar)
        Me.GroupBox4.Controls.Add(Me.Btcalcular)
        Me.GroupBox4.Location = New System.Drawing.Point(741, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(159, 185)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acciones"
        '
        'Btnlimpiarm
        '
        Me.Btnlimpiarm.Location = New System.Drawing.Point(8, 106)
        Me.Btnlimpiarm.Name = "Btnlimpiarm"
        Me.Btnlimpiarm.Size = New System.Drawing.Size(140, 29)
        Me.Btnlimpiarm.TabIndex = 3
        Me.Btnlimpiarm.Text = "Limpiar matriz"
        Me.Btnlimpiarm.UseVisualStyleBackColor = True
        '
        'Btsalir
        '
        Me.Btsalir.Location = New System.Drawing.Point(34, 143)
        Me.Btsalir.Name = "Btsalir"
        Me.Btsalir.Size = New System.Drawing.Size(94, 29)
        Me.Btsalir.TabIndex = 2
        Me.Btsalir.Text = "Salir"
        Me.Btsalir.UseVisualStyleBackColor = True
        '
        'Btlimpiar
        '
        Me.Btlimpiar.Location = New System.Drawing.Point(34, 71)
        Me.Btlimpiar.Name = "Btlimpiar"
        Me.Btlimpiar.Size = New System.Drawing.Size(94, 29)
        Me.Btlimpiar.TabIndex = 1
        Me.Btlimpiar.Text = "Limpiar"
        Me.Btlimpiar.UseVisualStyleBackColor = True
        '
        'Btcalcular
        '
        Me.Btcalcular.Location = New System.Drawing.Point(34, 36)
        Me.Btcalcular.Name = "Btcalcular"
        Me.Btcalcular.Size = New System.Drawing.Size(94, 29)
        Me.Btcalcular.TabIndex = 0
        Me.Btcalcular.Text = "Calcular"
        Me.Btcalcular.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Reg."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.FillWeight = 120.0!
        Me.Column2.HeaderText = "Carné"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 170
        '
        'Column4
        '
        Me.Column4.HeaderText = "Curso"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Horas"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha de inscripción"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Días"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Método pago"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Total Parcial"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "Descuento 1"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column11
        '
        Me.Column11.HeaderText = "Descuento 2"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "Total final"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(930, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Cursos libres"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txtcarne As TextBox
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cbcurso As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Rbefectivo As RadioButton
    Friend WithEvents Rbcheque As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Txthoras As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Btsalir As Button
    Friend WithEvents Btlimpiar As Button
    Friend WithEvents Btcalcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Dtpdate As DateTimePicker
    Friend WithEvents Cbxviernes As CheckBox
    Friend WithEvents Cbxsabado As CheckBox
    Friend WithEvents Btnlimpiarm As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
End Class
