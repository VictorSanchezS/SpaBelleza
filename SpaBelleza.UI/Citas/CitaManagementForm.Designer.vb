<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CitaManagementForm
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
        dgvCitas = New DataGridView()
        txtBuscar = New TextBox()
        btnEditar = New Button()
        btnAgregar = New Button()
        btnEliminar = New Button()
        CType(dgvCitas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvCitas
        ' 
        dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCitas.Location = New Point(149, 213)
        dgvCitas.Name = "dgvCitas"
        dgvCitas.RowHeadersWidth = 51
        dgvCitas.Size = New Size(719, 276)
        dgvCitas.TabIndex = 0
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(385, 179)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(283, 27)
        txtBuscar.TabIndex = 1
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(674, 178)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 29)
        btnEditar.TabIndex = 2
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(774, 178)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(94, 29)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(149, 495)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(94, 29)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' CitaManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1180, 607)
        Controls.Add(btnEliminar)
        Controls.Add(btnAgregar)
        Controls.Add(btnEditar)
        Controls.Add(txtBuscar)
        Controls.Add(dgvCitas)
        Name = "CitaManagementForm"
        Text = "CitaManagementForm"
        CType(dgvCitas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
End Class
