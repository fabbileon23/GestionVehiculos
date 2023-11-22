<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.cbogenero = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_Cabecera = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel_menus = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.btneliminarusuario = New System.Windows.Forms.Button()
        Me.btninsertarusuario = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnactualizarusuario = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Panel_Cabecera.SuspendLayout()
        Me.Panel_menus.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(290, 132)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(296, 39)
        Me.txtcedula.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(290, 227)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(296, 39)
        Me.txtnombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(290, 313)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(296, 39)
        Me.txtapellido.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 279)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(643, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfono"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(649, 132)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(296, 39)
        Me.txttelefono.TabIndex = 7
        '
        'cbogenero
        '
        Me.cbogenero.FormattingEnabled = True
        Me.cbogenero.Items.AddRange(New Object() {"Masculino", "Femenino", "No binario", "Prefiero no especificar"})
        Me.cbogenero.Location = New System.Drawing.Point(649, 227)
        Me.cbogenero.Name = "cbogenero"
        Me.cbogenero.Size = New System.Drawing.Size(296, 39)
        Me.cbogenero.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(643, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 31)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Género"
        '
        'Panel_Cabecera
        '
        Me.Panel_Cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel_Cabecera.Controls.Add(Me.Label6)
        Me.Panel_Cabecera.Controls.Add(Me.btncerrar)
        Me.Panel_Cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Cabecera.Name = "Panel_Cabecera"
        Me.Panel_Cabecera.Size = New System.Drawing.Size(1021, 64)
        Me.Panel_Cabecera.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(477, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 41)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Formulario Usuarios"
        '
        'Panel_menus
        '
        Me.Panel_menus.BackColor = System.Drawing.Color.DarkGray
        Me.Panel_menus.Controls.Add(Me.btneliminarusuario)
        Me.Panel_menus.Controls.Add(Me.Panel4)
        Me.Panel_menus.Controls.Add(Me.btninsertarusuario)
        Me.Panel_menus.Controls.Add(Me.Panel3)
        Me.Panel_menus.Controls.Add(Me.btnborrar)
        Me.Panel_menus.Controls.Add(Me.Panel2)
        Me.Panel_menus.Controls.Add(Me.btnactualizarusuario)
        Me.Panel_menus.Controls.Add(Me.Panel1)
        Me.Panel_menus.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_menus.Location = New System.Drawing.Point(0, 64)
        Me.Panel_menus.Name = "Panel_menus"
        Me.Panel_menus.Size = New System.Drawing.Size(226, 484)
        Me.Panel_menus.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 145)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 57)
        Me.Panel4.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 57)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 57)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 57)
        Me.Panel1.TabIndex = 3
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(290, 360)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.RowTemplate.Height = 24
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(655, 176)
        Me.dgvUsuarios.TabIndex = 12
        '
        'btneliminarusuario
        '
        Me.btneliminarusuario.Enabled = False
        Me.btneliminarusuario.FlatAppearance.BorderSize = 0
        Me.btneliminarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btneliminarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btneliminarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarusuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarusuario.ForeColor = System.Drawing.Color.White
        Me.btneliminarusuario.Image = Global.ProyectoUI.My.Resources.Resources.btndelete24x24
        Me.btneliminarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminarusuario.Location = New System.Drawing.Point(12, 145)
        Me.btneliminarusuario.Name = "btneliminarusuario"
        Me.btneliminarusuario.Size = New System.Drawing.Size(214, 57)
        Me.btneliminarusuario.TabIndex = 8
        Me.btneliminarusuario.Text = "Eliminar usuario"
        Me.btneliminarusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btneliminarusuario.UseVisualStyleBackColor = True
        '
        'btninsertarusuario
        '
        Me.btninsertarusuario.FlatAppearance.BorderSize = 0
        Me.btninsertarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btninsertarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btninsertarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsertarusuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsertarusuario.ForeColor = System.Drawing.Color.White
        Me.btninsertarusuario.Image = Global.ProyectoUI.My.Resources.Resources.btningressarusuario
        Me.btninsertarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninsertarusuario.Location = New System.Drawing.Point(12, 0)
        Me.btninsertarusuario.Name = "btninsertarusuario"
        Me.btninsertarusuario.Size = New System.Drawing.Size(214, 57)
        Me.btninsertarusuario.TabIndex = 6
        Me.btninsertarusuario.Text = "Insertar usuario"
        Me.btninsertarusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninsertarusuario.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.FlatAppearance.BorderSize = 0
        Me.btnborrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.Color.White
        Me.btnborrar.Image = Global.ProyectoUI.My.Resources.Resources.borrarcamposwhite
        Me.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnborrar.Location = New System.Drawing.Point(12, 222)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(214, 57)
        Me.btnborrar.TabIndex = 4
        Me.btnborrar.Text = "Borrar campos"
        Me.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnactualizarusuario
        '
        Me.btnactualizarusuario.Enabled = False
        Me.btnactualizarusuario.FlatAppearance.BorderSize = 0
        Me.btnactualizarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnactualizarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnactualizarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizarusuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizarusuario.ForeColor = System.Drawing.Color.White
        Me.btnactualizarusuario.Image = Global.ProyectoUI.My.Resources.Resources.modificar24x24
        Me.btnactualizarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactualizarusuario.Location = New System.Drawing.Point(12, 68)
        Me.btnactualizarusuario.Name = "btnactualizarusuario"
        Me.btnactualizarusuario.Size = New System.Drawing.Size(214, 57)
        Me.btnactualizarusuario.TabIndex = 2
        Me.btnactualizarusuario.Text = "Actualizar usuario"
        Me.btnactualizarusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnactualizarusuario.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.ProyectoUI.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrar.Location = New System.Drawing.Point(941, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(76, 64)
        Me.btncerrar.TabIndex = 3
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 548)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.Panel_menus)
        Me.Controls.Add(Me.Panel_Cabecera)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbogenero)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FrmUsuarios"
        Me.Text = "FrmUsuarios"
        Me.Panel_Cabecera.ResumeLayout(False)
        Me.Panel_Cabecera.PerformLayout()
        Me.Panel_menus.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents cbogenero As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel_Cabecera As Panel
    Friend WithEvents btncerrar As Button
    Friend WithEvents Panel_menus As Panel
    Friend WithEvents btneliminarusuario As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btninsertarusuario As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnborrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnactualizarusuario As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvUsuarios As DataGridView
End Class
