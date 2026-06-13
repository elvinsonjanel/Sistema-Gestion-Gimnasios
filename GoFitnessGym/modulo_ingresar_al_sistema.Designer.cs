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
            this.label_usuario = new System.Windows.Forms.Label();
            this.input_usuario = new System.Windows.Forms.TextBox();
            this.label_contrasena = new System.Windows.Forms.Label();
            this.input_contrasena = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iniciar_sesion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Lexend", 10F);
            this.label_usuario.Location = new System.Drawing.Point(212, 210);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(80, 27);
            this.label_usuario.TabIndex = 0;
            this.label_usuario.Text = "Usuario:";
            // 
            // input_usuario
            // 
            this.input_usuario.Font = new System.Drawing.Font("Lexend", 10F);
            this.input_usuario.Location = new System.Drawing.Point(320, 207);
            this.input_usuario.Name = "input_usuario";
            this.input_usuario.Size = new System.Drawing.Size(280, 28);
            this.input_usuario.TabIndex = 1;
            // 
            // label_contrasena
            // 
            this.label_contrasena.AutoSize = true;
            this.label_contrasena.Font = new System.Drawing.Font("Lexend", 10F);
            this.label_contrasena.Location = new System.Drawing.Point(196, 267);
            this.label_contrasena.Name = "label_contrasena";
            this.label_contrasena.Size = new System.Drawing.Size(112, 27);
            this.label_contrasena.TabIndex = 2;
            this.label_contrasena.Text = "Contraseña:";
            // 
            // input_contrasena
            // 
            this.input_contrasena.Font = new System.Drawing.Font("Lexend", 10F);
            this.input_contrasena.Location = new System.Drawing.Point(320, 266);
            this.input_contrasena.Name = "input_contrasena";
            this.input_contrasena.PasswordChar = '•';
            this.input_contrasena.Size = new System.Drawing.Size(280, 28);
            this.input_contrasena.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lexend", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(270, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Go Fitness GYM";
            // 
            // iniciar_sesion
            // 
            this.iniciar_sesion.AutoSize = true;
            this.iniciar_sesion.Font = new System.Drawing.Font("Lexend", 10F);
            this.iniciar_sesion.ForeColor = System.Drawing.Color.Gray;
            this.iniciar_sesion.Location = new System.Drawing.Point(330, 95);
            this.iniciar_sesion.Name = "iniciar_sesion";
            this.iniciar_sesion.Size = new System.Drawing.Size(126, 27);
            this.iniciar_sesion.TabIndex = 7;
            this.iniciar_sesion.Text = "Iniciar Sesión";
            // 
            // modulo_ingresar_al_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iniciar_sesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.input_contrasena);
            this.Controls.Add(this.label_contrasena);
            this.Controls.Add(this.input_usuario);
            this.Controls.Add(this.label_usuario);
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

        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.TextBox input_usuario;
        private System.Windows.Forms.Label label_contrasena;
        private System.Windows.Forms.TextBox input_contrasena;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label iniciar_sesion;
    }
}