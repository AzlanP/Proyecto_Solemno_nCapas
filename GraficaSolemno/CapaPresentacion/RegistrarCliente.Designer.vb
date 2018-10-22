<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCliente
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIDinfo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbIVA = New System.Windows.Forms.ComboBox()
        Me.checkCasa = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkDpto = New System.Windows.Forms.CheckBox()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.cboPais = New System.Windows.Forms.ComboBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtNumeracion = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 15)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "DNI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "CUIT"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 238)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(203, 21)
        Me.TextBox1.TabIndex = 116
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(208, 436)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 33)
        Me.btnGuardar.TabIndex = 115
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(137, 64)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 15)
        Me.lblID.TabIndex = 114
        '
        'lblIDinfo
        '
        Me.lblIDinfo.AutoSize = True
        Me.lblIDinfo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDinfo.Location = New System.Drawing.Point(13, 64)
        Me.lblIDinfo.Name = "lblIDinfo"
        Me.lblIDinfo.Size = New System.Drawing.Size(21, 15)
        Me.lblIDinfo.TabIndex = 113
        Me.lblIDinfo.Text = "ID:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(402, 436)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(182, 33)
        Me.btnCancelar.TabIndex = 112
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dpFecha
        '
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFecha.Location = New System.Drawing.Point(140, 310)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(203, 21)
        Me.dpFecha.TabIndex = 111
        Me.dpFecha.Value = New Date(2018, 5, 7, 22, 44, 48, 0)
        '
        'cbIVA
        '
        Me.cbIVA.FormattingEnabled = True
        Me.cbIVA.Location = New System.Drawing.Point(140, 346)
        Me.cbIVA.Name = "cbIVA"
        Me.cbIVA.Size = New System.Drawing.Size(205, 23)
        Me.cbIVA.TabIndex = 110
        Me.cbIVA.Text = "Consumidor Final"
        '
        'checkCasa
        '
        Me.checkCasa.AutoSize = True
        Me.checkCasa.Location = New System.Drawing.Point(504, 387)
        Me.checkCasa.Name = "checkCasa"
        Me.checkCasa.Size = New System.Drawing.Size(55, 19)
        Me.checkCasa.TabIndex = 109
        Me.checkCasa.Text = "Casa"
        Me.checkCasa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Numero:"
        '
        'checkDpto
        '
        Me.checkDpto.AutoSize = True
        Me.checkDpto.Location = New System.Drawing.Point(590, 387)
        Me.checkDpto.Name = "checkDpto"
        Me.checkDpto.Size = New System.Drawing.Size(55, 19)
        Me.checkDpto.TabIndex = 107
        Me.checkDpto.Text = "Dpto "
        Me.checkDpto.UseVisualStyleBackColor = True
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(504, 204)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(205, 23)
        Me.cboProvincia.TabIndex = 106
        '
        'cboPais
        '
        Me.cboPais.AutoCompleteCustomSource.AddRange(New String() {"Argentina", "Chile", "Bolivia", "Uruguay", "Paraguay"})
        Me.cboPais.FormattingEnabled = True
        Me.cboPais.Location = New System.Drawing.Point(504, 166)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Size = New System.Drawing.Size(205, 23)
        Me.cboPais.TabIndex = 105
        Me.cboPais.Text = "Argentina"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(140, 274)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(203, 21)
        Me.txtCP.TabIndex = 104
        '
        'txtNumeracion
        '
        Me.txtNumeracion.Location = New System.Drawing.Point(504, 350)
        Me.txtNumeracion.Name = "txtNumeracion"
        Me.txtNumeracion.Size = New System.Drawing.Size(203, 21)
        Me.txtNumeracion.TabIndex = 103
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(504, 314)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(203, 21)
        Me.txtCalle.TabIndex = 102
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(399, 317)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 15)
        Me.Label19.TabIndex = 101
        Me.Label19.Text = "calle"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(504, 278)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(203, 21)
        Me.txtBarrio.TabIndex = 100
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(504, 242)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(203, 21)
        Me.txtCiudad.TabIndex = 99
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 313)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 15)
        Me.Label18.TabIndex = 98
        Me.Label18.Text = "Fecha"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 351)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 15)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "Condicion de IVA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 277)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Codigo postal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(399, 281)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 15)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Barrio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(399, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "pais"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(399, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "apellido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(140, 94)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(203, 21)
        Me.txtNombre.TabIndex = 91
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(140, 202)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(203, 21)
        Me.txtDNI.TabIndex = 90
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(140, 166)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(203, 21)
        Me.txtEmail.TabIndex = 89
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(504, 130)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(203, 21)
        Me.txtCel.TabIndex = 88
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(140, 130)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(203, 21)
        Me.txtTel.TabIndex = 87
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(504, 94)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(203, 21)
        Me.txtApellido.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(399, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Provincia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Localidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "E-MAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Celular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Teléfono"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(208, 436)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(137, 33)
        Me.btnRegistrar.TabIndex = 80
        Me.btnRegistrar.Text = "Registrar Cliente"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'RegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(723, 533)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblIDinfo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dpFecha)
        Me.Controls.Add(Me.cbIVA)
        Me.Controls.Add(Me.checkCasa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.checkDpto)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.cboPais)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtNumeracion)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtBarrio)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "RegistrarCliente"
        Me.Text = "Registrar Nuevo Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblIDinfo As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbIVA As System.Windows.Forms.ComboBox
    Friend WithEvents checkCasa As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents checkDpto As System.Windows.Forms.CheckBox
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents cboPais As System.Windows.Forms.ComboBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeracion As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtBarrio As System.Windows.Forms.TextBox
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
End Class
