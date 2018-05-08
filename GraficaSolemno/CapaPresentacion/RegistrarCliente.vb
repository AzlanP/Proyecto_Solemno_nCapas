Imports CapaEntidad
Imports CapaNegocio
Public Class RegistrarCliente


    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim oCECliente As New CECliente
        Dim oCNCliente As New CNcliente
        'oCECliente.IDCliente = 7
        'oCECliente.Nombre = txtNombre.Text
        'oCECliente.Apellido = txtApellido.Text
        'oCECliente.Telefono = CInt(txtTel.Text)
        'oCECliente.Celular = CInt(txtCel.Text)
        'oCECliente.DNI = CInt(txtDNI.Text)
        'oCECliente.CUIT = CInt(txtDNI.Text)
        'oCECliente.Pais = CInt(cboPais.Text)
        'oCECliente.Provincia = CInt(cboProvincia.Text)
        'oCECliente.Ciudad = CInt(txtCiudad.Text)
        'oCECliente.Barrio = txtBarrio.Text
        'oCECliente.Calle = txtCalle.Text
        'oCECliente.NroCalle = CInt(txtNumeracion.Text)
        'oCECliente.NroDpto = CInt(txtNumeracion.Text)
        'oCECliente.NroCasa = CInt(txtNumeracion.Text)
        'oCECliente.CP = CInt(txtCP.Text)
        'oCECliente.Email = txtEmail.Text
        'oCECliente.CondIVA = CInt(cbIVA.Text)
        'oCECliente.Fecha = CDate(dpFecha.Value)

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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class