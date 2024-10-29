Imports SpaBelleza.Data
Imports SpaBelleza.Entities

Public Class TrabajadorService
    Private ReadOnly _repositorio As ITrabajadorRepository

    ' Constructor que recibe el repositorio
    Public Sub New(repositorio As ITrabajadorRepository)
        _repositorio = repositorio
    End Sub

    ' Método para obtener todos los trabajadores
    Public Function ObtenerTodos() As DataTable
        Return _repositorio.ObtenerTodos()
    End Function

    Public Function ObtenerPorId(trabajadorNombre As String) As Integer
        Try
            Return _repositorio.ObtenerPorId(trabajadorNombre)
        Catch ex As Exception
            ' Manejo de excepciones, se puede lanzar o manejar según se requiera
            Throw New Exception("Error al obtener el ID del trabajador: " & ex.Message)
        End Try
    End Function

    Public Function ObtenerPorNombre(trabajadorNombre As String) As Trabajador
        Return _repositorio.ObtenerPorNombre(trabajadorNombre)
    End Function
End Class
