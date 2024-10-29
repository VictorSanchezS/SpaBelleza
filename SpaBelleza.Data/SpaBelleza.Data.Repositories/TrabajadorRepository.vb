Imports SpaBelleza.Entities
Imports System.Data.SqlClient

Public Class TrabajadorRepository
    Implements ITrabajadorRepository

    Private ReadOnly conexion As ConexionDB

    Public Sub New()
        conexion = ConexionDB.ObtenerInstancia()
    End Sub

    Public Sub Agregar(trabajador As Trabajador) Implements ITrabajadorRepository.Agregar
        Throw New NotImplementedException()
    End Sub

    Public Sub Actualizar(trabajador As Trabajador) Implements ITrabajadorRepository.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar(id As Integer) Implements ITrabajadorRepository.Eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function ObtenerTodos() As DataTable Implements ITrabajadorRepository.ObtenerTodos
        Dim dt As New DataTable()

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerTrabajadores", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader) ' Cargar los resultados en el DataTable
            End Using
        End Using

        Return dt
    End Function

    Public Function ObtenerPorId(id As Integer) As Trabajador Implements ITrabajadorRepository.ObtenerPorId
        Throw New NotImplementedException()
    End Function

    Public Function ObtenerPorId(trabajadorNombre As String) As Integer Implements ITrabajadorRepository.ObtenerPorId
        Dim trabajadorID As Integer

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Using cmd As New SqlCommand("ObtenerTrabajadorID", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@TrabajadorNombre", trabajadorNombre)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    trabajadorID = Convert.ToInt32(result)
                Else
                    ' Si no se encuentra el trabajador, lanzar una excepción o manejarlo como sea necesario
                    Throw New Exception("Trabajador no encontrado")
                End If
            End Using
        End Using

        Return trabajadorID
    End Function

    Public Function ObtenerPorNombre(trabajadorNombre As String) As Trabajador Implements ITrabajadorRepository.ObtenerPorNombre
        Dim trabajador As New Trabajador()

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerTrabajadorPorNombre", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@TrabajadorNombre", trabajadorNombre)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    trabajador.TrabajadorID = Convert.ToInt32(reader("TrabajadorID"))
                    trabajador.NombreTrabajador = reader("NombreTrabajador").ToString()
                    ' Asigna otros campos relevantes si es necesario
                End If
            End Using
        End Using

        Return trabajador
    End Function
End Class
