
namespace GoFitnessGym
{
    partial class modulo_de_registrar_clientes
    {
        /// <summary>
        /// Variable requerida por el Diseñador de Windows Forms.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libera los recursos utilizados.
        /// </summary>
        /// <param name="disposing">
        /// true para liberar los recursos administrados;
        /// false en caso contrario.
        /// </param>
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
        /// Método requerido por el Diseñador de Windows Forms.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.panel_card = new System.Windows.Forms.Panel();
            this.lbl_datos_personales = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_campos_obligatorios = new System.Windows.Forms.Label();
            this.pnl_foto_cliente = new System.Windows.Forms.Panel();
            this.lbl_foto_cliente = new System.Windows.Forms.Label();
            this.pic_foto_cliente = new System.Windows.Forms.PictureBox();
            this.lbl_sin_foto = new System.Windows.Forms.Label();
            this.lbl_ayuda_foto = new System.Windows.Forms.Label();
            this.btn_seleccionar_foto = new System.Windows.Forms.Button();
            this.btn_quitar_foto = new System.Windows.Forms.Button();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.ofd_foto_cliente = new System.Windows.Forms.OpenFileDialog();
            this.panel_card.SuspendLayout();
            this.pnl_foto_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_cliente)).BeginInit();
            this.pnl_acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lbl_titulo.Location = new System.Drawing.Point(22, 15);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(277, 35);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Registrar nuevo cliente";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(24, 48);
            this.lbl_subtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(295, 22);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Complete los datos personales del cliente";
            // 
            // panel_card
            // 
            this.panel_card.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_card.BackColor = System.Drawing.Color.White;
            this.panel_card.Controls.Add(this.lbl_datos_personales);
            this.panel_card.Controls.Add(this.lbl_codigo);
            this.panel_card.Controls.Add(this.txt_codigo);
            this.panel_card.Controls.Add(this.lbl_sexo);
            this.panel_card.Controls.Add(this.cbo_sexo);
            this.panel_card.Controls.Add(this.lbl_nombre);
            this.panel_card.Controls.Add(this.txt_nombre);
            this.panel_card.Controls.Add(this.lbl_apellido);
            this.panel_card.Controls.Add(this.txt_apellido);
            this.panel_card.Controls.Add(this.lbl_telefono);
            this.panel_card.Controls.Add(this.txt_telefono);
            this.panel_card.Controls.Add(this.lbl_correo);
            this.panel_card.Controls.Add(this.txt_correo);
            this.panel_card.Controls.Add(this.lbl_cedula);
            this.panel_card.Controls.Add(this.txt_cedula);
            this.panel_card.Controls.Add(this.lbl_fecha_nacimiento);
            this.panel_card.Controls.Add(this.dtp_fecha_nacimiento);
            this.panel_card.Controls.Add(this.lbl_direccion);
            this.panel_card.Controls.Add(this.txt_direccion);
            this.panel_card.Controls.Add(this.lbl_campos_obligatorios);
            this.panel_card.Location = new System.Drawing.Point(22, 84);
            this.panel_card.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_card.Name = "panel_card";
            this.panel_card.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.panel_card.Size = new System.Drawing.Size(458, 362);
            this.panel_card.TabIndex = 2;
            // 
            // lbl_datos_personales
            // 
            this.lbl_datos_personales.AutoSize = true;
            this.lbl_datos_personales.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos_personales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_datos_personales.Location = new System.Drawing.Point(15, 12);
            this.lbl_datos_personales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_datos_personales.Name = "lbl_datos_personales";
            this.lbl_datos_personales.Size = new System.Drawing.Size(144, 24);
            this.lbl_datos_personales.TabIndex = 0;
            this.lbl_datos_personales.Text = "Datos personales";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_codigo.Location = new System.Drawing.Point(15, 47);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(112, 19);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Código de socio:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.txt_codigo.Location = new System.Drawing.Point(15, 69);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(203, 23);
            this.txt_codigo.TabIndex = 2;
            this.txt_codigo.TabStop = false;
            this.txt_codigo.Text = "Se generará automáticamente";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_sexo.Location = new System.Drawing.Point(240, 47);
            this.lbl_sexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(48, 19);
            this.lbl_sexo.TabIndex = 3;
            this.lbl_sexo.Text = "Sexo *";
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_sexo.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(new object[] {
            "Seleccione...",
            "Masculino",
            "Femenino"});
            this.cbo_sexo.Location = new System.Drawing.Point(240, 67);
            this.cbo_sexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(200, 29);
            this.cbo_sexo.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_nombre.Location = new System.Drawing.Point(15, 106);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 19);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre *";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_nombre.Location = new System.Drawing.Point(15, 128);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nombre.MaxLength = 60;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(203, 23);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_apellido.Location = new System.Drawing.Point(240, 106);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(69, 19);
            this.lbl_apellido.TabIndex = 7;
            this.lbl_apellido.Text = "Apellido *";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_apellido.Location = new System.Drawing.Point(240, 128);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_apellido.MaxLength = 60;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(200, 23);
            this.txt_apellido.TabIndex = 2;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_telefono.Location = new System.Drawing.Point(15, 164);
            this.lbl_telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(72, 19);
            this.lbl_telefono.TabIndex = 9;
            this.lbl_telefono.Text = "Teléfono *";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_telefono.Location = new System.Drawing.Point(15, 186);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_telefono.MaxLength = 20;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(203, 23);
            this.txt_telefono.TabIndex = 3;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_correo.Location = new System.Drawing.Point(240, 164);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(124, 19);
            this.lbl_correo.TabIndex = 11;
            this.lbl_correo.Text = "Correo electrónico";
            // 
            // txt_correo
            // 
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_correo.Location = new System.Drawing.Point(240, 186);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_correo.MaxLength = 100;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(200, 23);
            this.txt_correo.TabIndex = 4;
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_cedula.Location = new System.Drawing.Point(15, 223);
            this.lbl_cedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(173, 19);
            this.lbl_cedula.TabIndex = 13;
            this.lbl_cedula.Text = "Documento de identidad *";
            // 
            // txt_cedula
            // 
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cedula.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_cedula.Location = new System.Drawing.Point(15, 245);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cedula.MaxLength = 20;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(203, 23);
            this.txt_cedula.TabIndex = 5;
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(240, 223);
            this.lbl_fecha_nacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(143, 19);
            this.lbl_fecha_nacimiento.TabIndex = 15;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.CalendarFont = new System.Drawing.Font("Lexend", 9F);
            this.dtp_fecha_nacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(240, 245);
            this.dtp_fecha_nacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtp_fecha_nacimiento.TabIndex = 6;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_direccion.Location = new System.Drawing.Point(15, 281);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(77, 19);
            this.lbl_direccion.TabIndex = 17;
            this.lbl_direccion.Text = "Dirección *";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_direccion.Location = new System.Drawing.Point(15, 303);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_direccion.MaxLength = 250;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_direccion.Size = new System.Drawing.Size(425, 36);
            this.txt_direccion.TabIndex = 7;
            // 
            // lbl_campos_obligatorios
            // 
            this.lbl_campos_obligatorios.AutoSize = true;
            this.lbl_campos_obligatorios.Font = new System.Drawing.Font("Lexend", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campos_obligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_campos_obligatorios.Location = new System.Drawing.Point(323, 341);
            this.lbl_campos_obligatorios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_campos_obligatorios.Name = "lbl_campos_obligatorios";
            this.lbl_campos_obligatorios.Size = new System.Drawing.Size(125, 17);
            this.lbl_campos_obligatorios.TabIndex = 19;
            this.lbl_campos_obligatorios.Text = "* Campos obligatorios";
            // 
            // pnl_foto_cliente
            // 
            this.pnl_foto_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_foto_cliente.BackColor = System.Drawing.Color.White;
            this.pnl_foto_cliente.Controls.Add(this.lbl_foto_cliente);
            this.pnl_foto_cliente.Controls.Add(this.pic_foto_cliente);
            this.pnl_foto_cliente.Controls.Add(this.lbl_sin_foto);
            this.pnl_foto_cliente.Controls.Add(this.lbl_ayuda_foto);
            this.pnl_foto_cliente.Controls.Add(this.btn_seleccionar_foto);
            this.pnl_foto_cliente.Controls.Add(this.btn_quitar_foto);
            this.pnl_foto_cliente.Location = new System.Drawing.Point(489, 84);
            this.pnl_foto_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_foto_cliente.Name = "pnl_foto_cliente";
            this.pnl_foto_cliente.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnl_foto_cliente.Size = new System.Drawing.Size(208, 362);
            this.pnl_foto_cliente.TabIndex = 3;
            // 
            // lbl_foto_cliente
            // 
            this.lbl_foto_cliente.AutoSize = true;
            this.lbl_foto_cliente.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_foto_cliente.Location = new System.Drawing.Point(15, 12);
            this.lbl_foto_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_foto_cliente.Name = "lbl_foto_cliente";
            this.lbl_foto_cliente.Size = new System.Drawing.Size(131, 24);
            this.lbl_foto_cliente.TabIndex = 0;
            this.lbl_foto_cliente.Text = "Foto del cliente";
            // 
            // pic_foto_cliente
            // 
            this.pic_foto_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pic_foto_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_foto_cliente.Location = new System.Drawing.Point(18, 47);
            this.pic_foto_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_foto_cliente.Name = "pic_foto_cliente";
            this.pic_foto_cliente.Size = new System.Drawing.Size(173, 187);
            this.pic_foto_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto_cliente.TabIndex = 1;
            this.pic_foto_cliente.TabStop = false;
            // 
            // lbl_sin_foto
            // 
            this.lbl_sin_foto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sin_foto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sin_foto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_sin_foto.Location = new System.Drawing.Point(33, 125);
            this.lbl_sin_foto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sin_foto.Name = "lbl_sin_foto";
            this.lbl_sin_foto.Size = new System.Drawing.Size(142, 28);
            this.lbl_sin_foto.TabIndex = 2;
            this.lbl_sin_foto.Text = "Sin foto seleccionada";
            this.lbl_sin_foto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ayuda_foto
            // 
            this.lbl_ayuda_foto.Font = new System.Drawing.Font("Lexend", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ayuda_foto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_ayuda_foto.Location = new System.Drawing.Point(18, 243);
            this.lbl_ayuda_foto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ayuda_foto.Name = "lbl_ayuda_foto";
            this.lbl_ayuda_foto.Size = new System.Drawing.Size(172, 37);
            this.lbl_ayuda_foto.TabIndex = 3;
            this.lbl_ayuda_foto.Text = "La fotografía es opcional.\r\nFormatos permitidos: JPG,PNG.";
            this.lbl_ayuda_foto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_seleccionar_foto
            // 
            this.btn_seleccionar_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_seleccionar_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_seleccionar_foto.FlatAppearance.BorderSize = 0;
            this.btn_seleccionar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccionar_foto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar_foto.ForeColor = System.Drawing.Color.White;
            this.btn_seleccionar_foto.Location = new System.Drawing.Point(18, 288);
            this.btn_seleccionar_foto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_seleccionar_foto.Name = "btn_seleccionar_foto";
            this.btn_seleccionar_foto.Size = new System.Drawing.Size(172, 31);
            this.btn_seleccionar_foto.TabIndex = 0;
            this.btn_seleccionar_foto.Text = "Seleccionar foto";
            this.btn_seleccionar_foto.UseVisualStyleBackColor = false;
            // 
            // btn_quitar_foto
            // 
            this.btn_quitar_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_quitar_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar_foto.FlatAppearance.BorderSize = 0;
            this.btn_quitar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar_foto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_foto.ForeColor = System.Drawing.Color.White;
            this.btn_quitar_foto.Location = new System.Drawing.Point(18, 323);
            this.btn_quitar_foto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_quitar_foto.Name = "btn_quitar_foto";
            this.btn_quitar_foto.Size = new System.Drawing.Size(172, 26);
            this.btn_quitar_foto.TabIndex = 1;
            this.btn_quitar_foto.Text = "Quitar foto";
            this.btn_quitar_foto.UseVisualStyleBackColor = false;
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_guardar);
            this.pnl_acciones.Controls.Add(this.btn_cancelar);
            this.pnl_acciones.Location = new System.Drawing.Point(22, 455);
            this.pnl_acciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnl_acciones.Size = new System.Drawing.Size(675, 57);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(542, 12);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(414, 12);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 32);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // ofd_foto_cliente
            // 
            this.ofd_foto_cliente.DefaultExt = "jpg";
            this.ofd_foto_cliente.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            this.ofd_foto_cliente.RestoreDirectory = true;
            this.ofd_foto_cliente.Title = "Seleccionar foto del cliente";
            // 
            // modulo_de_registrar_clientes
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(720, 531);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_foto_cliente);
            this.Controls.Add(this.panel_card);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_registrar_clientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Cliente - Go Fitness Gym";
            this.panel_card.ResumeLayout(false);
            this.panel_card.PerformLayout();
            this.pnl_foto_cliente.ResumeLayout(false);
            this.pnl_foto_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_cliente)).EndInit();
            this.pnl_acciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.Panel panel_card;
        private System.Windows.Forms.Label lbl_datos_personales;

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigo;

        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.ComboBox cbo_sexo;

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;

        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;

        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;

        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_correo;

        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.TextBox txt_cedula;

        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.DateTimePicker
            dtp_fecha_nacimiento;

        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios;

        private System.Windows.Forms.Panel pnl_foto_cliente;
        private System.Windows.Forms.Label lbl_foto_cliente;
        private System.Windows.Forms.PictureBox pic_foto_cliente;
        private System.Windows.Forms.Label lbl_sin_foto;
        private System.Windows.Forms.Label lbl_ayuda_foto;
        private System.Windows.Forms.Button btn_seleccionar_foto;
        private System.Windows.Forms.Button btn_quitar_foto;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;

        private System.Windows.Forms.OpenFileDialog
            ofd_foto_cliente;
    }
}