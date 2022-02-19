<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btregreso = New System.Windows.Forms.Button()
        Me.Txtpcosto = New System.Windows.Forms.TextBox()
        Me.Txtpventa = New System.Windows.Forms.TextBox()
        Me.Txttcosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btregreso
        '
        Me.Btregreso.Location = New System.Drawing.Point(161, 183)
        Me.Btregreso.Name = "Btregreso"
        Me.Btregreso.Size = New System.Drawing.Size(113, 31)
        Me.Btregreso.TabIndex = 0
        Me.Btregreso.Text = "Regresar"
        Me.Btregreso.UseVisualStyleBackColor = True
        '
        'Txtpcosto
        '
        Me.Txtpcosto.Enabled = False
        Me.Txtpcosto.Location = New System.Drawing.Point(172, 33)
        Me.Txtpcosto.Name = "Txtpcosto"
        Me.Txtpcosto.Size = New System.Drawing.Size(126, 27)
        Me.Txtpcosto.TabIndex = 1
        '
        'Txtpventa
        '
        Me.Txtpventa.Enabled = False
        Me.Txtpventa.Location = New System.Drawing.Point(265, 83)
        Me.Txtpventa.Name = "Txtpventa"
        Me.Txtpventa.Size = New System.Drawing.Size(126, 27)
        Me.Txtpventa.TabIndex = 2
        '
        'Txttcosto
        '
        Me.Txttcosto.Enabled = False
        Me.Txttcosto.Location = New System.Drawing.Point(265, 135)
        Me.Txttcosto.Name = "Txttcosto"
        Me.Txttcosto.Size = New System.Drawing.Size(126, 27)
        Me.Txttcosto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(35, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Precio de costo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(35, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Precio de venta por unidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(35, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total de costo por unidad:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(420, 237)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txttcosto)
        Me.Controls.Add(Me.Txtpventa)
        Me.Controls.Add(Me.Txtpcosto)
        Me.Controls.Add(Me.Btregreso)
        Me.Name = "Form2"
        Me.Text = "Totales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btregreso As Button
    Friend WithEvents Txtpcosto As TextBox
    Friend WithEvents Txtpventa As TextBox
    Friend WithEvents Txttcosto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
