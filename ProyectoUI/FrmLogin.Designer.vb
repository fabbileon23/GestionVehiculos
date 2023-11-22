<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontrasena = New System.Windows.Forms.MaskedTextBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblcontrasena = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnminimizar
        '
        Me.btnminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Image = Global.ProyectoUI.My.Resources.Resources.Icono_Minimizar
        Me.btnminimizar.Location = New System.Drawing.Point(307, 0)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(61, 61)
        Me.btnminimizar.TabIndex = 0
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.ProyectoUI.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrar.Location = New System.Drawing.Point(361, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(61, 61)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.btnminimizar)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 61)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoUI.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(101, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtusuario
        '
        Me.txtusuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(101, 336)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(226, 35)
        Me.txtusuario.TabIndex = 4
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(101, 415)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(1422)
        Me.txtcontrasena.Size = New System.Drawing.Size(226, 35)
        Me.txtcontrasena.TabIndex = 5
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.Location = New System.Drawing.Point(98, 305)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(79, 28)
        Me.lblusuario.TabIndex = 6
        Me.lblusuario.Text = "Usuario"
        '
        'lblcontrasena
        '
        Me.lblcontrasena.AutoSize = True
        Me.lblcontrasena.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontrasena.Location = New System.Drawing.Point(98, 384)
        Me.lblcontrasena.Name = "lblcontrasena"
        Me.lblcontrasena.Size = New System.Drawing.Size(110, 28)
        Me.lblcontrasena.TabIndex = 7
        Me.lblcontrasena.Text = "Contraseña"
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(103, 481)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(224, 56)
        Me.btnlogin.TabIndex = 8
        Me.btnlogin.Text = "Iniciar sesión"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 592)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblcontrasena)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.txtcontrasena)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnminimizar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontrasena As MaskedTextBox
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblcontrasena As Label
    Friend WithEvents btnlogin As Button
End Class
