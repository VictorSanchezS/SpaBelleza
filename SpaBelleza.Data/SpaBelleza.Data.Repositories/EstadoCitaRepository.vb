Imports SpaBelleza.Entities
Imports System.Data.SqlClient

Public Class EstadoCitaRepository
    Implements IEstadoCitaRepository

    Private ReadOnly conexion As ConexionDB

    Public Sub New()
        conexion = ConexionDB.ObtenerInstancia()
    End Sub

    Public Sub Agregar(estado As EstadoCita) Implements IEstadoCitaRepository.Agregar
        Throw New NotImplementedException()
    End Sub

    Public Sub Actualizar(estado As EstadoCita) Implements IEstadoCitaRepository.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar(id As Integer) Implements IEstadoCitaRepository.Eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function ObtenerTodos() As DataTable Implements IEstadoCitaRepository.ObtenerTodos
        Dim dt As New DataTable()

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerEstadosCitas", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader) ' Cargar los resultados en el DataTable
            End Using
        End Using

        Return dt
    End Function

    Public Function ObtenerPorId(id As Integer) As EstadoCita Implements IEstadoCitaRepository.ObtenerPorId
        Throw New NotImplementedException()
    End Function
End Class
