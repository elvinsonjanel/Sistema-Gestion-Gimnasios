
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
            this.lbl_nombre_obligatorio = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();

            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_apellido_obligatorio = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();

            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_sexo_obligatorio = new System.Windows.Forms.Label();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();

            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_fecha_nacimiento_obligatoria =
                new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento =
                new System.Windows.Forms.DateTimePicker();

            this.lbl_documento_identidad =
                new System.Windows.Forms.Label();
            this.lbl_documento_obligatorio =
                new System.Windows.Forms.Label();
            this.txt_documento_identidad =
                new System.Windows.Forms.TextBox();

            this.pnl_contacto = new System.Windows.Forms.Panel();
            this.lbl_informacion_contacto =
                new System.Windows.Forms.Label();

            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_telefono_obligatorio =
                new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();

            this.lbl_correo_electronico =
                new System.Windows.Forms.Label();
            this.txt_correo_electronico =
                new System.Windows.Forms.TextBox();

            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_direccion_obligatoria =
                new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();

            this.lbl_campos_obligatorios =
                new System.Windows.Forms.Label();

            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();

            this.pnl_datos_personales.SuspendLayout();
            this.pnl_contacto.SuspendLayout();
            this.pnl_acciones.SuspendLayout();
            this.SuspendLayout();

            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font(
                "Lexend",
                16F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lbl_titulo.ForeColor =
                System.Drawing.Color.FromArgb(26, 32, 44);
            this.lbl_titulo.Location =
                new System.Drawing.Point(30, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size =
                new System.Drawing.Size(203, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Editar cliente";

            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font(
                "Lexend",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lbl_subtitulo.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.lbl_subtitulo.Location =
                new System.Drawing.Point(32, 59);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size =
                new System.Drawing.Size(462, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text =
                "Modifique la información del cliente seleccionado";

            // 
            // pnl_datos_personales
            // 
            this.pnl_datos_personales.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_datos_personales.BackColor =
                System.Drawing.Color.White;
            this.pnl_datos_personales.Controls.Add(
                this.lbl_datos_personales);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_codigo_cliente);
            this.pnl_datos_personales.Controls.Add(
                this.txt_codigo_cliente);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_ayuda_codigo);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_nombre);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_nombre_obligatorio);
            this.pnl_datos_personales.Controls.Add(
                this.txt_nombre);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_apellido);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_apellido_obligatorio);
            this.pnl_datos_personales.Controls.Add(
                this.txt_apellido);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_sexo);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_sexo_obligatorio);
            this.pnl_datos_personales.Controls.Add(
                this.cbo_sexo);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_fecha_nacimiento);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_fecha_nacimiento_obligatoria);
            this.pnl_datos_personales.Controls.Add(
                this.dtp_fecha_nacimiento);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_documento_identidad);
            this.pnl_datos_personales.Controls.Add(
                this.lbl_documento_obligatorio);
            this.pnl_datos_personales.Controls.Add(
                this.txt_documento_identidad);
            this.pnl_datos_personales.Location =
                new System.Drawing.Point(30, 103);
            this.pnl_datos_personales.Name =
                "pnl_datos_personales";
            this.pnl_datos_personales.Padding =
                new System.Windows.Forms.Padding(20);
            this.pnl_datos_personales.Size =
                new System.Drawing.Size(840, 285);
            this.pnl_datos_personales.TabIndex = 2;

            // 
            // lbl_datos_personales
            // 
            this.lbl_datos_personales.AutoSize = true;
            this.lbl_datos_personales.Font =
                new System.Drawing.Font(
                    "Lexend",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_datos_personales.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_datos_personales.Location =
                new System.Drawing.Point(20, 15);
            this.lbl_datos_personales.Name =
                "lbl_datos_personales";
            this.lbl_datos_personales.Size =
                new System.Drawing.Size(181, 30);
            this.lbl_datos_personales.TabIndex = 0;
            this.lbl_datos_personales.Text =
                "Datos personales";

            // 
            // lbl_codigo_cliente
            // 
            this.lbl_codigo_cliente.AutoSize = true;
            this.lbl_codigo_cliente.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_codigo_cliente.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_codigo_cliente.Location =
                new System.Drawing.Point(20, 57);
            this.lbl_codigo_cliente.Name =
                "lbl_codigo_cliente";
            this.lbl_codigo_cliente.Size =
                new System.Drawing.Size(155, 24);
            this.lbl_codigo_cliente.TabIndex = 1;
            this.lbl_codigo_cliente.Text =
                "Código del cliente:";

            // 
            // txt_codigo_cliente
            // 
            this.txt_codigo_cliente.BackColor =
                System.Drawing.Color.FromArgb(247, 250, 252);
            this.txt_codigo_cliente.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo_cliente.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_codigo_cliente.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.txt_codigo_cliente.Location =
                new System.Drawing.Point(20, 84);
            this.txt_codigo_cliente.Name =
                "txt_codigo_cliente";
            this.txt_codigo_cliente.ReadOnly = true;
            this.txt_codigo_cliente.Size =
                new System.Drawing.Size(245, 28);
            this.txt_codigo_cliente.TabIndex = 2;
            this.txt_codigo_cliente.TabStop = false;

            // 
            // lbl_ayuda_codigo
            // 
            this.lbl_ayuda_codigo.AutoSize = true;
            this.lbl_ayuda_codigo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_ayuda_codigo.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.lbl_ayuda_codigo.Location =
                new System.Drawing.Point(20, 115);
            this.lbl_ayuda_codigo.Name =
                "lbl_ayuda_codigo";
            this.lbl_ayuda_codigo.Size =
                new System.Drawing.Size(193, 22);
            this.lbl_ayuda_codigo.TabIndex = 3;
            this.lbl_ayuda_codigo.Text =
                "El código no puede modificarse.";

            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_nombre.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_nombre.Location =
                new System.Drawing.Point(298, 57);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size =
                new System.Drawing.Size(76, 24);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre:";

            // 
            // lbl_nombre_obligatorio
            // 
            this.lbl_nombre_obligatorio.AutoSize = true;
            this.lbl_nombre_obligatorio.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.lbl_nombre_obligatorio.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_nombre_obligatorio.Location =
                new System.Drawing.Point(372, 57);
            this.lbl_nombre_obligatorio.Name =
                "lbl_nombre_obligatorio";
            this.lbl_nombre_obligatorio.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_nombre_obligatorio.TabIndex = 5;
            this.lbl_nombre_obligatorio.Text = "*";

            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_nombre.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_nombre.Location =
                new System.Drawing.Point(298, 84);
            this.txt_nombre.MaxLength = 60;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size =
                new System.Drawing.Size(245, 28);
            this.txt_nombre.TabIndex = 0;

            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_apellido.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_apellido.Location =
                new System.Drawing.Point(576, 57);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size =
                new System.Drawing.Size(78, 24);
            this.lbl_apellido.TabIndex = 7;
            this.lbl_apellido.Text = "Apellido:";

            // 
            // lbl_apellido_obligatorio
            // 
            this.lbl_apellido_obligatorio.AutoSize = true;
            this.lbl_apellido_obligatorio.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.lbl_apellido_obligatorio.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_apellido_obligatorio.Location =
                new System.Drawing.Point(652, 57);
            this.lbl_apellido_obligatorio.Name =
                "lbl_apellido_obligatorio";
            this.lbl_apellido_obligatorio.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_apellido_obligatorio.TabIndex = 8;
            this.lbl_apellido_obligatorio.Text = "*";

            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_apellido.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_apellido.Location =
                new System.Drawing.Point(576, 84);
            this.txt_apellido.MaxLength = 60;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size =
                new System.Drawing.Size(240, 28);
            this.txt_apellido.TabIndex = 1;

            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_sexo.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_sexo.Location =
                new System.Drawing.Point(20, 160);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size =
                new System.Drawing.Size(52, 24);
            this.lbl_sexo.TabIndex = 10;
            this.lbl_sexo.Text = "Sexo:";

            // 
            // lbl_sexo_obligatorio
            // 
            this.lbl_sexo_obligatorio.AutoSize = true;
            this.lbl_sexo_obligatorio.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.lbl_sexo_obligatorio.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_sexo_obligatorio.Location =
                new System.Drawing.Point(70, 160);
            this.lbl_sexo_obligatorio.Name =
                "lbl_sexo_obligatorio";
            this.lbl_sexo_obligatorio.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_sexo_obligatorio.TabIndex = 11;
            this.lbl_sexo_obligatorio.Text = "*";

            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.cbo_sexo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.cbo_sexo.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(
                new object[]
                {
                    "Masculino",
                    "Femenino"
                });
            this.cbo_sexo.Location =
                new System.Drawing.Point(20, 187);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size =
                new System.Drawing.Size(245, 35);
            this.cbo_sexo.TabIndex = 2;

            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_fecha_nacimiento.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_fecha_nacimiento.Location =
                new System.Drawing.Point(298, 160);
            this.lbl_fecha_nacimiento.Name =
                "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size =
                new System.Drawing.Size(176, 24);
            this.lbl_fecha_nacimiento.TabIndex = 13;
            this.lbl_fecha_nacimiento.Text =
                "Fecha de nacimiento:";

            // 
            // lbl_fecha_nacimiento_obligatoria
            // 
            this.lbl_fecha_nacimiento_obligatoria.AutoSize = true;
            this.lbl_fecha_nacimiento_obligatoria.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.lbl_fecha_nacimiento_obligatoria.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_fecha_nacimiento_obligatoria.Location =
                new System.Drawing.Point(472, 160);
            this.lbl_fecha_nacimiento_obligatoria.Name =
                "lbl_fecha_nacimiento_obligatoria";
            this.lbl_fecha_nacimiento_obligatoria.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_fecha_nacimiento_obligatoria.TabIndex = 14;
            this.lbl_fecha_nacimiento_obligatoria.Text = "*";

            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.CustomFormat =
                "dd/MM/yyyy";
            this.dtp_fecha_nacimiento.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.dtp_fecha_nacimiento.Format =
                System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nacimiento.Location =
                new System.Drawing.Point(298, 187);
            this.dtp_fecha_nacimiento.Name =
                "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size =
                new System.Drawing.Size(245, 28);
            this.dtp_fecha_nacimiento.TabIndex = 3;

            // 
            // lbl_documento_identidad
            // 
            this.lbl_documento_identidad.AutoSize = true;
            this.lbl_documento_identidad.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_documento_identidad.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_documento_identidad.Location =
                new System.Drawing.Point(576, 160);
            this.lbl_documento_identidad.Name =
                "lbl_documento_identidad";
            this.lbl_documento_identidad.Size =
                new System.Drawing.Size(207, 24);
            this.lbl_documento_identidad.TabIndex = 16;
            this.lbl_documento_identidad.Text =
                "Documento de identidad:";

            // 
            // lbl_documento_obligatorio
            // 
            this.lbl_documento_obligatorio.AutoSize = true;
            this.lbl_documento_obligatorio.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.lbl_documento_obligatorio.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_documento_obligatorio.Location =
                new System.Drawing.Point(780, 160);
            this.lbl_documento_obligatorio.Name =
                "lbl_documento_obligatorio";
            this.lbl_documento_obligatorio.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_documento_obligatorio.TabIndex = 17;
            this.lbl_documento_obligatorio.Text = "*";

            // 
            // txt_documento_identidad
            // 
            this.txt_documento_identidad.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_documento_identidad.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_documento_identidad.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_documento_identidad.Location =
                new System.Drawing.Point(576, 187);
            this.txt_documento_identidad.MaxLength = 20;
            this.txt_documento_identidad.Name =
                "txt_documento_identidad";
            this.txt_documento_identidad.Size =
                new System.Drawing.Size(240, 28);
            this.txt_documento_identidad.TabIndex = 4;

            // 
            // pnl_contacto
            // 
            this.pnl_contacto.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_contacto.BackColor =
                System.Drawing.Color.White;
            this.pnl_contacto.Controls.Add(
                this.lbl_informacion_contacto);
            this.pnl_contacto.Controls.Add(
                this.lbl_telefono);
            this.pnl_contacto.Controls.Add(
                this.lbl_telefono_obligatorio);
            this.pnl_contacto.Controls.Add(
                this.txt_telefono);
            this.pnl_contacto.Controls.Add(
                this.lbl_correo_electronico);
            this.pnl_contacto.Controls.Add(
                this.txt_correo_electronico);
            this.pnl_contacto.Controls.Add(
                this.lbl_direccion);
            this.pnl_contacto.Controls.Add(
                this.lbl_direccion_obligatoria);
            this.pnl_contacto.Controls.Add(
                this.txt_direccion);
            this.pnl_contacto.Controls.Add(
                this.lbl_campos_obligatorios);
            this.pnl_contacto.Location =
                new System.Drawing.Point(30, 400);
            this.pnl_contacto.Name =
                "pnl_contacto";
            this.pnl_contacto.Padding =
                new System.Windows.Forms.Padding(20);
            this.pnl_contacto.Size =
                new System.Drawing.Size(840, 230);
            this.pnl_contacto.TabIndex = 3;

            // 
            // lbl_informacion_contacto
            // 
            this.lbl_informacion_contacto.AutoSize = true;
            this.lbl_informacion_contacto.Font =
                new System.Drawing.Font(
                    "Lexend",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_informacion_contacto.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_informacion_contacto.Location =
                new System.Drawing.Point(20, 15);
            this.lbl_informacion_contacto.Name =
                "lbl_informacion_contacto";
            this.lbl_informacion_contacto.Size =
                new System.Drawing.Size(240, 30);
            this.lbl_informacion_contacto.TabIndex = 0;
            this.lbl_informacion_contacto.Text =
                "Información de contacto";

            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_telefono.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_telefono.Location =
                new System.Drawing.Point(20, 57);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size =
                new System.Drawing.Size(82, 24);
            this.lbl_telefono.TabIndex = 1;
            this.lbl_telefono.Text = "Teléfono:";

            // 
            // lbl_telefono_obligatorio
            // 
            this.lbl_telefono_obligatorio.AutoSize = true;
            this.lbl_telefono_obligatorio.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.lbl_telefono_obligatorio.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_telefono_obligatorio.Location =
                new System.Drawing.Point(100, 57);
            this.lbl_telefono_obligatorio.Name =
                "lbl_telefono_obligatorio";
            this.lbl_telefono_obligatorio.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_telefono_obligatorio.TabIndex = 2;
            this.lbl_telefono_obligatorio.Text = "*";

            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_telefono.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_telefono.Location =
                new System.Drawing.Point(20, 84);
            this.txt_telefono.MaxLength = 20;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size =
                new System.Drawing.Size(245, 28);
            this.txt_telefono.TabIndex = 0;

            // 
            // lbl_correo_electronico
            // 
            this.lbl_correo_electronico.AutoSize = true;
            this.lbl_correo_electronico.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_correo_electronico.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_correo_electronico.Location =
                new System.Drawing.Point(298, 57);
            this.lbl_correo_electronico.Name =
                "lbl_correo_electronico";
            this.lbl_correo_electronico.Size =
                new System.Drawing.Size(159, 24);
            this.lbl_correo_electronico.TabIndex = 4;
            this.lbl_correo_electronico.Text =
                "Correo electrónico:";

            // 
            // txt_correo_electronico
            // 
            this.txt_correo_electronico.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo_electronico.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_correo_electronico.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_correo_electronico.Location =
                new System.Drawing.Point(298, 84);
            this.txt_correo_electronico.MaxLength = 100;
            this.txt_correo_electronico.Name =
                "txt_correo_electronico";
            this.txt_correo_electronico.Size =
                new System.Drawing.Size(518, 28);
            this.txt_correo_electronico.TabIndex = 1;

            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_direccion.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_direccion.Location =
                new System.Drawing.Point(20, 130);
            this.lbl_direccion.Name =
                "lbl_direccion";
            this.lbl_direccion.Size =
                new System.Drawing.Size(88, 24);
            this.lbl_direccion.TabIndex = 6;
            this.lbl_direccion.Text = "Dirección:";

            // 
            // lbl_direccion_obligatoria
            // 
            this.lbl_direccion_obligatoria.AutoSize = true;
            this.lbl_direccion_obligatoria.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.lbl_direccion_obligatoria.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_direccion_obligatoria.Location =
                new System.Drawing.Point(106, 130);
            this.lbl_direccion_obligatoria.Name =
                "lbl_direccion_obligatoria";
            this.lbl_direccion_obligatoria.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_direccion_obligatoria.TabIndex = 7;
            this.lbl_direccion_obligatoria.Text = "*";

            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_direccion.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_direccion.Location =
                new System.Drawing.Point(20, 157);
            this.txt_direccion.MaxLength = 250;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;
            this.txt_direccion.Size =
                new System.Drawing.Size(796, 43);
            this.txt_direccion.TabIndex = 2;

            // 
            // lbl_campos_obligatorios
            // 
            this.lbl_campos_obligatorios.AutoSize = true;
            this.lbl_campos_obligatorios.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_campos_obligatorios.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_campos_obligatorios.Location =
                new System.Drawing.Point(640, 203);
            this.lbl_campos_obligatorios.Name =
                "lbl_campos_obligatorios";
            this.lbl_campos_obligatorios.Size =
                new System.Drawing.Size(155, 22);
            this.lbl_campos_obligatorios.TabIndex = 9;
            this.lbl_campos_obligatorios.Text =
                "* Campos obligatorios";

            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor =
                System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(
                this.btn_guardar);
            this.pnl_acciones.Controls.Add(
                this.btn_cancelar);
            this.pnl_acciones.Location =
                new System.Drawing.Point(30, 642);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding =
                new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size =
                new System.Drawing.Size(840, 70);
            this.pnl_acciones.TabIndex = 4;

            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);
            this.btn_guardar.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.btn_guardar.ForeColor =
                System.Drawing.Color.White;
            this.btn_guardar.Location =
                new System.Drawing.Point(18, 15);
            this.btn_guardar.Name =
                "btn_guardar";
            this.btn_guardar.Size =
                new System.Drawing.Size(145, 40);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text =
                "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;

            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));
            this.btn_cancelar.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.btn_cancelar.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DialogResult =
                System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.btn_cancelar.ForeColor =
                System.Drawing.Color.White;
            this.btn_cancelar.Location =
                new System.Drawing.Point(677, 15);
            this.btn_cancelar.Name =
                "btn_cancelar";
            this.btn_cancelar.Size =
                new System.Drawing.Size(145, 40);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text =
                "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;

            // 
            // modulo_de_editar_cliente
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);
            this.CancelButton = this.btn_cancelar;
            this.ClientSize =
                new System.Drawing.Size(900, 735);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_contacto);
            this.Controls.Add(this.pnl_datos_personales);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name =
                "modulo_de_editar_cliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text =
                "Editar Cliente - Go Fitness Gym";

            this.pnl_datos_personales.ResumeLayout(false);
            this.pnl_datos_personales.PerformLayout();

            this.pnl_contacto.ResumeLayout(false);
            this.pnl_contacto.PerformLayout();

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
        private System.Windows.Forms.Label lbl_nombre_obligatorio;
        private System.Windows.Forms.TextBox txt_nombre;

        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_apellido_obligatorio;
        private System.Windows.Forms.TextBox txt_apellido;

        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_sexo_obligatorio;
        private System.Windows.Forms.ComboBox cbo_sexo;

        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label
            lbl_fecha_nacimiento_obligatoria;
        private System.Windows.Forms.DateTimePicker
            dtp_fecha_nacimiento;

        private System.Windows.Forms.Label
            lbl_documento_identidad;
        private System.Windows.Forms.Label
            lbl_documento_obligatorio;
        private System.Windows.Forms.TextBox
            txt_documento_identidad;

        private System.Windows.Forms.Panel pnl_contacto;
        private System.Windows.Forms.Label
            lbl_informacion_contacto;

        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label
            lbl_telefono_obligatorio;
        private System.Windows.Forms.TextBox txt_telefono;

        private System.Windows.Forms.Label
            lbl_correo_electronico;
        private System.Windows.Forms.TextBox
            txt_correo_electronico;

        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label
            lbl_direccion_obligatoria;
        private System.Windows.Forms.TextBox txt_direccion;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}