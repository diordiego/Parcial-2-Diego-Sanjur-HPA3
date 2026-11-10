namespace CapaNegocio.Contratos;

/// Contrato #2: su ÚNICA responsabilidad es verificar si una contraseña en texto
/// plano coincide con el hash almacenado. Se usa al iniciar sesión.
public interface IVerificarHashService
{
    /// Comprueba una contraseña contra el hash guardado.
    /// <param name="textoPlano">Contraseña escrita en el login.</param>
    /// <param name="hashAlmacenado">Hash recuperado de la base de datos.</param>
    /// <returns>true si la contraseña es correcta.</returns>
    bool Verificar(string textoPlano, string hashAlmacenado);
}