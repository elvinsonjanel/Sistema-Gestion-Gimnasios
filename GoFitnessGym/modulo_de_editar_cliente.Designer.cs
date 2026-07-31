
namespace GoFitnessGym
{
    partial class modulo_de_editar_cliente
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
            this.pnl_datos_personales = new System.Windows.Forms.Panel();
            this.lbl_datos_personales = new System.Windows.Forms.Label();
            this.lbl_codigo_cliente = new System.Windows.Forms.Label();
            this.txt_codigo_cliente = new System.Windows.Forms.TextBox();
            this.lbl_ayuda_codigo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_documento_identidad = new System.Windows.Forms.Label();
            this.txt_documento_identidad = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_correo_electronico = new System.Windows.Forms.Label();
            this.txt_correo_electronico = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnl_datos_personales.SuspendLayout();
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
            this.lbl_titulo.Location = new System.Drawing.Point(30, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(205, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Editar cliente";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 59);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(422, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Modifique la información del cliente seleccionado";
            // 
            // pnl_datos_personales
            // 
            this.pnl_datos_personales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_datos_personales.BackColor = System.Drawing.Color.White;
            this.pnl_datos_personales.Controls.Add(this.comboBox1);
            this.pnl_datos_personales.Controls.Add(this.label1);
            this.pnl_datos_personales.Controls.Add(this.lbl_datos_personales);
            this.pnl_datos_personales.Controls.Add(this.lbl_codigo_cliente);
            this.pnl_datos_personales.Controls.Add(this.txt_codigo_cliente);
            this.pnl_datos_personales.Controls.Add(this.lbl_ayuda_codigo);
            this.pnl_datos_personales.Controls.Add(this.lbl_nombre);
            this.pnl_datos_personales.Controls.Add(this.lbl_documento_identidad);
            this.pnl_datos_personales.Controls.Add(this.txt_documento_identidad);
            this.pnl_datos_personales.Controls.Add(this.txt_nombre);
            this.pnl_datos_personales.Controls.Add(this.lbl_apellido);
            this.pnl_datos_personales.Controls.Add(this.txt_apellido);
            this.pnl_datos_personales.Controls.Add(this.lbl_sexo);
            this.pnl_datos_personales.Controls.Add(this.cbo_sexo);
            this.pnl_datos_personales.Controls.Add(this.lbl_fecha_nacimiento);
            this.pnl_datos_personales.Controls.Add(this.dtp_fecha_nacimiento);
            this.pnl_datos_personales.Controls.Add(this.lbl_telefono);
            this.pnl_datos_personales.Controls.Add(this.txt_telefono);
            this.pnl_datos_personales.Controls.Add(this.lbl_correo_electronico);
            this.pnl_datos_personales.Controls.Add(this.txt_correo_electronico);
            this.pnl_datos_personales.Controls.Add(this.lbl_direccion);
            this.pnl_datos_personales.Controls.Add(this.txt_direccion);
            this.pnl_datos_personales.Controls.Add(this.lbl_campos_obligatorios);
            this.pnl_datos_personales.Location = new System.Drawing.Point(30, 103);
            this.pnl_datos_personales.Name = "pnl_datos_personales";
            this.pnl_datos_personales.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_datos_personales.Size = new System.Drawing.Size(760, 445);
            this.pnl_datos_personales.TabIndex = 2;
            // 
            // lbl_datos_personales
            // 
            this.lbl_datos_personales.AutoSize = true;
            this.lbl_datos_personales.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos_personales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_datos_personales.Location = new System.Drawing.Point(20, 15);
            this.lbl_datos_personales.Name = "lbl_datos_personales";
            this.lbl_datos_personales.Size = new System.Drawing.Size(181, 30);
            this.lbl_datos_personales.TabIndex = 0;
            this.lbl_datos_personales.Text = "Datos personales";
            // 
            // lbl_codigo_cliente
            // 
            this.lbl_codigo_cliente.AutoSize = true;
            this.lbl_codigo_cliente.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_codigo_cliente.Location = new System.Drawing.Point(20, 57);
            this.lbl_codigo_cliente.Name = "lbl_codigo_cliente";
            this.lbl_codigo_cliente.Size = new System.Drawing.Size(155, 24);
            this.lbl_codigo_cliente.TabIndex = 1;
            this.lbl_codigo_cliente.Text = "Código del cliente:";
            // 
            // txt_codigo_cliente
            // 
            this.txt_codigo_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_codigo_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo_cliente.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.txt_codigo_cliente.Location = new System.Drawing.Point(20, 84);
            this.txt_codigo_cliente.Name = "txt_codigo_cliente";
            this.txt_codigo_cliente.ReadOnly = true;
            this.txt_codigo_cliente.Size = new System.Drawing.Size(220, 28);
            this.txt_codigo_cliente.TabIndex = 2;
            this.txt_codigo_cliente.TabStop = false;
            // 
            // lbl_ayuda_codigo
            // 
            this.lbl_ayuda_codigo.AutoSize = true;
            this.lbl_ayuda_codigo.Font = new System.Drawing.Font("Lexend", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ayuda_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_ayuda_codigo.Location = new System.Drawing.Point(20, 115);
            this.lbl_ayuda_codigo.Name = "lbl_ayuda_codigo";
            this.lbl_ayuda_codigo.Size = new System.Drawing.Size(229, 22);
            this.lbl_ayuda_codigo.TabIndex = 3;
            this.lbl_ayuda_codigo.Text = "El código no puede modificarse.";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_nombre.Location = new System.Drawing.Point(270, 54);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(88, 24);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre: *";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_nombre.Location = new System.Drawing.Point(270, 84);
            this.txt_nombre.MaxLength = 60;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(220, 28);
            this.txt_nombre.TabIndex = 0;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_apellido.Location = new System.Drawing.Point(520, 57);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(90, 24);
            this.lbl_apellido.TabIndex = 7;
            this.lbl_apellido.Text = "Apellido: *";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_apellido.Location = new System.Drawing.Point(520, 84);
            this.txt_apellido.MaxLength = 60;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(216, 28);
            this.txt_apellido.TabIndex = 1;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_sexo.Location = new System.Drawing.Point(20, 153);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(64, 24);
            this.lbl_sexo.TabIndex = 10;
            this.lbl_sexo.Text = "Sexo: *";
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_sexo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbo_sexo.Location = new System.Drawing.Point(20, 180);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(220, 35);
            this.cbo_sexo.TabIndex = 2;
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(270, 153);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(176, 24);
            this.lbl_fecha_nacimiento.TabIndex = 13;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(270, 180);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(220, 28);
            this.dtp_fecha_nacimiento.TabIndex = 3;
            // 
            // lbl_documento_identidad
            // 
            this.lbl_documento_identidad.AutoSize = true;
            this.lbl_documento_identidad.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento_identidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_documento_identidad.Location = new System.Drawing.Point(270, 237);
            this.lbl_documento_identidad.Name = "lbl_documento_identidad";
            this.lbl_documento_identidad.Size = new System.Drawing.Size(219, 24);
            this.lbl_documento_identidad.TabIndex = 15;
            this.lbl_documento_identidad.Text = "Documento de identidad: *";
            // 
            // txt_documento_identidad
            // 
            this.txt_documento_identidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_documento_identidad.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_documento_identidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_documento_identidad.Location = new System.Drawing.Point(270, 264);
            this.txt_documento_identidad.MaxLength = 20;
            this.txt_documento_identidad.Name = "txt_documento_identidad";
            this.txt_documento_identidad.Size = new System.Drawing.Size(216, 28);
            this.txt_documento_identidad.TabIndex = 4;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_telefono.Location = new System.Drawing.Point(512, 153);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(94, 24);
            this.lbl_telefono.TabIndex = 18;
            this.lbl_telefono.Text = "Teléfono: *";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_telefono.Location = new System.Drawing.Point(512, 180);
            this.txt_telefono.MaxLength = 20;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(220, 28);
            this.txt_telefono.TabIndex = 5;
            // 
            // lbl_correo_electronico
            // 
            this.lbl_correo_electronico.AutoSize = true;
            this.lbl_correo_electronico.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo_electronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_correo_electronico.Location = new System.Drawing.Point(516, 237);
            this.lbl_correo_electronico.Name = "lbl_correo_electronico";
            this.lbl_correo_electronico.Size = new System.Drawing.Size(159, 24);
            this.lbl_correo_electronico.TabIndex = 21;
            this.lbl_correo_electronico.Text = "Correo electrónico:";
            // 
            // txt_correo_electronico
            // 
            this.txt_correo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo_electronico.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo_electronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_correo_electronico.Location = new System.Drawing.Point(516, 264);
            this.txt_correo_electronico.MaxLength = 100;
            this.txt_correo_electronico.Name = "txt_correo_electronico";
            this.txt_correo_electronico.Size = new System.Drawing.Size(220, 28);
            this.txt_correo_electronico.TabIndex = 6;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_direccion.Location = new System.Drawing.Point(20, 319);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(100, 24);
            this.lbl_direccion.TabIndex = 23;
            this.lbl_direccion.Text = "Dirección: *";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_direccion.Location = new System.Drawing.Point(20, 346);
            this.txt_direccion.MaxLength = 250;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_direccion.Size = new System.Drawing.Size(716, 55);
            this.txt_direccion.TabIndex = 7;
            // 
            // lbl_campos_obligatorios
            // 
            this.lbl_campos_obligatorios.AutoSize = true;
            this.lbl_campos_obligatorios.Font = new System.Drawing.Font("Lexend", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campos_obligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_campos_obligatorios.Location = new System.Drawing.Point(581, 409);
            this.lbl_campos_obligatorios.Name = "lbl_campos_obligatorios";
            this.lbl_campos_obligatorios.Size = new System.Drawing.Size(164, 22);
            this.lbl_campos_obligatorios.TabIndex = 26;
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
            this.pnl_foto_cliente.Location = new System.Drawing.Point(802, 103);
            this.pnl_foto_cliente.Name = "pnl_foto_cliente";
            this.pnl_foto_cliente.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_foto_cliente.Size = new System.Drawing.Size(268, 445);
            this.pnl_foto_cliente.TabIndex = 3;
            // 
            // lbl_foto_cliente
            // 
            this.lbl_foto_cliente.AutoSize = true;
            this.lbl_foto_cliente.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_foto_cliente.Location = new System.Drawing.Point(20, 15);
            this.lbl_foto_cliente.Name = "lbl_foto_cliente";
            this.lbl_foto_cliente.Size = new System.Drawing.Size(162, 30);
            this.lbl_foto_cliente.TabIndex = 0;
            this.lbl_foto_cliente.Text = "Foto del cliente";
            // 
            // pic_foto_cliente
            // 
            this.pic_foto_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pic_foto_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_foto_cliente.Location = new System.Drawing.Point(24, 58);
            this.pic_foto_cliente.Name = "pic_foto_cliente";
            this.pic_foto_cliente.Size = new System.Drawing.Size(220, 230);
            this.pic_foto_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto_cliente.TabIndex = 1;
            this.pic_foto_cliente.TabStop = false;
            // 
            // lbl_sin_foto
            // 
            this.lbl_sin_foto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sin_foto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sin_foto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_sin_foto.Location = new System.Drawing.Point(39, 150);
            this.lbl_sin_foto.Name = "lbl_sin_foto";
            this.lbl_sin_foto.Size = new System.Drawing.Size(190, 45);
            this.lbl_sin_foto.TabIndex = 2;
            this.lbl_sin_foto.Text = "Cliente sin fotografía";
            this.lbl_sin_foto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ayuda_foto
            // 
            this.lbl_ayuda_foto.Font = new System.Drawing.Font("Lexend", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ayuda_foto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_ayuda_foto.Location = new System.Drawing.Point(24, 299);
            this.lbl_ayuda_foto.Name = "lbl_ayuda_foto";
            this.lbl_ayuda_foto.Size = new System.Drawing.Size(220, 42);
            this.lbl_ayuda_foto.TabIndex = 3;
            this.lbl_ayuda_foto.Text = "La fotografía es opcional.\r\nFormatos permitidos: JPG y PNG.";
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
            this.btn_seleccionar_foto.Location = new System.Drawing.Point(24, 354);
            this.btn_seleccionar_foto.Name = "btn_seleccionar_foto";
            this.btn_seleccionar_foto.Size = new System.Drawing.Size(220, 38);
            this.btn_seleccionar_foto.TabIndex = 0;
            this.btn_seleccionar_foto.Text = "Cambiar foto";
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
            this.btn_quitar_foto.Location = new System.Drawing.Point(24, 398);
            this.btn_quitar_foto.Name = "btn_quitar_foto";
            this.btn_quitar_foto.Size = new System.Drawing.Size(220, 32);
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
            this.pnl_acciones.Location = new System.Drawing.Point(30, 560);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size = new System.Drawing.Size(1040, 70);
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
            this.btn_guardar.Location = new System.Drawing.Point(877, 15);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(145, 40);
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
            this.btn_cancelar.Location = new System.Drawing.Point(722, 15);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(145, 40);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(23, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo de Documento: *";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cédula de Identidad (Nacional)",
            "Pasaporte",
            "Cédula de Extranjero"});
            this.comboBox1.Location = new System.Drawing.Point(25, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 35);
            this.comboBox1.TabIndex = 30;
            // 
            // modulo_de_editar_cliente
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(1100, 653);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_foto_cliente);
            this.Controls.Add(this.pnl_datos_personales);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_editar_cliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Cliente - Go Fitness Gym";
            this.pnl_datos_personales.ResumeLayout(false);
            this.pnl_datos_personales.PerformLayout();
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

        private System.Windows.Forms.Panel pnl_datos_personales;
        private System.Windows.Forms.Label lbl_datos_personales;

        private System.Windows.Forms.Label lbl_codigo_cliente;
        private System.Windows.Forms.TextBox txt_codigo_cliente;
        private System.Windows.Forms.Label lbl_ayuda_codigo;

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;

        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;

        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.ComboBox cbo_sexo;

        private System.Windows.Forms.Label lbl_fecha_nacimiento;

        private System.Windows.Forms.DateTimePicker
            dtp_fecha_nacimiento;

        private System.Windows.Forms.Label
            lbl_documento_identidad;

        private System.Windows.Forms.TextBox
            txt_documento_identidad;

        private System.Windows.Forms.Label lbl_telefono;

        private System.Windows.Forms.TextBox txt_telefono;

        private System.Windows.Forms.Label
            lbl_correo_electronico;

        private System.Windows.Forms.TextBox
            txt_correo_electronico;

        private System.Windows.Forms.Label lbl_direccion;

        private System.Windows.Forms.TextBox txt_direccion;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios;

        private System.Windows.Forms.Panel pnl_foto_cliente;
        private System.Windows.Forms.Label lbl_foto_cliente;

        private System.Windows.Forms.PictureBox
            pic_foto_cliente;

        private System.Windows.Forms.Label lbl_sin_foto;
        private System.Windows.Forms.Label lbl_ayuda_foto;

        private System.Windows.Forms.Button
            btn_seleccionar_foto;

        private System.Windows.Forms.Button
            btn_quitar_foto;

        private System.Windows.Forms.OpenFileDialog
            ofd_foto_cliente;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}