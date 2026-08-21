
namespace GoFitnessGym
{
    partial class detalle_de_cliente
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.txt_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.lbl_documento_identidad = new System.Windows.Forms.Label();
            this.txt_documento_identidad = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_correo_electronico = new System.Windows.Forms.Label();
            this.txt_correo_electronico = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.pnl_foto_cliente = new System.Windows.Forms.Panel();
            this.lbl_foto_cliente = new System.Windows.Forms.Label();
            this.pic_foto_cliente = new System.Windows.Forms.PictureBox();
            this.lbl_sin_foto = new System.Windows.Forms.Label();
            this.lbl_ayuda_foto = new System.Windows.Forms.Label();
            this.pnl_membresia = new System.Windows.Forms.Panel();
            this.lbl_informacion_membresia = new System.Windows.Forms.Label();
            this.lbl_membresia = new System.Windows.Forms.Label();
            this.txt_membresia = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_fecha_inicio = new System.Windows.Forms.Label();
            this.txt_fecha_inicio = new System.Windows.Forms.TextBox();
            this.lbl_fecha_vencimiento = new System.Windows.Forms.Label();
            this.txt_fecha_vencimiento = new System.Windows.Forms.TextBox();
            this.lbl_saldo_pendiente = new System.Windows.Forms.Label();
            this.txt_saldo_pendiente = new System.Windows.Forms.TextBox();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_datos_personales.SuspendLayout();
            this.pnl_foto_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_cliente)).BeginInit();
            this.pnl_membresia.SuspendLayout();
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
            this.lbl_titulo.Size = new System.Drawing.Size(269, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Detalle del cliente";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 59);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(507, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Consulte la información personal y la membresía del cliente";
            // 
            // pnl_datos_personales
            // 
            this.pnl_datos_personales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_datos_personales.BackColor = System.Drawing.Color.White;
            this.pnl_datos_personales.Controls.Add(this.textBox1);
            this.pnl_datos_personales.Controls.Add(this.label1);
            this.pnl_datos_personales.Controls.Add(this.lbl_datos_personales);
            this.pnl_datos_personales.Controls.Add(this.lbl_codigo_cliente);
            this.pnl_datos_personales.Controls.Add(this.txt_codigo_cliente);
            this.pnl_datos_personales.Controls.Add(this.lbl_nombre);
            this.pnl_datos_personales.Controls.Add(this.lbl_documento_identidad);
            this.pnl_datos_personales.Controls.Add(this.txt_nombre);
            this.pnl_datos_personales.Controls.Add(this.txt_documento_identidad);
            this.pnl_datos_personales.Controls.Add(this.lbl_apellido);
            this.pnl_datos_personales.Controls.Add(this.txt_apellido);
            this.pnl_datos_personales.Controls.Add(this.lbl_sexo);
            this.pnl_datos_personales.Controls.Add(this.txt_sexo);
            this.pnl_datos_personales.Controls.Add(this.lbl_fecha_nacimiento);
            this.pnl_datos_personales.Controls.Add(this.txt_fecha_nacimiento);
            this.pnl_datos_personales.Controls.Add(this.lbl_telefono);
            this.pnl_datos_personales.Controls.Add(this.txt_telefono);
            this.pnl_datos_personales.Controls.Add(this.lbl_correo_electronico);
            this.pnl_datos_personales.Controls.Add(this.txt_correo_electronico);
            this.pnl_datos_personales.Controls.Add(this.lbl_direccion);
            this.pnl_datos_personales.Controls.Add(this.txt_direccion);
            this.pnl_datos_personales.Location = new System.Drawing.Point(30, 103);
            this.pnl_datos_personales.Name = "pnl_datos_personales";
            this.pnl_datos_personales.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_datos_personales.Size = new System.Drawing.Size(760, 365);
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
            this.txt_codigo_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_codigo_cliente.Location = new System.Drawing.Point(20, 84);
            this.txt_codigo_cliente.Name = "txt_codigo_cliente";
            this.txt_codigo_cliente.ReadOnly = true;
            this.txt_codigo_cliente.Size = new System.Drawing.Size(220, 28);
            this.txt_codigo_cliente.TabIndex = 2;
            this.txt_codigo_cliente.TabStop = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_nombre.Location = new System.Drawing.Point(270, 57);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(76, 24);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_nombre.Location = new System.Drawing.Point(270, 84);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(220, 28);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.TabStop = false;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_apellido.Location = new System.Drawing.Point(520, 57);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(78, 24);
            this.lbl_apellido.TabIndex = 5;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_apellido.Location = new System.Drawing.Point(520, 84);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(216, 28);
            this.txt_apellido.TabIndex = 6;
            this.txt_apellido.TabStop = false;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_sexo.Location = new System.Drawing.Point(20, 130);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(52, 24);
            this.lbl_sexo.TabIndex = 7;
            this.lbl_sexo.Text = "Sexo:";
            // 
            // txt_sexo
            // 
            this.txt_sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_sexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sexo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_sexo.Location = new System.Drawing.Point(20, 157);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.ReadOnly = true;
            this.txt_sexo.Size = new System.Drawing.Size(220, 28);
            this.txt_sexo.TabIndex = 8;
            this.txt_sexo.TabStop = false;
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(270, 130);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(176, 24);
            this.lbl_fecha_nacimiento.TabIndex = 9;
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento:";
            // 
            // txt_fecha_nacimiento
            // 
            this.txt_fecha_nacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_fecha_nacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fecha_nacimiento.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_nacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_fecha_nacimiento.Location = new System.Drawing.Point(270, 157);
            this.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento";
            this.txt_fecha_nacimiento.ReadOnly = true;
            this.txt_fecha_nacimiento.Size = new System.Drawing.Size(220, 28);
            this.txt_fecha_nacimiento.TabIndex = 10;
            this.txt_fecha_nacimiento.TabStop = false;
            // 
            // lbl_documento_identidad
            // 
            this.lbl_documento_identidad.AutoSize = true;
            this.lbl_documento_identidad.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento_identidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_documento_identidad.Location = new System.Drawing.Point(274, 203);
            this.lbl_documento_identidad.Name = "lbl_documento_identidad";
            this.lbl_documento_identidad.Size = new System.Drawing.Size(207, 24);
            this.lbl_documento_identidad.TabIndex = 11;
            this.lbl_documento_identidad.Text = "Documento de identidad:";
            // 
            // txt_documento_identidad
            // 
            this.txt_documento_identidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_documento_identidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_documento_identidad.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_documento_identidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_documento_identidad.Location = new System.Drawing.Point(274, 230);
            this.txt_documento_identidad.Name = "txt_documento_identidad";
            this.txt_documento_identidad.ReadOnly = true;
            this.txt_documento_identidad.Size = new System.Drawing.Size(216, 28);
            this.txt_documento_identidad.TabIndex = 12;
            this.txt_documento_identidad.TabStop = false;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_telefono.Location = new System.Drawing.Point(516, 130);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(82, 24);
            this.lbl_telefono.TabIndex = 13;
            this.lbl_telefono.Text = "Teléfono:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_telefono.Location = new System.Drawing.Point(516, 157);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(220, 28);
            this.txt_telefono.TabIndex = 14;
            this.txt_telefono.TabStop = false;
            // 
            // lbl_correo_electronico
            // 
            this.lbl_correo_electronico.AutoSize = true;
            this.lbl_correo_electronico.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo_electronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_correo_electronico.Location = new System.Drawing.Point(512, 203);
            this.lbl_correo_electronico.Name = "lbl_correo_electronico";
            this.lbl_correo_electronico.Size = new System.Drawing.Size(159, 24);
            this.lbl_correo_electronico.TabIndex = 15;
            this.lbl_correo_electronico.Text = "Correo electrónico:";
            // 
            // txt_correo_electronico
            // 
            this.txt_correo_electronico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_correo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo_electronico.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo_electronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_correo_electronico.Location = new System.Drawing.Point(512, 230);
            this.txt_correo_electronico.Name = "txt_correo_electronico";
            this.txt_correo_electronico.ReadOnly = true;
            this.txt_correo_electronico.Size = new System.Drawing.Size(220, 28);
            this.txt_correo_electronico.TabIndex = 16;
            this.txt_correo_electronico.TabStop = false;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_direccion.Location = new System.Drawing.Point(20, 276);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(88, 24);
            this.lbl_direccion.TabIndex = 17;
            this.lbl_direccion.Text = "Dirección:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_direccion.Location = new System.Drawing.Point(20, 303);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ReadOnly = true;
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_direccion.Size = new System.Drawing.Size(716, 40);
            this.txt_direccion.TabIndex = 18;
            this.txt_direccion.TabStop = false;
            // 
            // pnl_foto_cliente
            // 
            this.pnl_foto_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_foto_cliente.BackColor = System.Drawing.Color.White;
            this.pnl_foto_cliente.Controls.Add(this.lbl_foto_cliente);
            this.pnl_foto_cliente.Controls.Add(this.pic_foto_cliente);
            this.pnl_foto_cliente.Controls.Add(this.lbl_sin_foto);
            this.pnl_foto_cliente.Controls.Add(this.lbl_ayuda_foto);
            this.pnl_foto_cliente.Location = new System.Drawing.Point(802, 103);
            this.pnl_foto_cliente.Name = "pnl_foto_cliente";
            this.pnl_foto_cliente.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_foto_cliente.Size = new System.Drawing.Size(268, 365);
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
            this.pic_foto_cliente.Size = new System.Drawing.Size(220, 240);
            this.pic_foto_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto_cliente.TabIndex = 1;
            this.pic_foto_cliente.TabStop = false;
            // 
            // lbl_sin_foto
            // 
            this.lbl_sin_foto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sin_foto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sin_foto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_sin_foto.Location = new System.Drawing.Point(39, 155);
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
            this.lbl_ayuda_foto.Location = new System.Drawing.Point(24, 307);
            this.lbl_ayuda_foto.Name = "lbl_ayuda_foto";
            this.lbl_ayuda_foto.Size = new System.Drawing.Size(220, 40);
            this.lbl_ayuda_foto.TabIndex = 3;
            this.lbl_ayuda_foto.Text = "Fotografía del perfil.";
            this.lbl_ayuda_foto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_membresia
            // 
            this.pnl_membresia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_membresia.BackColor = System.Drawing.Color.White;
            this.pnl_membresia.Controls.Add(this.lbl_informacion_membresia);
            this.pnl_membresia.Controls.Add(this.lbl_membresia);
            this.pnl_membresia.Controls.Add(this.txt_membresia);
            this.pnl_membresia.Controls.Add(this.lbl_estado);
            this.pnl_membresia.Controls.Add(this.txt_estado);
            this.pnl_membresia.Controls.Add(this.lbl_fecha_inicio);
            this.pnl_membresia.Controls.Add(this.txt_fecha_inicio);
            this.pnl_membresia.Controls.Add(this.lbl_fecha_vencimiento);
            this.pnl_membresia.Controls.Add(this.txt_fecha_vencimiento);
            this.pnl_membresia.Controls.Add(this.lbl_saldo_pendiente);
            this.pnl_membresia.Controls.Add(this.txt_saldo_pendiente);
            this.pnl_membresia.Location = new System.Drawing.Point(30, 480);
            this.pnl_membresia.Name = "pnl_membresia";
            this.pnl_membresia.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_membresia.Size = new System.Drawing.Size(1040, 200);
            this.pnl_membresia.TabIndex = 4;
            // 
            // lbl_informacion_membresia
            // 
            this.lbl_informacion_membresia.AutoSize = true;
            this.lbl_informacion_membresia.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacion_membresia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_informacion_membresia.Location = new System.Drawing.Point(20, 15);
            this.lbl_informacion_membresia.Name = "lbl_informacion_membresia";
            this.lbl_informacion_membresia.Size = new System.Drawing.Size(277, 30);
            this.lbl_informacion_membresia.TabIndex = 0;
            this.lbl_informacion_membresia.Text = "Información de membresía";
            // 
            // lbl_membresia
            // 
            this.lbl_membresia.AutoSize = true;
            this.lbl_membresia.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_membresia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_membresia.Location = new System.Drawing.Point(20, 58);
            this.lbl_membresia.Name = "lbl_membresia";
            this.lbl_membresia.Size = new System.Drawing.Size(97, 24);
            this.lbl_membresia.TabIndex = 1;
            this.lbl_membresia.Text = "Membresía:";
            // 
            // txt_membresia
            // 
            this.txt_membresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_membresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_membresia.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_membresia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_membresia.Location = new System.Drawing.Point(20, 85);
            this.txt_membresia.Name = "txt_membresia";
            this.txt_membresia.ReadOnly = true;
            this.txt_membresia.Size = new System.Drawing.Size(300, 28);
            this.txt_membresia.TabIndex = 2;
            this.txt_membresia.TabStop = false;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_estado.Location = new System.Drawing.Point(350, 58);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(67, 24);
            this.lbl_estado.TabIndex = 3;
            this.lbl_estado.Text = "Estado:";
            // 
            // txt_estado
            // 
            this.txt_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estado.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.txt_estado.Location = new System.Drawing.Point(350, 85);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(300, 28);
            this.txt_estado.TabIndex = 4;
            this.txt_estado.TabStop = false;
            this.txt_estado.Text = "Activo";
            // 
            // lbl_fecha_inicio
            // 
            this.lbl_fecha_inicio.AutoSize = true;
            this.lbl_fecha_inicio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_inicio.Location = new System.Drawing.Point(20, 128);
            this.lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            this.lbl_fecha_inicio.Size = new System.Drawing.Size(132, 24);
            this.lbl_fecha_inicio.TabIndex = 7;
            this.lbl_fecha_inicio.Text = "Fecha de inicio:";
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_fecha_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fecha_inicio.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_fecha_inicio.Location = new System.Drawing.Point(20, 155);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.ReadOnly = true;
            this.txt_fecha_inicio.Size = new System.Drawing.Size(300, 28);
            this.txt_fecha_inicio.TabIndex = 8;
            this.txt_fecha_inicio.TabStop = false;
            // 
            // lbl_fecha_vencimiento
            // 
            this.lbl_fecha_vencimiento.AutoSize = true;
            this.lbl_fecha_vencimiento.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_vencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_vencimiento.Location = new System.Drawing.Point(350, 128);
            this.lbl_fecha_vencimiento.Name = "lbl_fecha_vencimiento";
            this.lbl_fecha_vencimiento.Size = new System.Drawing.Size(184, 24);
            this.lbl_fecha_vencimiento.TabIndex = 9;
            this.lbl_fecha_vencimiento.Text = "Fecha de vencimiento:";
            // 
            // txt_fecha_vencimiento
            // 
            this.txt_fecha_vencimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_fecha_vencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fecha_vencimiento.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_vencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_fecha_vencimiento.Location = new System.Drawing.Point(350, 155);
            this.txt_fecha_vencimiento.Name = "txt_fecha_vencimiento";
            this.txt_fecha_vencimiento.ReadOnly = true;
            this.txt_fecha_vencimiento.Size = new System.Drawing.Size(300, 28);
            this.txt_fecha_vencimiento.TabIndex = 10;
            this.txt_fecha_vencimiento.TabStop = false;
            // 
            // lbl_saldo_pendiente
            // 
            this.lbl_saldo_pendiente.AutoSize = true;
            this.lbl_saldo_pendiente.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo_pendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_saldo_pendiente.Location = new System.Drawing.Point(680, 58);
            this.lbl_saldo_pendiente.Name = "lbl_saldo_pendiente";
            this.lbl_saldo_pendiente.Size = new System.Drawing.Size(142, 24);
            this.lbl_saldo_pendiente.TabIndex = 5;
            this.lbl_saldo_pendiente.Text = "Saldo pendiente:";
            // 
            // txt_saldo_pendiente
            // 
            this.txt_saldo_pendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.txt_saldo_pendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_saldo_pendiente.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldo_pendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.txt_saldo_pendiente.Location = new System.Drawing.Point(680, 85);
            this.txt_saldo_pendiente.Name = "txt_saldo_pendiente";
            this.txt_saldo_pendiente.ReadOnly = true;
            this.txt_saldo_pendiente.Size = new System.Drawing.Size(336, 28);
            this.txt_saldo_pendiente.TabIndex = 6;
            this.txt_saldo_pendiente.TabStop = false;
            this.txt_saldo_pendiente.Text = "RD$ 0.00";
            this.txt_saldo_pendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_imprimir);
            this.pnl_acciones.Controls.Add(this.btn_cerrar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 692);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size = new System.Drawing.Size(1040, 70);
            this.pnl_acciones.TabIndex = 5;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Location = new System.Drawing.Point(18, 15);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(145, 40);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(877, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(145, 40);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(21, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo de Documento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.textBox1.Location = new System.Drawing.Point(25, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(216, 28);
            this.textBox1.TabIndex = 20;
            this.textBox1.TabStop = false;
            // 
            // detalle_de_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(1100, 785);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_membresia);
            this.Controls.Add(this.pnl_foto_cliente);
            this.Controls.Add(this.pnl_datos_personales);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "detalle_de_cliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del Cliente - Go Fitness Gym";
            this.pnl_datos_personales.ResumeLayout(false);
            this.pnl_datos_personales.PerformLayout();
            this.pnl_foto_cliente.ResumeLayout(false);
            this.pnl_foto_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto_cliente)).EndInit();
            this.pnl_membresia.ResumeLayout(false);
            this.pnl_membresia.PerformLayout();
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

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;

        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;

        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.TextBox txt_sexo;

        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.TextBox txt_fecha_nacimiento;

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

        private System.Windows.Forms.Panel pnl_foto_cliente;
        private System.Windows.Forms.Label lbl_foto_cliente;

        private System.Windows.Forms.PictureBox
            pic_foto_cliente;

        private System.Windows.Forms.Label lbl_sin_foto;
        private System.Windows.Forms.Label lbl_ayuda_foto;

        private System.Windows.Forms.Panel pnl_membresia;

        private System.Windows.Forms.Label
            lbl_informacion_membresia;

        private System.Windows.Forms.Label lbl_membresia;
        private System.Windows.Forms.TextBox txt_membresia;

        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_estado;

        private System.Windows.Forms.Label lbl_fecha_inicio;
        private System.Windows.Forms.TextBox txt_fecha_inicio;

        private System.Windows.Forms.Label
            lbl_fecha_vencimiento;

        private System.Windows.Forms.TextBox
            txt_fecha_vencimiento;

        private System.Windows.Forms.Label
            lbl_saldo_pendiente;

        private System.Windows.Forms.TextBox
            txt_saldo_pendiente;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}