Public Class CECliente
    'tendria que ver si es mejor referirse como ciudad o localidad
    Dim oCECliente As CECliente

    Private _IDCliente, _Nombre, _Apellido, _Email, _Barrio, _Calle As String
    Private _Telefono, _Celular, _CUIT, _DNI, _NroCasa, _NroCalle, _NroDpto, _CP As Integer
    Private _Pais, _Provincia, _Ciudad, _CondIVA As Integer
    Private _Fecha As Date

    'SET and GET de las variables
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
    Public Property Pais() As Integer
        Get
            Return _Pais
        End Get
        Set(ByVal value As Integer)
            _Pais = value
        End Set
    End Property
    Public Property Provincia() As Integer
        Get
            Return _Provincia
        End Get
        Set(ByVal value As Integer)
            _Provincia = value
        End Set
    End Property
    Public Property Ciudad() As Integer
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As Integer)
            _Ciudad = value
        End Set
    End Property
    Public Property Barrio() As String
        Get
            Return _Barrio
        End Get
        Set(ByVal value As String)
            _Barrio = value
        End Set
    End Property
    Public Property Calle() As String
        Get
            Return _Calle
        End Get
        Set(ByVal value As String)
            _Calle = value
        End Set
    End Property
    Public Property CondIVA() As Integer
        Get
            Return _CondIVA
        End Get
        Set(ByVal value As Integer)
            _CondIVA = value
        End Set
    End Property
    Public Property Telefono() As Integer
        Get
            Return _Telefono
        End Get
        Set(ByVal value As Integer)
            _Telefono = value
        End Set
    End Property
    Public Property Celular() As Integer
        Get
            Return _Celular
        End Get
        Set(ByVal value As Integer)
            _Celular = value
        End Set
    End Property
    Public Property CUIT() As Integer
        Get
            Return _CUIT
        End Get
        Set(ByVal value As Integer)
            _CUIT = value
        End Set
    End Property
    Public Property DNI() As Integer
        Get
            Return _DNI
        End Get
        Set(ByVal value As Integer)
            _DNI = value
        End Set
    End Property
    Public Property NroCasa() As Integer
        Get
            Return _NroCasa
        End Get
        Set(ByVal value As Integer)
            _NroCasa = value
        End Set
    End Property
    Public Property NroCalle() As Integer
        Get
            Return _NroCalle
        End Get
        Set(ByVal value As Integer)
            _NroCalle = value
        End Set
    End Property
    Public Property NroDpto() As Integer
        Get
            Return _NroDpto
        End Get
        Set(ByVal value As Integer)
            _NroDpto = value
        End Set
    End Property
    Public Property CP() As Integer
        Get
            Return _CP
        End Get
        Set(ByVal value As Integer)
            _CP = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property
    Public Property IDCliente() As Integer
        Get
            Return _IDCliente
        End Get
        Set(ByVal value As Integer)
            _IDCliente = value
        End Set
    End Property
End Class
