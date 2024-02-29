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
        dgvUsuarios.Columns.Add("columna2", "Edad")
        dgvUsuarios.Columns.Add("columna3", "Fecha de Nacimiento")
        dgvUsuarios.Columns.Add("columna4", "Teléfono")
        dgvUsuarios.Columns.Add("columna5", "Dirección")

        dgvUsuarios.Columns(0).DataPropertyName = "cedula"
        dgvUsuarios.Columns(1).DataPropertyName = "nombre"
        dgvUsuarios.Columns(2).DataPropertyName = "edad"
        dgvUsuarios.Columns(3).DataPropertyName = "fechanacimiento"
        dgvUsuarios.Columns(4).DataPropertyName = "telefono"
        dgvUsuarios.Columns(5).DataPropertyName = "direccion"




    End Sub

    Private Sub dgvUsuarios_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.RowHeaderMouseDoubleClick
        If Not IsDBNull(dgvUsuarios.SelectedCells.Item(3).Value) Then
            txtcedula.Text = dgvUsuarios.SelectedCells.Item(0).Value.ToString
            txtnombre.Text = dgvUsuarios.SelectedCells.Item(1).Value.ToString
            cbedad.Text = dgvUsuarios.SelectedCells.Item(2).Value.ToString
            dtfecha.Value = dgvUsuarios.SelectedCells.Item(3).Value
            txttelefono.Text = dgvUsuarios.SelectedCells.Item(4).Value.ToString
            txtdireccion.Text = dgvUsuarios.SelectedCells.Item(5).Value.ToString

            txtcedula.ReadOnly = True
            dtfecha.Enabled = False
        Else
            Return
        End If
    End Sub

    Private Sub btninsertarusuario_Click(sender As Object, e As EventArgs) Handles btninsertarusuario.Click
        If txtcedula.Text <> "" And txtnombre.Text <> "" And cbedad.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" Then

            Dim existe As Boolean = False

            ' Iterar a través de las filas del DataGridView
            For Each fila As DataGridViewRow In dgvUsuarios.Rows
                ' Verificar si la celda en la columna deseada tiene el valor buscado
                If fila.Cells("columna0").Value IsNot Nothing AndAlso fila.Cells("columna0").Value.ToString() = txtcedula.Text Then
                    ' El valor buscado se encontró en la columna deseada
                    ' Realiza aquí las acciones que deseas cuando encuentras el valor

                    existe = True
                    Exit For ' Puedes salir del bucle si solo estás buscando la primera coincidencia
                End If

            Next

            If Not existe Then
                Dim datausuario As New Usuarios()

                datausuario.cedula = txtcedula.Text
                datausuario.nombre = txtnombre.Text
                datausuario.edad = cbedad.Text
                datausuario.fechanacimento = dtfecha.Value
                datausuario.telefono = txttelefono.Text
                datausuario.direccion = txtdireccion.Text

                Dim respuesta = AccesoLogica.InsertarUsuariosDB(datausuario)

                If respuesta.Success Then
                    Avisos.lblmensaje.Text = "Datos insertados correctamente"
                    Avisos.ShowDialog()
                    LimpiarCampos()
                    dgvUsuarios.DataSource = AccesoLogica.ObtenerUsuariosDB.Data
                    dtfecha.Enabled = True
                    txtcedula.ReadOnly = False
                Else
                    Avisos.lblmensaje.Text = "Ha ocurrido un error"
                    Avisos.ShowDialog()
                End If
                LimpiarCampos()

            Else
                Avisos.lblmensaje.Text = "Ya existe la cédula"
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
        cbedad.Text = ""
        txttelefono.Text = ""
        txtdireccion.Text = ""
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnlimpiarcampos.Click
        LimpiarCampos()
        dtfecha.Enabled = True
        txtcedula.ReadOnly = False
    End Sub

    Private Sub btnactualizarusuario_Click(sender As Object, e As EventArgs) Handles btnactualizarusuario.Click
        txtcedula.ReadOnly = True
        If txtcedula.Text <> "" And txtnombre.Text <> "" And cbedad.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" Then

            Dim datausuario As New Usuarios()

            datausuario.cedula = txtcedula.Text
            datausuario.nombre = txtnombre.Text
            datausuario.edad = cbedad.Text
            datausuario.fechanacimento = dtfecha.ToString
            datausuario.telefono = txttelefono.Text
            datausuario.direccion = txtdireccion.Text

            AvisosOperaciones.lblmensaje.Text = "¿Está seguro que desea modificar este usuario?"
            AvisosOperaciones.ShowDialog()

            If Variable.autorizacion Then

                Dim respuesta = AccesoLogica.ActualizarUsuariosDB(datausuario)

                If respuesta.Success Then
                    Avisos.lblmensaje.Text = "Datos insertados correctamente"
                    Avisos.ShowDialog()
                    LimpiarCampos()
                    txtcedula.ReadOnly = False
                    dgvUsuarios.DataSource = AccesoLogica.ObtenerUsuariosDB.Data
                    dtfecha.Enabled = True
                Else
                    Avisos.lblmensaje.Text = "Ha ocurrido un error"
                    Avisos.ShowDialog()
                End If

            Else
                Return
            End If

        Else
            Avisos.lblmensaje.Text = "Debes rellenar todos los campos"
            Avisos.ShowDialog()

            End If
    End Sub

    Private Sub btneliminarusuario_Click(sender As Object, e As EventArgs) Handles btneliminarusuario.Click
        txtcedula.ReadOnly = True
        If txtcedula.Text <> "" And txtnombre.Text <> "" And cbedad.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" Then

            Dim datausuario As New Usuarios()

            datausuario.cedula = txtcedula.Text

            AvisosOperaciones.lblmensaje.Text = "¿Está seguro que desea eliminar este usuario?"
            AvisosOperaciones.ShowDialog()

            If Variable.autorizacion Then
                Dim respuesta = AccesoLogica.EliminarUsuariosDB(datausuario)

                If respuesta.Success Then
                    Avisos.lblmensaje.Text = "Datos eliminados correctamente"
                    Avisos.ShowDialog()
                    LimpiarCampos()
                    txtcedula.ReadOnly = False
                    dgvUsuarios.DataSource = AccesoLogica.ObtenerUsuariosDB.Data
                    dtfecha.Enabled = True
                Else
                    Avisos.lblmensaje.Text = "Ha ocurrido un error"
                    Avisos.ShowDialog()
                End If

            Else
                Return

            End If


        Else
            Avisos.lblmensaje.Text = "Debes rellenar todos los campos"
            Avisos.ShowDialog()
        End If


    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()
    End Sub

    Private Sub Panel_Cabecera_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick

    End Sub
End Class