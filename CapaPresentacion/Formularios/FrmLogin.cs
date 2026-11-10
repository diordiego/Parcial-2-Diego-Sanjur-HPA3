using System.Runtime.InteropServices;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.Formularios;

// Vista del login: solo muestra controles y avisa al presentador.
// No sabe qué es un hash ni toca la base de datos.
public partial class FrmLogin : Form, ILoginView
{
    private static readonly Color ColorLinea = Color.FromArgb(200, 205, 210);
    private static readonly Color ColorActivo = Color.FromArgb(0, 122, 204);

    public event EventHandler? IngresarSolicitado;

    public FrmLogin()
    {
        InitializeComponent();

        btnIngresar.Click += (_, _) => IngresarSolicitado?.Invoke(this, EventArgs.Empty);
        btnSalir.Click += (_, _) => Close();
        chkMostrarPassword.CheckedChanged += (_, _) =>
            txtPassword.UseSystemPasswordChar = !chkMostrarPassword.Checked;

        // La línea debajo del campo se pone azul mientras se escribe en él
        txtUsuario.Enter += (_, _) => pnlLineaUsuario.BackColor = ColorActivo;
        txtUsuario.Leave += (_, _) => pnlLineaUsuario.BackColor = ColorLinea;
        txtPassword.Enter += (_, _) => pnlLineaPassword.BackColor = ColorActivo;
        txtPassword.Leave += (_, _) => pnlLineaPassword.BackColor = ColorLinea;

        // Como no tiene barra de título, se mueve arrastrando el panel lateral
        pnlLateral.MouseDown += ArrastrarVentana;
        MouseDown += ArrastrarVentana;
    }

    // ----- ILoginView -----

    public string NombreUsuario => txtUsuario.Text;
    public string Password => txtPassword.Text;

    public void MostrarError(string mensaje) => lblMensaje.Text = mensaje;
    public void MostrarErrorUsuario(string mensaje) => errorProvider.SetError(txtUsuario, mensaje);
    public void MostrarErrorPassword(string mensaje) => errorProvider.SetError(txtPassword, mensaje);

    public void LimpiarErrores()
    {
        errorProvider.Clear();
        lblMensaje.Text = string.Empty;
    }

    public void LimpiarPassword()
    {
        txtPassword.Clear();
        txtPassword.Focus();
    }

    public void HabilitarFormulario(bool habilitado)
    {
        txtUsuario.Enabled = habilitado;
        txtPassword.Enabled = habilitado;
        btnIngresar.Enabled = habilitado;
        Cursor = habilitado ? Cursors.Default : Cursors.WaitCursor;
    }

    public void CerrarConExito()
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    // ----- Detalles visuales -----

    [DllImport("user32.dll")] private static extern bool ReleaseCapture();
    [DllImport("user32.dll")] private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
    [DllImport("dwmapi.dll")] private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int value, int size);

    // Simula que se está arrastrando la barra de título
    private void ArrastrarVentana(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        ReleaseCapture();
        SendMessage(Handle, 0xA1, 0x2, 0);
    }

    // Esquinas redondeadas (Windows 11; en Windows 10 simplemente no tiene efecto)
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        int redondeado = 2;
        DwmSetWindowAttribute(Handle, 33, ref redondeado, sizeof(int));
    }
}