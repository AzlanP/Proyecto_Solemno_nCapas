'importo la libreria de sqlite
' si una libreria no aparece en el imports significa que debes agregar la referencia a la misma
Imports System.Data.SQLite
Imports System.Text
'se importa esta libreria para el caso de hacer uso de la clase stringbuilder

Imports System.IO
'uso .io para el uso de getcurrentdirectory

Public Class CDConexion
    ' definir las variables requeridas usualmente como globales para poder hacer mejor uso de ellas.
    Dim con As SQLiteConnection = Nothing
    ';Data Source=|DataDirectory|\data
    'Data source= C:\Users\Admin\Documents\GitHub\Proyecto_Solemno_nCapas\GraficaSolemno\CapaDatos\Solemno.db
    Private directorio As String = Directory.GetCurrentDirectory()
    Private CadenaDeConexion As String = "Data Source=" & directorio & " \Solemno.db; version=3"
    Dim InstruccionSQL As String = ""
    Dim comando As SQLiteCommand
    Dim dt As DataTable
    Dim da As SQLiteDataAdapter


    Public Function Conectar() As SQLiteConnection
        'se modifico el con.state=open ya que generaba error al llamar el metodo desde el modmain
        ' creo se debe a que intentamos usar una funcion "State" en un objeto no inicializado
        Try
            If con Is Nothing Then
                con = New SQLiteConnection(CadenaDeConexion)
                con.Open() 'abro la coneccion de la base de datos

            Else
                MsgBox("La base de datos ya se encuentra activa.")

            End If
            Return con
        Catch ex As Exception
            Throw New Exception("Error: No pudo inciarse la conexcion con la base de datos.")
        End Try


        'con.state verifica el estado de la conexion, si es 1 es que esta abierta, si es 0 es que esta cerrada.

    End Function
    Public Sub Desconectar()
        If con.State = Data.ConnectionState.Open Then
            con.Dispose() 'libera los recursos 
            con.Close()
        End If
    End Sub
    Public Sub EjecutarConsulta(ByVal pInstruccionSQL As String)
        Dim Tran As SQLiteTransaction  '(*)
        con = Conectar()
        Tran = con.BeginTransaction    '(*)
        Try                            '(*)

            comando = New SQLiteCommand(pInstruccionSQL, con, Tran)
            comando.ExecuteNonQuery()
            Tran.Commit()               '(*)

        Catch ex As Exception           '(*)
            Tran.Rollback()            '(*)

        End Try                        '(*)lineas agregadas para la prueba de transaction

    End Sub
    Public Sub EjecutarComando(ByVal pcomando As SQLiteCommand)
        comando = New SQLiteCommand
        comando = pcomando
        comando.ExecuteNonQuery()

    End Sub
    Public Function MostrarTabla(ByVal pNombreTabla) As DataTable
        dt = New DataTable
        con = Conectar()
        da = New SQLiteDataAdapter
        InstruccionSQL = "Select * From " & pNombreTabla

        comando = New SQLiteCommand(InstruccionSQL, con)
        da.SelectCommand = comando
        da.Fill(dt)
        Return dt
    End Function
End Class
