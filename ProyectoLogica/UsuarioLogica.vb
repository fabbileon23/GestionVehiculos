Imports ProyectoEntidades
Imports ProyectoData
Public Class UsuarioLogica


    Public AccesoData As UsuariosData

    Public Sub New()
        AccesoData = New UsuariosData()
    End Sub

    Public Sub ObtenerUsuarios(crendencial As Usuarios)
        Throw New NotImplementedException()
    End Sub

    Public Function ObtenerUsuario(credencial As Usuarios) As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.ObtenerUsuario(credencial)

        If (_reply.Success) Then
            If (_reply.Data.Rows(0)(0) = "Éxito al iniciar sesión") Then
                reply.Success = True
                reply.Message = _reply.Data.Rows(0)(0)
            Else
                reply.Success = False
                reply.Message = _reply.Data.Rows(0)(0)
            End If
        Else
            reply.Message = _reply.Data.Rows(0)(0)
        End If

        Return reply
    End Function

    Public Function ObtenerUsuariosDB() As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.ObtenerUsuariosDB

        If (_reply.Success) Then
            reply.Success = True
            reply.Message = "Datos obtenidos correctamente"
            reply.Data = _reply.Data
        Else
            reply.Success = False
            reply.Message = "Ha ocurrido un error"

        End If

        Return reply
    End Function

    Public Function InsertarUsuariosDB(Datausuario As Usuarios) As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.InsertarUsuariosDB(Datausuario)

        If (_reply.Success) Then
            reply.Success = True
            reply.Message = "Datos insertados correctamente"
            reply.Data = _reply.Data
        Else
            reply.Success = False
            reply.Message = "Ha ocurrido un error"

        End If

        Return reply
    End Function

    Public Function ActualizarUsuariosDB(Datausuario As Usuarios) As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.ActualizarUsuariosDB(Datausuario)

        If (_reply.Success) Then
            reply.Success = True
            reply.Message = "Datos actualizados correctamente"
            reply.Data = _reply.Data
        Else
            reply.Success = False
            reply.Message = "Ha ocurrido un error"

        End If

        Return reply
    End Function

    Public Function EliminarUsuariosDB(Datausuario As Usuarios) As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.EliminarUsuariosDB(Datausuario)

        If (_reply.Success) Then
            reply.Success = True
            reply.Message = "Datos eliminados correctamente"
            reply.Data = _reply.Data
        Else
            reply.Success = False
            reply.Message = "Ha ocurrido un error"

        End If

        Return reply
    End Function

End Class
