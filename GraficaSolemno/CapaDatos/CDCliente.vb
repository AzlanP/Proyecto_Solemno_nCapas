Imports System.Data.SQLite
Imports CapaEntidad

Public Class CDCliente
    Dim oCDConexion As New CDConexion
    Dim con As SQLiteConnection
    Dim da As SQLiteDataAdapter
    'esta funcion retorna un dataset con la tabla de cliente
    Function ListarCliente() As DataTable
        Try
            Dim dt As New DataTable
            da = New SQLiteDataAdapter()
            'con = New SQLiteConnection
            con = oCDConexion.Conectar()
            Dim InstruccionSQL As String = "SELECT * FROM Clientes"
            Dim comando As New SQLiteCommand(InstruccionSQL, con)
            da.SelectCommand = comando
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error: La Instruccion para cargar la tabla cliente a fallado")
        Finally
            con.Dispose()
            con.Close()
            da.Dispose()
        End Try
       
    End Function
    Public Sub RegistrarCliente(ByVal oCECliente As CECliente)
        con = oCDConexion.Conectar()
        Dim instruccionSQL = "Insert into Cliente values"
        Dim comando As New SQLiteCommand(instruccionSQL, con)
        With comando.Parameters
            .Add("@Nombre", SqlDbType.VarChar).Value = oCECliente.Nombre
            .Add("@Apellido", SqlDbType.VarChar).Value = oCECliente.Apellido
            .Add("@Tel", SqlDbType.Int).Value = oCECliente.Telefono
            .Add("@Cel", SqlDbType.Int).Value = oCECliente.Celular
            .Add("@Nacionalidad", SqlDbType.VarChar).Value = oCECliente.Pais
            .Add("@Provincia", SqlDbType.VarChar).Value = oCECliente.Provincia
            .Add("@Localidad", SqlDbType.VarChar).Value = oCECliente.Localidad
            .Add("@Barrio", SqlDbType.VarChar).Value = oCECliente.Barrio
            .Add("@Calle", SqlDbType.VarChar).Value = oCECliente.Calle
            .Add("@Nro_Calle", SqlDbType.Int).Value = oCECliente.NroCalle
            .Add("@Nro_Dpto_Piso", SqlDbType.Int).Value = oCECliente.NroDpto
            .Add("@CP", SqlDbType.Int).Value = oCECliente.CP
            .Add("@DNI", SqlDbType.Int).Value = oCECliente.DNI
            .Add("@CUIT", SqlDbType.Int).Value = oCECliente.CUIT
        End With
        comando.ExecuteNonQuery()
    End Sub
End Class
