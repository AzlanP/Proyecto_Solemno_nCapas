Imports System.Data.SQLite
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
End Class
