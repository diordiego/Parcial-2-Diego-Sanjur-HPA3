namespace CapaPresentacion.Formularios
{
    partial class FrmPrincipalAdmin
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
            pnlMenu = new Panel();
            pnlSesion = new Panel();
            lblUltimoAcceso = new Label();
            lblDetalleSesion = new Label();
            lblNombreSesion = new Label();
            lblAvatar = new Label();
            btnCerrarSesion = new Button();
            btnRegistro = new Button();
            btnInicio = new Button();
            lblLogoSub = new Label();
            lblLogo = new Label();
            pnlSuperior = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            lblTituloSeccion = new Label();
            timerReloj = new System.Windows.Forms.Timer(components);
            pnlMenu.SuspendLayout();
            pnlSesion.SuspendLayout();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(30, 42, 56);
            pnlMenu.Controls.Add(pnlSesion);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(btnRegistro);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(lblLogoSub);
            pnlMenu.Controls.Add(lblLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(240, 673);
            pnlMenu.TabIndex = 1;
            // 
            // pnlSesion
            // 
            pnlSesion.BackColor = Color.FromArgb(22, 32, 43);
            pnlSesion.Controls.Add(lblUltimoAcceso);
            pnlSesion.Controls.Add(lblDetalleSesion);
            pnlSesion.Controls.Add(lblNombreSesion);
            pnlSesion.Controls.Add(lblAvatar);
            pnlSesion.Dock = DockStyle.Bottom;
            pnlSesion.Location = new Point(0, 583);
            pnlSesion.Name = "pnlSesion";
            pnlSesion.Size = new Size(240, 90);
            pnlSesion.TabIndex = 5;
            // 
            // lblUltimoAcceso
            // 
            lblUltimoAcceso.AutoEllipsis = true;
            lblUltimoAcceso.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblUltimoAcceso.ForeColor = Color.FromArgb(120, 140, 160);
            lblUltimoAcceso.Location = new Point(70, 56);
            lblUltimoAcceso.Name = "lblUltimoAcceso";
            lblUltimoAcceso.Size = new Size(165, 18);
            lblUltimoAcceso.TabIndex = 3;
            lblUltimoAcceso.Text = "label1";
            // 
            // lblDetalleSesion
            // 
            lblDetalleSesion.AutoEllipsis = true;
            lblDetalleSesion.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDetalleSesion.ForeColor = Color.FromArgb(160, 190, 220);
            lblDetalleSesion.Location = new Point(70, 36);
            lblDetalleSesion.Name = "lblDetalleSesion";
            lblDetalleSesion.Size = new Size(165, 18);
            lblDetalleSesion.TabIndex = 2;
            lblDetalleSesion.Text = "label1";
            // 
            // lblNombreSesion
            // 
            lblNombreSesion.AutoEllipsis = true;
            lblNombreSesion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombreSesion.ForeColor = Color.White;
            lblNombreSesion.Location = new Point(70, 14);
            lblNombreSesion.Name = "lblNombreSesion";
            lblNombreSesion.Size = new Size(165, 20);
            lblNombreSesion.TabIndex = 1;
            lblNombreSesion.Text = "label1";
            // 
            // lblAvatar
            // 
            lblAvatar.BackColor = Color.FromArgb(0, 122, 204);
            lblAvatar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(14, 20);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(48, 48);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "?";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 40, 40);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10.5F);
            btnCerrarSesion.ForeColor = Color.FromArgb(255, 170, 170);
            btnCerrarSesion.Location = new Point(0, 196);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(20, 0, 0, 0);
            btnCerrarSesion.Size = new Size(240, 48);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "\u23fb   Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 62, 80);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Segoe UI", 10.5F);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Location = new Point(0, 148);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Padding = new Padding(20, 0, 0, 0);
            btnRegistro.Size = new Size(240, 48);
            btnRegistro.TabIndex = 3;
            btnRegistro.Text = "✎   Registro de usuarios";
            btnRegistro.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 62, 80);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 10.5F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 100);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(20, 0, 0, 0);
            btnInicio.Size = new Size(240, 48);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "⌂   Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // lblLogoSub
            // 
            lblLogoSub.AutoSize = true;
            lblLogoSub.Font = new Font("Segoe UI", 8.5F);
            lblLogoSub.ForeColor = Color.FromArgb(160, 190, 220);
            lblLogoSub.Location = new Point(23, 54);
            lblLogoSub.Name = "lblLogoSub";
            lblLogoSub.Size = new Size(167, 20);
            lblLogoSub.TabIndex = 1;
            lblLogoSub.Text = "Panel de administración";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(20, 18);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(106, 37);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "HPA III";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.Controls.Add(lblFecha);
            pnlSuperior.Controls.Add(lblHora);
            pnlSuperior.Controls.Add(lblTituloSeccion);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(240, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(942, 80);
            pnlSuperior.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.ForeColor = Color.FromArgb(0, 122, 204);
            lblFecha.Location = new Point(584, 48);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(340, 24);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "label1";
            lblFecha.TextAlign = ContentAlignment.TopRight;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblHora.ForeColor = Color.FromArgb(30, 42, 56);
            lblHora.Location = new Point(584, 2);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(340, 44);
            lblHora.TabIndex = 1;
            lblHora.Text = "00:00:00";
            lblHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTituloSeccion
            // 
            lblTituloSeccion.AutoSize = true;
            lblTituloSeccion.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloSeccion.ForeColor = Color.FromArgb(30, 42, 56);
            lblTituloSeccion.Location = new Point(20, 22);
            lblTituloSeccion.Name = "lblTituloSeccion";
            lblTituloSeccion.Size = new Size(88, 37);
            lblTituloSeccion.TabIndex = 0;
            lblTituloSeccion.Text = "Inicio";
            // 
            // timerReloj
            // 
            timerReloj.Interval = 1000;
            // 
            // FrmPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            IsMdiContainer = true;
            MinimumSize = new Size(1000, 600);
            Name = "FrmPrincipalAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel de administración";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlSesion.ResumeLayout(false);
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Label lblLogoSub;
        private Label lblLogo;
        private Button btnCerrarSesion;
        private Button btnRegistro;
        private Button btnInicio;
        private Panel pnlSesion;
        private Label lblUltimoAcceso;
        private Label lblDetalleSesion;
        private Label lblNombreSesion;
        private Label lblAvatar;
        private Panel pnlSuperior;
        private Label lblFecha;
        private Label lblHora;
        private Label lblTituloSeccion;
        private System.Windows.Forms.Timer timerReloj;
    }
}