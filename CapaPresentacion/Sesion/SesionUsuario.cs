using CapaEntidades;

namespace CapaPresentacion.Sesion;

/// Guarda en memoria al usuario que inició sesión.
public static class SesionUsuario
{
    /// Usuario autenticado, o null si no hay sesión.
    public static Usuario? UsuarioActual { get; private set; }

    /// True si el usuario de la sesión es administrador.
    public static bool EsAdmin => UsuarioActual?.Rol == RolUsuario.Admin;

    /// Inicia la sesión con el usuario autenticado.
    public static void Iniciar(Usuario usuario) =>
        UsuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));

    /// Cierra la sesión.
    public static void Cerrar() => UsuarioActual = null;
}