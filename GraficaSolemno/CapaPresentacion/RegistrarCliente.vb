Imports CapaEntidad
Imports CapaNegocio
Public Class RegistrarCliente
    Dim oCNCliente As New CNCliente
    Dim oCECliente As New CECliente

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
       btnRegistrar.Text = "Registrar Cliente"
        

        oCECliente.IDCliente = 9
        oCECliente.Nombre = "prueba2"
        oCECliente.Apellido = "demierda2"
        oCECliente.Telefono = 1234
        oCECliente.Celular = 1234
        oCECliente.DNI = 12345
        oCECliente.CUIT = 12345
        oCECliente.Pais = 1
        oCECliente.Provincia = 5
        oCECliente.Ciudad = 6
        oCECliente.Barrio = "Ayacucho"
        oCECliente.Calle = "Mierdosa"
        oCECliente.NroCalle = 10
        oCECliente.NroDpto = 12
        oCECliente.NroCasa = 13
        oCECliente.CP = 1214
        oCECliente.Email = "as@gmail.com"
        oCECliente.CondIVA = 1
        oCECliente.Fecha = CStr(dpFecha.Value)

        oCNCliente.RegistrarCliente(oCECliente)
        Close()
    End Sub

    Public Sub Modificar(ByVal ID As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        'realizo la busqueda del cliente segun su ID
        dt = oCNCliente.Buscar("IDCliente", ID)
        'guardo el registro del cliente en el datarow para mostrarlo
        dr = dt.Rows(0)
        'para mostrar los datos precargados de el registro
        lblID.Text = dr("IDCliente").ToString
        txtNombre.Text = dr("Nombre").ToString
        txtApellido.Text = dr("Apellido").ToString
        txtTel.Text = dr("Telefono").ToString
        txtCel.Text = dr("Celular").ToString
        txtDNI.Text = dr("DNI").ToString
        txtDNI.Text = dr("CUIT").ToString
        cboPais.Text = dr("IDPais").ToString
        cboProvincia.Text = dr("IDProvincia").ToString
        txtCiudad.Text = dr("IDCiudad").ToString
        txtBarrio.Text = dr("Barrio").ToString
        txtCalle.Text = dr("Calle").ToString
        txtNumeracion.Text = dr("Nro_Calle").ToString
        txtNumeracion.Text = dr("Nro_Dpto").ToString
        txtCP.Text = dr("CP").ToString
        txtEmail.Text = dr("EMAIL").ToString
        cbIVA.Text = dr("IDCondIVA").ToString
        dpFecha.Text = dr("Fecha").ToString


        'la modificacion fallo porque ya se encotraba abierta la base de datos.
    End Sub
    '
    Public Function TomarDatos() As CECliente
        'en este metodo debo guardar los datos de los textbox indiferente si es para registrar o para modificar
        oCECliente = New CECliente
        oCECliente.IDCliente = CInt(lblID.Text) + 2
        oCECliente.Nombre = txtNombre.Text
        oCECliente.Apellido = txtApellido.Text
        oCECliente.Telefono = CInt(txtTel.Text)
        oCECliente.Celular = CInt(txtCel.Text)
        oCECliente.DNI = CInt(txtDNI.Text)
        oCECliente.CUIT = CInt(txtDNI.Text)
        oCECliente.Pais = CInt(cboPais.Text)
        oCECliente.Provincia = CInt(cboProvincia.Text)
        oCECliente.Ciudad = CInt(txtCiudad.Text)
        oCECliente.Barrio = txtBarrio.Text
        oCECliente.Calle = txtCalle.Text
        oCECliente.NroCalle = CInt(txtNumeracion.Text)
        oCECliente.NroDpto = CInt(txtNumeracion.Text)
        oCECliente.NroCasa = CInt(txtNumeracion.Text)
        oCECliente.CP = CInt(txtCP.Text)
        oCECliente.Email = txtEmail.Text
        oCECliente.CondIVA = CInt(cbIVA.Text)
        oCECliente.Fecha = CDate(dpFecha.Value.ToShortDateString)
        Return oCECliente

    End Function





    '
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar.Click
        oCNCliente.ModificarCliente(TomarDatos())
    End Sub
End Class