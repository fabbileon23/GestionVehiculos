Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Imports ProyectoLogica
Public Class frmReportes

    Private AccesoLogica As New UsuarioLogica()
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Hide()
    End Sub

    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btninsertarusuario_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        Dim reply = AccesoLogica.ObtenerUsuariosDB()
        Dim parametro1 As DateTime = DateTime.Now

        Dim parametroreporte As ReportParameter = New ReportParameter("ParametroFecha", parametro1.ToString)
        Me.ReportViewer1.ProcessingMode = ProcessingMode.Local
        Me.ReportViewer1.LocalReport.ReportPath = "reporteUsuarios.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {parametroreporte})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", reply.Data))
        Me.ReportViewer1.RefreshReport()


    End Sub


End Class