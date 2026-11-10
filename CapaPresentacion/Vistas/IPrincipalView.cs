namespace CapaPresentacion.Vistas;

/*Contrato de las Vistas principales (Admin y Usuario): menú lateral,
  hora y usuario de la sesión. Cada formulario solo dispara los eventos de su menú.*/

public interface IPrincipalView
{
    /// Se dispara cuando el formulario termina de cargar.
    event EventHandler? VistaCargada;

    /// Se dispara cada segundo para actualizar la hora.
    event EventHandler? RelojTick;

    /// Opción "Inicio".
    event EventHandler? InicioSolicitado;

    /// Opción "Registro de usuarios" (solo pantalla Admin).
    event EventHandler? RegistroSolicitado;

    /// Opción "Mi perfil" (solo pantalla Usuario).
    event EventHandler? PerfilSolicitado;

    /// Opción "Cerrar sesión".
    event EventHandler? CerrarSesionSolicitado;

    /// Muestra la hora y la fecha.
    void MostrarHora(string hora, string fecha);

    /// Muestra quién inició sesión (parte inferior).
    void MostrarSesion(string nombreCompleto, string nombreUsuario, string rol, string ultimoAcceso);

    /// Cambia el título de la sección actual.
    void MostrarTituloSeccion(string titulo);

    /// Resalta la opción activa del menú.
    void ResaltarOpcion(ModuloSistema modulo);

    /// Abre (o trae al frente) el formulario hijo MDI del módulo.
    void AbrirModulo(ModuloSistema modulo);

    /// Cierra todos los formularios hijos.
    void CerrarModulos();

    /// Pregunta si se desea cerrar sesión.
    bool ConfirmarCerrarSesion();

    /// Cierra el formulario.
    void Cerrar();
}