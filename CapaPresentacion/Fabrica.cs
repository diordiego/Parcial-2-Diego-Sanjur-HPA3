using CapaDatos;
using CapaNegocio.Servicios;
using CapaPresentacion.Formularios;
using CapaPresentacion.Presentadores;
using CapaPresentacion.Sesion;
using CapaPresentacion.Vistas;

namespace CapaPresentacion;

// Único lugar donde se crean las clases concretas y se conectan
// Vista <-> Presentador <-> Negocio <-> Datos
internal static class Fabrica
{
    private static readonly Sha256PasswordService ServicioPassword = new();
    private static readonly IUsuarioRepositorio Repositorio = new UsuarioRepositorio();
    private static readonly UsuarioServicio ServicioUsuarios =
        new(ServicioPassword, ServicioPassword, Repositorio);

    public static FrmLogin CrearLogin()
    {
        var vista = new FrmLogin();
        _ = new LoginPresenter(vista, ServicioUsuarios);
        return vista;
    }

    // Según el rol abre una pantalla u otra; las dos usan el mismo presentador
    public static (Form Vista, PrincipalPresenter Presentador) CrearPrincipal()
    {
        Form vista = SesionUsuario.EsAdmin ? new FrmPrincipalAdmin() : new FrmPrincipalUsuario();
        var presentador = new PrincipalPresenter((IPrincipalView)vista);
        return (vista, presentador);
    }

    // Crea el formulario hijo de cada opción del menú con su presentador
    public static Form? CrearModulo(ModuloSistema modulo) => modulo switch
    {
        ModuloSistema.Registro => CrearRegistro(),
        ModuloSistema.Perfil => CrearPerfil(),
        _ => null
    };

    private static FrmRegistroUsuario CrearRegistro()
    {
        var vista = new FrmRegistroUsuario();
        _ = new RegistroUsuarioPresenter(vista, ServicioUsuarios);
        return vista;
    }

    private static FrmPerfil CrearPerfil()
    {
        var vista = new FrmPerfil();
        _ = new PerfilPresenter(vista);
        return vista;
    }
}   