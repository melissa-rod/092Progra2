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
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBlarge = New System.Windows.Forms.RadioButton()
        Me.RBmedium = New System.Windows.Forms.RadioButton()
        Me.RBsmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBlona = New System.Windows.Forms.RadioButton()
        Me.RBseda = New System.Windows.Forms.RadioButton()
        Me.RBalgodon = New System.Windows.Forms.RadioButton()
        Me.Btcalcular = New System.Windows.Forms.Button()
        Me.Btlimpiar = New System.Windows.Forms.Button()
        Me.Btsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(209, 36)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(125, 27)
        Me.Txtcantidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de chumpas:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBlarge)
        Me.GroupBox1.Controls.Add(Me.RBmedium)
        Me.GroupBox1.Controls.Add(Me.RBsmall)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'RBlarge
        '
        Me.RBlarge.AutoSize = True
        Me.RBlarge.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBlarge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBlarge.Location = New System.Drawing.Point(20, 86)
        Me.RBlarge.Name = "RBlarge"
        Me.RBlarge.Size = New System.Drawing.Size(70, 25)
        Me.RBlarge.TabIndex = 4
        Me.RBlarge.TabStop = True
        Me.RBlarge.Text = "Large"
        Me.RBlarge.UseVisualStyleBackColor = True
        '
        'RBmedium
        '
        Me.RBmedium.AutoSize = True
        Me.RBmedium.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBmedium.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBmedium.Location = New System.Drawing.Point(20, 56)
        Me.RBmedium.Name = "RBmedium"
        Me.RBmedium.Size = New System.Drawing.Size(89, 25)
        Me.RBmedium.TabIndex = 3
        Me.RBmedium.TabStop = True
        Me.RBmedium.Text = "Medium"
        Me.RBmedium.UseVisualStyleBackColor = True
        '
        'RBsmall
        '
        Me.RBsmall.AutoSize = True
        Me.RBsmall.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBsmall.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBsmall.Location = New System.Drawing.Point(20, 26)
        Me.RBsmall.Name = "RBsmall"
        Me.RBsmall.Size = New System.Drawing.Size(70, 25)
        Me.RBsmall.TabIndex = 2
        Me.RBsmall.TabStop = True
        Me.RBsmall.Text = "Small"
        Me.RBsmall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBlona)
        Me.GroupBox2.Controls.Add(Me.RBseda)
        Me.GroupBox2.Controls.Add(Me.RBalgodon)
        Me.GroupBox2.Location = New System.Drawing.Point(217, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 127)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'RBlona
        '
        Me.RBlona.AutoSize = True
        Me.RBlona.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBlona.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBlona.Location = New System.Drawing.Point(21, 86)
        Me.RBlona.Name = "RBlona"
        Me.RBlona.Size = New System.Drawing.Size(65, 25)
        Me.RBlona.TabIndex = 4
        Me.RBlona.TabStop = True
        Me.RBlona.Text = "Lona"
        Me.RBlona.UseVisualStyleBackColor = True
        '
        'RBseda
        '
        Me.RBseda.AutoSize = True
        Me.RBseda.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBseda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBseda.Location = New System.Drawing.Point(21, 56)
        Me.RBseda.Name = "RBseda"
        Me.RBseda.Size = New System.Drawing.Size(65, 25)
        Me.RBseda.TabIndex = 3
        Me.RBseda.TabStop = True
        Me.RBseda.Text = "Seda"
        Me.RBseda.UseVisualStyleBackColor = True
        '
        'RBalgodon
        '
        Me.RBalgodon.AutoSize = True
        Me.RBalgodon.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBalgodon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBalgodon.Location = New System.Drawing.Point(21, 26)
        Me.RBalgodon.Name = "RBalgodon"
        Me.RBalgodon.Size = New System.Drawing.Size(90, 25)
        Me.RBalgodon.TabIndex = 2
        Me.RBalgodon.TabStop = True
        Me.RBalgodon.Text = "Algodón"
        Me.RBalgodon.UseVisualStyleBackColor = True
        '
        'Btcalcular
        '
        Me.Btcalcular.Location = New System.Drawing.Point(35, 238)
        Me.Btcalcular.Name = "Btcalcular"
        Me.Btcalcular.Size = New System.Drawing.Size(94, 29)
        Me.Btcalcular.TabIndex = 0
        Me.Btcalcular.Text = "Calcular"
        Me.Btcalcular.UseVisualStyleBackColor = True
        '
        'Btlimpiar
        '
        Me.Btlimpiar.Location = New System.Drawing.Point(135, 238)
        Me.Btlimpiar.Name = "Btlimpiar"
        Me.Btlimpiar.Size = New System.Drawing.Size(94, 29)
        Me.Btlimpiar.TabIndex = 6
        Me.Btlimpiar.Text = "Limpiar"
        Me.Btlimpiar.UseVisualStyleBackColor = True
        '
        'Btsalir
        '
        Me.Btsalir.Location = New System.Drawing.Point(240, 238)
        Me.Btsalir.Name = "Btsalir"
        Me.Btsalir.Size = New System.Drawing.Size(94, 29)
        Me.Btsalir.TabIndex = 7
        Me.Btsalir.Text = "Salir"
        Me.Btsalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(383, 294)
        Me.Controls.Add(Me.Btsalir)
        Me.Controls.Add(Me.Btlimpiar)
        Me.Controls.Add(Me.Btcalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Txtcantidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtcantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBlarge As RadioButton
    Friend WithEvents RBmedium As RadioButton
    Friend WithEvents RBsmall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBlona As RadioButton
    Friend WithEvents RBseda As RadioButton
    Friend WithEvents RBalgodon As RadioButton
    Friend WithEvents Btcalcular As Button
    Friend WithEvents Btlimpiar As Button
    Friend WithEvents Btsalir As Button
End Class
