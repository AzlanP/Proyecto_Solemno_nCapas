Imports CapaDatos
Imports CapaEntidad
Public Class CNProducto
    Dim oCDProducto As New CDProducto
    Dim oCEProducto As New CEproducto
    Public Function MostrarProducto() As DataTable
        Return oCDProducto.MostrarProducto()
    End Function
    Public Sub RegistrarProducto(ByVal oCEProducto As CEProducto)
        oCDProducto.RegistrarProducto(oCEProducto)
    End Sub

    Public Sub EliminarProducto(ByVal id As Integer)
        oCDProducto.EliminarProducto(id)
    End Sub
    Public Sub ModificarProducto(ByVal oCEProducto As CEProducto)
        oCDProducto.ModificarProducto(oCEProducto)
    End Sub
    Function BuscarProducto(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        Dim dt As New DataTable
        dt = oCDProducto.BuscarProducto(pcampo, pbuscar)
        Return dt
    End Function
    Function ConsultarUltimoID() As Integer
        Return oCDProducto.ConsultarUltimoID()
    End Function
End Class
