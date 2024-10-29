<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CitaEditForm
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
        Label4 = New Label()
        cmbEstados = New ComboBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        Label1 = New Label()
        dtpHoraCita = New DateTimePicker()
        cmbTrabajadores = New ComboBox()
        cmbClientes = New ComboBox()
        dtpFechaCita = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        lblCliente = New Label()
        txtCitaID = New TextBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(81, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 66
        Label4.Text = "Estado"
        ' 
        ' cmbEstados
        ' 
        cmbEstados.FormattingEnabled = True
        cmbEstados.Location = New Point(211, 164)
        cmbEstados.Name = "cmbEstados"
        cmbEstados.Size = New Size(233, 28)
        cmbEstados.TabIndex = 65
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(325, 371)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 64
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(225, 371)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 63
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(81, 285)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 62
        Label1.Text = "Hora"
        ' 
        ' dtpHoraCita
        ' 
        dtpHoraCita.CustomFormat = "HH:mm"
        dtpHoraCita.Format = DateTimePickerFormat.Custom
        dtpHoraCita.Location = New Point(211, 280)
        dtpHoraCita.Name = "dtpHoraCita"
        dtpHoraCita.ShowUpDown = True
        dtpHoraCita.Size = New Size(233, 27)
        dtpHoraCita.TabIndex = 61
        ' 
        ' cmbTrabajadores
        ' 
        cmbTrabajadores.FormattingEnabled = True
        cmbTrabajadores.Location = New Point(211, 118)
        cmbTrabajadores.Name = "cmbTrabajadores"
        cmbTrabajadores.Size = New Size(233, 28)
        cmbTrabajadores.TabIndex = 60
        ' 
        ' cmbClientes
        ' 
        cmbClientes.FormattingEnabled = True
        cmbClientes.Location = New Point(211, 59)
        cmbClientes.Name = "cmbClientes"
        cmbClientes.Size = New Size(233, 28)
        cmbClientes.TabIndex = 59
        ' 
        ' dtpFechaCita
        ' 
        dtpFechaCita.CustomFormat = "yyyy-MM-dd"
        dtpFechaCita.Format = DateTimePickerFormat.Custom
        dtpFechaCita.Location = New Point(211, 219)
        dtpFechaCita.Name = "dtpFechaCita"
        dtpFechaCita.Size = New Size(233, 27)
        dtpFechaCita.TabIndex = 58
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(79, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 57
        Label3.Text = "Fecha"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 56
        Label2.Text = "Trabajador"
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Location = New Point(79, 62)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(55, 20)
        lblCliente.TabIndex = 55
        lblCliente.Text = "Cliente"
        ' 
        ' txtCitaID
        ' 
        txtCitaID.Location = New Point(79, 22)
        txtCitaID.Name = "txtCitaID"
        txtCitaID.Size = New Size(78, 27)
        txtCitaID.TabIndex = 67
        txtCitaID.Visible = False
        ' 
        ' CitaEditForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(573, 477)
        Controls.Add(txtCitaID)
        Controls.Add(Label4)
        Controls.Add(cmbEstados)
        Controls.Add(btnGuardar)
        Controls.Add(btnCancelar)
        Controls.Add(Label1)
        Controls.Add(dtpHoraCita)
        Controls.Add(cmbTrabajadores)
        Controls.Add(cmbClientes)
        Controls.Add(dtpFechaCita)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblCliente)
        Name = "CitaEditForm"
        Text = "CitaEditForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEstados As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpHoraCita As DateTimePicker
    Friend WithEvents cmbTrabajadores As ComboBox
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents dtpFechaCita As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCitaID As TextBox
End Class
