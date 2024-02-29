Imports ProyectoData
Imports ProyectoEntidades

Public Class VehiculoLogica
    Public AccesoData As VehiculosData

    Public Sub New()
        AccesoData = New VehiculosData()
    End Sub

    Public Sub ObtenerVehiculos(vehiculos As Vehiculos)
        Throw New NotImplementedException()
    End Sub

    Public Function ObtenerVehiculosDB() As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.ObtenerVehiculosDB

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

    Public Function InsertarVehiculosDB(vehiculo As Vehiculos) As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.InsertarVehiculosDB(vehiculo)

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

    Public Function ActualizarVehiculosDB(vehiculo As Vehiculos) As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.ActualizarVehiculosDB(vehiculo)

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

    Public Function EliminarVehiculosDB(vehiculo As Vehiculos) As Reply
        Dim reply As New Reply
        Dim _reply = AccesoData.EliminarVehiculosDB(vehiculo)

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
