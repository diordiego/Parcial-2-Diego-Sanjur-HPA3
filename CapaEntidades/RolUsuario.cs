namespace CapaEntidades;

/// <summary>Roles posibles de un usuario. Definen qué pantalla se abre después del login.</summary>
public enum RolUsuario
{
    /// <summary>Administrador: puede registrar y ver usuarios.</summary>
    Admin,

    /// <summary>Usuario normal: solo ve su información.</summary>
    Usuario
}