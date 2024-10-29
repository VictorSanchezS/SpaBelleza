Imports SpaBelleza.Entities
Imports System.Data.SqlClient

Public Class ClienteRepository
    Implements IClienteRepository

    Private ReadOnly conexion As ConexionDB

    Public Sub New()
        conexion = ConexionDB.ObtenerInstancia()
    End Sub

    Public Sub Agregar(cliente As Cliente) Implements IClienteRepository.Agregar
        Throw New NotImplementedException()
    End Sub

    Public Sub Actualizar(cliente As Cliente) Implements IClienteRepository.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar(id As Integer) Implements IClienteRepository.Eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function ObtenerTodos() As DataTable Implements IClienteRepository.ObtenerTodos
        Dim dt As New DataTable()

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerClientes", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader) ' Cargar los resultados en el DataTable
            End Using
        End Using

        Return dt
    End Function

    Public Function ObtenerPorId(id As Integer) As Cliente Implements IClienteRepository.ObtenerPorId
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerClientePorId", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ClienteID", id)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Return New Cliente With {
                .ClienteID = Convert.ToInt32(reader("ClienteID")),
                .Nombre = reader("Nombre").ToString(),
                .Email = reader("Email").ToString(),
                .Telefono = reader("Telefono").ToString(),
                .FechaRegistro = Convert.ToDateTime(reader("FechaRegistro"))
            }
            Else
                Return Nothing ' Si no se encuentra el cliente
            End If
        End Using
    End Function

    Public Function ObtenerPorId(clienteNombre As String) As Integer Implements IClienteRepository.ObtenerPorId
        Dim clienteID As Integer = -1 ' Valor predeterminado en caso de que no se encuentre
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Using cmd As New SqlCommand("ObtenerClienteID", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ClienteNombre", clienteNombre)
                cmd.Parameters.Add("@ClienteID", SqlDbType.Int).Direction = ParameterDirection.Output

                cmd.ExecuteNonQuery()
                ' Obtener el valor del parámetro de salida
                Dim result = cmd.Parameters("@ClienteID").Value
                If result IsNot DBNull.Value Then
                    clienteID = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return clienteID
    End Function

    Public Function ObtenerPorNombre(clienteNombre As String) As Cliente Implements IClienteRepository.ObtenerPorNombre
        Dim cliente As New Cliente()

        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim cmd As New SqlCommand("ObtenerClientePorNombre", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ClienteNombre", clienteNombre)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    cliente.ClienteID = Convert.ToInt32(reader("ClienteID"))
                    cliente.Nombre = reader("Nombre").ToString()
                    ' Asigna otros campos relevantes si es necesario
                End If
            End Using
        End Using

        Return cliente
    End Function
End Class
