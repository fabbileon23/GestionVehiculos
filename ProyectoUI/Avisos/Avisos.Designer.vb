<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Avisos
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
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblmensaje
        '
        Me.lblmensaje.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.Color.White
        Me.lblmensaje.Location = New System.Drawing.Point(2, 93)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(556, 28)
        Me.lblmensaje.TabIndex = 0
        Me.lblmensaje.Text = "Label1"
        Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnaceptar
        '
        Me.btnaceptar.FlatAppearance.BorderSize = 0
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.White
        Me.btnaceptar.Image = Global.ProyectoUI.My.Resources.Resources.check
        Me.btnaceptar.Location = New System.Drawing.Point(2, 171)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(556, 76)
        Me.btnaceptar.TabIndex = 1
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'Avisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 267)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lblmensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Avisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AvisoLogin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnaceptar As Button
    Public WithEvents lblmensaje As Label
End Class
