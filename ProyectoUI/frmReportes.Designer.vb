<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.Panel_Cabecera = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Panel_menus = New System.Windows.Forms.Panel()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel_Cabecera.SuspendLayout()
        Me.Panel_menus.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel_Cabecera.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(477, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 41)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Reportería"
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
        'Panel_menus
        '
        Me.Panel_menus.BackColor = System.Drawing.Color.DarkGray
        Me.Panel_menus.Controls.Add(Me.btnreporte)
        Me.Panel_menus.Controls.Add(Me.Panel3)
        Me.Panel_menus.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_menus.Location = New System.Drawing.Point(0, 64)
        Me.Panel_menus.Name = "Panel_menus"
        Me.Panel_menus.Size = New System.Drawing.Size(226, 484)
        Me.Panel_menus.TabIndex = 12
        '
        'btnreporte
        '
        Me.btnreporte.FlatAppearance.BorderSize = 0
        Me.btnreporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnreporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.ForeColor = System.Drawing.Color.White
        Me.btnreporte.Image = Global.ProyectoUI.My.Resources.Resources.btngenerarreporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(12, 0)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(214, 57)
        Me.btnreporte.TabIndex = 6
        Me.btnreporte.Text = "Generar reporte "
        Me.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 57)
        Me.Panel3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(226, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 484)
        Me.Panel1.TabIndex = 13
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(795, 484)
        Me.ReportViewer1.TabIndex = 0
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 548)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_menus)
        Me.Controls.Add(Me.Panel_Cabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportes"
        Me.Text = "frmReportes"
        Me.Panel_Cabecera.ResumeLayout(False)
        Me.Panel_Cabecera.PerformLayout()
        Me.Panel_menus.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Cabecera As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btncerrar As Button
    Friend WithEvents Panel_menus As Panel
    Friend WithEvents btnreporte As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
