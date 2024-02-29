Imports ProyectoEntidades
Imports ProyectoLogica

Public Class formVehiculos
    Private AccesoLogica As New VehiculoLogica
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGridVehiculos()
        dgvVehiculos.DataSource = AccesoLogica.ObtenerVehiculosDB.Data
    End Sub

    Sub CrearGridVehiculos()
        dgvVehiculos.AutoGenerateColumns = False
        dgvVehiculos.Columns.Add("columna0", "ID")
        dgvVehiculos.Columns.Add("columna1", "Marca")
        dgvVehiculos.Columns.Add("columna2", "Modelo")
        dgvVehiculos.Columns.Add("columna3", "Color")
        dgvVehiculos.Columns.Add("columna4", "Placa")

        dgvVehiculos.Columns(0).DataPropertyName = "Id"
        dgvVehiculos.Columns(1).DataPropertyName = "marca"
        dgvVehiculos.Columns(2).DataPropertyName = "modelo"
        dgvVehiculos.Columns(3).DataPropertyName = "color"
        dgvVehiculos.Columns(4).DataPropertyName = "placa"



    End Sub

    Private Sub btninsertarvehiculo_Click(sender As Object, e As EventArgs) Handles btninsertarvehiculo.Click
        If txtMarca.Text <> "" And txtModelo.Text <> "" And txtColor.Text <> "" And txtPlaca.Text <> "" Then

            Dim vehiculodata As New Vehiculos()

            vehiculodata.marca = txtMarca.Text
            vehiculodata.modelo = txtModelo.Text
            vehiculodata.color = txtColor.Text
            vehiculodata.placa = txtPlaca.Text

            Dim respuesta = AccesoLogica.InsertarVehiculosDB(vehiculodata)

            If respuesta.Success Then
                Avisos.lblmensaje.Text = "Datos insertados correctamente"
                Avisos.ShowDialog()
                LimpiarCampos()
                dgvVehiculos.DataSource = AccesoLogica.ObtenerVehiculosDB.Data
                txtid.Visible = False
                lblid.Visible = False
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
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtColor.Text = ""
        txtPlaca.Text = ""
        txtid.Text = ""
    End Sub

    Private Sub btnactualizarvehiculo_Click(sender As Object, e As EventArgs) Handles btnactualizarvehiculo.Click
        If txtMarca.Text <> "" And txtModelo.Text <> "" And txtColor.Text <> "" And txtPlaca.Text <> "" Then

            Dim vehiculodata As New Vehiculos()

            vehiculodata.marca = txtMarca.Text
            vehiculodata.modelo = txtModelo.Text
            vehiculodata.color = txtColor.Text
            vehiculodata.placa = txtPlaca.Text
            vehiculodata.ID = txtid.Text


            AvisosOperaciones.lblmensaje.Text = "¿Está seguro que desea modificar este vehiculo?"
            AvisosOperaciones.ShowDialog()

            If Variable.autorizacion Then
                Dim respuesta = AccesoLogica.ActualizarVehiculosDB(vehiculodata)

                If respuesta.Success Then
                    Avisos.lblmensaje.Text = "Datos actualizados correctamente"
                    Avisos.ShowDialog()
                    LimpiarCampos()
                    dgvVehiculos.DataSource = AccesoLogica.ObtenerVehiculosDB.Data
                    txtid.Visible = False
                    lblid.Visible = False
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

    Private Sub btneliminarvehiculo_Click(sender As Object, e As EventArgs) Handles btneliminarvehiculo.Click
        If txtMarca.Text <> "" And txtModelo.Text <> "" And txtColor.Text <> "" And txtPlaca.Text <> "" Then

            Dim vehiculodata As New Vehiculos()

            vehiculodata.marca = txtMarca.Text
            vehiculodata.modelo = txtModelo.Text
            vehiculodata.color = txtColor.Text
            vehiculodata.placa = txtPlaca.Text
            vehiculodata.ID = txtid.Text


            AvisosOperaciones.lblmensaje.Text = "¿Está seguro que desea eliminar este vehiculo?"
            AvisosOperaciones.ShowDialog()

            If Variable.autorizacion Then
                Dim respuesta = AccesoLogica.EliminarVehiculosDB(vehiculodata)

                If respuesta.Success Then
                    Avisos.lblmensaje.Text = "Datos eliminados correctamente"
                    Avisos.ShowDialog()
                    LimpiarCampos()
                    dgvVehiculos.DataSource = AccesoLogica.ObtenerVehiculosDB.Data
                    txtid.Visible = False
                    lblid.Visible = False
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

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        LimpiarCampos()
        txtid.Visible = False
        lblid.Visible = False
    End Sub

    Private Sub dgvVehiculos_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVehiculos.RowHeaderMouseDoubleClick
        txtMarca.Text = dgvVehiculos.SelectedRows(0).Cells(1).Value.ToString
        txtModelo.Text = dgvVehiculos.SelectedRows(0).Cells(2).Value.ToString
        txtColor.Text = dgvVehiculos.SelectedRows(0).Cells(3).Value.ToString
        txtPlaca.Text = dgvVehiculos.SelectedRows(0).Cells(4).Value.ToString
        txtid.Text = dgvVehiculos.SelectedRows(0).Cells(0).Value.ToString

        txtid.Visible = True
        lblid.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub
End Class