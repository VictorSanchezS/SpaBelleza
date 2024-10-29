Imports System.Data.SqlClient


Public Class ConexionDB
    ' Cadena de conexión
    'Cambiar credenciales por cada dispositivo
    Private ReadOnly cadenaConexion As String = "Data Source=LAPTOP-PAHPU2LO;Initial Catalog=SpaDB;Integrated Security=True"

    ' Variable estática para mantener la instancia única de la clase
    Private Shared instancia As ConexionDB = Nothing

    ' Constructor privado para evitar que se creen instancias directamente
    Private Sub New()
    End Sub

    ' Propiedad para obtener la instancia única de la clase
    Public Shared ReadOnly Property ObtenerInstancia() As ConexionDB
        Get
            If instancia Is Nothing Then
                instancia = New ConexionDB()
            End If
            Return instancia
        End Get
    End Property

    ' Función para obtener la conexión
    Public Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(cadenaConexion)
    End Function
End Class
