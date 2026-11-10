using System.Globalization;
using CapaEntidades;
using CapaPresentacion.Sesion;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Presentadores;

// Sirve para las dos pantallas principales (Admin y Usuario)
public class PrincipalPresenter
{
    private static readonly CultureInfo Cultura = new("es-PA");
    private readonly IPrincipalView _vista;

    // True si el usuario eligió "Cerrar sesión" (para volver al login)
    public bool CerrarSesionSolicitada { get; private set; }

    public PrincipalPresenter(IPrincipalView vista)
    {
        _vista = vista ?? throw new ArgumentNullException(nameof(vista));

        _vista.VistaCargada += OnVistaCargada;
        _vista.RelojTick += (_, _) => ActualizarHora();
        _vista.InicioSolicitado += (_, _) => IrAInicio();
        _vista.RegistroSolicitado += (_, _) =>
        {
            if (SesionUsuario.EsAdmin)   // solo un admin puede registrar usuarios
                Abrir(ModuloSistema.Registro, "Registro de usuarios");
        };
        _vista.PerfilSolicitado += (_, _) => Abrir(ModuloSistema.Perfil, "Mi perfil");
        _vista.CerrarSesionSolicitado += OnCerrarSesion;
    }

    private void OnVistaCargada(object? sender, EventArgs e)
    {
        Usuario? u = SesionUsuario.UsuarioActual;
        if (u is null) { _vista.Cerrar(); return; }

        string ultimo = u.UltimoAcceso?.ToString("dd/MM/yyyy hh:mm tt", Cultura) ?? "Primer acceso";
        string rol = u.Rol == RolUsuario.Admin ? "Administrador" : "Usuario";
        _vista.MostrarSesion(u.NombreCompleto, u.NombreUsuario, rol, ultimo);
        ActualizarHora();
        IrAInicio();
    }

    private void ActualizarHora()
    {
        DateTime ahora = DateTime.Now;
        string fecha = ahora.ToString("dddd, dd 'de' MMMM 'de' yyyy", Cultura);
        fecha = char.ToUpper(fecha[0], Cultura) + fecha[1..];
        _vista.MostrarHora(ahora.ToString("hh:mm:ss tt", Cultura), fecha);
    }

    private void IrAInicio()
    {
        _vista.CerrarModulos();
        _vista.MostrarTituloSeccion("Inicio");
        _vista.ResaltarOpcion(ModuloSistema.Inicio);
    }

    private void Abrir(ModuloSistema modulo, string titulo)
    {
        _vista.AbrirModulo(modulo);
        _vista.MostrarTituloSeccion(titulo);
        _vista.ResaltarOpcion(modulo);
    }

    private void OnCerrarSesion(object? sender, EventArgs e)
    {
        if (!_vista.ConfirmarCerrarSesion()) return;

        CerrarSesionSolicitada = true;
        SesionUsuario.Cerrar();
        _vista.Cerrar();
    }
}