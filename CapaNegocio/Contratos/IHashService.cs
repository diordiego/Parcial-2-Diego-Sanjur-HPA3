namespace CapaNegocio.Contratos;

/// Contrato #1: su ÚNICA responsabilidad es generar el hash de una contraseña.
/// Se usa cuando un usuario se registra o cambia su contraseña.
public interface IHashService
{
    /// Genera el hash (con salt aleatorio) de una contraseña en texto plano.
    /// <param name="textoPlano">Contraseña tal como la escribió el usuario.</param>
    /// <returns>Cadena con el hash lista para guardarse en la base de datos.</returns>
    string GenerarHash(string textoPlano);
}