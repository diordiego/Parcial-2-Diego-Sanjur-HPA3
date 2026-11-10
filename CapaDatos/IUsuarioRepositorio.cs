using CapaEntidades;

namespace CapaDatos;

/// <summary>
/// Contrato de acceso a datos de usuarios. La capa de Negocio depende de esta
/// interfaz y no de MySQL directamente, así se puede reemplazar o simular en pruebas.
/// </summary>
public interface IUsuarioRepositorio
{
    /// <summary>Busca un usuario por su nombre de usuario (incluye hash y rol). Null si no existe.</summary>
    Usuario? ObtenerPorNombreUsuario(string nombreUsuario);

    /// <summary>Indica si ya existe un usuario con ese nombre de usuario o correo.</summary>
    bool Existe(string nombreUsuario, string correo);

    /// <summary>Inserta el usuario (con su rol) y devuelve el Id generado.</summary>
    int Insertar(Usuario usuario);

    /// <summary>Guarda la fecha y hora actual como último acceso.</summary>
    void RegistrarAcceso(int idUsuario);

    /// <summary>Lista todos los usuarios (sin el hash).</summary>
    List<Usuario> Listar();
}