using CapaEntidades;
using CapaNegocio.Servicios;
using CapaNegocio.Validaciones;
using CapaPresentacion.Sesion;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Presentadores;

public class LoginPresenter
{
    private readonly ILoginView _vista;
    private readonly UsuarioServicio _servicio;

    public LoginPresenter(ILoginView vista, UsuarioServicio servicio)
    {
        _vista = vista ?? throw new ArgumentNullException(nameof(vista));
        _servicio = servicio ?? throw new ArgumentNullException(nameof(servicio));
        _vista.IngresarSolicitado += OnIngresarSolicitado;
    }

    private void OnIngresarSolicitado(object? sender, EventArgs e)
    {
        _vista.LimpiarErrores();

        // Validar que los campos no estén vacíos
        bool completos = true;
        if (Validador.EstaEnBlanco(_vista.NombreUsuario))
        {
            _vista.MostrarErrorUsuario("Ingrese su usuario.");
            completos = false;
        }
        if (string.IsNullOrEmpty(_vista.Password))
        {
            _vista.MostrarErrorPassword("Ingrese su contraseña.");
            completos = false;
        }
        if (!completos) return;

        _vista.HabilitarFormulario(false);
        try
        {
            // Negocio verifica la contraseña con IVerificarHashService
            Usuario? usuario = _servicio.IniciarSesion(_vista.NombreUsuario, _vista.Password);
            if (usuario is null)
            {
                _vista.MostrarError("Usuario o contraseña incorrectos.");
                _vista.LimpiarPassword();
                return;
            }

            SesionUsuario.Iniciar(usuario);
            _vista.CerrarConExito();
        }
        catch (Exception ex)
        {
            _vista.MostrarError("No se pudo conectar con la base de datos: " + ex.Message);
        }
        finally
        {
            _vista.HabilitarFormulario(true);
        }
    }
}