
Imports SpaBelleza.Entities
Imports System.Data.SqlClient

Public Class CitaRepository
    Implements ICitaRepository

    Private ReadOnly conexion As ConexionDB

    Public Sub New()
        conexion = ConexionDB.ObtenerInstancia
    End Sub
    Public Sub Agregar(cita As Cita) Implements ICitaRepository.Agregar
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("InsertarCita", conn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar parámetros
            cmd.Parameters.AddWithValue("@ClienteID", cita.ClienteID)
            cmd.Parameters.AddWithValue("@TrabajadorID", cita.TrabajadorID)
            cmd.Parameters.AddWithValue("@FechaCita", cita.FechaCita)
            cmd.Parameters.AddWithValue("@HoraCita", cita.HoraCita)
            cmd.Parameters.AddWithValue("@EstadoID", cita.EstadoID)

            cmd.ExecuteNonQuery() ' Ejecuta el comando
        End Using
    End Sub

    Public Sub Actualizar(cita As Cita) Implements ICitaRepository.Actualizar
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ActualizarCita", conn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar parámetros
            cmd.Parameters.AddWithValue("@CitaID", cita.CitaID)
            cmd.Parameters.AddWithValue("@ClienteID", cita.ClienteID)
            cmd.Parameters.AddWithValue("@TrabajadorID", cita.TrabajadorID)
            cmd.Parameters.AddWithValue("@FechaCita", cita.FechaCita)
            cmd.Parameters.AddWithValue("@HoraCita", cita.HoraCita)
            cmd.Parameters.AddWithValue("@EstadoID", cita.EstadoID)

            cmd.ExecuteNonQuery() ' Ejecuta el comando
        End Using
    End Sub

    Public Sub Eliminar(id As Integer) Implements ICitaRepository.Eliminar
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("EliminarCita", conn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar parámetro
            cmd.Parameters.AddWithValue("@CitaID", id)

            cmd.ExecuteNonQuery() ' Ejecuta el comando
        End Using
    End Sub

    Public Function ObtenerTodos() As DataTable Implements ICitaRepository.ObtenerTodos
        Dim dt As New DataTable()

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerCitas", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader) ' Cargar los resultados en el DataTable
            End Using
        End Using

        Return dt
    End Function

    Public Function ObtenerCitasConAtencion() As DataTable Implements ICitaRepository.ObtenerCitasConAtencion
        Dim dt As New DataTable()

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerCitasConAtencion", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader) ' Cargar los resultados en el DataTable
            End Using
        End Using

        Return dt
    End Function

    Public Function ObtenerPorId(id As Integer) As Cita Implements ICitaRepository.ObtenerPorId
        Dim cita As Cita = Nothing

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Using cmd As New SqlCommand("ObtenerCitaPorId", conn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@CitaID", id)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        cita = New Cita() With {
                        .CitaID = Convert.ToInt32(reader("CitaID")),
                        .ClienteID = Convert.ToInt32(reader("ClienteID")),
                        .TrabajadorID = Convert.ToInt32(reader("TrabajadorID")),
                        .FechaCita = Convert.ToDateTime(reader("FechaCita")),
                        .HoraCita = TimeSpan.Parse(reader("HoraCita").ToString()),
                        .EstadoID = Convert.ToInt32(reader("EstadoID"))
                    }
                    End If
                End Using
            End Using
        End Using

        Return cita
    End Function

    Public Function ObtenerCitaID(clienteID As Integer, fechaCita As Date) As Object Implements ICitaRepository.ObtenerCitaID
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerCitaID", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ClienteID", clienteID)
            cmd.Parameters.AddWithValue("@FechaCita", fechaCita)

            Dim citaID As Integer = 0
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    citaID = Convert.ToInt32(reader("CitaID"))
                End If
            End Using

            Return citaID
        End Using
    End Function

    Public Function ObtenerPorClienteFecha(clienteID As Integer, fechaCita As Date) As Cita Implements ICitaRepository.ObtenerPorClienteFecha
        Dim cita As New Cita()

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerCitaPorClienteFecha", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ClienteID", clienteID)
            cmd.Parameters.AddWithValue("@FechaCita", fechaCita)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    cita.CitaID = Convert.ToInt32(reader("CitaID"))
                    cita.ClienteID = Convert.ToInt32(reader("ClienteID"))
                    cita.FechaCita = Convert.ToDateTime(reader("FechaCita"))
                    ' Asigna otros campos relevantes si es necesario
                End If
            End Using
        End Using

        Return cita
    End Function

End Class