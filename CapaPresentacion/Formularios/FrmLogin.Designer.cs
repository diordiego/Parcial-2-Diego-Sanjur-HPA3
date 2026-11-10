namespace CapaPresentacion.Formularios
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlLateral = new Panel();
            lblSubtitulo = new Label();
            lblIcono = new Label();
            lblTitulo = new Label();
            lblIniciar = new Label();
            lblInstruccion = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            pnlLineaUsuario = new Panel();
            pnlLineaPassword = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            chkMostrarPassword = new CheckBox();
            btnIngresar = new Button();
            lblMensaje = new Label();
            btnSalir = new Button();
            errorProvider = new ErrorProvider(components);
            pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(30, 42, 56);
            pnlLateral.Controls.Add(lblSubtitulo);
            pnlLateral.Controls.Add(lblIcono);
            pnlLateral.Controls.Add(lblTitulo);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(300, 460);
            pnlLateral.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(160, 190, 220);
            lblSubtitulo.Location = new Point(54, 139);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(187, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Sistema de usuarios";
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Bold);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(80, 9);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(116, 80);
            lblIcono.TabIndex = 1;
            lblIcono.Text = "🔒";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(40, 89);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido";
            // 
            // lblIniciar
            // 
            lblIniciar.AutoSize = true;
            lblIniciar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblIniciar.ForeColor = Color.FromArgb(30, 42, 56);
            lblIniciar.Location = new Point(332, 43);
            lblIniciar.Name = "lblIniciar";
            lblIniciar.Size = new Size(229, 46);
            lblIniciar.TabIndex = 1;
            lblIniciar.Text = "Iniciar sesión";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 10F);
            lblInstruccion.ForeColor = Color.DimGray;
            lblInstruccion.Location = new Point(332, 89);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(309, 23);
            lblInstruccion.TabIndex = 2;
            lblInstruccion.Text = "Ingresa tus credenciales para continuar";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblUsuario.Location = new Point(352, 140);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(352, 162);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(340, 19);
            txtUsuario.TabIndex = 5;
            // 
            // pnlLineaUsuario
            // 
            pnlLineaUsuario.BackColor = Color.FromArgb(200, 205, 210);
            pnlLineaUsuario.Location = new Point(352, 190);
            pnlLineaUsuario.Name = "pnlLineaUsuario";
            pnlLineaUsuario.Size = new Size(340, 2);
            pnlLineaUsuario.TabIndex = 6;
            // 
            // pnlLineaPassword
            // 
            pnlLineaPassword.BackColor = Color.FromArgb(200, 205, 210);
            pnlLineaPassword.Location = new Point(352, 260);
            pnlLineaPassword.Name = "pnlLineaPassword";
            pnlLineaPassword.Size = new Size(340, 2);
            pnlLineaPassword.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(352, 232);
            txtPassword.MaxLength = 64;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(340, 19);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPassword.Location = new Point(352, 210);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(110, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "CONTRASEÑA";
            // 
            // chkMostrarPassword
            // 
            chkMostrarPassword.AutoSize = true;
            chkMostrarPassword.ForeColor = Color.Gray;
            chkMostrarPassword.Location = new Point(352, 275);
            chkMostrarPassword.Name = "chkMostrarPassword";
            chkMostrarPassword.Size = new Size(158, 24);
            chkMostrarPassword.TabIndex = 10;
            chkMostrarPassword.Text = "Mostrar contraseña";
            chkMostrarPassword.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 122, 204);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(352, 315);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(340, 44);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // lblMensaje
            // 
            lblMensaje.ForeColor = Color.Firebrick;
            lblMensaje.Location = new Point(352, 372);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(340, 40);
            lblMensaje.TabIndex = 12;
            lblMensaje.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 17, 35);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.ForeColor = Color.Gray;
            btnSalir.Location = new Point(715, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 36);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "✕";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 460);
            Controls.Add(btnSalir);
            Controls.Add(lblMensaje);
            Controls.Add(btnIngresar);
            Controls.Add(chkMostrarPassword);
            Controls.Add(pnlLineaPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(pnlLineaUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblInstruccion);
            Controls.Add(lblIniciar);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLateral;
        private Label lblTitulo;
        private Label lblIcono;
        private Label lblSubtitulo;
        private Label lblIniciar;
        private Label lblInstruccion;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Panel pnlLineaUsuario;
        private Panel pnlLineaPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private CheckBox chkMostrarPassword;
        private Button btnIngresar;
        private Label lblMensaje;
        private Button btnSalir;
        private ErrorProvider errorProvider;
    }
}