Imports System.Data.SQLite
Imports CapaEntidad

Public Class CDProducto
    Dim oCDConexion As New CDConexion
    Dim oCEProducto As New CEProducto

    Public Function MostrarProducto() As DataTable
        Return oCDConexion.MostrarTabla("Productos")
    End Function



    Public Sub RegistrarProducto(ByVal oCEProducto As CEProducto)
        oCDConexion.Conectar()
        Dim confirma As String
        Try
            Dim instruccionSQL = "INSERT INTO Productos (IDProductos, Nombre, Cantidad, Precio, Tipo, Descripcion,Codigo) VALUES (@IDProducto, @Nombre, @Cantidad, @Precio, @Tipo, @Descripcion, @Codigo)"

            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            With comando.Parameters
                .Add("@IDProducto", SqlDbType.Int).Value = oCEProducto.IDProductos
                .Add("@Nombre", SqlDbType.VarChar).Value = oCEProducto.Nombre
                .Add("@Cantidad", SqlDbType.Int).Value = oCEProducto.Cantidad
                .Add("@Precio", SqlDbType.Int).Value = oCEProducto.Precio
                .Add("@Tipo", SqlDbType.Int).Value = oCEProducto.Tipo
                .Add("@Descripcion", SqlDbType.VarChar).Value = oCEProducto.Descripcion
                .Add("@Codigo", SqlDbType.Int).Value = oCEProducto.Codigo
            End With
            MsgBox(instruccionSQL)
            comando.ExecuteNonQuery()
            'confirma = Console.ReadLine()
            'If confirma.ToUpper = "s" Then
            '    MsgBox("Se ah hecho el registro del producto con exito")
            'Else
            '    MsgBox("No se cargo el registro del producto")
            'End If
        Catch ex As Exception


            Throw New Exception("ERROR al registrar " & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try
    End Sub
    Public Sub EliminarProducto(ByVal id As Integer)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = "DELETE FROM Productos WHERE (IDProductos=@IDProductos)"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            comando.Parameters.Add("@IDProductos", SqlDbType.Int).Value = id
            comando.ExecuteNonQuery()

            MsgBox("Registro eliminado")
        Catch ex As Exception
            Throw New Exception("No se ah podido eliminar el registro:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try

    End Sub
    Public Sub ModificarProducto(ByVal oCEProducto As CEProducto)
        oCDConexion.Conectar()
        Try
            Dim instruccionsql = " UPDATE Producto SET Nombre=@Nombre, ID_Productos=@ID_Productos, Codigo=@Codigo, Descripcion=@Descripcion, Cantidad=@Cantidad, Precio=@Precio, Tipo=@Tipo"
            Dim comando As New SQLiteCommand(instruccionsql, oCDConexion.con)
            With comando.Parameters
                .Add("@Nombre", SqlDbType.Int).Value = oCEProducto.Nombre
                .Add("@ID_Producto", SqlDbType.Int).Value = oCEProducto.IDProductos
                .Add("@Codigo", SqlDbType.Int).Value = oCEProducto.Codigo
                .Add("@Descripcion", SqlDbType.Int).Value = oCEProducto.Descripcion
                .Add("@Cantidad", SqlDbType.Int).Value = oCEProducto.Cantidad
                .Add("@Precio", SqlDbType.Int).Value = oCEProducto.Precio
                .Add("@Tipo", SqlDbType.Int).Value = oCEProducto.Tipo
            End With
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("No se ah podido modificar el registro seleccionado:" & ex.Message)

        End Try

    End Sub
    Function BuscarProducto(ByVal camp As String, ByVal pbuscar As String) As DataTable
        oCDConexion.Conectar()
        Dim da As New SQLiteDataAdapter
        Dim dt As New DataTable
        Try

            Dim instruccionSQL = "Select * FROM Productos where " & camp & "=@buscar "
            Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
            If IsNumeric(pbuscar) Then
                comando.Parameters.Add("@buscar", SqlDbType.Int).Value = pbuscar
            Else
                comando.Parameters.Add("@buscar", SqlDbType.VarChar).Value = pbuscar
            End If
            da.SelectCommand = comando
            da.Fill(dt)
            Return dt

        Catch ex As Exception
            Throw New Exception("ERROR la busqueda ah fallado. Descripcion:" & ex.Message)
        Finally
            oCDConexion.Desconectar()
        End Try

        'oCDConexion.Conectar()
        'Dim da = New SQLiteDataAdapter
        'Dim dt As New DataTable
        'Dim instruccionSQL = "Select * FROM Productos where " & camp & "=@buscar "
        'Dim comando As New SQLiteCommand(instruccionSQL, oCDConexion.con)
        'da.SelectCommand = comando
        'da.Fill(dt)
        'Return dt
    End Function
    Public Function ConsultarUltimoID() As Integer
        oCDConexion.Conectar()
        Try
            'la sentencia retorna el id del ultimo registro agregado guardado en la tabla de configuracion sequence del autoincrementar.
            Dim sql As String = "Select seq from sqlite_sequence where name='Productos'"
            Dim cmd As New SQLiteCommand(sql, oCDConexion.con)
            'el executescalar devuelve la primera columna de la primera fila
            Dim UltimoID As Integer = CInt(cmd.ExecuteScalar())
            Return UltimoID + 1
        Catch ex As Exception
            Throw New Exception("ERROR La consulta de ultimo ID fallo. Descripcion:" & ex.Message)
        End Try
        oCDConexion.Desconectar()

    End Function

End Class
