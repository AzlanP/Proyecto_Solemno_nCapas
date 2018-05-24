Imports System.Data.SQLite

Public Class CDProducto
    Dim oCDConexion As New CDConexion


    Public Function MostrarTabla() As DataTable
        oCDConexion.Conectar()
        Dim dt As New DataTable


        dt = oCDConexion.MostrarTabla("Productos")
        Return dt

    End Function




End Class
