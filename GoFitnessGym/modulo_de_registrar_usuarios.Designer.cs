
namespace GoFitnessGym
{
    partial class modulo_de_registrar_usuarios
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
            this.tab_datos_usuario = new System.Windows.Forms.TabControl();
            this.tab_datos_personales = new System.Windows.Forms.TabPage();
            this.pnl_datos_personales = new System.Windows.Forms.Panel();
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
            this.lbl_campos_obligatorios_personales = new System.Windows.Forms.Label();
            this.tab_acceso_y_rol = new System.Windows.Forms.TabPage();
            this.pnl_acceso_y_rol = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.lbl_confirmar_contrasena = new System.Windows.Forms.Label();
            this.txt_confirmar_contrasena = new System.Windows.Forms.TextBox();
            this.chk_mostrar_contrasena = new System.Windows.Forms.CheckBox();
            this.lbl_informacion_rol_titulo = new System.Windows.Forms.Label();
            this.lbl_informacion_rol = new System.Windows.Forms.Label();
            this.lbl_campos_obligatorios_acceso = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_tipo_documento = new System.Windows.Forms.Label();
            this.cbo_tipo_documento = new System.Windows.Forms.ComboBox();
            this.tab_datos_usuario.SuspendLayout();
            this.tab_datos_personales.SuspendLayout();
            this.pnl_datos_personales.SuspendLayout();
            this.tab_acceso_y_rol.SuspendLayout();
            this.pnl_acceso_y_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lbl_titulo.Location = new System.Drawing.Point(30, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(358, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Registrar Nuevo Usuario";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 61);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(464, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Complete los datos personales y de acceso del usuario";
            // 
            // tab_datos_usuario
            // 
            this.tab_datos_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_datos_usuario.Controls.Add(this.tab_datos_personales);
            this.tab_datos_usuario.Controls.Add(this.tab_acceso_y_rol);
            this.tab_datos_usuario.Font = new System.Drawing.Font("Lexend", 10F);
            this.tab_datos_usuario.Location = new System.Drawing.Point(30, 105);
            this.tab_datos_usuario.Name = "tab_datos_usuario";
            this.tab_datos_usuario.SelectedIndex = 0;
            this.tab_datos_usuario.Size = new System.Drawing.Size(840, 432);
            this.tab_datos_usuario.TabIndex = 2;
            // 
            // tab_datos_personales
            // 
            this.tab_datos_personales.BackColor = System.Drawing.Color.White;
            this.tab_datos_personales.Controls.Add(this.pnl_datos_personales);
            this.tab_datos_personales.Location = new System.Drawing.Point(4, 36);
            this.tab_datos_personales.Name = "tab_datos_personales";
            this.tab_datos_personales.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos_personales.Size = new System.Drawing.Size(832, 392);
            this.tab_datos_personales.TabIndex = 0;
            this.tab_datos_personales.Text = "Datos personales";
            // 
            // pnl_datos_personales
            // 
            this.pnl_datos_personales.BackColor = System.Drawing.Color.White;
            this.pnl_datos_personales.Controls.Add(this.cbo_tipo_documento);
            this.pnl_datos_personales.Controls.Add(this.lbl_tipo_documento);
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
            this.pnl_datos_personales.Controls.Add(this.lbl_campos_obligatorios_personales);
            this.pnl_datos_personales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_datos_personales.Location = new System.Drawing.Point(3, 3);
            this.pnl_datos_personales.Name = "pnl_datos_personales";
            this.pnl_datos_personales.Size = new System.Drawing.Size(826, 386);
            this.pnl_datos_personales.TabIndex = 0;
            // 
            // lbl_codigo_usuario
            // 
            this.lbl_codigo_usuario.AutoSize = true;
            this.lbl_codigo_usuario.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_codigo_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_codigo_usuario.Location = new System.Drawing.Point(25, 22);
            this.lbl_codigo_usuario.Name = "lbl_codigo_usuario";
            this.lbl_codigo_usuario.Size = new System.Drawing.Size(153, 24);
            this.lbl_codigo_usuario.TabIndex = 0;
            this.lbl_codigo_usuario.Text = "Código de usuario";
            // 
            // txt_codigo_usuario
            // 
            this.txt_codigo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_codigo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo_usuario.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_codigo_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.txt_codigo_usuario.Location = new System.Drawing.Point(25, 50);
            this.txt_codigo_usuario.Name = "txt_codigo_usuario";
            this.txt_codigo_usuario.ReadOnly = true;
            this.txt_codigo_usuario.Size = new System.Drawing.Size(365, 28);
            this.txt_codigo_usuario.TabIndex = 1;
            this.txt_codigo_usuario.Text = "Se generará automáticamente";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_nombre.Location = new System.Drawing.Point(25, 98);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(84, 24);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre *";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_nombre.Location = new System.Drawing.Point(25, 126);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(365, 28);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_apellido.Location = new System.Drawing.Point(425, 98);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(86, 24);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido *";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_apellido.Location = new System.Drawing.Point(425, 126);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(365, 28);
            this.txt_apellido.TabIndex = 5;
            // 
            // lbl_documento_identidad
            // 
            this.lbl_documento_identidad.AutoSize = true;
            this.lbl_documento_identidad.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_documento_identidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_documento_identidad.Location = new System.Drawing.Point(425, 182);
            this.lbl_documento_identidad.Name = "lbl_documento_identidad";
            this.lbl_documento_identidad.Size = new System.Drawing.Size(215, 24);
            this.lbl_documento_identidad.TabIndex = 6;
            this.lbl_documento_identidad.Text = "Documento de identidad *";
            // 
            // txt_documento_identidad
            // 
            this.txt_documento_identidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_documento_identidad.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_documento_identidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_documento_identidad.Location = new System.Drawing.Point(425, 210);
            this.txt_documento_identidad.Name = "txt_documento_identidad";
            this.txt_documento_identidad.Size = new System.Drawing.Size(365, 28);
            this.txt_documento_identidad.TabIndex = 7;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_telefono.Location = new System.Drawing.Point(25, 262);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(90, 24);
            this.lbl_telefono.TabIndex = 8;
            this.lbl_telefono.Text = "Teléfono *";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_telefono.Location = new System.Drawing.Point(25, 290);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(365, 28);
            this.txt_telefono.TabIndex = 9;
            // 
            // lbl_correo_electronico
            // 
            this.lbl_correo_electronico.AutoSize = true;
            this.lbl_correo_electronico.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_correo_electronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_correo_electronico.Location = new System.Drawing.Point(421, 262);
            this.lbl_correo_electronico.Name = "lbl_correo_electronico";
            this.lbl_correo_electronico.Size = new System.Drawing.Size(167, 24);
            this.lbl_correo_electronico.TabIndex = 10;
            this.lbl_correo_electronico.Text = "Correo electrónico *";
            // 
            // txt_correo_electronico
            // 
            this.txt_correo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo_electronico.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_correo_electronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_correo_electronico.Location = new System.Drawing.Point(421, 290);
            this.txt_correo_electronico.Name = "txt_correo_electronico";
            this.txt_correo_electronico.Size = new System.Drawing.Size(365, 28);
            this.txt_correo_electronico.TabIndex = 11;
            // 
            // lbl_campos_obligatorios_personales
            // 
            this.lbl_campos_obligatorios_personales.AutoSize = true;
            this.lbl_campos_obligatorios_personales.Font = new System.Drawing.Font("Lexend", 8F);
            this.lbl_campos_obligatorios_personales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_campos_obligatorios_personales.Location = new System.Drawing.Point(25, 342);
            this.lbl_campos_obligatorios_personales.Name = "lbl_campos_obligatorios_personales";
            this.lbl_campos_obligatorios_personales.Size = new System.Drawing.Size(164, 22);
            this.lbl_campos_obligatorios_personales.TabIndex = 12;
            this.lbl_campos_obligatorios_personales.Text = "* Campos obligatorios";
            // 
            // tab_acceso_y_rol
            // 
            this.tab_acceso_y_rol.BackColor = System.Drawing.Color.White;
            this.tab_acceso_y_rol.Controls.Add(this.pnl_acceso_y_rol);
            this.tab_acceso_y_rol.Location = new System.Drawing.Point(4, 36);
            this.tab_acceso_y_rol.Name = "tab_acceso_y_rol";
            this.tab_acceso_y_rol.Padding = new System.Windows.Forms.Padding(3);
            this.tab_acceso_y_rol.Size = new System.Drawing.Size(832, 392);
            this.tab_acceso_y_rol.TabIndex = 1;
            this.tab_acceso_y_rol.Text = "Acceso y rol";
            // 
            // pnl_acceso_y_rol
            // 
            this.pnl_acceso_y_rol.BackColor = System.Drawing.Color.White;
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_usuario);
            this.pnl_acceso_y_rol.Controls.Add(this.txt_usuario);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_rol);
            this.pnl_acceso_y_rol.Controls.Add(this.cbo_rol);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_contrasena);
            this.pnl_acceso_y_rol.Controls.Add(this.txt_contrasena);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_confirmar_contrasena);
            this.pnl_acceso_y_rol.Controls.Add(this.txt_confirmar_contrasena);
            this.pnl_acceso_y_rol.Controls.Add(this.chk_mostrar_contrasena);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_informacion_rol_titulo);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_informacion_rol);
            this.pnl_acceso_y_rol.Controls.Add(this.lbl_campos_obligatorios_acceso);
            this.pnl_acceso_y_rol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_acceso_y_rol.Location = new System.Drawing.Point(3, 3);
            this.pnl_acceso_y_rol.Name = "pnl_acceso_y_rol";
            this.pnl_acceso_y_rol.Size = new System.Drawing.Size(826, 386);
            this.pnl_acceso_y_rol.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_usuario.Location = new System.Drawing.Point(25, 25);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(82, 24);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario *";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_usuario.Location = new System.Drawing.Point(25, 53);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(365, 28);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_rol.Location = new System.Drawing.Point(425, 25);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(48, 24);
            this.lbl_rol.TabIndex = 2;
            this.lbl_rol.Text = "Rol *";
            // 
            // cbo_rol
            // 
            this.cbo_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rol.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista"});
            this.cbo_rol.Location = new System.Drawing.Point(425, 50);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(365, 35);
            this.cbo_rol.TabIndex = 3;
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_contrasena.Location = new System.Drawing.Point(25, 114);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(111, 24);
            this.lbl_contrasena.TabIndex = 4;
            this.lbl_contrasena.Text = "Contraseña *";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contrasena.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_contrasena.Location = new System.Drawing.Point(25, 142);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '●';
            this.txt_contrasena.Size = new System.Drawing.Size(365, 28);
            this.txt_contrasena.TabIndex = 5;
            // 
            // lbl_confirmar_contrasena
            // 
            this.lbl_confirmar_contrasena.AutoSize = true;
            this.lbl_confirmar_contrasena.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_confirmar_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_confirmar_contrasena.Location = new System.Drawing.Point(425, 114);
            this.lbl_confirmar_contrasena.Name = "lbl_confirmar_contrasena";
            this.lbl_confirmar_contrasena.Size = new System.Drawing.Size(193, 24);
            this.lbl_confirmar_contrasena.TabIndex = 6;
            this.lbl_confirmar_contrasena.Text = "Confirmar contraseña *";
            // 
            // txt_confirmar_contrasena
            // 
            this.txt_confirmar_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_confirmar_contrasena.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_confirmar_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_confirmar_contrasena.Location = new System.Drawing.Point(425, 142);
            this.txt_confirmar_contrasena.Name = "txt_confirmar_contrasena";
            this.txt_confirmar_contrasena.PasswordChar = '●';
            this.txt_confirmar_contrasena.Size = new System.Drawing.Size(365, 28);
            this.txt_confirmar_contrasena.TabIndex = 7;
            // 
            // chk_mostrar_contrasena
            // 
            this.chk_mostrar_contrasena.AutoSize = true;
            this.chk_mostrar_contrasena.Font = new System.Drawing.Font("Lexend", 8F);
            this.chk_mostrar_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.chk_mostrar_contrasena.Location = new System.Drawing.Point(25, 184);
            this.chk_mostrar_contrasena.Name = "chk_mostrar_contrasena";
            this.chk_mostrar_contrasena.Size = new System.Drawing.Size(166, 26);
            this.chk_mostrar_contrasena.TabIndex = 8;
            this.chk_mostrar_contrasena.Text = "Mostrar contraseña";
            this.chk_mostrar_contrasena.UseVisualStyleBackColor = true;
            // 
            // lbl_informacion_rol_titulo
            // 
            this.lbl_informacion_rol_titulo.AutoSize = true;
            this.lbl_informacion_rol_titulo.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_informacion_rol_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_informacion_rol_titulo.Location = new System.Drawing.Point(25, 226);
            this.lbl_informacion_rol_titulo.Name = "lbl_informacion_rol_titulo";
            this.lbl_informacion_rol_titulo.Size = new System.Drawing.Size(164, 24);
            this.lbl_informacion_rol_titulo.TabIndex = 9;
            this.lbl_informacion_rol_titulo.Text = "Información del rol";
            // 
            // lbl_informacion_rol
            // 
            this.lbl_informacion_rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lbl_informacion_rol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_informacion_rol.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_informacion_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lbl_informacion_rol.Location = new System.Drawing.Point(25, 256);
            this.lbl_informacion_rol.Name = "lbl_informacion_rol";
            this.lbl_informacion_rol.Padding = new System.Windows.Forms.Padding(12);
            this.lbl_informacion_rol.Size = new System.Drawing.Size(765, 72);
            this.lbl_informacion_rol.TabIndex = 10;
            this.lbl_informacion_rol.Text = "Administrador: acceso completo al sistema. Recepcionista: acceso a las funciones " +
    "operativas necesarias para la atención diaria.";
            this.lbl_informacion_rol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_campos_obligatorios_acceso
            // 
            this.lbl_campos_obligatorios_acceso.AutoSize = true;
            this.lbl_campos_obligatorios_acceso.Font = new System.Drawing.Font("Lexend", 8F);
            this.lbl_campos_obligatorios_acceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_campos_obligatorios_acceso.Location = new System.Drawing.Point(25, 351);
            this.lbl_campos_obligatorios_acceso.Name = "lbl_campos_obligatorios_acceso";
            this.lbl_campos_obligatorios_acceso.Size = new System.Drawing.Size(164, 22);
            this.lbl_campos_obligatorios_acceso.TabIndex = 11;
            this.lbl_campos_obligatorios_acceso.Text = "* Campos obligatorios";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(560, 576);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 40);
            this.btn_cancelar.TabIndex = 1;
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
            this.btn_guardar.Location = new System.Drawing.Point(723, 576);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(140, 40);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // lbl_tipo_documento
            // 
            this.lbl_tipo_documento.AutoSize = true;
            this.lbl_tipo_documento.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_tipo_documento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_tipo_documento.Location = new System.Drawing.Point(25, 182);
            this.lbl_tipo_documento.Name = "lbl_tipo_documento";
            this.lbl_tipo_documento.Size = new System.Drawing.Size(175, 24);
            this.lbl_tipo_documento.TabIndex = 13;
            this.lbl_tipo_documento.Text = "Tipo de Documento *";
            // 
            // cbo_tipo_documento
            // 
            this.cbo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_tipo_documento.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_documento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_tipo_documento.FormattingEnabled = true;
            this.cbo_tipo_documento.Items.AddRange(new object[] {
            "Cédula de Identidad (Nacional)",
            "Pasaporte",
            "Cédula de Extranjero"});
            this.cbo_tipo_documento.Location = new System.Drawing.Point(29, 210);
            this.cbo_tipo_documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_tipo_documento.Name = "cbo_tipo_documento";
            this.cbo_tipo_documento.Size = new System.Drawing.Size(361, 33);
            this.cbo_tipo_documento.TabIndex = 23;
            // 
            // modulo_de_registrar_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(900, 642);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tab_datos_usuario);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_registrar_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Usuario - Go Fitness Gym";
            this.tab_datos_usuario.ResumeLayout(false);
            this.tab_datos_personales.ResumeLayout(false);
            this.pnl_datos_personales.ResumeLayout(false);
            this.pnl_datos_personales.PerformLayout();
            this.tab_acceso_y_rol.ResumeLayout(false);
            this.pnl_acceso_y_rol.ResumeLayout(false);
            this.pnl_acceso_y_rol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.TabControl tab_datos_usuario;
        private System.Windows.Forms.TabPage tab_datos_personales;
        private System.Windows.Forms.TabPage tab_acceso_y_rol;

        private System.Windows.Forms.Panel pnl_datos_personales;

        private System.Windows.Forms.Label lbl_codigo_usuario;
        private System.Windows.Forms.TextBox txt_codigo_usuario;

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;

        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;

        private System.Windows.Forms.Label lbl_documento_identidad;
        private System.Windows.Forms.TextBox txt_documento_identidad;

        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;

        private System.Windows.Forms.Label lbl_correo_electronico;
        private System.Windows.Forms.TextBox txt_correo_electronico;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios_personales;

        private System.Windows.Forms.Panel pnl_acceso_y_rol;

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_usuario;

        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.ComboBox cbo_rol;

        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena;

        private System.Windows.Forms.Label lbl_confirmar_contrasena;
        private System.Windows.Forms.TextBox txt_confirmar_contrasena;

        private System.Windows.Forms.CheckBox chk_mostrar_contrasena;

        private System.Windows.Forms.Label
            lbl_informacion_rol_titulo;

        private System.Windows.Forms.Label
            lbl_informacion_rol;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios_acceso;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_tipo_documento;
        private System.Windows.Forms.ComboBox cbo_tipo_documento;
    }
}