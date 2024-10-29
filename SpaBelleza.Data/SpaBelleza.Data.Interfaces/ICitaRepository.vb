Imports SpaBelleza.Entities

Public Interface ICitaRepository
    Function ObtenerTodos() As DataTable
    Function ObtenerCitasConAtencion() As DataTable
    Function ObtenerPorId(id As Integer) As Cita
    Function ObtenerPorClienteFecha(clienteID As Integer, fechaCita As Date) As Cita
    Function ObtenerCitaID(clienteID As Integer, fechaCita As Date) 'No se uso
    Sub Agregar(cita As Cita)
    Sub Actualizar(cita As Cita)
    Sub Eliminar(id As Integer)
End Interface