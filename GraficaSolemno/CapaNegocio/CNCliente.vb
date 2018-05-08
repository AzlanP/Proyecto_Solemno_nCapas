Imports CapaDatos
Imports CapaEntidad
Public Class CNCliente
    Dim oCDCliente As New CDCliente
    'por buenas practicas la funcion llevara el mismo nombre que en la capa de datos
    Function ListarCliente() As DataTable
        Return oCDCliente.ListarCliente
    End Function
    Public Sub RegistrarCliente(ByVal oCECliente As CECliente)
        oCDCliente.RegistrarCliente(oCECliente)
    End Sub
    Public Sub EliminarCliente(ByVal id As Integer)
        oCDCliente.EliminarCliente(id)
    End Sub
    Public Sub ModificarCliente(ByVal oCECliente As CECliente)
        oCDCliente.ModificarCliente(oCECliente)
    End Sub
    Function Buscar(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        Dim dt As New DataTable
        dt = oCDCliente.Buscar(pcampo, pbuscar)
        Return dt
    End Function
End Class
