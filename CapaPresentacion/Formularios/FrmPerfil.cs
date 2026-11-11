using System.Drawing.Drawing2D;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Formularios;

// Vista "Mi perfil" del usuario no admin: solo muestra sus datos.
public partial class FrmPerfil : Form, IPerfilView
{
    public event EventHandler? VistaCargada;

    public FrmPerfil()
    {
        InitializeComponent();

        Load += (_, _) =>
        {
            // Avatar circular
            using var circulo = new GraphicsPath();
            circulo.AddEllipse(0, 0, lblAvatar.Width, lblAvatar.Height);
            lblAvatar.Region = new Region(circulo);

            VistaCargada?.Invoke(this, EventArgs.Empty);
        };
    }

    public void MostrarPerfil(string nombreCompleto, string nombreUsuario, string correo,
                              string rol, string fechaCreacion, string ultimoAcceso)
    {
        lblAvatar.Text = Iniciales(nombreCompleto);
        lblNombre.Text = nombreCompleto;
        lblRol.Text = rol;
        lblUsuario.Text = "@" + nombreUsuario;
        lblCorreo.Text = correo;
        lblCreado.Text = fechaCreacion;
        lblUltimoAcceso.Text = ultimoAcceso;
    }

    private static string Iniciales(string nombre)
    {
        string[] partes = nombre.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (partes.Length == 0) return "?";
        if (partes.Length == 1) return partes[0][..1].ToUpper();
        return (partes[0][..1] + partes[^1][..1]).ToUpper();
    }
}