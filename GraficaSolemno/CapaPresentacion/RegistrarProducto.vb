Imports CapaEntidad
Imports CapaNegocio
Public Class RegistrarProducto
    Dim oCEProducto As New CEProducto
    Dim oCNProducto As New CNProducto


    Public Function TomarDatos() As CEProducto

        oCEProducto.IDProductos = CInt(lblID.Text)
        oCEProducto.Nombre = txtNombre.Text
        oCEProducto.Cantidad = CInt(txtCantidad.Text)
        oCEProducto.Precio = CDbl(txtPrecio.Text)
        oCEProducto.Tipo = txtTipo.Text
        oCEProducto.Descripcion = txtDescripcion.Text
        oCEProducto.Codigo = CInt(txtCodigo.Text)
        Return oCEProducto

    End Function
    Public Sub LlenarFormulario(ByVal ID As Integer)
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oCNProducto.BuscarProducto("IDProductos", ID)
        dr = dt.Rows(0)
        lblID.Text = dr("IDProductos").ToString
        txtNombre.Text = dr("Nombre").ToString
        txtCantidad.Text = dr("Cantidad").ToString
        txtPrecio.Text = dr("Precio").ToString
        txtTipo.Text = dr("Tipo").ToString
        txtDescripcion.Text = dr("Descripcion").ToString
        txtCodigo.Text = dr("Codigo").ToString

        btnRegistrarProducto.Visible = False
        btnGuardarProducto.Visible = True

        Me.Text = "Modificar Producto"
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProducto.Click
        oCNProducto.ModificarProducto(TomarDatos())
        MsgBox("Los Datos fueron modificados con exito.")
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Esta seguro de descartar los cambios?", "Confirmacion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Close()
        End If

    End Sub
    Public Sub Disesabletext()
        'este codigo es para desabilitar la edicion de todos los campos
        Dim ctrl As Control

        For Each ctrl In Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is DateTimePicker Then
                ctrl.Enabled = False 'Creo que el error es aqui
            End If
        Next

    End Sub

    Private Sub btnRegistrarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarProducto.Click
        oCNProducto.RegistrarProducto(TomarDatos())
        MsgBox("Los Datos fueron guardados con exito.")
        Close()
    End Sub

    Private Sub RegistrarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class