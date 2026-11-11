using CapaEntidades;
using CapaNegocio.Servicios;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Formularios;

// Vista de registro de usuarios (solo Admin). Muestra los errores de validación
// con ErrorProvider y la lista de usuarios en un DataGridView.
public partial class FrmRegistroUsuario : Form, IRegistroUsuarioView
{
    public event EventHandler? VistaCargada;
    public event EventHandler? GuardarSolicitado;
    public event EventHandler? LimpiarSolicitado;

    public FrmRegistroUsuario()
    {
        InitializeComponent();

        cboRol.Items.AddRange(new object[] { RolUsuario.Usuario, RolUsuario.Admin });
        cboRol.SelectedIndex = 0;

        Load += (_, _) => VistaCargada?.Invoke(this, EventArgs.Empty);
        btnGuardar.Click += (_, _) => GuardarSolicitado?.Invoke(this, EventArgs.Empty);
        btnLimpiar.Click += (_, _) => LimpiarSolicitado?.Invoke(this, EventArgs.Empty);
    }

    public string NombreCompleto => txtNombreCompleto.Text;
    public string NombreUsuario => txtNombreUsuario.Text;
    public string Correo => txtCorreo.Text;
    public string Password => txtPassword.Text;
    public string Confirmacion => txtConfirmacion.Text;
    public RolUsuario RolSeleccionado => cboRol.SelectedItem is RolUsuario rol ? rol : RolUsuario.Usuario;

    public void MostrarErrorCampo(CampoUsuario campo, string mensaje)
    {
        Control control = campo switch
        {
            CampoUsuario.NombreCompleto => txtNombreCompleto,
            CampoUsuario.NombreUsuario => txtNombreUsuario,
            CampoUsuario.Correo => txtCorreo,
            CampoUsuario.Password => txtPassword,
            _ => txtConfirmacion
        };
        errorProvider.SetError(control, mensaje);
    }

    public void LimpiarErrores()
    {
        errorProvider.Clear();
        lblMensaje.Text = string.Empty;
    }

    public void LimpiarFormulario()
    {
        txtNombreCompleto.Clear();
        txtNombreUsuario.Clear();
        txtCorreo.Clear();
        txtPassword.Clear();
        txtConfirmacion.Clear();
        cboRol.SelectedIndex = 0;
        txtNombreCompleto.Focus();
    }

    public void MostrarUsuarios(IList<Usuario> usuarios)
    {
        // El grid nunca recibe el hash de la contraseña
        dgvUsuarios.DataSource = usuarios.Select(u => new
        {
            u.Id,
            Usuario = u.NombreUsuario,
            Nombre = u.NombreCompleto,
            u.Correo,
            Rol = u.Rol.ToString(),
            Creado = u.FechaCreacion.ToString("dd/MM/yyyy"),
            UltimoAcceso = u.UltimoAcceso?.ToString("dd/MM/yyyy HH:mm") ?? "—"
        }).ToList();
    }

    public void MostrarMensaje(string mensaje, bool esError)
    {
        lblMensaje.ForeColor = esError ? Color.Firebrick : Color.ForestGreen;
        lblMensaje.Text = mensaje;
    }
}