
namespace GoFitnessGym
{
    partial class detalle_de_usuario
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
            this.lbl_codigo_usuario = new System.Windows.Forms.Label();
            this.txt_codigo_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_documento_identidad = new System.Windows.Forms.Label();
            this.txt_documento_identidad = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_correo_electronico = new System.Windows.Forms.Label();
            this.txt_correo_electronico = new System.Windows.Forms.TextBox();
            this.pnl_acceso_y_rol = new System.Windows.Forms.Panel();
            this.lbl_acceso_y_rol = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.txt_rol = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_ultimo_acceso = new System.Windows.Forms.Label();
            this.txt_ultimo_acceso = new System.Windows.Forms.TextBox();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_datos_personales.SuspendLayout();
            this.pnl_acceso_y_rol.SuspendLayout();
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
            this.lbl_titulo.Size = new System.Drawing.Size(284, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Detalle del Usuario";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 61);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(483, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Consulte la información personal y de acceso del usuario";
            // 
            // pnl_datos_personales
            // 
            this.pnl_datos_personales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_datos_personales.BackColor = System.Drawing.Color.White;
            this.pnl_datos_personales.Controls.Add(this.lbl_datos_personales);
            this.pnl_datos_personales.Controls.Add(this.lbl_codigo_usuario);
            this.pnl_datos_personales.Controls.Add(this.txt_codigo_usuario);
            this.pnl_datos_personales.Controls.Add(this.lbl_nombre);
            this.pnl_datos_personales.Controls.Add(this.txt_nombre);
            this.pnl_datos_personales.Controls.Add(this.lbl_apellido);
            this.pnl_datos_personales.Controls.Add(this.txt_apellido);
            this.pnl_datos_personales.Controls.Add(this.lbl_documento_identidad);
            this.pnl_datos_personales.Controls.Add(this.txt_documento_identidad);
            this.pnl_datos_personales.Controls.Add(this.lbl_telefono);
            this.pnl_datos_personales.Controls.Add(this.txt_telefono);
            this.pnl_datos_personales.Controls.Add(this.lbl_correo_electronico);
            this.pnl_datos_personales.Controls.Add(this.txt_correo_electronico);
            this.pnl_datos_personales.Location = new System.Drawing.Point(30, 103);
            this.pnl_datos_personales.Name = "pnl_datos_personales";
            this.pnl_datos_personales.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_datos_personales.Size = new System.Drawing.Size(839, 236);
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
            // lbl_codigo_usuario
            // 
            this.lbl_codigo_usuario.AutoSize = true;
            this.lbl_codigo_usuario.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_codigo_usuario.Location = new System.Drawing.Point(20, 57);
            this.lbl_codigo_usuario.Name = "lbl_codigo_usuario";
            this.lbl_codigo_usuario.Size = new System.Drawing.Size(157, 24);
            this.lbl_codigo_usuario.TabIndex = 1;
            this.lbl_codigo_usuario.Text = "Código de usuario:";
            // 
            // txt_codigo_usuario
            // 
            this.txt_codigo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_codigo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo_usuario.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_codigo_usuario.Location = new System.Drawing.Point(20, 84);
            this.txt_codigo_usuario.Name = "txt_codigo_usuario";
            this.txt_codigo_usuario.ReadOnly = true;
            this.txt_codigo_usuario.Size = new System.Drawing.Size(245, 28);
            this.txt_codigo_usuario.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_nombre.Location = new System.Drawing.Point(298, 57);
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
            this.txt_nombre.Location = new System.Drawing.Point(298, 84);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(245, 28);
            this.txt_nombre.TabIndex = 4;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_apellido.Location = new System.Drawing.Point(576, 57);
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
            this.txt_apellido.Location = new System.Drawing.Point(576, 84);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(240, 28);
            this.txt_apellido.TabIndex = 6;
            // 
            // lbl_documento_identidad
            // 
            this.lbl_documento_identidad.AutoSize = true;
            this.lbl_documento_identidad.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento_identidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_documento_identidad.Location = new System.Drawing.Point(20, 130);
            this.lbl_documento_identidad.Name = "lbl_documento_identidad";
            this.lbl_documento_identidad.Size = new System.Drawing.Size(207, 24);
            this.lbl_documento_identidad.TabIndex = 7;
            this.lbl_documento_identidad.Text = "Documento de identidad:";
            // 
            // txt_documento_identidad
            // 
            this.txt_documento_identidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_documento_identidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_documento_identidad.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_documento_identidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_documento_identidad.Location = new System.Drawing.Point(20, 157);
            this.txt_documento_identidad.Name = "txt_documento_identidad";
            this.txt_documento_identidad.ReadOnly = true;
            this.txt_documento_identidad.Size = new System.Drawing.Size(245, 28);
            this.txt_documento_identidad.TabIndex = 8;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_telefono.Location = new System.Drawing.Point(298, 130);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(82, 24);
            this.lbl_telefono.TabIndex = 9;
            this.lbl_telefono.Text = "Teléfono:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_telefono.Location = new System.Drawing.Point(298, 157);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(245, 28);
            this.txt_telefono.TabIndex = 10;
            // 
            // lbl_correo_electronico
            // 
            this.lbl_correo_electronico.AutoSize = true;
            this.lbl_correo_electronico.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo_electronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_correo_electronico.Location = new System.Drawing.Point(576, 130);
            this.lbl_correo_electronico.Name = "lbl_correo_electronico";
            this.lbl_correo_electronico.Size = new System.Drawing.Size(159, 24);
            this.lbl_correo_electronico.TabIndex = 11;
            this.lbl_correo_electronico.Text = "Correo electrónico:";
            // 
            // txt_correo_electronico
            // 
            this.txt_correo_electronico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_correo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo_electronico.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo_electronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_correo_electronico.Location = new System.Drawing.Point(576, 157);
            this.txt_correo_electronico.Name = "txt_correo_electronico";
            this.txt_correo_electronico.ReadOnly = true;
            this.txt_correo_electronico.Size = new System.Drawing.Size(245, 28);
            this.txt_correo_electronico.TabIndex = 12;
            // 
            // pnl_acceso_y_rol
            // 
            this.pnl_acceso_y_rol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acceso_y_rol.BackColor = System.Drawing.Color.White;
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_acceso_y_rol);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_usuario);
            this.pnl_acceso_y_rol.Controls.Add(this.txt_usuario);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_rol);
            this.pnl_acceso_y_rol.Controls.Add(this.txt_rol);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_estado);
            this.pnl_acceso_y_rol.Controls.Add(this.txt_estado);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_ultimo_acceso);
            this.pnl_acceso_y_rol.Controls.Add(this.txt_ultimo_acceso);
            this.pnl_acceso_y_rol.Location = new System.Drawing.Point(30, 369);
            this.pnl_acceso_y_rol.Name = "pnl_acceso_y_rol";
            this.pnl_acceso_y_rol.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_acceso_y_rol.Size = new System.Drawing.Size(839, 214);
            this.pnl_acceso_y_rol.TabIndex = 3;
            // 
            // lbl_acceso_y_rol
            // 
            this.lbl_acceso_y_rol.AutoSize = true;
            this.lbl_acceso_y_rol.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acceso_y_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_acceso_y_rol.Location = new System.Drawing.Point(20, 15);
            this.lbl_acceso_y_rol.Name = "lbl_acceso_y_rol";
            this.lbl_acceso_y_rol.Size = new System.Drawing.Size(129, 30);
            this.lbl_acceso_y_rol.TabIndex = 0;
            this.lbl_acceso_y_rol.Text = "Acceso y rol";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_usuario.Location = new System.Drawing.Point(20, 57);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 24);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_usuario.Location = new System.Drawing.Point(20, 84);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.ReadOnly = true;
            this.txt_usuario.Size = new System.Drawing.Size(245, 28);
            this.txt_usuario.TabIndex = 2;
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_rol.Location = new System.Drawing.Point(298, 57);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(40, 24);
            this.lbl_rol.TabIndex = 3;
            this.lbl_rol.Text = "Rol:";
            // 
            // txt_rol
            // 
            this.txt_rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_rol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rol.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_rol.Location = new System.Drawing.Point(298, 84);
            this.txt_rol.Name = "txt_rol";
            this.txt_rol.ReadOnly = true;
            this.txt_rol.Size = new System.Drawing.Size(245, 28);
            this.txt_rol.TabIndex = 4;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_estado.Location = new System.Drawing.Point(576, 57);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(67, 24);
            this.lbl_estado.TabIndex = 5;
            this.lbl_estado.Text = "Estado:";
            // 
            // txt_estado
            // 
            this.txt_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estado.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.txt_estado.Location = new System.Drawing.Point(576, 84);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(205, 28);
            this.txt_estado.TabIndex = 6;
            this.txt_estado.Text = "Activo";
            // 
            // lbl_ultimo_acceso
            // 
            this.lbl_ultimo_acceso.AutoSize = true;
            this.lbl_ultimo_acceso.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ultimo_acceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_ultimo_acceso.Location = new System.Drawing.Point(20, 130);
            this.lbl_ultimo_acceso.Name = "lbl_ultimo_acceso";
            this.lbl_ultimo_acceso.Size = new System.Drawing.Size(122, 24);
            this.lbl_ultimo_acceso.TabIndex = 7;
            this.lbl_ultimo_acceso.Text = "Último acceso:";
            // 
            // txt_ultimo_acceso
            // 
            this.txt_ultimo_acceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_ultimo_acceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ultimo_acceso.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ultimo_acceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_ultimo_acceso.Location = new System.Drawing.Point(20, 157);
            this.txt_ultimo_acceso.Name = "txt_ultimo_acceso";
            this.txt_ultimo_acceso.ReadOnly = true;
            this.txt_ultimo_acceso.Size = new System.Drawing.Size(264, 28);
            this.txt_ultimo_acceso.TabIndex = 8;
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_imprimir);
            this.pnl_acciones.Controls.Add(this.btn_cerrar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 595);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size = new System.Drawing.Size(839, 70);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
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
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(676, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(145, 40);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // detalle_de_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(899, 720);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_acceso_y_rol);
            this.Controls.Add(this.pnl_datos_personales);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "detalle_de_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del Usuario - Go Fitness Gym";
            this.pnl_datos_personales.ResumeLayout(false);
            this.pnl_datos_personales.PerformLayout();
            this.pnl_acceso_y_rol.ResumeLayout(false);
            this.pnl_acceso_y_rol.PerformLayout();
            this.pnl_acciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label
            lbl_titulo;

        private System.Windows.Forms.Label
            lbl_subtitulo;

        private System.Windows.Forms.Panel
            pnl_datos_personales;

        private System.Windows.Forms.Label
            lbl_datos_personales;

        private System.Windows.Forms.Label
            lbl_codigo_usuario;

        private System.Windows.Forms.TextBox
            txt_codigo_usuario;

        private System.Windows.Forms.Label
            lbl_nombre;

        private System.Windows.Forms.TextBox
            txt_nombre;

        private System.Windows.Forms.Label
            lbl_apellido;

        private System.Windows.Forms.TextBox
            txt_apellido;

        private System.Windows.Forms.Label
            lbl_documento_identidad;

        private System.Windows.Forms.TextBox
            txt_documento_identidad;

        private System.Windows.Forms.Label
            lbl_telefono;

        private System.Windows.Forms.TextBox
            txt_telefono;

        private System.Windows.Forms.Label
            lbl_correo_electronico;

        private System.Windows.Forms.TextBox
            txt_correo_electronico;

        private System.Windows.Forms.Panel
            pnl_acceso_y_rol;

        private System.Windows.Forms.Label
            lbl_acceso_y_rol;

        private System.Windows.Forms.Label
            lbl_usuario;

        private System.Windows.Forms.TextBox
            txt_usuario;

        private System.Windows.Forms.Label
            lbl_rol;

        private System.Windows.Forms.TextBox
            txt_rol;

        private System.Windows.Forms.Label
            lbl_estado;

        private System.Windows.Forms.TextBox
            txt_estado;

        private System.Windows.Forms.Label
            lbl_ultimo_acceso;

        private System.Windows.Forms.TextBox
            txt_ultimo_acceso;

        private System.Windows.Forms.Panel
            pnl_acciones;

        private System.Windows.Forms.Button
            btn_imprimir;

        private System.Windows.Forms.Button
            btn_cerrar;
    }
}