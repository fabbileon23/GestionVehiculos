<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formVehiculos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvVehiculos = New System.Windows.Forms.DataGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btneliminarvehiculo = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btninsertarvehiculo = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnactualizarvehiculo = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.ProyectoUI.My.Resources.Resources.Icono_cerrar_FN
        Me.Button5.Location = New System.Drawing.Point(945, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 64)
        Me.Button5.TabIndex = 13
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.Black
        Me.lblid.Location = New System.Drawing.Point(284, 306)
        Me.lblid.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(36, 31)
        Me.lblid.TabIndex = 73
        Me.lblid.Text = "ID"
        Me.lblid.Visible = False
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(649, 159)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(321, 39)
        Me.txtModelo.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(643, 125)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 31)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(643, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 31)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Placa"
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(290, 252)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(321, 39)
        Me.txtColor.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(284, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 31)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Color"
        '
        'txtPlaca
        '
        Me.txtPlaca.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(649, 252)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(321, 39)
        Me.txtPlaca.TabIndex = 72
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(290, 159)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(321, 39)
        Me.txtMarca.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(284, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 31)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Marca"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(226, 393)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(795, 52)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Lista de Vehiculos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvVehiculos
        '
        Me.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehiculos.Location = New System.Drawing.Point(303, 448)
        Me.dgvVehiculos.Name = "dgvVehiculos"
        Me.dgvVehiculos.ReadOnly = True
        Me.dgvVehiculos.RowHeadersWidth = 51
        Me.dgvVehiculos.RowTemplate.Height = 24
        Me.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVehiculos.Size = New System.Drawing.Size(680, 167)
        Me.dgvVehiculos.TabIndex = 60
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Controls.Add(Me.Button5)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1021, 65)
        Me.Panel10.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(236, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(316, 41)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Formulario Vehiculos"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(290, 340)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(321, 39)
        Me.txtid.TabIndex = 74
        Me.txtid.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.ProyectoUI.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrar.Location = New System.Drawing.Point(1064, -3)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(76, 62)
        Me.btncerrar.TabIndex = 62
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btneliminarvehiculo)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.btninsertarvehiculo)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.btnborrar)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.btnactualizarvehiculo)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 562)
        Me.Panel1.TabIndex = 75
        '
        'btneliminarvehiculo
        '
        Me.btneliminarvehiculo.FlatAppearance.BorderSize = 0
        Me.btneliminarvehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btneliminarvehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btneliminarvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarvehiculo.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarvehiculo.ForeColor = System.Drawing.Color.White
        Me.btneliminarvehiculo.Image = Global.ProyectoUI.My.Resources.Resources.btndelete24x24
        Me.btneliminarvehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminarvehiculo.Location = New System.Drawing.Point(12, 182)
        Me.btneliminarvehiculo.Name = "btneliminarvehiculo"
        Me.btneliminarvehiculo.Size = New System.Drawing.Size(214, 57)
        Me.btneliminarvehiculo.TabIndex = 16
        Me.btneliminarvehiculo.Text = "Eliminar vehiculo"
        Me.btneliminarvehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btneliminarvehiculo.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 182)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 57)
        Me.Panel6.TabIndex = 17
        '
        'btninsertarvehiculo
        '
        Me.btninsertarvehiculo.FlatAppearance.BorderSize = 0
        Me.btninsertarvehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btninsertarvehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btninsertarvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsertarvehiculo.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsertarvehiculo.ForeColor = System.Drawing.Color.White
        Me.btninsertarvehiculo.Image = Global.ProyectoUI.My.Resources.Resources.btningressarusuario
        Me.btninsertarvehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninsertarvehiculo.Location = New System.Drawing.Point(12, 37)
        Me.btninsertarvehiculo.Name = "btninsertarvehiculo"
        Me.btninsertarvehiculo.Size = New System.Drawing.Size(214, 57)
        Me.btninsertarvehiculo.TabIndex = 14
        Me.btninsertarvehiculo.Text = "Insertar vehiculo"
        Me.btninsertarvehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninsertarvehiculo.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 37)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 57)
        Me.Panel7.TabIndex = 15
        '
        'btnborrar
        '
        Me.btnborrar.FlatAppearance.BorderSize = 0
        Me.btnborrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.Color.White
        Me.btnborrar.Image = Global.ProyectoUI.My.Resources.Resources.borrarcamposwhite
        Me.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnborrar.Location = New System.Drawing.Point(12, 259)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(214, 57)
        Me.btnborrar.TabIndex = 12
        Me.btnborrar.Text = "Borrar vehiculos"
        Me.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(0, 259)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 57)
        Me.Panel8.TabIndex = 13
        '
        'btnactualizarvehiculo
        '
        Me.btnactualizarvehiculo.FlatAppearance.BorderSize = 0
        Me.btnactualizarvehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnactualizarvehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnactualizarvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizarvehiculo.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizarvehiculo.ForeColor = System.Drawing.Color.White
        Me.btnactualizarvehiculo.Image = Global.ProyectoUI.My.Resources.Resources.modificar24x24
        Me.btnactualizarvehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactualizarvehiculo.Location = New System.Drawing.Point(12, 105)
        Me.btnactualizarvehiculo.Name = "btnactualizarvehiculo"
        Me.btnactualizarvehiculo.Size = New System.Drawing.Size(214, 57)
        Me.btnactualizarvehiculo.TabIndex = 10
        Me.btnactualizarvehiculo.Text = "Actualizar vehiculo"
        Me.btnactualizarvehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnactualizarvehiculo.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 105)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 57)
        Me.Panel9.TabIndex = 11
        '
        'formVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1021, 627)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvVehiculos)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btncerrar)
        Me.Font = New System.Drawing.Font("Ebrima", 13.8!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "formVehiculos"
        Me.Text = "0"
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As Button
    Friend WithEvents lblid As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvVehiculos As DataGridView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents btncerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btneliminarvehiculo As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btninsertarvehiculo As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnborrar As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnactualizarvehiculo As Button
    Friend WithEvents Panel9 As Panel
End Class
