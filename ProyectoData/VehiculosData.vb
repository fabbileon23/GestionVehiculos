Imports ProyectoEntidades
Imports System.Data.SqlClient

Public Class VehiculosData

    Public Function InsertarVehiculosDB(vehiculo As Vehiculos) As Reply

        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "InsertarVehiculosDB"
        vMySQLCommand.CommandType = CommandType.StoredProcedure ' Establecer el tipo de comando como Stored Procedure
        ' Agregar parámetros al Stored Procedure
        vMySQLCommand.Parameters.Add("@pmarca", SqlDbType.VarChar, 50).Value = vehiculo.marca
        vMySQLCommand.Parameters.Add("@pmodelo", SqlDbType.VarChar, 180).Value = vehiculo.modelo
        vMySQLCommand.Parameters.Add("@pcolor", SqlDbType.VarChar, 50).Value = vehiculo.color
        vMySQLCommand.Parameters.Add("@pplaca", SqlDbType.VarChar, 20).Value = vehiculo.placa
        ' vMySQLCommand.Parameters.Add("@Parametro3", SqlDbType.DateTime).Value = param3
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLCommand.ExecuteNonQuery()
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Conexión Exitosa!"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Vehiculos: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el vehiculo"
        End Try

        Return reply
    End Function

    Public Function ActualizarVehiculosDB(vehiculo As Vehiculos)
        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "ActualizarVehiculosDB"
        vMySQLCommand.CommandType = CommandType.StoredProcedure ' Establecer el tipo de comando como Stored Procedure
        ' Agregar parámetros al Stored Procedure
        vMySQLCommand.Parameters.Add("@pmarca", SqlDbType.VarChar, 50).Value = vehiculo.marca
        vMySQLCommand.Parameters.Add("@pmodelo", SqlDbType.VarChar, 180).Value = vehiculo.modelo
        vMySQLCommand.Parameters.Add("@pcolor", SqlDbType.VarChar, 50).Value = vehiculo.color
        vMySQLCommand.Parameters.Add("@pplaca", SqlDbType.VarChar, 20).Value = vehiculo.placa
        vMySQLCommand.Parameters.Add("@pid", SqlDbType.VarChar, 20).Value = vehiculo.ID
        ' vMySQLCommand.Parameters.Add("@Parametro3", SqlDbType.DateTime).Value = param3
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLCommand.ExecuteNonQuery()
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Actualización Exitosa!"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Vehiculos: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el vehiculo"
        End Try

        Return reply
    End Function

    Function EliminarVehiculosDB(vehiculo As Vehiculos) As Reply
        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "EliminarVehiculoDB"
        vMySQLCommand.CommandType = CommandType.StoredProcedure ' Establecer el tipo de comando como Stored Procedure
        ' Agregar parámetros al Stored Procedure
        vMySQLCommand.Parameters.Add("@pid", SqlDbType.VarChar, 50).Value = vehiculo.ID
        ' vMySQLCommand.Parameters.Add("@Parametro3", SqlDbType.DateTime).Value = param3
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLCommand.ExecuteNonQuery()
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Eliminación Exitosa!"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Vehiculos: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el vehiculo"
        End Try

        Return reply
    End Function

    Function ObtenerVehiculosDB() As Reply
        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "ObtenerVehiculosDB"
        vMySQLCommand.CommandType = CommandType.StoredProcedure
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLDataAdapter.Fill(vDataTable)
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Consulta Exitosa"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Vehiculos: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el vehiculo"
        End Try

        Return reply
    End Function



End Class
