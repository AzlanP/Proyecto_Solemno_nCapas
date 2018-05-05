Imports CapaNegocio
Public Class FrmMenu

    Private Sub TabCliente_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabCliente.Enter

    End Sub


    Public Sub CargarGridCliente()
        Dim oCNCliente As New CNCliente
        'la funcion de listar cliente retornara un datatable que contendra la tabla del cliente, y esta sera mostrada en el datagrid
        DGCliente.DataSource = oCNCliente.ListarCliente
    End Sub

    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGridCliente()

    End Sub
End Class