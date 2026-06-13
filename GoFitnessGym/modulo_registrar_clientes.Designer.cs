namespace GoFitnessGym
{
    partial class modulo_registrar_clientes
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.panel_card = new System.Windows.Forms.Panel();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lbl_titulo.Location = new System.Drawing.Point(39, 22);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(347, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Registrar Nuevo Cliente";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(42, 65);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(303, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Complete los datos del nuevo socio";
            // 
            // panel_card
            // 
            this.panel_card.BackColor = System.Drawing.Color.White;
            this.panel_card.Controls.Add(this.lbl_codigo);
            this.panel_card.Controls.Add(this.txt_codigo);
            this.panel_card.Controls.Add(this.lbl_sexo);
            this.panel_card.Controls.Add(this.cbo_sexo);
            this.panel_card.Controls.Add(this.lbl_nombre);
            this.panel_card.Controls.Add(this.txt_nombre);
            this.panel_card.Controls.Add(this.lbl_telefono);
            this.panel_card.Controls.Add(this.txt_telefono);
            this.panel_card.Controls.Add(this.lbl_apellido);
            this.panel_card.Controls.Add(this.txt_apellido);
            this.panel_card.Controls.Add(this.lbl_correo);
            this.panel_card.Controls.Add(this.txt_correo);
            this.panel_card.Controls.Add(this.lbl_cedula);
            this.panel_card.Controls.Add(this.txt_cedula);
            this.panel_card.Controls.Add(this.lbl_direccion);
            this.panel_card.Controls.Add(this.txt_direccion);
            this.panel_card.Controls.Add(this.lbl_fecha_nacimiento);
            this.panel_card.Controls.Add(this.dtp_fecha_nacimiento);
            this.panel_card.Location = new System.Drawing.Point(40, 100);
            this.panel_card.Name = "panel_card";
            this.panel_card.Padding = new System.Windows.Forms.Padding(30);
            this.panel_card.Size = new System.Drawing.Size(770, 450);
            this.panel_card.TabIndex = 2;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_codigo.Location = new System.Drawing.Point(30, 20);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(128, 24);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código de Socio";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.txt_codigo.Location = new System.Drawing.Point(30, 45);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(340, 28);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.Text = "Se generará automáticamente";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_sexo.Location = new System.Drawing.Point(400, 20);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(45, 24);
            this.lbl_sexo.TabIndex = 2;
            this.lbl_sexo.Text = "Sexo";
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_sexo.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(new object[] {
            "Seleccione...",
            "Masculino",
            "Femenino"});
            this.cbo_sexo.Location = new System.Drawing.Point(400, 45);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(340, 35);
            this.cbo_sexo.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_nombre.Location = new System.Drawing.Point(30, 90);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(79, 24);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre *";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_nombre.Location = new System.Drawing.Point(30, 115);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(340, 28);
            this.txt_nombre.TabIndex = 5;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_telefono.Location = new System.Drawing.Point(400, 90);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(169, 24);
            this.lbl_telefono.TabIndex = 6;
            this.lbl_telefono.Text = "Número de Teléfono *";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_telefono.Location = new System.Drawing.Point(400, 115);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(340, 28);
            this.txt_telefono.TabIndex = 7;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_apellido.Location = new System.Drawing.Point(30, 160);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(79, 24);
            this.lbl_apellido.TabIndex = 8;
            this.lbl_apellido.Text = "Apellido *";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_apellido.Location = new System.Drawing.Point(30, 185);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(340, 28);
            this.txt_apellido.TabIndex = 9;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_correo.Location = new System.Drawing.Point(400, 160);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(144, 24);
            this.lbl_correo.TabIndex = 10;
            this.lbl_correo.Text = "Correo Electrónico";
            // 
            // txt_correo
            // 
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_correo.Location = new System.Drawing.Point(400, 185);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(340, 28);
            this.txt_correo.TabIndex = 11;
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_cedula.Location = new System.Drawing.Point(30, 230);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(172, 24);
            this.lbl_cedula.TabIndex = 12;
            this.lbl_cedula.Text = "Cédula de Identidad *";
            // 
            // txt_cedula
            // 
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cedula.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_cedula.Location = new System.Drawing.Point(30, 255);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(340, 28);
            this.txt_cedula.TabIndex = 13;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_direccion.Location = new System.Drawing.Point(400, 230);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(88, 24);
            this.lbl_direccion.TabIndex = 14;
            this.lbl_direccion.Text = "Dirección *";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_direccion.Location = new System.Drawing.Point(400, 255);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(340, 70);
            this.txt_direccion.TabIndex = 15;
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_fecha_nacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(30, 300);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(165, 24);
            this.lbl_fecha_nacimiento.TabIndex = 16;
            this.lbl_fecha_nacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.CalendarFont = new System.Drawing.Font("Lexend", 10F);
            this.dtp_fecha_nacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Lexend", 10F);
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(30, 325);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(340, 28);
            this.dtp_fecha_nacimiento.TabIndex = 17;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(530, 569);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(130, 45);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(680, 570);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(130, 45);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // modulo_registrar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.panel_card);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_registrar_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Cliente - Go Fitness";
            this.panel_card.ResumeLayout(false);
            this.panel_card.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel panel_card;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.ComboBox cbo_sexo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
    }
}