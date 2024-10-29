Imports SpaBelleza.Data

Public Class EstadoCitaService
    Private ReadOnly _repositorio As IEstadoCitaRepository

    ' Constructor que recibe el repositorio
    Public Sub New(repositorio As IEstadoCitaRepository)
        _repositorio = repositorio
    End Sub

    ' Método para obtener todos los estados de cita
    Public Function ObtenerTodos() As DataTable
        Return _repositorio.ObtenerTodos()
    End Function
End Class
