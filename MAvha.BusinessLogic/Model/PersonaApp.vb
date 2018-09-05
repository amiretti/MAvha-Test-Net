Public Class PersonaApp
    Private _ID As Integer
    Private _nombre As String
    Private _nacimiento As DateTime
    Private _edad As Integer
    Private _sexo As String

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Nacimiento() As DateTime
        Get
            Return _nacimiento
        End Get
        Set(ByVal value As DateTime)
            _nacimiento = value
        End Set
    End Property

    Public Property Edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    Public Property Sexo() As String
        Get
            Return _sexo
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property
End Class
