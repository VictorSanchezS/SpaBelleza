Imports SpaBelleza.Business
Imports SpaBelleza.Data
Imports SpaBelleza.Entities

Public Class CitaCreateForm
    Private ReadOnly _citaService As New CitaService(New CitaRepository())
    Private ReadOnly _clienteService As New ClienteService(New ClienteRepository())
    Private ReadOnly _trabajadorService As New TrabajadorService(New TrabajadorRepository())
    Private ReadOnly _estadoService As New EstadoCitaService(New EstadoCitaRepository())

    Private Sub CitaCreateForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarClientes()
        CargarTrabajadores()
        CargarEstados()
    End Sub

    Private Sub CargarClientes()
        Dim clientes As DataTable = _clienteService.ObtenerTodos()

        cmbClientes.DataSource = clientes
        cmbClientes.DisplayMember = "Nombre" ' El campo que quieres mostrar
        cmbClientes.ValueMember = "ClienteID" ' El valor que se pasará
    End Sub

    Private Sub CargarTrabajadores()
        Dim trabajadores As DataTable = _trabajadorService.ObtenerTodos()

        cmbTrabajadores.DataSource = trabajadores
        cmbTrabajadores.DisplayMember = "NombreTrabajador" ' El campo que quieres mostrar
        cmbTrabajadores.ValueMember = "TrabajadorID" ' El valor que se pasará
    End Sub

    Private Sub CargarEstados()
        Dim estados As DataTable = _estadoService.ObtenerTodos() ' Llama al servicio para obtener todos los estados

        cmbEstados.DataSource = estados
        cmbEstados.DisplayMember = "DescripcionEstado" ' Campo que quieres mostrar
        cmbEstados.ValueMember = "EstadoID" ' Valor que se pasará
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Crear un objeto Cita
            Dim nuevaCita As New Cita() With {
            .ClienteID = Convert.ToInt32(cmbClientes.SelectedValue),
            .TrabajadorID = Convert.ToInt32(cmbTrabajadores.SelectedValue),
            .FechaCita = dtpFechaCita.Value.Date, ' Obtener solo la fecha
            .HoraCita = dtpHoraCita.Value.TimeOfDay, ' Obtener solo la hora
            .EstadoID = Convert.ToInt32(cmbEstados.SelectedValue)
        }

            ' Guardar la cita
            _citaService.Agregar(nuevaCita)

            MessageBox.Show("Cita guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar los campos después de guardar
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub

    Private Sub LimpiarCampos()
        cmbClientes.SelectedIndex = -1
        cmbTrabajadores.SelectedIndex = -1
        cmbEstados.SelectedIndex = -1
        dtpFechaCita.Value = DateTime.Now
        dtpHoraCita.Value = DateTime.Now
    End Sub


End Class