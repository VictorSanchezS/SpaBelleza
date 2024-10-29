Imports SpaBelleza.Entities

Public Interface IClienteRepository
    Function ObtenerTodos() As DataTable
    Function ObtenerPorId(id As Integer) As Cliente
    Function ObtenerPorNombre(clienteNombre As String) As Cliente
    Function ObtenerPorId(clienteNombre As String) As Integer 'No se uso
    Sub Agregar(cliente As Cliente)
    Sub Actualizar(cliente As Cliente)
    Sub Eliminar(id As Integer)
End Interface
