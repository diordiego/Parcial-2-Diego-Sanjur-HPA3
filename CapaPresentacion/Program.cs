namespace CapaPresentacion;

internal static class Program
{
    // Muestra el login; si es correcto abre la pantalla según el rol.
    // Al cerrar sesión vuelve al login; al cerrar la ventana termina.
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            using (var login = Fabrica.CrearLogin())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            var (principal, presentador) = Fabrica.CrearPrincipal();
            Application.Run(principal);

            if (!presentador.CerrarSesionSolicitada)
                return;
        }
    }
}