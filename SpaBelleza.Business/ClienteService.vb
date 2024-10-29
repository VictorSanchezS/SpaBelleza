Imports SpaBelleza.Data
Imports SpaBelleza.Entities

Public Class ClienteService
    Private ReadOnly _repositorio As IClienteRepository

    ' Constructor que recibe el repositorio
    Public Sub New(repositorio As IClienteRepository)
        _repositorio = repositorio
    End Sub

    ' Método para obtener todos los clientes como DataTable
    Public Function ObtenerTodos() As DataTable
        Return _repositorio.ObtenerTodos()
    End Function
    Public Function ObtenerPorId(clienteNombre As String) As Integer
        Return _repositorio.ObtenerPorId(clienteNombre)
    End Function

    Public Function ObtenerPorNombre(clienteNombre As String) As Cliente
        Return _repositorio.ObtenerPorNombre(clienteNombre)
    End Function

    Public Function ObtenerPorId(id As Integer) As Cliente
        ' Validar que el ID sea mayor a cero
        If id <= 0 Then
            Throw New ArgumentException("El ID del cliente debe ser mayor que cero.")
        End If

        Try
            ' Llamar al repositorio para obtener el cliente
            Return _repositorio.ObtenerPorId(id)
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir
            Throw New Exception("Error al obtener el cliente: " & ex.Message)
        End Try
    End Function
End Class
