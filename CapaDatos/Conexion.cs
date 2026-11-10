using System.Configuration;
using MySql.Data.MySqlClient;

namespace CapaDatos;

/// <summary>
/// Crea las conexiones a MySQL usando la cadena "ConexionParcial" del App.config.
/// Esa cadena usa el usuario app_parcial, que solo tiene permiso EXECUTE
/// sobre los procedimientos almacenados (principio de mínimos privilegios).
/// </summary>
public static class Conexion
{
    private const string NombreCadena = "ConexionParcial";

    /// <summary>Devuelve una nueva conexión cerrada. Quien la use debe abrirla y liberarla.</summary>
    public static MySqlConnection Crear()
    {
        string? cadena = ConfigurationManager.ConnectionStrings[NombreCadena]?.ConnectionString;

        if (string.IsNullOrWhiteSpace(cadena))
            throw new InvalidOperationException(
                $"No se encontró la cadena de conexión '{NombreCadena}' en App.config.");

        return new MySqlConnection(cadena);
    }
}