using CapaDatos;
using CapaEntidades;
using CapaNegocio.Contratos;
using CapaNegocio.Validaciones;

namespace CapaNegocio.Servicios;

/// <summary>
/// Lógica de negocio de usuarios: inicio de sesión y registro.
/// Recibe sus dependencias por constructor, así que solo conoce los CONTRATOS
/// (IHashService, IVerificarHashService, IUsuarioRepositorio), no sus implementaciones.
/// </summary>
public class UsuarioServicio
{
    private readonly IHashService _servicioHash;
    private readonly IVerificarHashService _servicioVerificacion;
    private readonly IUsuarioRepositorio _repositorio;

    /// <summary>Crea el servicio con sus dependencias.</summary>
    public UsuarioServicio(IHashService servicioHash,
                           IVerificarHashService servicioVerificacion,
                           IUsuarioRepositorio repositorio)
    {
        _servicioHash = servicioHash ?? throw new ArgumentNullException(nameof(servicioHash));
        _servicioVerificacion = servicioVerificacion ?? throw new ArgumentNullException(nameof(servicioVerificacion));
        _repositorio = repositorio ?? throw new ArgumentNullException(nameof(repositorio));
    }

    /// <summary>
    /// Valida las credenciales usando IVerificarHashService. Devuelve el usuario
    /// (con su rol) o null si no existe, está inactivo o la contraseña no coincide.
    /// </summary>
    public Usuario? IniciarSesion(string nombreUsuario, string password)
    {
        if (Validador.EstaEnBlanco(nombreUsuario) || string.IsNullOrEmpty(password))
            return null;

        Usuario? usuario = _repositorio.ObtenerPorNombreUsuario(nombreUsuario.Trim());
        if (usuario is null || !usuario.Activo)
            return null;

        if (!_servicioVerificacion.Verificar(password, usuario.PasswordHash))
            return null;

        _repositorio.RegistrarAcceso(usuario.Id);
        usuario.PasswordHash = string.Empty;   // el hash no se queda en memoria
        return usuario;
    }

    /// <summary>Valida los datos del formulario de registro y devuelve los errores por campo.</summary>
    public Dictionary<CampoUsuario, string> ValidarRegistro(string nombreCompleto, string nombreUsuario,
                                                             string correo, string password, string confirmacion)
    {
        var errores = new Dictionary<CampoUsuario, string>();

        if (Validador.EstaEnBlanco(nombreCompleto))
            errores[CampoUsuario.NombreCompleto] = "El nombre completo es obligatorio.";
        else if (!Validador.EsNombreCompletoValido(nombreCompleto))
            errores[CampoUsuario.NombreCompleto] = "Escriba nombre y apellido, solo letras.";

        if (Validador.EstaEnBlanco(nombreUsuario))
            errores[CampoUsuario.NombreUsuario] = "El usuario es obligatorio.";
        else if (!Validador.EsNombreUsuarioValido(nombreUsuario))
            errores[CampoUsuario.NombreUsuario] = "De 4 a 20 caracteres: letras, números, punto o guion bajo.";

        if (Validador.EstaEnBlanco(correo))
            errores[CampoUsuario.Correo] = "El correo es obligatorio.";
        else if (!Validador.EsCorreoValido(correo))
            errores[CampoUsuario.Correo] = "El formato del correo no es válido.";

        if (string.IsNullOrEmpty(password))
            errores[CampoUsuario.Password] = "La contraseña es obligatoria.";
        else if (!Validador.EsPasswordSegura(password))
            errores[CampoUsuario.Password] = "Mínimo 8 caracteres con mayúscula, minúscula, número y símbolo.";

        if (confirmacion != password)
            errores[CampoUsuario.Confirmacion] = "Las contraseñas no coinciden.";

        return errores;
    }

    /// <summary>
    /// Registra un usuario: valida, revisa duplicados, genera el hash con IHashService
    /// y lo envía a la capa de Datos con el rol indicado.
    /// </summary>
    public ResultadoRegistro Registrar(string nombreCompleto, string nombreUsuario, string correo,
                                       string password, string confirmacion, RolUsuario rol)
    {
        var errores = ValidarRegistro(nombreCompleto, nombreUsuario, correo, password, confirmacion);
        if (errores.Count > 0)
            return ResultadoRegistro.ConErrores(errores);

        if (_repositorio.Existe(nombreUsuario.Trim(), correo.Trim()))
            return ResultadoRegistro.Fallido("Ya existe un usuario con ese nombre de usuario o correo.");

        var usuario = new Usuario
        {
            NombreCompleto = nombreCompleto.Trim(),
            NombreUsuario = nombreUsuario.Trim(),
            Correo = correo.Trim().ToLowerInvariant(),
            PasswordHash = _servicioHash.GenerarHash(password),
            Rol = rol
        };

        usuario.Id = _repositorio.Insertar(usuario);
        return ResultadoRegistro.Correcto($"Usuario '{usuario.NombreUsuario}' ({rol}) registrado con el Id {usuario.Id}.");
    }

    /// <summary>Devuelve todos los usuarios registrados (sin hashes).</summary>
    public List<Usuario> ListarUsuarios() => _repositorio.Listar();
}