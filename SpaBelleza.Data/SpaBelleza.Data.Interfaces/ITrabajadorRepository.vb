Imports SpaBelleza.Entities

Public Interface ITrabajadorRepository
    Function ObtenerTodos() As DataTable
    Function ObtenerPorId(id As Integer) As Trabajador
    Function ObtenerPorNombre(trabajadorNombre As String) As Trabajador
    Function ObtenerPorId(trabajadorNombre As String) As Integer 'No se uso
    Sub Agregar(trabajador As Trabajador)
    Sub Actualizar(trabajador As Trabajador)
    Sub Eliminar(id As Integer)
End Interface
