Imports SpaBelleza.Business
Imports SpaBelleza.Data

Public Class CitaManagementForm
    Private ReadOnly _citaService As New CitaService(New CitaRepository())

    Private Sub CitaManagementForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCitas()
    End Sub

    Private Sub CargarCitas()
        Dim citasDataTable As DataTable = _citaService.ObtenerTodos()

        ' Limpiar el DataGridView
        dgvCitas.DataSource = Nothing
        dgvCitas.Rows.Clear()

        ' Reemplazar la hora en el DataTable por un formato de string
        For Each row As DataRow In citasDataTable.Rows
            Dim hora As TimeSpan = CType(row("HoraCita"), TimeSpan)
            row("HoraCita") = hora.ToString("hh\:mm") ' Formato de hora
        Next

        ' Asignar el DataTable como fuente de datos
        dgvCitas.DataSource = citasDataTable
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim citaCreateForm As New CitaCreateForm()
        citaCreateForm.ShowDialog()

        ' Opcionalmente, podrías recargar la lista de citas después de registrar una nueva
        CargarCitas()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvCitas.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvCitas.SelectedRows(0)
            Dim citaID As Integer = Convert.ToInt32(selectedRow.Cells("CitaID").Value)

            ' Crear una instancia del formulario de editar cita
            Dim citaEditForm As New CitaEditForm()

            ' Cargar los datos de la cita en el formulario
            citaEditForm.CargarDatosCita(citaID)

            ' Mostrar el formulario de edición
            citaEditForm.ShowDialog()

            ' Volver a cargar las citas después de cerrar el formulario
            CargarCitas()
        Else
            MessageBox.Show("Por favor, selecciona una cita para editar.")
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarCitas(txtBuscar.Text)
    End Sub

    Private Sub BuscarCitas(busqueda As String)
        Dim citasDataTable As DataTable = _citaService.ObtenerTodos()

        Dim filtro As String = $"Cliente LIKE '%{busqueda}%' OR Trabajador LIKE '%{busqueda}%' OR Estado LIKE '%{busqueda}%'"

        Dim filteredRows As DataRow() = citasDataTable.Select(filtro)

        Dim filteredDataTable As DataTable = citasDataTable.Clone() ' Crea una copia de la estructura

        For Each row As DataRow In filteredRows
            filteredDataTable.ImportRow(row) ' Agrega las filas filtradas
        Next

        dgvCitas.DataSource = filteredDataTable ' Asigna el DataTable filtrado
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCitas.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona un servicio para eliminar.")
            Return
        End If

        If MessageBox.Show("¿Estás seguro de que deseas eliminar esta cita?", "Confirmar Eliminación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim citaID As Integer = Convert.ToInt32(dgvCitas.CurrentRow.Cells("CitaID").Value)

            Try
                _citaService.Eliminar(citaID) ' Llama al método de eliminar
                MessageBox.Show("Cita eliminada con éxito.")
                CargarCitas() ' Recarga el DataGridView para reflejar los cambios
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la cita: " & ex.Message)
            End Try
        End If
    End Sub
End Class