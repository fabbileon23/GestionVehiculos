Imports System.Data.SqlClient
Imports ProyectoEntidades
Public Class UsuariosData

    Function ObtenerUsuario(credencial As Usuarios) As Reply
        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "VerificarUsuario"
        vMySQLCommand.CommandType = CommandType.StoredProcedure ' Establecer el tipo de comando como Stored Procedure
        ' Agregar parámetros al Stored Procedure
        vMySQLCommand.Parameters.Add("@nombreUsuario", SqlDbType.NVarChar, 50).Value = credencial.username
        vMySQLCommand.Parameters.Add("@contrasenaUsuario", SqlDbType.NVarChar, 150).Value = credencial.password
        ' vMySQLCommand.Parameters.Add("@Parametro3", SqlDbType.DateTime).Value = param3
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLDataAdapter.Fill(vDataTable)
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Conexión Exitosa!"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Clientes: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el usuario"
        End Try

        Return reply
    End Function


    Function ObtenerUsuariosDB() As Reply
        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "ObtenerUsuariosBD"
        vMySQLCommand.CommandType = CommandType.StoredProcedure 
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLDataAdapter.Fill(vDataTable)
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Consulta Exitosa"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Clientes: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el usuario"
        End Try

        Return reply
    End Function

    Function InsertarUsuariosDB(Datausuario As Usuarios) As Reply
        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "InsertarUsuariosDB"
        vMySQLCommand.CommandType = CommandType.StoredProcedure ' Establecer el tipo de comando como Stored Procedure
        ' Agregar parámetros al Stored Procedure
        vMySQLCommand.Parameters.Add("@pcedula", SqlDbType.VarChar, 50).Value = Datausuario.cedula
        vMySQLCommand.Parameters.Add("@pnombre", SqlDbType.VarChar, 180).Value = Datausuario.nombre
        vMySQLCommand.Parameters.Add("@papellidos", SqlDbType.VarChar, 50).Value = Datausuario.apellidos
        vMySQLCommand.Parameters.Add("@ptelefono", SqlDbType.VarChar, 20).Value = Datausuario.telefono
        vMySQLCommand.Parameters.Add("@pgenero", SqlDbType.VarChar, 20).Value = Datausuario.genero
        ' vMySQLCommand.Parameters.Add("@Parametro3", SqlDbType.DateTime).Value = param3
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLCommand.ExecuteNonQuery()
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Conexión Exitosa!"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Clientes: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el usuario"
        End Try

        Return reply
    End Function


    Function ActualizarUsuariosDB(Datausuario As Usuarios) As Reply
        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "ActualizarUsuariosDB"
        vMySQLCommand.CommandType = CommandType.StoredProcedure ' Establecer el tipo de comando como Stored Procedure
        ' Agregar parámetros al Stored Procedure
        vMySQLCommand.Parameters.Add("@pcedula", SqlDbType.VarChar, 50).Value = Datausuario.cedula
        vMySQLCommand.Parameters.Add("@pnombre", SqlDbType.VarChar, 180).Value = Datausuario.nombre
        vMySQLCommand.Parameters.Add("@papellidos", SqlDbType.VarChar, 50).Value = Datausuario.apellidos
        vMySQLCommand.Parameters.Add("@ptelefono", SqlDbType.VarChar, 20).Value = Datausuario.telefono
        vMySQLCommand.Parameters.Add("@pgenero", SqlDbType.VarChar, 20).Value = Datausuario.genero
        ' vMySQLCommand.Parameters.Add("@Parametro3", SqlDbType.DateTime).Value = param3
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLCommand.ExecuteNonQuery()
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Actualización Exitosa!"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Clientes: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el usuario"
        End Try

        Return reply
    End Function

    Function EliminarUsuariosDB(Datausuario As Usuarios) As Reply
        Dim vDataTable As New DataTable 'almacena el resultado de las consultas
        Dim reply As New Reply
        vConexionSisUser.Open() 'Abrir conexion
        vMySQLCommand = New SqlCommand
        vMySQLCommand.Connection = vConexionSisUser 'asigno el string de conexion
        vMySQLCommand.CommandText = "EliminarUsuariosDB"
        vMySQLCommand.CommandType = CommandType.StoredProcedure ' Establecer el tipo de comando como Stored Procedure
        ' Agregar parámetros al Stored Procedure
        vMySQLCommand.Parameters.Add("@pcedula", SqlDbType.VarChar, 50).Value = Datausuario.cedula
        ' vMySQLCommand.Parameters.Add("@Parametro3", SqlDbType.DateTime).Value = param3
        Try
            vMySQLDataAdapter = New SqlDataAdapter(vMySQLCommand)
            vMySQLCommand.ExecuteNonQuery()
            vConexionSisUser.Close() 'Cierro conexion

            reply.Success = True
            reply.Message = "Eliminación Exitosa!"
            reply.Data = vDataTable

        Catch ex As Exception
            MsgBox("Error al consultar Clientes: " & ex.Message, vbCritical, "Sistema")
            reply.Success = False
            reply.Message = "Ha ocurrido un error al consultar el usuario"
        End Try

        Return reply
    End Function
End Class
