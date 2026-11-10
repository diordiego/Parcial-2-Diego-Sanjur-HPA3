namespace CapaPresentacion.Vistas;

/// <summary>Contrato de la Vista "Mi perfil" (usuario no admin).</summary>
public interface IPerfilView
{
    /// <summary>Se dispara al cargar el formulario.</summary>
    event EventHandler? VistaCargada;

    /// <summary>Muestra los datos del usuario de la sesión.</summary>
    void MostrarPerfil(string nombreCompleto, string nombreUsuario, string correo,
                       string rol, string fechaCreacion, string ultimoAcceso);
}