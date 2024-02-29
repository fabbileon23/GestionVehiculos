Public Class Usuarios
    Private _username As String
    Private _password As String
    Private _cedula As String
    Private _nombre As String
    Private _edad As Integer
    Private _fechanacimiento As String
    Private _telefono As String
    Private _direccion As String

    Public Property username() As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
    Public Property cedula() As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property edad() As String
        Get
            Return _edad
        End Get
        Set(value As String)
            _edad = value
        End Set
    End Property
    Public Property fechanacimento() As String
        Get
            Return _fechanacimiento
        End Get
        Set(value As String)
            _fechanacimiento = value
        End Set
    End Property
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
End Class
