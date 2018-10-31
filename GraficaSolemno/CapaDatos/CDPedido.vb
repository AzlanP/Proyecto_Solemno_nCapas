Imports System.Data.SQLite
Imports CapaEntidad
Public Class CDPedidos
    Dim oCDConexion As New CDConexion

    Dim da As SQLiteDataAdapter
    Function MostrarPedido() As DataTable
        Return oCDConexion.MostrarTabla("Pedidos")
    End Function
    Public Sub AgregarPedido(ByVal oCEPedido As CEPedidos)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "INSERT INTO Pedidos (ID, Descripcion, Cliente, Fecha, Tipo_de_Envio) VALUE (@ID, @Descripcion, @Cliente, @Fecha, @Tipo_de_Envio)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDPedido", SqlDbType.Int).Value = oCEPedido.IDPedido
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEPedido.Descripcion
                .Add("Cliente", SqlDbType.VarChar).Value = oCEPedido.Cliente
                .Add("@Fecha", SqlDbType.VarChar).Value = oCEPedido.Fecha
                .Add("@Tipo_de_Envio", SqlDbType.VarChar).Value = oCEPedido.Tipo_de_Envio
            End With
            comando.ExecuteNonQuery()
            MsgBox("Pedido agregado")
        Catch ex As Exception
            Throw New Exception("No se pudo agregar el pedido: " & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub ModificarPedido(ByVal oCEPedido As CEPedidos)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "UPDATE Pedidos SET IDPedido=@IDPedido,Descripcion=@Descripcion, Cliente=@Cliente, Fecha=@Fecha, Tipo_de_Envio=@Tipo_de_Envio"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@IDPedido", SqlDbType.Int).Value = oCEPedido.IDPedido
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEPedido.Descripcion
                .Add("@Cliente", SqlDbType.VarChar).Value = oCEPedido.Cliente
                .Add("@Tipo_de_Envio", SqlDbType.VarChar).Value = oCEPedido.Tipo_de_Envio
            End With
            comando.ExecuteNonQuery()
            MsgBox("La modificacion se realizo con exito")
        Catch ex As Exception
            Throw New Exception("No se pudo modificar: " & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub EliminarPedido(ByVal IDPedido As Integer)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "DELETE FROM Pedidos WHERE (IDPedido=@IDPedido)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            comando.Parameters.Add("@IDPedido", SqlDbType.Int).Value = IDPedido
            comando.ExecuteNonQuery()
            MsgBox("El pedido se acaba de eliminar")
        Catch ex As Exception
            Throw New Exception("No se pudo eliminar:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
End Class