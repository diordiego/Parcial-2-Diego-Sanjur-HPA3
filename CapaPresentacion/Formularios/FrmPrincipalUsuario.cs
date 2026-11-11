using System.Drawing.Drawing2D;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Formularios;

// Vista principal del usuario normal: mismo diseño que la de Admin,
// pero solo puede ver su perfil. Usa el mismo PrincipalPresenter.
public partial class FrmPrincipalUsuario : Form, IPrincipalView
{
    private static readonly Color ColorMenu = Color.FromArgb(30, 42, 56);
    private static readonly Color ColorActivo = Color.FromArgb(0, 122, 204);

    public event EventHandler? VistaCargada;
    public event EventHandler? RelojTick;
    public event EventHandler? InicioSolicitado;
    public event EventHandler? RegistroSolicitado { add { } remove { } } 
    public event EventHandler? PerfilSolicitado;
    public event EventHandler? CerrarSesionSolicitado;

    public FrmPrincipalUsuario()
    {
        InitializeComponent();

        Load += (_, _) =>
        {
            foreach (MdiClient area in Controls.OfType<MdiClient>())
                area.BackColor = Color.FromArgb(236, 240, 244);

            RedondearAvatar();
            timerReloj.Start();
            VistaCargada?.Invoke(this, EventArgs.Empty);
        };
        FormClosed += (_, _) => timerReloj.Stop();

        timerReloj.Tick += (_, _) => RelojTick?.Invoke(this, EventArgs.Empty);
        btnInicio.Click += (_, _) => InicioSolicitado?.Invoke(this, EventArgs.Empty);
        btnPerfil.Click += (_, _) => PerfilSolicitado?.Invoke(this, EventArgs.Empty);
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
        btnPerfil.BackColor = modulo == ModuloSistema.Perfil ? ColorActivo : ColorMenu;
    }

    public void AbrirModulo(ModuloSistema modulo)
    {
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
        nuevo.FormBorderStyle = FormBorderStyle.None;
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

    private void RedondearAvatar()
    {
        using var circulo = new GraphicsPath();
        circulo.AddEllipse(0, 0, lblAvatar.Width, lblAvatar.Height);
        lblAvatar.Region = new Region(circulo);
    }
}