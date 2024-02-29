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
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btneliminarusuario = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btninsertarusuario = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnlimpiarcampos = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnactualizarusuario = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbedad = New System.Windows.Forms.ComboBox()
        Me.lblgene = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.lblcedula = New System.Windows.Forms.Label()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(290, 420)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.RowTemplate.Height = 24
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(655, 176)
        Me.dgvUsuarios.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(226, 377)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(795, 31)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Lista de Usuarios"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(320, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 41)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Formulario Usuarios"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Controls.Add(Me.btnclose)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1021, 65)
        Me.Panel10.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(378, 14)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 41)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Formulario Usuarios"
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Image = Global.ProyectoUI.My.Resources.Resources.Icono_cerrar_FN
        Me.btnclose.Location = New System.Drawing.Point(945, -2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(76, 64)
        Me.btnclose.TabIndex = 13
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btneliminarusuario)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.btninsertarusuario)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.btnlimpiarcampos)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.btnactualizarusuario)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(226, 562)
        Me.Panel5.TabIndex = 12
        '
        'btneliminarusuario
        '
        Me.btneliminarusuario.FlatAppearance.BorderSize = 0
        Me.btneliminarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btneliminarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btneliminarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarusuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarusuario.ForeColor = System.Drawing.Color.White
        Me.btneliminarusuario.Image = Global.ProyectoUI.My.Resources.Resources.btndelete24x24
        Me.btneliminarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminarusuario.Location = New System.Drawing.Point(12, 179)
        Me.btneliminarusuario.Name = "btneliminarusuario"
        Me.btneliminarusuario.Size = New System.Drawing.Size(214, 57)
        Me.btneliminarusuario.TabIndex = 8
        Me.btneliminarusuario.Text = "Eliminar usuario"
        Me.btneliminarusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btneliminarusuario.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 179)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 57)
        Me.Panel6.TabIndex = 9
        '
        'btninsertarusuario
        '
        Me.btninsertarusuario.FlatAppearance.BorderSize = 0
        Me.btninsertarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btninsertarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btninsertarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsertarusuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsertarusuario.ForeColor = System.Drawing.Color.White
        Me.btninsertarusuario.Image = Global.ProyectoUI.My.Resources.Resources.btningressarusuario
        Me.btninsertarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninsertarusuario.Location = New System.Drawing.Point(12, 34)
        Me.btninsertarusuario.Name = "btninsertarusuario"
        Me.btninsertarusuario.Size = New System.Drawing.Size(214, 57)
        Me.btninsertarusuario.TabIndex = 6
        Me.btninsertarusuario.Text = "Insertar usuario"
        Me.btninsertarusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninsertarusuario.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 34)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 57)
        Me.Panel7.TabIndex = 7
        '
        'btnlimpiarcampos
        '
        Me.btnlimpiarcampos.FlatAppearance.BorderSize = 0
        Me.btnlimpiarcampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnlimpiarcampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnlimpiarcampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiarcampos.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiarcampos.ForeColor = System.Drawing.Color.White
        Me.btnlimpiarcampos.Image = Global.ProyectoUI.My.Resources.Resources.borrarcamposwhite
        Me.btnlimpiarcampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpiarcampos.Location = New System.Drawing.Point(12, 256)
        Me.btnlimpiarcampos.Name = "btnlimpiarcampos"
        Me.btnlimpiarcampos.Size = New System.Drawing.Size(214, 57)
        Me.btnlimpiarcampos.TabIndex = 4
        Me.btnlimpiarcampos.Text = "Borrar campos"
        Me.btnlimpiarcampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlimpiarcampos.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(0, 256)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 57)
        Me.Panel8.TabIndex = 5
        '
        'btnactualizarusuario
        '
        Me.btnactualizarusuario.FlatAppearance.BorderSize = 0
        Me.btnactualizarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnactualizarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnactualizarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizarusuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizarusuario.ForeColor = System.Drawing.Color.White
        Me.btnactualizarusuario.Image = Global.ProyectoUI.My.Resources.Resources.modificar24x24
        Me.btnactualizarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactualizarusuario.Location = New System.Drawing.Point(12, 102)
        Me.btnactualizarusuario.Name = "btnactualizarusuario"
        Me.btnactualizarusuario.Size = New System.Drawing.Size(214, 57)
        Me.btnactualizarusuario.TabIndex = 2
        Me.btnactualizarusuario.Text = "Actualizar usuario"
        Me.btnactualizarusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnactualizarusuario.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 102)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 57)
        Me.Panel9.TabIndex = 3
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.ProyectoUI.My.Resources.Resources.cerrar__2_
        Me.btncerrar.Location = New System.Drawing.Point(945, 3)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(76, 52)
        Me.btncerrar.TabIndex = 14
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'dtfecha
        '
        Me.dtfecha.Font = New System.Drawing.Font("Ebrima", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Location = New System.Drawing.Point(646, 156)
        Me.dtfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(346, 32)
        Me.dtfecha.TabIndex = 38
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(646, 329)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(346, 39)
        Me.txtdireccion.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 13.8!)
        Me.Label3.Location = New System.Drawing.Point(640, 293)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 31)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Dirección"
        '
        'cbedad
        '
        Me.cbedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbedad.FormattingEnabled = True
        Me.cbedad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150"})
        Me.cbedad.Location = New System.Drawing.Point(285, 328)
        Me.cbedad.Margin = New System.Windows.Forms.Padding(4)
        Me.cbedad.Name = "cbedad"
        Me.cbedad.Size = New System.Drawing.Size(308, 33)
        Me.cbedad.TabIndex = 35
        '
        'lblgene
        '
        Me.lblgene.AutoSize = True
        Me.lblgene.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgene.Location = New System.Drawing.Point(640, 116)
        Me.lblgene.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgene.Name = "lblgene"
        Me.lblgene.Size = New System.Drawing.Size(225, 31)
        Me.lblgene.TabIndex = 34
        Me.lblgene.Text = "Fecha de nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 13.8!)
        Me.Label2.Location = New System.Drawing.Point(640, 208)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 31)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Teléfono"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(646, 243)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(346, 39)
        Me.txttelefono.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 293)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Edad"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(285, 239)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(308, 39)
        Me.txtnombre.TabIndex = 30
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Ebrima", 13.8!)
        Me.lblnombre.Location = New System.Drawing.Point(279, 204)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(98, 31)
        Me.lblnombre.TabIndex = 29
        Me.lblnombre.Text = "Nombre"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(285, 154)
        Me.txtcedula.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(308, 39)
        Me.txtcedula.TabIndex = 28
        '
        'lblcedula
        '
        Me.lblcedula.AutoSize = True
        Me.lblcedula.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedula.Location = New System.Drawing.Point(279, 116)
        Me.lblcedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcedula.Name = "lblcedula"
        Me.lblcedula.Size = New System.Drawing.Size(85, 31)
        Me.lblcedula.TabIndex = 27
        Me.lblcedula.Text = "Cédula"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1021, 627)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbedad)
        Me.Controls.Add(Me.lblgene)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.lblcedula)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FrmUsuarios"
        Me.Text = "FrmUsuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btncerrar As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btneliminarusuario As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btninsertarusuario As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnlimpiarcampos As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnactualizarusuario As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbedad As ComboBox
    Friend WithEvents lblgene As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents lblcedula As Label
End Class
