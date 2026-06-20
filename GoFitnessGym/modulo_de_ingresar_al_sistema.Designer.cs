namespace GoFitnessGym
{
    partial class modulo_de_ingresar_al_sistema
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
            this.lbl_usuario.Location = new System.Drawing.Point(159, 171);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(66, 22);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_usuario.Location = new System.Drawing.Point(240, 168);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(211, 24);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_contrasena.Location = new System.Drawing.Point(147, 217);
            this.lbl_contrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(92, 22);
            this.lbl_contrasena.TabIndex = 2;
            this.lbl_contrasena.Text = "Contraseña:";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_contrasena.Location = new System.Drawing.Point(240, 216);
            this.txt_contrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '•';
            this.txt_contrasena.Size = new System.Drawing.Size(211, 24);
            this.txt_contrasena.TabIndex = 3;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.Navy;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Location = new System.Drawing.Point(210, 288);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(180, 32);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbl_titulo.Location = new System.Drawing.Point(202, 32);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(209, 38);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Go Fitness GYM";
            // 
            // lbl_iniciar_sesion
            // 
            this.lbl_iniciar_sesion.AutoSize = true;
            this.lbl_iniciar_sesion.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_iniciar_sesion.ForeColor = System.Drawing.Color.Gray;
            this.lbl_iniciar_sesion.Location = new System.Drawing.Point(248, 77);
            this.lbl_iniciar_sesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_iniciar_sesion.Name = "lbl_iniciar_sesion";
            this.lbl_iniciar_sesion.Size = new System.Drawing.Size(104, 22);
            this.lbl_iniciar_sesion.TabIndex = 7;
            this.lbl_iniciar_sesion.Text = "Iniciar Sesión";
            // 
            // modulo_de_ingresar_al_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbl_iniciar_sesion);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_ingresar_al_sistema";
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