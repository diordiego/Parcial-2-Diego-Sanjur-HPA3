using CapaEntidades;
using CapaPresentacion.Sesion;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Presentadores;

public class PerfilPresenter
{
    private readonly IPerfilView _vista;

    public PerfilPresenter(IPerfilView vista)
    {
        _vista = vista ?? throw new ArgumentNullException(nameof(vista));
        _vista.VistaCargada += (_, _) => CargarPerfil();
    }

    // Muestra los datos del usuario que inició sesión
    private void CargarPerfil()
    {
        Usuario? u = SesionUsuario.UsuarioActual;
        if (u is null) return;

        _vista.MostrarPerfil(
            u.NombreCompleto,
            u.NombreUsuario,
            u.Correo,
            u.Rol == RolUsuario.Admin ? "Administrador" : "Usuario",
            u.FechaCreacion.ToString("dd/MM/yyyy"),
            u.UltimoAcceso?.ToString("dd/MM/yyyy hh:mm tt") ?? "Primer acceso");
    }
}