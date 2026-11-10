using CapaNegocio.Servicios;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Presentadores;

public class RegistroUsuarioPresenter
{
    private readonly IRegistroUsuarioView _vista;
    private readonly UsuarioServicio _servicio;

    public RegistroUsuarioPresenter(IRegistroUsuarioView vista, UsuarioServicio servicio)
    {
        _vista = vista ?? throw new ArgumentNullException(nameof(vista));
        _servicio = servicio ?? throw new ArgumentNullException(nameof(servicio));

        _vista.VistaCargada += (_, _) => CargarUsuarios();
        _vista.GuardarSolicitado += OnGuardar;
        _vista.LimpiarSolicitado += (_, _) =>
        {
            _vista.LimpiarErrores();
            _vista.LimpiarFormulario();
        };
    }

    private void OnGuardar(object? sender, EventArgs e)
    {
        _vista.LimpiarErrores();
        try
        {
            // Negocio valida y genera el hash con IHashService antes de guardar
            ResultadoRegistro r = _servicio.Registrar(
                _vista.NombreCompleto, _vista.NombreUsuario, _vista.Correo,
                _vista.Password, _vista.Confirmacion, _vista.RolSeleccionado);

            foreach (var error in r.Errores)
                _vista.MostrarErrorCampo(error.Key, error.Value);

            _vista.MostrarMensaje(r.Mensaje, esError: !r.Exitoso);

            if (r.Exitoso)
            {
                _vista.LimpiarFormulario();
                CargarUsuarios();
            }
        }
        catch (Exception ex)
        {
            _vista.MostrarMensaje("Error al guardar: " + ex.Message, esError: true);
        }
    }

    private void CargarUsuarios()
    {
        try
        {
            _vista.MostrarUsuarios(_servicio.ListarUsuarios());
        }
        catch (Exception ex)
        {
            _vista.MostrarMensaje("No se pudo cargar la lista: " + ex.Message, esError: true);
        }
    }
}