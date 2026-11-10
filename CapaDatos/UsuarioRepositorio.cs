using CapaEntidades;
using MySql.Data.MySqlClient;

namespace CapaDatos;

/// <summary>
/// Implementación de IUsuarioRepositorio para MySQL. Solo llama procedimientos
/// almacenados con parámetros: nunca concatena texto del usuario (evita inyección SQL).
/// </summary>
public class UsuarioRepositorio : IUsuarioRepositorio
{
    /// <inheritdoc />
    public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
    {
        using MySqlConnection cn = Conexion.Crear();
        using var cmd = new MySqlCommand("CALL sp_usuario_obtener_por_nombre(@nombreUsuario);", cn);
        cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

        cn.Open();
        using MySqlDataReader dr = cmd.ExecuteReader();
        return dr.Read() ? Mapear(dr, incluirHash: true) : null;
    }

    /// <inheritdoc />
    public bool Existe(string nombreUsuario, string correo)
    {
        using MySqlConnection cn = Conexion.Crear();
        using var cmd = new MySqlCommand("CALL sp_usuario_existe(@nombreUsuario, @correo);", cn);
        cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
        cmd.Parameters.AddWithValue("@correo", correo);

        cn.Open();
        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
    }

    /// <inheritdoc />
    public int Insertar(Usuario usuario)
    {
        using MySqlConnection cn = Conexion.Crear();
        using var cmd = new MySqlCommand(
            "CALL sp_usuario_insertar(@nombreUsuario, @nombreCompleto, @correo, @passwordHash, @rol);", cn);
        cmd.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
        cmd.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
        cmd.Parameters.AddWithValue("@correo", usuario.Correo);
        cmd.Parameters.AddWithValue("@passwordHash", usuario.PasswordHash);
        cmd.Parameters.AddWithValue("@rol", usuario.Rol.ToString());   // "Admin" o "Usuario"

        cn.Open();
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    /// <inheritdoc />
    public void RegistrarAcceso(int idUsuario)
    {
        using MySqlConnection cn = Conexion.Crear();
        using var cmd = new MySqlCommand("CALL sp_usuario_registrar_acceso(@id);", cn);
        cmd.Parameters.AddWithValue("@id", idUsuario);

        cn.Open();
        cmd.ExecuteNonQuery();
    }

    /// <inheritdoc />
    public List<Usuario> Listar()
    {
        var lista = new List<Usuario>();

        using MySqlConnection cn = Conexion.Crear();
        using var cmd = new MySqlCommand("CALL sp_usuario_listar();", cn);

        cn.Open();
        using MySqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
            lista.Add(Mapear(dr, incluirHash: false));

        return lista;
    }

    /// <summary>Convierte la fila actual del lector en un objeto Usuario.</summary>
    private static Usuario Mapear(MySqlDataReader dr, bool incluirHash)
    {
        int ordUltimoAcceso = dr.GetOrdinal("ultimo_acceso");

        return new Usuario
        {
            Id = dr.GetInt32("id"),
            NombreUsuario = dr.GetString("nombre_usuario"),
            NombreCompleto = dr.GetString("nombre_completo"),
            Correo = dr.GetString("correo"),
            PasswordHash = incluirHash ? dr.GetString("password_hash") : string.Empty,
            Rol = Enum.Parse<RolUsuario>(dr.GetString("rol")),
            Activo = dr.GetBoolean("activo"),
            FechaCreacion = dr.GetDateTime("fecha_creacion"),
            UltimoAcceso = dr.IsDBNull(ordUltimoAcceso) ? null : dr.GetDateTime(ordUltimoAcceso)
        };
    }
}