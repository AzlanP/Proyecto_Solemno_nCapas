Imports CapaEntidad
Imports CapaNegocio
Public Class RegistrarCliente
    Dim oCNCliente As New CNCliente
    Dim oCECliente As New CECliente

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        oCNCliente.RegistrarCliente(TomarDatos())
        MsgBox("Los Datos fueron guardados")
        Close()
    End Sub

    Public Sub LlenarFormulario(ByVal ID As Integer)
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
        'la modificacion no fallo  pero ya se encotraba abierta la base de datos. revisar

        'Esto es para cambiar segun si se esta modificando aparasca el boton de guardar, o el boton de registro
        btnRegistrar.Visible = False
        btnGuardar.Visible = True
        'Esto es para que segun sea el caso el texto del formulario cambie.
        Me.Text = "Modificar Cliente"
    End Sub
    '
    Public Function TomarDatos() As CECliente
        'en este metodo debo guardar los datos de los textbox indiferente si es para registrar o para modificar
        oCECliente = New CECliente
        oCECliente.IDCliente = CInt(lblID.Text)
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

    Public Sub Disesabletext()
        'este codigo es para desabilitar la edicion de todos los campos
        Dim ctrl As Control

        For Each ctrl In Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is DateTimePicker Then
                ctrl.Enabled = False 'Creo que el error es aqui
            End If
        Next

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        oCNCliente.ModificarCliente(TomarDatos())
        MsgBox("Los Datos fueron guardados")
        Close()
    End Sub
End Class