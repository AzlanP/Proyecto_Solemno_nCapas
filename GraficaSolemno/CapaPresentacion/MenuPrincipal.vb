Imports CapaNegocio
Public Class FrmMenu

    Public Sub CargarGridCliente()
        Dim oCNCliente As New CNCliente
        'la funcion de listar cliente retornara un datatable que contendra la tabla del cliente, y esta sera mostrada en el datagrid
        DGCliente.DataSource = oCNCliente.ListarCliente
    End Sub
    'este procedimiento se ejecuta cuando se carga el formulario
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGridCliente()

    End Sub

    Private Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click
        Dim frmRegistrar As New RegistrarCliente
        frmRegistrar.ShowDialog()
    End Sub
End Class