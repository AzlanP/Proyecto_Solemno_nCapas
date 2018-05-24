<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabCliente = New System.Windows.Forms.TabPage()
        Me.DGCliente = New System.Windows.Forms.DataGridView()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnVerCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.TabProducto = New System.Windows.Forms.TabPage()
        Me.TabPedido = New System.Windows.Forms.TabPage()
        Me.TabEstadistica = New System.Windows.Forms.TabPage()
        Me.TabAyuda = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabGeneral.SuspendLayout()
        Me.TabCliente.SuspendLayout()
        CType(Me.DGCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProducto.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabCliente)
        Me.TabGeneral.Controls.Add(Me.TabProducto)
        Me.TabGeneral.Controls.Add(Me.TabPedido)
        Me.TabGeneral.Controls.Add(Me.TabEstadistica)
        Me.TabGeneral.Controls.Add(Me.TabAyuda)
        Me.TabGeneral.Location = New System.Drawing.Point(12, 12)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(702, 450)
        Me.TabGeneral.TabIndex = 0
        '
        'TabCliente
        '
        Me.TabCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabCliente.Controls.Add(Me.DGCliente)
        Me.TabCliente.Controls.Add(Me.cboBuscar)
        Me.TabCliente.Controls.Add(Me.btnBuscar)
        Me.TabCliente.Controls.Add(Me.btnEliminarCliente)
        Me.TabCliente.Controls.Add(Me.btnVerCliente)
        Me.TabCliente.Controls.Add(Me.btnModificarCliente)
        Me.TabCliente.Controls.Add(Me.btnNuevoCliente)
        Me.TabCliente.Controls.Add(Me.txtBuscar)
        Me.TabCliente.Location = New System.Drawing.Point(4, 22)
        Me.TabCliente.Name = "TabCliente"
        Me.TabCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCliente.Size = New System.Drawing.Size(694, 424)
        Me.TabCliente.TabIndex = 0
        Me.TabCliente.Text = "Cliente"
        '
        'DGCliente
        '
        Me.DGCliente.AllowUserToAddRows = False
        Me.DGCliente.AllowUserToDeleteRows = False
        Me.DGCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGCliente.BackgroundColor = System.Drawing.Color.White
        Me.DGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCliente.Location = New System.Drawing.Point(38, 62)
        Me.DGCliente.MultiSelect = False
        Me.DGCliente.Name = "DGCliente"
        Me.DGCliente.ReadOnly = True
        Me.DGCliente.Size = New System.Drawing.Size(621, 284)
        Me.DGCliente.TabIndex = 7
        '
        'cboBuscar
        '
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "CUIT"})
        Me.cboBuscar.Location = New System.Drawing.Point(405, 35)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscar.TabIndex = 6
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(543, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(441, 352)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(110, 23)
        Me.btnEliminarCliente.TabIndex = 4
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnVerCliente
        '
        Me.btnVerCliente.Location = New System.Drawing.Point(299, 352)
        Me.btnVerCliente.Name = "btnVerCliente"
        Me.btnVerCliente.Size = New System.Drawing.Size(110, 23)
        Me.btnVerCliente.TabIndex = 3
        Me.btnVerCliente.Text = "Ver Cliente"
        Me.btnVerCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(167, 352)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(110, 23)
        Me.btnModificarCliente.TabIndex = 2
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Location = New System.Drawing.Point(38, 352)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(110, 23)
        Me.btnNuevoCliente.TabIndex = 1
        Me.btnNuevoCliente.Text = "Nuevo Cliente"
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(38, 36)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(352, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'TabProducto
        '
        Me.TabProducto.Controls.Add(Me.ComboBox1)
        Me.TabProducto.Controls.Add(Me.TextBox1)
        Me.TabProducto.Controls.Add(Me.Button5)
        Me.TabProducto.Controls.Add(Me.Button4)
        Me.TabProducto.Controls.Add(Me.Button3)
        Me.TabProducto.Controls.Add(Me.Button2)
        Me.TabProducto.Controls.Add(Me.Button1)
        Me.TabProducto.Controls.Add(Me.DataGridView1)
        Me.TabProducto.Location = New System.Drawing.Point(4, 22)
        Me.TabProducto.Name = "TabProducto"
        Me.TabProducto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProducto.Size = New System.Drawing.Size(694, 424)
        Me.TabProducto.TabIndex = 1
        Me.TabProducto.Text = "Producto"
        Me.TabProducto.UseVisualStyleBackColor = True
        '
        'TabPedido
        '
        Me.TabPedido.Location = New System.Drawing.Point(4, 22)
        Me.TabPedido.Name = "TabPedido"
        Me.TabPedido.Size = New System.Drawing.Size(694, 424)
        Me.TabPedido.TabIndex = 2
        Me.TabPedido.Text = "Pedido"
        Me.TabPedido.UseVisualStyleBackColor = True
        '
        'TabEstadistica
        '
        Me.TabEstadistica.Location = New System.Drawing.Point(4, 22)
        Me.TabEstadistica.Name = "TabEstadistica"
        Me.TabEstadistica.Size = New System.Drawing.Size(694, 424)
        Me.TabEstadistica.TabIndex = 3
        Me.TabEstadistica.Text = "Estadistica"
        Me.TabEstadistica.UseVisualStyleBackColor = True
        '
        'TabAyuda
        '
        Me.TabAyuda.Location = New System.Drawing.Point(4, 22)
        Me.TabAyuda.Name = "TabAyuda"
        Me.TabAyuda.Size = New System.Drawing.Size(694, 424)
        Me.TabAyuda.TabIndex = 4
        Me.TabAyuda.Text = "Ayuda"
        Me.TabAyuda.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(49, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(534, 303)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(508, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(160, 367)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(281, 367)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(402, 367)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(49, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(250, 20)
        Me.TextBox1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(323, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(726, 491)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmMenu"
        Me.Text = "MenuPrincipal"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabCliente.ResumeLayout(False)
        Me.TabCliente.PerformLayout()
        CType(Me.DGCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProducto.ResumeLayout(False)
        Me.TabProducto.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabGeneral As System.Windows.Forms.TabControl
    Friend WithEvents TabCliente As System.Windows.Forms.TabPage
    Friend WithEvents TabProducto As System.Windows.Forms.TabPage
    Friend WithEvents DGCliente As System.Windows.Forms.DataGridView
    Friend WithEvents cboBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminarCliente As System.Windows.Forms.Button
    Friend WithEvents btnVerCliente As System.Windows.Forms.Button
    Friend WithEvents btnModificarCliente As System.Windows.Forms.Button
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents TabPedido As System.Windows.Forms.TabPage
    Friend WithEvents TabEstadistica As System.Windows.Forms.TabPage
    Friend WithEvents TabAyuda As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
