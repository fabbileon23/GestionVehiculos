Imports System.Data.SqlClient

Module Conexion
    Public vStringConexionSisUsuarios As String = "data source=localhost;initial catalog=CRUDUSUARIOS;Integrated Security=SSPI"
    Public vMySQLDataAdapter As SqlDataAdapter 'permite hacer consultas a sqlserver, no se recomienda para insert o update
    Public vMySQLCommand As SqlCommand ' permite hacer insert con parametros, para evitar sqlinjection
    Public vConexionSisUser As New SqlConnection(vStringConexionSisUsuarios)
End Module
