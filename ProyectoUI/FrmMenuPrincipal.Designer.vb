﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel_Cabecera = New System.Windows.Forms.Panel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Timerfechahora = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_menus = New System.Windows.Forms.Panel()
        Me.btnReportería = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnregistrousuarios = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_contenedor = New System.Windows.Forms.Panel()
        Me.Panel_Cabecera.SuspendLayout()
        Me.Panel_menus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Cabecera
        '
        Me.Panel_Cabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel_Cabecera.Controls.Add(Me.btncerrar)
        Me.Panel_Cabecera.Controls.Add(Me.btnminimizar)
        Me.Panel_Cabecera.Controls.Add(Me.lblhora)
        Me.Panel_Cabecera.Controls.Add(Me.lblfecha)
        Me.Panel_Cabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Cabecera.Name = "Panel_Cabecera"
        Me.Panel_Cabecera.Size = New System.Drawing.Size(1404, 64)
        Me.Panel_Cabecera.TabIndex = 0
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.ProyectoUI.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrar.Location = New System.Drawing.Point(1325, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(76, 64)
        Me.btncerrar.TabIndex = 3
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnminimizar
        '
        Me.btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Image = Global.ProyectoUI.My.Resources.Resources.Icono_Minimizar
        Me.btnminimizar.Location = New System.Drawing.Point(1243, 0)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(76, 64)
        Me.btnminimizar.TabIndex = 1
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.White
        Me.lblhora.Location = New System.Drawing.Point(701, 12)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(87, 41)
        Me.lblhora.TabIndex = 2
        Me.lblhora.Text = "Hora"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Ebrima", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.White
        Me.lblfecha.Location = New System.Drawing.Point(51, 20)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(75, 31)
        Me.lblfecha.TabIndex = 1
        Me.lblfecha.Text = "Fecha"
        '
        'Timerfechahora
        '
        Me.Timerfechahora.Enabled = True
        '
        'Panel_menus
        '
        Me.Panel_menus.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel_menus.Controls.Add(Me.btnReportería)
        Me.Panel_menus.Controls.Add(Me.Panel3)
        Me.Panel_menus.Controls.Add(Me.btnVehiculos)
        Me.Panel_menus.Controls.Add(Me.Panel2)
        Me.Panel_menus.Controls.Add(Me.btnregistrousuarios)
        Me.Panel_menus.Controls.Add(Me.Panel1)
        Me.Panel_menus.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_menus.Location = New System.Drawing.Point(0, 64)
        Me.Panel_menus.Name = "Panel_menus"
        Me.Panel_menus.Size = New System.Drawing.Size(263, 705)
        Me.Panel_menus.TabIndex = 1
        '
        'btnReportería
        '
        Me.btnReportería.FlatAppearance.BorderSize = 0
        Me.btnReportería.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnReportería.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReportería.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportería.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportería.ForeColor = System.Drawing.Color.White
        Me.btnReportería.Image = Global.ProyectoUI.My.Resources.Resources.btnreportes
        Me.btnReportería.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportería.Location = New System.Drawing.Point(12, 229)
        Me.btnReportería.Name = "btnReportería"
        Me.btnReportería.Size = New System.Drawing.Size(251, 57)
        Me.btnReportería.TabIndex = 6
        Me.btnReportería.Text = "Reportería"
        Me.btnReportería.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportería.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 57)
        Me.Panel3.TabIndex = 7
        '
        'btnVehiculos
        '
        Me.btnVehiculos.FlatAppearance.BorderSize = 0
        Me.btnVehiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehiculos.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnVehiculos.Image = Global.ProyectoUI.My.Resources.Resources.insertarvehiculo
        Me.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.Location = New System.Drawing.Point(12, 155)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(251, 57)
        Me.btnVehiculos.TabIndex = 4
        Me.btnVehiculos.Text = "Insertar Vehiculo"
        Me.btnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 57)
        Me.Panel2.TabIndex = 5
        '
        'btnregistrousuarios
        '
        Me.btnregistrousuarios.FlatAppearance.BorderSize = 0
        Me.btnregistrousuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnregistrousuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnregistrousuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistrousuarios.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistrousuarios.ForeColor = System.Drawing.Color.White
        Me.btnregistrousuarios.Image = Global.ProyectoUI.My.Resources.Resources.empleados
        Me.btnregistrousuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistrousuarios.Location = New System.Drawing.Point(12, 79)
        Me.btnregistrousuarios.Name = "btnregistrousuarios"
        Me.btnregistrousuarios.Size = New System.Drawing.Size(251, 57)
        Me.btnregistrousuarios.TabIndex = 2
        Me.btnregistrousuarios.Text = "Agregar usuario"
        Me.btnregistrousuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnregistrousuarios.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 57)
        Me.Panel1.TabIndex = 3
        '
        'Panel_contenedor
        '
        Me.Panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_contenedor.Location = New System.Drawing.Point(263, 64)
        Me.Panel_contenedor.Name = "Panel_contenedor"
        Me.Panel_contenedor.Size = New System.Drawing.Size(1141, 705)
        Me.Panel_contenedor.TabIndex = 2
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1404, 769)
        Me.Controls.Add(Me.Panel_contenedor)
        Me.Controls.Add(Me.Panel_menus)
        Me.Controls.Add(Me.Panel_Cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuPrincipal"
        Me.Panel_Cabecera.ResumeLayout(False)
        Me.Panel_Cabecera.PerformLayout()
        Me.Panel_menus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Cabecera As Panel
    Friend WithEvents lblhora As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Timerfechahora As Timer
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnminimizar As Button
    Friend WithEvents Panel_menus As Panel
    Friend WithEvents btnregistrousuarios As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_contenedor As Panel
    Friend WithEvents btnVehiculos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReportería As Button
    Friend WithEvents Panel3 As Panel
End Class
