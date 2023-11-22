Imports System.Drawing.Text
Imports ProyectoLogica
Imports ProyectoEntidades

Public Class FrmUsuarios

    Private AccesoLogica As New UsuarioLogica
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGridUsuarios()
        dgvUsuarios.DataSource = AccesoLogica.ObtenerUsuariosDB.Data
    End Sub

    Sub CrearGridUsuarios()
        dgvUsuarios.AutoGenerateColumns = False
        dgvUsuarios.Columns.Add("columna0", "Cédula")
        dgvUsuarios.Columns.Add("columna1", "Nombre")
        dgvUsuarios.Columns.Add("columna2", "Apellidos")
        dgvUsuarios.Columns.Add("columna3", "Teléfono")
        dgvUsuarios.Columns.Add("columna4", "Género")

        dgvUsuarios.Columns(0).DataPropertyName = "cedula"
        dgvUsuarios.Columns(1).DataPropertyName = "nombre"
        dgvUsuarios.Columns(2).DataPropertyName = "apellidos"
        dgvUsuarios.Columns(3).DataPropertyName = "telefono"
        dgvUsuarios.Columns(4).DataPropertyName = "genero"




    End Sub

    Private Sub dgvUsuarios_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.RowHeaderMouseDoubleClick
        txtcedula.Text = dgvUsuarios.SelectedRows(0).Cells(0).Value.ToString
        txtnombre.Text = dgvUsuarios.SelectedRows(0).Cells(1).Value.ToString
        txtapellido.Text = dgvUsuarios.SelectedRows(0).Cells(2).Value.ToString
        txttelefono.Text = dgvUsuarios.SelectedRows(0).Cells(3).Value.ToString
        cbogenero.Text = dgvUsuarios.SelectedRows(0).Cells(4).Value.ToString
        btnactualizarusuario.Enabled = True
        btneliminarusuario.Enabled = True
    End Sub

    Private Sub btninsertarusuario_Click(sender As Object, e As EventArgs) Handles btninsertarusuario.Click
        If txtcedula.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txttelefono.Text <> "" And cbogenero.Text <> "" Then

            Dim datausuario As New Usuarios()

            datausuario.cedula = txtcedula.Text
            datausuario.nombre = txtcedula.Text
            datausuario.apellidos = txtapellido.Text
            datausuario.telefono = txttelefono.Text
            datausuario.genero = cbogenero.Text

            Dim respuesta = AccesoLogica.InsertarUsuariosDB(datausuario)

            If respuesta.Success Then
                Avisos.lblmensaje.Text = "Datos insertados correctamente"
                Avisos.ShowDialog()
                LimpiarCampos()
                dgvUsuarios.DataSource = AccesoLogica.ObtenerUsuariosDB.Data
            Else
                Avisos.lblmensaje.Text = "Ha ocurrido un error"
                Avisos.ShowDialog()
            End If


        Else
            Avisos.lblmensaje.Text = "Debes rellenar todos los campos"
            Avisos.ShowDialog()
        End If
    End Sub

    Sub LimpiarCampos()
        txtcedula.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txttelefono.Text = ""
        cbogenero.Text = ""
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnactualizarusuario_Click(sender As Object, e As EventArgs) Handles btnactualizarusuario.Click
        txtcedula.ReadOnly = True
        If txtcedula.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txttelefono.Text <> "" And cbogenero.Text <> "" Then

            Dim datausuario As New Usuarios()

            datausuario.cedula = txtcedula.Text
            datausuario.nombre = txtnombre.Text
            datausuario.apellidos = txtapellido.Text
            datausuario.telefono = txttelefono.Text
            datausuario.genero = cbogenero.Text

            Dim respuesta = AccesoLogica.ActualizarUsuariosDB(datausuario)

            If respuesta.Success Then
                Avisos.lblmensaje.Text = "Datos insertados correctamente"
                Avisos.ShowDialog()
                LimpiarCampos()
                txtcedula.ReadOnly = False
                dgvUsuarios.DataSource = AccesoLogica.ObtenerUsuariosDB.Data
            Else
                Avisos.lblmensaje.Text = "Ha ocurrido un error"
                Avisos.ShowDialog()
            End If


        Else
            Avisos.lblmensaje.Text = "Debes rellenar todos los campos"
            Avisos.ShowDialog()
        End If
    End Sub

    Private Sub btneliminarusuario_Click(sender As Object, e As EventArgs) Handles btneliminarusuario.Click
        txtcedula.ReadOnly = True
        If txtcedula.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txttelefono.Text <> "" And cbogenero.Text <> "" Then

            Dim datausuario As New Usuarios()

            datausuario.cedula = txtcedula.Text

            Dim respuesta = AccesoLogica.EliminarUsuariosDB(datausuario)

            If respuesta.Success Then
                Avisos.lblmensaje.Text = "Datos eliminados correctamente"
                Avisos.ShowDialog()
                LimpiarCampos()
                txtcedula.ReadOnly = False
                dgvUsuarios.DataSource = AccesoLogica.ObtenerUsuariosDB.Data
            Else
                Avisos.lblmensaje.Text = "Ha ocurrido un error"
                Avisos.ShowDialog()
            End If


        Else
            Avisos.lblmensaje.Text = "Debes rellenar todos los campos"
            Avisos.ShowDialog()
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Hide()
    End Sub
End Class