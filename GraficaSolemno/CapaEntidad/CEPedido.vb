Public Class CEPedidos
    Private _Descripcion As String
    Private _Cliente As String
    Private _IDPedido As Integer
    Private _Fecha As Date
    Private _Tipo_de_Envio As String

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property
    Public Property IDPedido() As Integer
        Get
            Return _IDPedido
        End Get
        Set(ByVal value As Integer)
            _IDPedido = value
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
    Public Property Tipo_de_Envio() As String
        Get
            Return _Tipo_de_Envio
        End Get
        Set(ByVal value As String)
            _Tipo_de_Envio = value
        End Set
    End Property