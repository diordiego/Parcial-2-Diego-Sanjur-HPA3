namespace CapaEntidades;

/// Entidad que representa a un usuario del sistema (tabla <c>usuarios</c>).
public class Usuario
{
    /// <summary>Identificador único (llave primaria).</summary>
    public int Id { get; set; }

    /// <summary>Nombre con el que el usuario inicia sesión.</summary>
    public string NombreUsuario { get; set; } = string.Empty;

    /// <summary>Nombre y apellido del usuario.</summary>
    public string NombreCompleto { get; set; } = string.Empty;

    /// <summary>Correo electrónico.</summary>
    public string Correo { get; set; } = string.Empty;

    /// <summary>Hash de la contraseña. Nunca se guarda la contraseña en texto plano.</summary>
    public string PasswordHash { get; set; } = string.Empty;

    /// <summary>Rol del usuario (Admin o Usuario).</summary>
    public RolUsuario Rol { get; set; } = RolUsuario.Usuario;

    /// <summary>Indica si el usuario puede iniciar sesión.</summary>
    public bool Activo { get; set; } = true;

    /// <summary>Fecha en que se creó el registro.</summary>
    public DateTime FechaCreacion { get; set; }

    /// <summary>Fecha del último inicio de sesión (null si nunca ha ingresado).</summary>
    public DateTime? UltimoAcceso { get; set; }
}