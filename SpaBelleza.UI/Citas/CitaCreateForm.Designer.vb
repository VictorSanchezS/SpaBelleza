<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CitaCreateForm
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
        lblCliente = New Label()
        Label2 = New Label()
        Label3 = New Label()
        dtpFechaCita = New DateTimePicker()
        cmbClientes = New ComboBox()
        cmbTrabajadores = New ComboBox()
        dtpHoraCita = New DateTimePicker()
        Label1 = New Label()
        btnCancelar = New Button()
        btnGuardar = New Button()
        cmbEstados = New ComboBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Location = New Point(49, 56)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(55, 20)
        lblCliente.TabIndex = 0
        lblCliente.Text = "Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 1
        Label2.Text = "Trabajador"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 2
        Label3.Text = "Fecha"
        ' 
        ' dtpFechaCita
        ' 
        dtpFechaCita.CustomFormat = "yyyy-MM-dd"
        dtpFechaCita.Format = DateTimePickerFormat.Custom
        dtpFechaCita.Location = New Point(181, 213)
        dtpFechaCita.Name = "dtpFechaCita"
        dtpFechaCita.Size = New Size(233, 27)
        dtpFechaCita.TabIndex = 46
        ' 
        ' cmbClientes
        ' 
        cmbClientes.FormattingEnabled = True
        cmbClientes.Location = New Point(181, 53)
        cmbClientes.Name = "cmbClientes"
        cmbClientes.Size = New Size(233, 28)
        cmbClientes.TabIndex = 47
        ' 
        ' cmbTrabajadores
        ' 
        cmbTrabajadores.FormattingEnabled = True
        cmbTrabajadores.Location = New Point(181, 112)
        cmbTrabajadores.Name = "cmbTrabajadores"
        cmbTrabajadores.Size = New Size(233, 28)
        cmbTrabajadores.TabIndex = 48
        ' 
        ' dtpHoraCita
        ' 
        dtpHoraCita.CustomFormat = "HH:mm"
        dtpHoraCita.Format = DateTimePickerFormat.Custom
        dtpHoraCita.Location = New Point(181, 274)
        dtpHoraCita.Name = "dtpHoraCita"
        dtpHoraCita.ShowUpDown = True
        dtpHoraCita.Size = New Size(233, 27)
        dtpHoraCita.TabIndex = 49
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 279)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 50
        Label1.Text = "Hora"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(195, 365)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 51
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(295, 365)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 52
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' cmbEstados
        ' 
        cmbEstados.FormattingEnabled = True
        cmbEstados.Location = New Point(181, 158)
        cmbEstados.Name = "cmbEstados"
        cmbEstados.Size = New Size(233, 28)
        cmbEstados.TabIndex = 53
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 54
        Label4.Text = "Estado"
        ' 
        ' CitaCreateForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(563, 497)
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
        Name = "CitaCreateForm"
        Text = "CitaCreateForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaCita As DateTimePicker
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents cmbTrabajadores As ComboBox
    Friend WithEvents dtpHoraCita As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cmbEstados As ComboBox
    Friend WithEvents Label4 As Label
End Class
