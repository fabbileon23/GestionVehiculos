Public Class Vehiculos
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Private _marca As String
    Public Property marca() As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Private _modelo As String
    Public Property modelo() As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Private _color As String
    Public Property color() As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Private _placa As String
    Public Property placa() As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
        End Set
    End Property



End Class
