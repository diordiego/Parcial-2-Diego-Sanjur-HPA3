using CapaEntidades;
using CapaNegocio.Servicios;

namespace CapaPresentacion.Vistas;

/// Contrato de la Vista de registro de usuarios (solo Admin).
public interface IRegistroUsuarioView
{
    /// Nombre completo escrito.
    string NombreCompleto { get; }
    /// Nombre de usuario escrito.
    string NombreUsuario { get; }
    /// Correo escrito.
    string Correo { get; }
    /// Contraseña escrita.
    string Password { get; }
    /// Confirmación de la contraseña.
    string Confirmacion { get; }
    /// Rol elegido para el nuevo usuario.
    RolUsuario RolSeleccionado { get; }

    /// Se dispara al cargar el formulario.
    event EventHandler? VistaCargada;
    /// Se dispara al presionar "Guardar".
    event EventHandler? GuardarSolicitado;
    /// Se dispara al presionar "Limpiar".
    event EventHandler? LimpiarSolicitado;

    /// Marca un campo con su error.
    void MostrarErrorCampo(CampoUsuario campo, string mensaje);
    /// Quita todos los errores.
    void LimpiarErrores();
    /// Vacía los campos.
    void LimpiarFormulario();
    /// Muestra la lista de usuarios.
    void MostrarUsuarios(IList<Usuario> usuarios);
    /// Muestra un mensaje de resultado.
    void MostrarMensaje(string mensaje, bool esError);
}