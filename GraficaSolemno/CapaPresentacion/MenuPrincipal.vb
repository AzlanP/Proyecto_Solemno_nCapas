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

    Private Sub DGCliente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCliente.CellClick
        'se usa esto para cuando hagan click en alguna celda del datagridview se seleccione la fila completa
        DGCliente.CurrentRow.Selected = True
        'esta siguiente parte es para cuando das click en el datagridview te de el ID de esa fila
        Dim id2 As String = DGCliente.Rows(e.RowIndex).Cells("IDCliente").Value
        MsgBox(id2)
    End Sub

   
    Private Sub DGCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGCliente.DoubleClick
        'Dim dr As DataRow = DGCliente.SelectedRows(0).Index

        'Dim ID As String = DGCliente.SelectedRows(0).Cells("IDCliente").Value.ToString()


    End Sub
End Class