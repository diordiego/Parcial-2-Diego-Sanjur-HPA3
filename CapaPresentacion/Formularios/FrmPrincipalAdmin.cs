using System.Drawing.Drawing2D;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Formularios;

// Vista principal del administrador: menú lateral, hora arriba y sesión abajo.
// Los módulos se abren como formularios hijos MDI.
public partial class FrmPrincipalAdmin : Form, IPrincipalView
{
    private static readonly Color ColorMenu = Color.FromArgb(30, 42, 56);
    private static readonly Color ColorActivo = Color.FromArgb(0, 122, 204);

    public event EventHandler? VistaCargada;
    public event EventHandler? RelojTick;
    public event EventHandler? InicioSolicitado;
    public event EventHandler? RegistroSolicitado;
    public event EventHandler? PerfilSolicitado;   // no se usa en esta pantalla
    public event EventHandler? CerrarSesionSolicitado;

    public FrmPrincipalAdmin()
    {
        InitializeComponent();

        Load += (_, _) =>
        {
            // Color de fondo del área MDI
            foreach (MdiClient area in Controls.OfType<MdiClient>())
                area.BackColor = Color.FromArgb(236, 240, 244);

            RedondearAvatar();
            timerReloj.Start();
            VistaCargada?.Invoke(this, EventArgs.Empty);
        };
        FormClosed += (_, _) => timerReloj.Stop();

        timerReloj.Tick += (_, _) => RelojTick?.Invoke(this, EventArgs.Empty);
        btnInicio.Click += (_, _) => InicioSolicitado?.Invoke(this, EventArgs.Empty);
        btnRegistro.Click += (_, _) => RegistroSolicitado?.Invoke(this, EventArgs.Empty);
        btnCerrarSesion.Click += (_, _) => CerrarSesionSolicitado?.Invoke(this, EventArgs.Empty);
    }

    public void MostrarHora(string hora, string fecha)
    {
        lblHora.Text = hora;
        lblFecha.Text = fecha;
    }

    public void MostrarSesion(string nombreCompleto, string nombreUsuario, string rol, string ultimoAcceso)
    {
        lblAvatar.Text = Iniciales(nombreCompleto);
        lblNombreSesion.Text = nombreCompleto;
        lblDetalleSesion.Text = $"@{nombreUsuario} · {rol}";
        lblUltimoAcceso.Text = $"Último acceso: {ultimoAcceso}";
    }

    public void MostrarTituloSeccion(string titulo) => lblTituloSeccion.Text = titulo;

    public void ResaltarOpcion(ModuloSistema modulo)
    {
        btnInicio.BackColor = modulo == ModuloSistema.Inicio ? ColorActivo : ColorMenu;
        btnRegistro.BackColor = modulo == ModuloSistema.Registro ? ColorActivo : ColorMenu;
    }

    public void AbrirModulo(ModuloSistema modulo)
    {
        // Si ya está abierto, se trae al frente en lugar de duplicarlo
        Form? existente = MdiChildren.FirstOrDefault(f => Equals(f.Tag, modulo));
        if (existente is not null)
        {
            existente.BringToFront();
            existente.Activate();
            return;
        }

        Form? nuevo = Fabrica.CrearModulo(modulo);
        if (nuevo is null) return;

        nuevo.Tag = modulo;
        nuevo.MdiParent = this;
        nuevo.FormBorderStyle = FormBorderStyle.None;   // se ve integrado en la pantalla
        nuevo.Dock = DockStyle.Fill;
        nuevo.Show();
    }

    public void CerrarModulos()
    {
        foreach (Form hijo in MdiChildren)
            hijo.Close();
    }

    public bool ConfirmarCerrarSesion() =>
        MessageBox.Show("¿Desea cerrar la sesión?", "Cerrar sesión",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    public void Cerrar() => Close();

    private static string Iniciales(string nombre)
    {
        string[] partes = nombre.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (partes.Length == 0) return "?";
        if (partes.Length == 1) return partes[0][..1].ToUpper();
        return (partes[0][..1] + partes[^1][..1]).ToUpper();
    }

    // Avatar circular
    private void RedondearAvatar()
    {
        using var circulo = new GraphicsPath();
        circulo.AddEllipse(0, 0, lblAvatar.Width, lblAvatar.Height);
        lblAvatar.Region = new Region(circulo);
    }
}