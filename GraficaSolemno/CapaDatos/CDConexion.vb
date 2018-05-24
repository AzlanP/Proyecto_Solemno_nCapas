'importo la libreria de sqlite
' si una libreria no aparece en el imports significa que debes agregar la referencia a la misma
Imports System.Data.SQLite
Imports System.IO
'uso .io para el uso de getcurrentdirectory
Public Class CDConexion
    ' definir las variables requeridas usualmente como globales para poder hacer mejor uso de ellas.
    Public con As New SQLiteConnection

    'Data source= C:\Users\Admin\Documents\GitHub\Proyecto_Solemno_nCapas\GraficaSolemno\CapaDatos\Solemno.db
    Private directorio As String = Directory.GetCurrentDirectory()
    'la funcion getcurrentdirectory retorna un string con la direccion de la carpeta donde se encuentra el ejecutable
    Private CadenaDeConexion As String = "Data Source=" & directorio & "\Solemno.db; version=3"
    'aca concatenamos la direccion del ejecutable con el nombre de base de datos y version de sqlite
    Dim InstruccionSQL As String = ""

    Dim comando As SQLiteCommand
    Dim dt As DataTable
    Dim da As SQLiteDataAdapter


    Public Sub Conectar()
        Try
            If con.State = ConnectionState.Closed Then
                con = New SQLiteConnection(CadenaDeConexion)
                con.Open() 'abro la coneccion de la base de datos
            Else
                MsgBox("La base de datos ya se encuentra activa.")
            End If
        Catch ex As Exception
            Throw New Exception("Error: No pudo inciarse la conexcion con la base de datos.")
        End Try
    End Sub

    Public Sub Desconectar()
        If con.State = Data.ConnectionState.Open Then
            con.Close()
            'este metodo llama tambien al metodo .close() y ademas libera los recursos utilizados
        End If
    End Sub

    Public Sub EjecutarConsulta(ByVal pInstruccionSQL As String)
        Dim Tran As SQLiteTransaction
        Conectar()
        Tran = con.BeginTransaction
        Try
            comando = New SQLiteCommand(pInstruccionSQL, con, Tran)
            comando.ExecuteNonQuery()
            Tran.Commit()
        Catch ex As Exception
            Tran.Rollback()
        Finally
            Desconectar()
        End Try
    End Sub

    Public Sub EjecutarComando(ByVal pcomando As SQLiteCommand)
        Conectar()
        Try

            comando = New SQLiteCommand
            comando = pcomando
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al ejecutar el comando.")
        Finally
            Desconectar()
        End Try

    End Sub
    Public Function MostrarTabla(ByVal pNombreTabla) As DataTable
        dt = New DataTable
        Conectar()
        da = New SQLiteDataAdapter
        Try
            InstruccionSQL = "Select * From " & pNombreTabla

            comando = New SQLiteCommand(InstruccionSQL, con)
            da.SelectCommand = comando
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("ERROR: La tabla no pudo ser mostrada.")
        Finally
            Desconectar()
        End Try
        
    End Function
End Class
