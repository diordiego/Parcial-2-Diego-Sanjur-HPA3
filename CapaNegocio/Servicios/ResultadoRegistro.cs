namespace CapaNegocio.Servicios;

/// <summary>Resultado de intentar registrar un usuario.</summary>
public class ResultadoRegistro
{
    /// <summary>True si el usuario se guardó.</summary>
    public bool Exitoso { get; private init; }

    /// <summary>Mensaje general para mostrar.</summary>
    public string Mensaje { get; private init; } = string.Empty;

    /// <summary>Errores de validación por campo (vacío si no hay).</summary>
    public IReadOnlyDictionary<CampoUsuario, string> Errores { get; private init; } =
        new Dictionary<CampoUsuario, string>();

    /// <summary>Crea un resultado exitoso.</summary>
    public static ResultadoRegistro Correcto(string mensaje) =>
        new() { Exitoso = true, Mensaje = mensaje };

    /// <summary>Crea un resultado fallido con un mensaje general.</summary>
    public static ResultadoRegistro Fallido(string mensaje) =>
        new() { Exitoso = false, Mensaje = mensaje };

    /// <summary>Crea un resultado fallido con errores por campo.</summary>
    public static ResultadoRegistro ConErrores(Dictionary<CampoUsuario, string> errores) =>
        new() { Exitoso = false, Mensaje = "Corrija los campos marcados.", Errores = errores };
}