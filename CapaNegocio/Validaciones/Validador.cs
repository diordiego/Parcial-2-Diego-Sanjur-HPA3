using System.Text.RegularExpressions;

namespace CapaNegocio.Validaciones;

/// <summary>Reglas de validación reutilizables (clase estática de utilería).</summary>
public static class Validador
{
    private static readonly Regex RegexCorreo =
        new(@"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$", RegexOptions.Compiled);

    private static readonly Regex RegexUsuario =
        new(@"^[a-zA-Z0-9_.]{4,20}$", RegexOptions.Compiled);

    private static readonly Regex RegexNombre =
        new(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ]+( [a-zA-ZáéíóúÁÉÍÓÚñÑüÜ   ]+)+$", RegexOptions.Compiled);

    /// <summary>True si el texto es null, vacío o solo espacios.</summary>
    public static bool EstaEnBlanco(string? texto) => string.IsNullOrWhiteSpace(texto);

    /// <summary>True si el correo tiene formato usuario@dominio.ext.</summary>
    public static bool EsCorreoValido(string correo) => RegexCorreo.IsMatch(correo.Trim());

    /// <summary>True si el usuario tiene de 4 a 20 caracteres: letras, números, punto o guion bajo.</summary>
    public static bool EsNombreUsuarioValido(string usuario) => RegexUsuario.IsMatch(usuario.Trim());

    /// <summary>True si tiene al menos nombre y apellido, solo letras y espacios.</summary>
    public static bool EsNombreCompletoValido(string nombre) => RegexNombre.IsMatch(nombre.Trim());

    /// <summary>
    /// True si la contraseña tiene mínimo 8 caracteres, una mayúscula,
    /// una minúscula, un número y un carácter especial.
    /// </summary>
    public static bool EsPasswordSegura(string password) =>
        password.Length >= 8 &&
        password.Any(char.IsUpper) &&
        password.Any(char.IsLower) &&
        password.Any(char.IsDigit) &&
        password.Any(c => !char.IsLetterOrDigit(c));
}