namespace CapaPresentacion.Formularios
{
    partial class FrmRegistroUsuario
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
            pnlFormulario = new Panel();
            lblMensaje = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            lblReglas = new Label();
            cboRol = new ComboBox();
            lblRol = new Label();
            lblConfirmacion = new Label();
            txtConfirmacion = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblNombreCompleto = new Label();
            txtNombreCompleto = new TextBox();
            lblTituloForm = new Label();
            lblLista = new Label();
            dgvUsuarios = new DataGridView();
            errorProvider = new ErrorProvider(components);
            pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlFormulario
            // 
            pnlFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.Controls.Add(lblMensaje);
            pnlFormulario.Controls.Add(btnLimpiar);
            pnlFormulario.Controls.Add(btnGuardar);
            pnlFormulario.Controls.Add(lblReglas);
            pnlFormulario.Controls.Add(cboRol);
            pnlFormulario.Controls.Add(lblRol);
            pnlFormulario.Controls.Add(lblConfirmacion);
            pnlFormulario.Controls.Add(txtConfirmacion);
            pnlFormulario.Controls.Add(lblPassword);
            pnlFormulario.Controls.Add(txtPassword);
            pnlFormulario.Controls.Add(lblCorreo);
            pnlFormulario.Controls.Add(txtCorreo);
            pnlFormulario.Controls.Add(lblNombreUsuario);
            pnlFormulario.Controls.Add(txtNombreUsuario);
            pnlFormulario.Controls.Add(lblNombreCompleto);
            pnlFormulario.Controls.Add(txtNombreCompleto);
            pnlFormulario.Controls.Add(lblTituloForm);
            pnlFormulario.Location = new Point(12, 12);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(340, 569);
            pnlFormulario.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMensaje.Location = new Point(20, 510);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(300, 40);
            lblMensaje.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(175, 465);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 36);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(20, 465);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 36);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblReglas
            // 
            lblReglas.Font = new Font("Segoe UI", 8F);
            lblReglas.ForeColor = Color.Gray;
            lblReglas.Location = new Point(20, 411);
            lblReglas.Name = "lblReglas";
            lblReglas.Size = new Size(300, 45);
            lblReglas.TabIndex = 13;
            lblReglas.Text = "Mínimo 8 caracteres, con mayúscula, minúscula, número y símbolo.";
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(20, 375);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(300, 28);
            cboRol.TabIndex = 12;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(20, 355);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 20);
            lblRol.TabIndex = 11;
            lblRol.Text = "Rol";
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Location = new Point(20, 295);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(151, 20);
            lblConfirmacion.TabIndex = 10;
            lblConfirmacion.Text = "Confirmar contraseña";
            // 
            // txtConfirmacion
            // 
            txtConfirmacion.Font = new Font("Segoe UI", 10.5F);
            txtConfirmacion.Location = new Point(20, 315);
            txtConfirmacion.MaxLength = 100;
            txtConfirmacion.Name = "txtConfirmacion";
            txtConfirmacion.Size = new Size(300, 31);
            txtConfirmacion.TabIndex = 9;
            txtConfirmacion.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 235);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.Location = new Point(20, 255);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(20, 175);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(132, 20);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10.5F);
            txtCorreo.Location = new Point(20, 195);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(300, 31);
            txtCorreo.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(20, 115);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(59, 20);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 10.5F);
            txtNombreUsuario.Location = new Point(20, 135);
            txtNombreUsuario.MaxLength = 20;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(300, 31);
            txtNombreUsuario.TabIndex = 3;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(20, 55);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(132, 20);
            lblNombreCompleto.TabIndex = 2;
            lblNombreCompleto.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 10.5F);
            txtNombreCompleto.Location = new Point(20, 75);
            txtNombreCompleto.MaxLength = 100;
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(300, 31);
            txtNombreCompleto.TabIndex = 1;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.FromArgb(30, 42, 56);
            lblTituloForm.Location = new Point(20, 15);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(162, 30);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Nuevo usuario";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLista.ForeColor = Color.FromArgb(30, 42, 56);
            lblLista.Location = new Point(380, 20);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(194, 25);
            lblLista.TabIndex = 1;
            lblLista.Text = "Usuarios registrados";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(370, 48);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(560, 500);
            dgvUsuarios.TabIndex = 2;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // FrmRegistroUsuario
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(942, 593);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblLista);
            Controls.Add(pnlFormulario);
            Name = "FrmRegistroUsuario";
            Text = "Registro de usuarios";
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlFormulario;
        private Label lblConfirmacion;
        private TextBox txtConfirmacion;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblNombreCompleto;
        private TextBox txtNombreCompleto;
        private Label lblTituloForm;
        private ComboBox cboRol;
        private Label lblRol;
        private Label lblReglas;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label lblMensaje;
        private Label lblLista;
        private DataGridView dgvUsuarios;
        private ErrorProvider errorProvider;
    }
}