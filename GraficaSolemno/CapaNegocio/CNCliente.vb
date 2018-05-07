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
End Class
