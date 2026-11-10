using System.Security.Cryptography;
using CapaNegocio.Contratos;

namespace CapaNegocio.Servicios;

/// <summary>
/// Implementa los dos contratos (IHashService e IVerificarHashService) usando
/// PBKDF2 con HMAC-SHA256, un salt aleatorio de 16 bytes y 100 000 iteraciones.
/// Si se cambia el algoritmo (BCrypt, Argon2...) solo se reemplaza esta clase;
/// la Vista, el Presentador y la capa de Datos no cambian.
/// Formato guardado: PBKDF2-SHA256$iteraciones$saltBase64$hashBase64
/// </summary>
public class Sha256PasswordService : IHashService, IVerificarHashService
{
    private const string Prefijo = "PBKDF2-SHA256";
    private const int TamanoSalt = 16;       // 128 bits
    private const int TamanoHash = 32;       // 256 bits
    private const int Iteraciones = 100_000;
    private static readonly HashAlgorithmName Algoritmo = HashAlgorithmName.SHA256;

    /// <inheritdoc />
    public string GenerarHash(string textoPlano)
    {
        ArgumentNullException.ThrowIfNull(textoPlano);

        byte[] salt = RandomNumberGenerator.GetBytes(TamanoSalt);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(textoPlano, salt, Iteraciones, Algoritmo, TamanoHash);

        return $"{Prefijo}${Iteraciones}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
    }

    /// <inheritdoc />
    public bool Verificar(string textoPlano, string hashAlmacenado)
    {
        if (string.IsNullOrEmpty(textoPlano) || string.IsNullOrWhiteSpace(hashAlmacenado))
            return false;

        string[] partes = hashAlmacenado.Split('$');
        if (partes.Length != 4 || partes[0] != Prefijo || !int.TryParse(partes[1], out int iteraciones))
            return false;

        try
        {
            byte[] salt = Convert.FromBase64String(partes[2]);
            byte[] hashEsperado = Convert.FromBase64String(partes[3]);
            byte[] hashCalculado = Rfc2898DeriveBytes.Pbkdf2(
                textoPlano, salt, iteraciones, Algoritmo, hashEsperado.Length);

            // Comparación en tiempo constante: evita ataques de temporización
            return CryptographicOperations.FixedTimeEquals(hashCalculado, hashEsperado);
        }
        catch (FormatException)
        {
            return false;   // hash almacenado corrupto
        }
    }
}