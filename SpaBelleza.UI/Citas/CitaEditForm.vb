Imports SpaBelleza.Business
Imports SpaBelleza.Data
Imports SpaBelleza.Entities

Public Class CitaEditForm
    Private ReadOnly _citaService As New CitaService(New CitaRepository())
    Private ReadOnly _clienteService As New ClienteService(New ClienteRepository())
    Private ReadOnly _trabajadorService As New TrabajadorService(New TrabajadorRepository())
    Private ReadOnly _estadoService As New EstadoCitaService(New EstadoCitaRepository())

    Public Sub New()
        InitializeComponent()
        CargarClientes()
        CargarTrabajadores()
        CargarEstados()
    End Sub

    Private Sub CargarClientes()
        Dim clientes As DataTable = _clienteService.ObtenerTodos()
        cmbClientes.DataSource = clientes
        cmbClientes.DisplayMember = "Nombre"
        cmbClientes.ValueMember = "ClienteID"
    End Sub

    Private Sub CargarTrabajadores()
        Dim trabajadores As DataTable = _trabajadorService.ObtenerTodos()
        cmbTrabajadores.DataSource = trabajadores
        cmbTrabajadores.DisplayMember = "NombreTrabajador"
        cmbTrabajadores.ValueMember = "TrabajadorID"
    End Sub

    Private Sub CargarEstados()
        Dim estados As DataTable = _estadoService.ObtenerTodos()
        cmbEstados.DataSource = estados
        cmbEstados.DisplayMember = "DescripcionEstado"
        cmbEstados.ValueMember = "EstadoID"
    End Sub

    Public Sub CargarDatosCita(citaID As Integer)
        Dim cita As Cita = _citaService.ObtenerPorId(citaID)
        txtCitaID.Text = cita.CitaID.ToString()
        cmbClientes.SelectedValue = cita.ClienteID
        cmbTrabajadores.SelectedValue = cita.TrabajadorID
        dtpFechaCita.Value = cita.FechaCita
        dtpHoraCita.Value = DateTime.Today.Add(cita.HoraCita) ' Ajusta aquí
        cmbEstados.SelectedValue = cita.EstadoID
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cita As New Cita With {
            .CitaID = Convert.ToInt32(txtCitaID.Text),
            .ClienteID = Convert.ToInt32(cmbClientes.SelectedValue),
            .TrabajadorID = Convert.ToInt32(cmbTrabajadores.SelectedValue),
            .FechaCita = dtpFechaCita.Value,
            .HoraCita = dtpHoraCita.Value.TimeOfDay,
            .EstadoID = Convert.ToInt32(cmbEstados.SelectedValue)
        }

        _citaService.Actualizar(cita)
        MessageBox.Show("Cita actualizada con éxito.")
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub



End Class