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
            con.Close()

            da.Dispose()
        End Try
       
    End Function
    Public Sub RegistrarCliente(ByVal oCECliente As CECliente)
        con = oCDConexion.Conectar()
        'ya la sentencia quedo bien...NO TOCAR!!!
        Dim instruccionSQL = "INSERT INTO Clientes  (IDCliente, Nombre ,Apellido ,Telefono, Celular, DNI, CUIT, IDPais, IDProvincia, IDCiudad, Barrio, Calle, Nro_Calle, Nro_Dpto, CP, EMAIL, IDCondIVA, Fecha) VALUES (@IDCliente, @Nombre ,@Apellido ,@Telefono, @Celular, @DNI, @CUIT, @IDPais, @IDProvincia, @IDCiudad, @Barrio, @Calle, @Nro_Calle, @Nro_Dpto, @CP, @EMAIL, @IDCondIVA, @Fecha)"
        Dim comando As New SQLiteCommand(instruccionSQL, con)
        With comando.Parameters
            .Add("@IDCliente", SqlDbType.Int).Value = oCECliente.IDCliente
            .Add("@Nombre", SqlDbType.VarChar).Value = oCECliente.Nombre
            .Add("@Apellido", SqlDbType.VarChar).Value = oCECliente.Apellido
            .Add("@Telefono", SqlDbType.Int).Value = oCECliente.Telefono
            .Add("@Celular", SqlDbType.Int).Value = oCECliente.Celular
            .Add("@DNI", SqlDbType.Int).Value = oCECliente.DNI
            .Add("@CUIT", SqlDbType.Int).Value = oCECliente.CUIT
            .Add("@IDPais", SqlDbType.Int).Value = oCECliente.Pais
            .Add("@IDProvincia", SqlDbType.Int).Value = oCECliente.Provincia
            .Add("@IDCiudad", SqlDbType.Int).Value = oCECliente.Ciudad
            .Add("@Barrio", SqlDbType.VarChar).Value = oCECliente.Barrio
            .Add("@Calle", SqlDbType.VarChar).Value = oCECliente.Calle
            .Add("@Nro_Calle", SqlDbType.Int).Value = oCECliente.NroCalle
            .Add("@Nro_Dpto", SqlDbType.Int).Value = oCECliente.NroDpto
            .Add("@CP", SqlDbType.Int).Value = oCECliente.CP
            .Add("@EMAIL", SqlDbType.VarChar).Value = oCECliente.Email
            .Add("@IDCondIVA", SqlDbType.Int).Value = oCECliente.CondIVA
            .Add("@Fecha", SqlDbType.VarChar).Value = oCECliente.Fecha

        End With
        comando.ExecuteNonQuery()
        MsgBox("Se ah hecho el registro con exito")

        con.Close()
        con.Dispose()
    End Sub
    Public Sub EliminarCliente(ByVal id As Integer)
        con = oCDConexion.Conectar()
        con.Open()
        Dim instruccionSQL = "DELETE FROM Clientes WHERE ( IDCliente = @IDCliente)"
        Dim comando As New SQLiteCommand(instruccionSQL, con)
        comando.Parameters.Add("@IDCliente", SqlDbType.Int).Value = id
        comando.ExecuteNonQuery()

        con.Close()
        con.Dispose()
        MsgBox("El registro se ah eliminado exitosamente.")
    End Sub
    Public Sub ModificarCliente(ByVal oCECliente As CECliente)
        con = oCDConexion.Conectar()

        Dim instruccionSQL = "UPDATE Clientes  SET Nombre=@Nombre ,Apellido=@Apellido ,Telefono=@Telefono, Celular=@Celular, DNI=@DNI, CUIT= @CUIT, IDPais=@IDPais, IDProvincia=@IDProvincia, IDCiudad=@IDCiudad, Barrio=@Barrio, Calle=@Calle, Nro_Calle=@Nro_Calle, Nro_Dpto=@Nro_Dpto, CP=@CP, EMAIL=@EMAIL, IDCondIVA=@IDCondIVA, Fecha=@Fecha WHERE IDCliente=@IDCliente"
        Dim comando As New SQLiteCommand(instruccionSQL, con)
        With comando.Parameters
            .Add("@IDCliente", SqlDbType.Int).Value = oCECliente.IDCliente
            .Add("@Nombre", SqlDbType.VarChar).Value = oCECliente.Nombre
            .Add("@Apellido", SqlDbType.VarChar).Value = oCECliente.Apellido
            .Add("@Telefono", SqlDbType.Int).Value = oCECliente.Telefono
            .Add("@Celular", SqlDbType.Int).Value = oCECliente.Celular
            .Add("@DNI", SqlDbType.Int).Value = oCECliente.DNI
            .Add("@CUIT", SqlDbType.Int).Value = oCECliente.CUIT
            .Add("@IDPais", SqlDbType.Int).Value = oCECliente.Pais
            .Add("@IDProvincia", SqlDbType.Int).Value = oCECliente.Provincia
            .Add("@IDCiudad", SqlDbType.Int).Value = oCECliente.Ciudad
            .Add("@Barrio", SqlDbType.VarChar).Value = oCECliente.Barrio
            .Add("@Calle", SqlDbType.VarChar).Value = oCECliente.Calle
            .Add("@Nro_Calle", SqlDbType.Int).Value = oCECliente.NroCalle
            .Add("@Nro_Dpto", SqlDbType.Int).Value = oCECliente.NroDpto
            .Add("@CP", SqlDbType.Int).Value = oCECliente.CP
            .Add("@EMAIL", SqlDbType.VarChar).Value = oCECliente.Email
            .Add("@IDCondIVA", SqlDbType.Int).Value = oCECliente.CondIVA
            .Add("@Fecha", SqlDbType.VarChar).Value = oCECliente.Fecha
        End With
        comando.ExecuteNonQuery()
    End Sub
    Function Buscar(ByVal pcampo As String, ByVal pbuscar As String) As DataTable
        con = oCDConexion.Conectar()
        da = New SQLiteDataAdapter
        Dim dt As New DataTable
        Dim instruccionSQL = "Select * FROM Clientes where " & pcampo & "=@buscar "
        Dim comando As New SQLiteCommand(instruccionSQL, con)
        If IsNumeric(pbuscar) Then
            comando.Parameters.Add("@buscar", SqlDbType.Int).Value = pbuscar
        Else
            comando.Parameters.Add("@buscar", SqlDbType.VarChar).Value = pbuscar
        End If
        da.SelectCommand = comando
        da.Fill(dt)
        Return dt
        con.Close()
    End Function
    Function ConsultarUltimoID() As Integer
        con = oCDConexion.Conectar()
        'este open aveces da algunos errores, revisarlo.
        'Operación no válida dado el estado actual del objeto.
        'el error se produce la segunda vez de ser llamado.
        con.Open()

        'la sentencia retorna el id del ultimo registro agregado guardado en la tabla de configuracion sequence del autoincrementar.
        Dim sql As String = "Select seq from sqlite_sequence where name='Clientes'"
        Dim cmd As New SQLiteCommand(sql, con)
        'el executescalar devuelve la primera columna de la primera fila
        Dim UltimoID As Integer = CInt(cmd.ExecuteScalar())
        con.Close()
        Return UltimoID + 1
    End Function
End Class
