Public Class CEPedido
    Private _Descripcion As String
    Private _ID_Pedido As Integer
    Private _Fecha_Inicio As Date
    Private _Fecha_Entrega As Date
    Private _Entregado As String

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property ID_Pedido() As Integer
        Get
            Return _ID_Pedido
        End Get
        Set(ByVal value As Integer)
            _ID_Pedido = value
        End Set
    End Property
    Public Property Fecha_Inicio() As Date
        Get
            Return _Fecha_Inicio
        End Get
        Set(ByVal value As Date)
            _Fecha_Inicio = value
        End Set
    End Property
    Public Property Fecha_Entrega() As Date
        Get
            Return _Fecha_Entrega
        End Get
        Set(ByVal value As Date)
            _Fecha_Entrega = value
        End Set
    End Property
    Public Property Entregado() As String
        Get
            Return _Entregado
        End Get
        Set(ByVal value As String)
            _Entregado = value
        End Set
    End Property

End Class
