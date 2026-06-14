namespace GoFitnessGym
{
    partial class modulo_ingresar_al_sistema
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_iniciar_sesion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_usuario.Location = new System.Drawing.Point(212, 210);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(80, 27);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_usuario.Location = new System.Drawing.Point(320, 207);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(280, 28);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_contrasena.Location = new System.Drawing.Point(196, 267);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(112, 27);
            this.lbl_contrasena.TabIndex = 2;
            this.lbl_contrasena.Text = "Contraseña:";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_contrasena.Location = new System.Drawing.Point(320, 266);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '•';
            this.txt_contrasena.Size = new System.Drawing.Size(280, 28);
            this.txt_contrasena.TabIndex = 3;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.Navy;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Location = new System.Drawing.Point(280, 355);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(240, 40);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbl_titulo.Location = new System.Drawing.Point(270, 40);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(259, 48);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Go Fitness GYM";
            // 
            // lbl_iniciar_sesion
            // 
            this.lbl_iniciar_sesion.AutoSize = true;
            this.lbl_iniciar_sesion.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_iniciar_sesion.ForeColor = System.Drawing.Color.Gray;
            this.lbl_iniciar_sesion.Location = new System.Drawing.Point(330, 95);
            this.lbl_iniciar_sesion.Name = "lbl_iniciar_sesion";
            this.lbl_iniciar_sesion.Size = new System.Drawing.Size(126, 27);
            this.lbl_iniciar_sesion.TabIndex = 7;
            this.lbl_iniciar_sesion.Text = "Iniciar Sesión";
            // 
            // modulo_ingresar_al_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_iniciar_sesion);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_ingresar_al_sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar al Sistema - Go Fitness";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_iniciar_sesion;
    }
}