Imports System.Runtime.InteropServices

Public Class FrmMenuPrincipal
#Region "Codigo para mover ventana"
    'este proceso hara que se pueda mover la ventana, el panel cabecera actua como la barra principal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
#End Region
#Region "Mover ventana de páneles"
    'proceso para que se puede mover la ventana en toda la pantalla 
    Private Sub Panel_Cabecera_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel_Cabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
    Private Sub Timerfechahora_Tick(sender As Object, e As EventArgs) Handles Timerfechahora.Tick
        lblhora.Text = DateTime.Now.ToString("h:mm:ss")
        lblfecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
    'hara que se puedan abrir forms creados en el panel contenedor padre de este form, solamenmte llamando la funcion llamada abrir_from_panel
    Private Sub Abrir_Form_Panel(ByVal Form_Hijo As Object)
        If Me.Panel_contenedor.Controls.Count > 0 Then Me.Panel_contenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Form_Hijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_contenedor.Controls.Add(fh)
        Me.Panel_contenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnregistrousuarios_Click(sender As Object, e As EventArgs) Handles btnregistrousuarios.Click
        Abrir_Form_Panel(FrmUsuarios)
        'Commit
        'Para que el proyecto pueda ser trabajado por otros del mismo equipo primero se selecciona enviar cambios
        'Luego sincronizar
        'Pull



        'ssssss
    End Sub

    Private Sub btnReportería_Click(sender As Object, e As EventArgs) Handles btnReportería.Click
        Abrir_Form_Panel(frmReportes)
    End Sub
End Class