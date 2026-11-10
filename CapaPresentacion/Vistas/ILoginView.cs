namespace CapaPresentacion.Vistas;

/// Contrato de la Vista de inicio de sesión.
public interface ILoginView
{
    /// Texto escrito en el campo usuario.
    string NombreUsuario { get; }

    /// Texto escrito en el campo contraseña.
    string Password { get; }

    /// Se dispara al presionar "Ingresar".
    event EventHandler? IngresarSolicitado;

    /// Muestra un mensaje de error general.
    void MostrarError(string mensaje);

    /// Marca el campo usuario con un error.
    void MostrarErrorUsuario(string mensaje);

    /// Marca el campo contraseña con un error.
    void MostrarErrorPassword(string mensaje);

    /// Quita todos los errores.
    void LimpiarErrores();

    /// Borra la contraseña escrita.
    void LimpiarPassword();

    /// Habilita o deshabilita los controles mientras se valida.
    void HabilitarFormulario(bool habilitado);

    /// Cierra el login indicando que la autenticación fue exitosa.
    void CerrarConExito();
}