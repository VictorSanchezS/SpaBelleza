
Imports SpaBelleza.Data
Imports SpaBelleza.Entities

Public Class CitaService
    Private ReadOnly _repositorio As ICitaRepository

    ' Constructor que recibe el repositorio
    Public Sub New(repositorio As ICitaRepository)
        _repositorio = repositorio
    End Sub

    ' Método para agregar una cita
    Public Sub Agregar(cita As Cita)
        If cita.ClienteID <= 0 Then
            Throw New ArgumentException("El ClienteID es obligatorio.")
        End If
        If cita.TrabajadorID <= 0 Then
            Throw New ArgumentException("El TrabajadorID es obligatorio.")
        End If
        If cita.FechaCita = DateTime.MinValue Then
            Throw New ArgumentException("La FechaCita es obligatoria.")
        End If
        If cita.HoraCita = TimeSpan.Zero Then
            Throw New ArgumentException("La HoraCita es obligatoria.")
        End If
        If cita.EstadoID <= 0 Then
            Throw New ArgumentException("El EstadoID es obligatorio.")
        End If

        _repositorio.Agregar(cita)
    End Sub

    ' Método para actualizar una cita
    Public Sub Actualizar(cita As Cita)
        If cita.CitaID <= 0 Then
            Throw New ArgumentException("El ID de la cita es inválido.")
        End If
        If cita.ClienteID <= 0 Or cita.TrabajadorID <= 0 Then
            Throw New ArgumentException("Cliente y Trabajador son obligatorios.")
        End If
        If cita.FechaCita = DateTime.MinValue Or cita.HoraCita = TimeSpan.Zero Then
            Throw New ArgumentException("La Fecha y Hora de la cita son obligatorias.")
        End If
        If cita.EstadoID <= 0 Then
            Throw New ArgumentException("El EstadoID es obligatorio.")
        End If

        _repositorio.Actualizar(cita)
    End Sub

    ' Método para eliminar una cita
    Public Sub Eliminar(id As Integer)
        If id <= 0 Then
            Throw New ArgumentException("El ID de la cita es inválido.")
        End If

        _repositorio.Eliminar(id)
    End Sub

    ' Método para obtener todas las citas como DataTable
    Public Function ObtenerTodos() As DataTable
        Return _repositorio.ObtenerTodos()
    End Function

    Public Function ObtenerCitasConAtencion() As DataTable
        Return _repositorio.ObtenerCitasConAtencion()
    End Function



    ' Método para obtener una cita por ID
    Public Function ObtenerPorId(id As Integer) As Cita
        If id <= 0 Then
            Throw New ArgumentException("El ID de la cita es inválido.")
        End If
        Return _repositorio.ObtenerPorId(id)
    End Function

    Public Function ObtenerCitaID(clienteID As Integer, fechaCita As Date) As Integer
        Try
            Return _repositorio.ObtenerCitaID(clienteID, fechaCita)
        Catch ex As Exception
            ' Manejo de excepciones, se puede lanzar o manejar según se requiera
            Throw New Exception("Error al obtener el ID de la cita: " & ex.Message)
        End Try
    End Function

    Public Function ObtenerPorClienteFecha(clienteID As Integer, fechaCita As Date) As Cita
        Return _repositorio.ObtenerPorClienteFecha(clienteID, fechaCita)
    End Function

End Class
