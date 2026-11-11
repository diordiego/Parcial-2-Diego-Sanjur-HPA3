namespace CapaPresentacion.Formularios
{
    partial class FrmPerfil
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
            panel1 = new Panel();
            lblAvatar = new Label();
            lblNombre = new Label();
            lblRol = new Label();
            lblTituloUsuario = new Label();
            lblTituloCorreo = new Label();
            lblTituloCreado = new Label();
            lblTituloAcceso = new Label();
            lblUsuario = new Label();
            lblCreado = new Label();
            lblUltimoAcceso = new Label();
            lblCorreo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblUltimoAcceso);
            panel1.Controls.Add(lblCreado);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblTituloAcceso);
            panel1.Controls.Add(lblTituloCreado);
            panel1.Controls.Add(lblTituloCorreo);
            panel1.Controls.Add(lblTituloUsuario);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblAvatar);
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 300);
            panel1.TabIndex = 0;
            // 
            // lblAvatar
            // 
            lblAvatar.BackColor = Color.FromArgb(0, 122, 204);
            lblAvatar.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(30, 30);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(80, 80);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "?";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(30, 42, 56);
            lblNombre.Location = new Point(130, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(123, 37);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.ForeColor = Color.FromArgb(0, 122, 204);
            lblRol.Location = new Point(132, 75);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 23);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol";
            // 
            // lblTituloUsuario
            // 
            lblTituloUsuario.AutoSize = true;
            lblTituloUsuario.Font = new Font("Segoe UI", 9.5F);
            lblTituloUsuario.ForeColor = Color.Gray;
            lblTituloUsuario.Location = new Point(30, 140);
            lblTituloUsuario.Name = "lblTituloUsuario";
            lblTituloUsuario.Size = new Size(64, 21);
            lblTituloUsuario.TabIndex = 3;
            lblTituloUsuario.Text = "Usuario";
            // 
            // lblTituloCorreo
            // 
            lblTituloCorreo.AutoSize = true;
            lblTituloCorreo.Font = new Font("Segoe UI", 9.5F);
            lblTituloCorreo.ForeColor = Color.Gray;
            lblTituloCorreo.Location = new Point(30, 175);
            lblTituloCorreo.Name = "lblTituloCorreo";
            lblTituloCorreo.Size = new Size(58, 21);
            lblTituloCorreo.TabIndex = 4;
            lblTituloCorreo.Text = "Correo";
            // 
            // lblTituloCreado
            // 
            lblTituloCreado.AutoSize = true;
            lblTituloCreado.Font = new Font("Segoe UI", 9.5F);
            lblTituloCreado.ForeColor = Color.Gray;
            lblTituloCreado.Location = new Point(30, 210);
            lblTituloCreado.Name = "lblTituloCreado";
            lblTituloCreado.Size = new Size(119, 21);
            lblTituloCreado.TabIndex = 5;
            lblTituloCreado.Text = "Miembro desde";
            // 
            // lblTituloAcceso
            // 
            lblTituloAcceso.AutoSize = true;
            lblTituloAcceso.Font = new Font("Segoe UI", 9.5F);
            lblTituloAcceso.ForeColor = Color.Gray;
            lblTituloAcceso.Location = new Point(30, 245);
            lblTituloAcceso.Name = "lblTituloAcceso";
            lblTituloAcceso.Size = new Size(107, 21);
            lblTituloAcceso.TabIndex = 6;
            lblTituloAcceso.Text = "Último acceso";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.5F);
            lblUsuario.ForeColor = Color.FromArgb(30, 42, 56);
            lblUsuario.Location = new Point(180, 140);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(19, 25);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "-";
            // 
            // lblCreado
            // 
            lblCreado.AutoSize = true;
            lblCreado.Font = new Font("Segoe UI", 10.5F);
            lblCreado.ForeColor = Color.FromArgb(30, 42, 56);
            lblCreado.Location = new Point(180, 210);
            lblCreado.Name = "lblCreado";
            lblCreado.Size = new Size(19, 25);
            lblCreado.TabIndex = 9;
            lblCreado.Text = "-";
            // 
            // lblUltimoAcceso
            // 
            lblUltimoAcceso.AutoSize = true;
            lblUltimoAcceso.Font = new Font("Segoe UI", 10.5F);
            lblUltimoAcceso.ForeColor = Color.FromArgb(30, 42, 56);
            lblUltimoAcceso.Location = new Point(180, 245);
            lblUltimoAcceso.Name = "lblUltimoAcceso";
            lblUltimoAcceso.Size = new Size(19, 25);
            lblUltimoAcceso.TabIndex = 10;
            lblUltimoAcceso.Text = "-";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.5F);
            lblCorreo.ForeColor = Color.FromArgb(30, 42, 56);
            lblCorreo.Location = new Point(180, 175);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(19, 25);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "-";
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(942, 533);
            Controls.Add(panel1);
            Name = "FrmPerfil";
            Text = "Mi perfil";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAvatar;
        private Label lblTituloAcceso;
        private Label lblTituloCreado;
        private Label lblTituloCorreo;
        private Label lblTituloUsuario;
        private Label lblRol;
        private Label lblNombre;
        private Label lblCorreo;
        private Label lblUltimoAcceso;
        private Label lblCreado;
        private Label lblUsuario;
    }
}