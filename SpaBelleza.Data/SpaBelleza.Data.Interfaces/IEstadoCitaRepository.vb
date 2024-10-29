Imports SpaBelleza.Entities

Public Interface IEstadoCitaRepository
    Function ObtenerTodos() As DataTable
    Function ObtenerPorId(id As Integer) As EstadoCita
    Sub Agregar(estado As EstadoCita)
    Sub Actualizar(estado As EstadoCita)
    Sub Eliminar(id As Integer)
End Interface
