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

    // Se completa en el paso 10 con Registro y Perfil
    public static Form? CrearModulo(ModuloSistema modulo) => null;
}   