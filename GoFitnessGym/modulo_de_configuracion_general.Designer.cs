
namespace GoFitnessGym
{
    partial class modulo_de_configuracion_general
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

            this.pnl_datos_empresa = new System.Windows.Forms.Panel();
            this.lbl_datos_empresa = new System.Windows.Forms.Label();
            this.lbl_descripcion_empresa = new System.Windows.Forms.Label();

            this.lbl_nombre_empresa = new System.Windows.Forms.Label();
            this.lbl_nombre_empresa_obligatorio =
                new System.Windows.Forms.Label();
            this.txt_nombre_empresa = new System.Windows.Forms.TextBox();

            this.lbl_rnc = new System.Windows.Forms.Label();
            this.txt_rnc = new System.Windows.Forms.TextBox();

            this.lbl_telefono_empresa = new System.Windows.Forms.Label();
            this.lbl_telefono_empresa_obligatorio =
                new System.Windows.Forms.Label();
            this.txt_telefono_empresa = new System.Windows.Forms.TextBox();

            this.lbl_correo_empresa = new System.Windows.Forms.Label();
            this.lbl_correo_empresa_obligatorio =
                new System.Windows.Forms.Label();
            this.txt_correo_empresa = new System.Windows.Forms.TextBox();

            this.lbl_direccion_empresa = new System.Windows.Forms.Label();
            this.lbl_direccion_empresa_obligatoria =
                new System.Windows.Forms.Label();
            this.txt_direccion_empresa = new System.Windows.Forms.TextBox();

            this.lbl_campos_obligatorios =
                new System.Windows.Forms.Label();

            this.pnl_preferencias = new System.Windows.Forms.Panel();
            this.lbl_preferencias = new System.Windows.Forms.Label();
            this.lbl_descripcion_preferencias =
                new System.Windows.Forms.Label();

            this.lbl_moneda = new System.Windows.Forms.Label();
            this.cbo_moneda = new System.Windows.Forms.ComboBox();

            this.lbl_formato_fecha = new System.Windows.Forms.Label();
            this.cbo_formato_fecha = new System.Windows.Forms.ComboBox();

            this.lbl_impuesto_predeterminado =
                new System.Windows.Forms.Label();
            this.nud_impuesto_predeterminado =
                new System.Windows.Forms.NumericUpDown();
            this.lbl_simbolo_porcentaje =
                new System.Windows.Forms.Label();

            this.pnl_seguridad = new System.Windows.Forms.Panel();
            this.lbl_seguridad = new System.Windows.Forms.Label();
            this.lbl_descripcion_seguridad =
                new System.Windows.Forms.Label();
            this.btn_roles_y_permisos =
                new System.Windows.Forms.Button();

            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();

            this.pnl_datos_empresa.SuspendLayout();
            this.pnl_preferencias.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.nud_impuesto_predeterminado)).BeginInit();

            this.pnl_seguridad.SuspendLayout();
            this.pnl_acciones.SuspendLayout();
            this.SuspendLayout();

            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    16F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_titulo.ForeColor =
                System.Drawing.Color.FromArgb(26, 32, 44);
            this.lbl_titulo.Location =
                new System.Drawing.Point(30, 18);
            this.lbl_titulo.Name =
                "lbl_titulo";
            this.lbl_titulo.Size =
                new System.Drawing.Size(359, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text =
                "Configuración general";

            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_subtitulo.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.lbl_subtitulo.Location =
                new System.Drawing.Point(32, 59);
            this.lbl_subtitulo.Name =
                "lbl_subtitulo";
            this.lbl_subtitulo.Size =
                new System.Drawing.Size(567, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text =
                "Administre los datos básicos y preferencias del sistema";

            // 
            // pnl_datos_empresa
            // 
            this.pnl_datos_empresa.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_datos_empresa.BackColor =
                System.Drawing.Color.White;
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_datos_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_descripcion_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_nombre_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_nombre_empresa_obligatorio);
            this.pnl_datos_empresa.Controls.Add(
                this.txt_nombre_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_rnc);
            this.pnl_datos_empresa.Controls.Add(
                this.txt_rnc);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_telefono_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_telefono_empresa_obligatorio);
            this.pnl_datos_empresa.Controls.Add(
                this.txt_telefono_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_correo_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_correo_empresa_obligatorio);
            this.pnl_datos_empresa.Controls.Add(
                this.txt_correo_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_direccion_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_direccion_empresa_obligatoria);
            this.pnl_datos_empresa.Controls.Add(
                this.txt_direccion_empresa);
            this.pnl_datos_empresa.Controls.Add(
                this.lbl_campos_obligatorios);
            this.pnl_datos_empresa.Location =
                new System.Drawing.Point(30, 103);
            this.pnl_datos_empresa.Name =
                "pnl_datos_empresa";
            this.pnl_datos_empresa.Padding =
                new System.Windows.Forms.Padding(20);
            this.pnl_datos_empresa.Size =
                new System.Drawing.Size(840, 330);
            this.pnl_datos_empresa.TabIndex = 2;

            // 
            // lbl_datos_empresa
            // 
            this.lbl_datos_empresa.AutoSize = true;
            this.lbl_datos_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_datos_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_datos_empresa.Location =
                new System.Drawing.Point(20, 15);
            this.lbl_datos_empresa.Name =
                "lbl_datos_empresa";
            this.lbl_datos_empresa.Size =
                new System.Drawing.Size(204, 30);
            this.lbl_datos_empresa.TabIndex = 0;
            this.lbl_datos_empresa.Text =
                "Datos de la empresa";

            // 
            // lbl_descripcion_empresa
            // 
            this.lbl_descripcion_empresa.AutoSize = true;
            this.lbl_descripcion_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8.5F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_descripcion_empresa.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.lbl_descripcion_empresa.Location =
                new System.Drawing.Point(22, 43);
            this.lbl_descripcion_empresa.Name =
                "lbl_descripcion_empresa";
            this.lbl_descripcion_empresa.Size =
                new System.Drawing.Size(532, 23);
            this.lbl_descripcion_empresa.TabIndex = 1;
            this.lbl_descripcion_empresa.Text =
                "Información institucional que podrá utilizarse en reportes y comprobantes.";

            // 
            // lbl_nombre_empresa
            // 
            this.lbl_nombre_empresa.AutoSize = true;
            this.lbl_nombre_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_nombre_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_nombre_empresa.Location =
                new System.Drawing.Point(20, 82);
            this.lbl_nombre_empresa.Name =
                "lbl_nombre_empresa";
            this.lbl_nombre_empresa.Size =
                new System.Drawing.Size(181, 24);
            this.lbl_nombre_empresa.TabIndex = 2;
            this.lbl_nombre_empresa.Text =
                "Nombre de la empresa:";

            // 
            // lbl_nombre_empresa_obligatorio
            // 
            this.lbl_nombre_empresa_obligatorio.AutoSize = true;
            this.lbl_nombre_empresa_obligatorio.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_nombre_empresa_obligatorio.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_nombre_empresa_obligatorio.Location =
                new System.Drawing.Point(199, 82);
            this.lbl_nombre_empresa_obligatorio.Name =
                "lbl_nombre_empresa_obligatorio";
            this.lbl_nombre_empresa_obligatorio.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_nombre_empresa_obligatorio.TabIndex = 3;
            this.lbl_nombre_empresa_obligatorio.Text =
                "*";

            // 
            // txt_nombre_empresa
            // 
            this.txt_nombre_empresa.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_nombre_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_nombre_empresa.Location =
                new System.Drawing.Point(20, 109);
            this.txt_nombre_empresa.MaxLength = 120;
            this.txt_nombre_empresa.Name =
                "txt_nombre_empresa";
            this.txt_nombre_empresa.Size =
                new System.Drawing.Size(510, 28);
            this.txt_nombre_empresa.TabIndex = 0;

            // 
            // lbl_rnc
            // 
            this.lbl_rnc.AutoSize = true;
            this.lbl_rnc.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_rnc.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_rnc.Location =
                new System.Drawing.Point(560, 82);
            this.lbl_rnc.Name =
                "lbl_rnc";
            this.lbl_rnc.Size =
                new System.Drawing.Size(46, 24);
            this.lbl_rnc.TabIndex = 5;
            this.lbl_rnc.Text =
                "RNC:";

            // 
            // txt_rnc
            // 
            this.txt_rnc.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rnc.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_rnc.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_rnc.Location =
                new System.Drawing.Point(560, 109);
            this.txt_rnc.MaxLength = 20;
            this.txt_rnc.Name =
                "txt_rnc";
            this.txt_rnc.Size =
                new System.Drawing.Size(256, 28);
            this.txt_rnc.TabIndex = 1;

            // 
            // lbl_telefono_empresa
            // 
            this.lbl_telefono_empresa.AutoSize = true;
            this.lbl_telefono_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_telefono_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_telefono_empresa.Location =
                new System.Drawing.Point(20, 157);
            this.lbl_telefono_empresa.Name =
                "lbl_telefono_empresa";
            this.lbl_telefono_empresa.Size =
                new System.Drawing.Size(82, 24);
            this.lbl_telefono_empresa.TabIndex = 7;
            this.lbl_telefono_empresa.Text =
                "Teléfono:";

            // 
            // lbl_telefono_empresa_obligatorio
            // 
            this.lbl_telefono_empresa_obligatorio.AutoSize = true;
            this.lbl_telefono_empresa_obligatorio.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_telefono_empresa_obligatorio.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_telefono_empresa_obligatorio.Location =
                new System.Drawing.Point(100, 157);
            this.lbl_telefono_empresa_obligatorio.Name =
                "lbl_telefono_empresa_obligatorio";
            this.lbl_telefono_empresa_obligatorio.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_telefono_empresa_obligatorio.TabIndex = 8;
            this.lbl_telefono_empresa_obligatorio.Text =
                "*";

            // 
            // txt_telefono_empresa
            // 
            this.txt_telefono_empresa.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_telefono_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_telefono_empresa.Location =
                new System.Drawing.Point(20, 184);
            this.txt_telefono_empresa.MaxLength = 25;
            this.txt_telefono_empresa.Name =
                "txt_telefono_empresa";
            this.txt_telefono_empresa.Size =
                new System.Drawing.Size(245, 28);
            this.txt_telefono_empresa.TabIndex = 2;

            // 
            // lbl_correo_empresa
            // 
            this.lbl_correo_empresa.AutoSize = true;
            this.lbl_correo_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_correo_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_correo_empresa.Location =
                new System.Drawing.Point(298, 157);
            this.lbl_correo_empresa.Name =
                "lbl_correo_empresa";
            this.lbl_correo_empresa.Size =
                new System.Drawing.Size(209, 24);
            this.lbl_correo_empresa.TabIndex = 10;
            this.lbl_correo_empresa.Text =
                "Correo electrónico institucional:";

            // 
            // lbl_correo_empresa_obligatorio
            // 
            this.lbl_correo_empresa_obligatorio.AutoSize = true;
            this.lbl_correo_empresa_obligatorio.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_correo_empresa_obligatorio.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_correo_empresa_obligatorio.Location =
                new System.Drawing.Point(504, 157);
            this.lbl_correo_empresa_obligatorio.Name =
                "lbl_correo_empresa_obligatorio";
            this.lbl_correo_empresa_obligatorio.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_correo_empresa_obligatorio.TabIndex = 11;
            this.lbl_correo_empresa_obligatorio.Text =
                "*";

            // 
            // txt_correo_empresa
            // 
            this.txt_correo_empresa.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_correo_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_correo_empresa.Location =
                new System.Drawing.Point(298, 184);
            this.txt_correo_empresa.MaxLength = 120;
            this.txt_correo_empresa.Name =
                "txt_correo_empresa";
            this.txt_correo_empresa.Size =
                new System.Drawing.Size(518, 28);
            this.txt_correo_empresa.TabIndex = 3;

            // 
            // lbl_direccion_empresa
            // 
            this.lbl_direccion_empresa.AutoSize = true;
            this.lbl_direccion_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_direccion_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_direccion_empresa.Location =
                new System.Drawing.Point(20, 232);
            this.lbl_direccion_empresa.Name =
                "lbl_direccion_empresa";
            this.lbl_direccion_empresa.Size =
                new System.Drawing.Size(88, 24);
            this.lbl_direccion_empresa.TabIndex = 13;
            this.lbl_direccion_empresa.Text =
                "Dirección:";

            // 
            // lbl_direccion_empresa_obligatoria
            // 
            this.lbl_direccion_empresa_obligatoria.AutoSize = true;
            this.lbl_direccion_empresa_obligatoria.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_direccion_empresa_obligatoria.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);
            this.lbl_direccion_empresa_obligatoria.Location =
                new System.Drawing.Point(106, 232);
            this.lbl_direccion_empresa_obligatoria.Name =
                "lbl_direccion_empresa_obligatoria";
            this.lbl_direccion_empresa_obligatoria.Size =
                new System.Drawing.Size(18, 24);
            this.lbl_direccion_empresa_obligatoria.TabIndex = 14;
            this.lbl_direccion_empresa_obligatoria.Text =
                "*";

            // 
            // txt_direccion_empresa
            // 
            this.txt_direccion_empresa.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion_empresa.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion_empresa.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.txt_direccion_empresa.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.txt_direccion_empresa.Location =
                new System.Drawing.Point(20, 259);
            this.txt_direccion_empresa.MaxLength = 250;
            this.txt_direccion_empresa.Multiline = true;
            this.txt_direccion_empresa.Name =
                "txt_direccion_empresa";
            this.txt_direccion_empresa.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;
            this.txt_direccion_empresa.Size =
                new System.Drawing.Size(796, 42);
            this.txt_direccion_empresa.TabIndex = 4;

            // 
            // lbl_campos_obligatorios
            // 
            this.lbl_campos_obligatorios.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right));
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
                new System.Drawing.Point(640, 304);
            this.lbl_campos_obligatorios.Name =
                "lbl_campos_obligatorios";
            this.lbl_campos_obligatorios.Size =
                new System.Drawing.Size(155, 22);
            this.lbl_campos_obligatorios.TabIndex = 16;
            this.lbl_campos_obligatorios.Text =
                "* Campos obligatorios";

            // 
            // pnl_preferencias
            // 
            this.pnl_preferencias.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_preferencias.BackColor =
                System.Drawing.Color.White;
            this.pnl_preferencias.Controls.Add(
                this.lbl_preferencias);
            this.pnl_preferencias.Controls.Add(
                this.lbl_descripcion_preferencias);
            this.pnl_preferencias.Controls.Add(
                this.lbl_moneda);
            this.pnl_preferencias.Controls.Add(
                this.cbo_moneda);
            this.pnl_preferencias.Controls.Add(
                this.lbl_formato_fecha);
            this.pnl_preferencias.Controls.Add(
                this.cbo_formato_fecha);
            this.pnl_preferencias.Controls.Add(
                this.lbl_impuesto_predeterminado);
            this.pnl_preferencias.Controls.Add(
                this.nud_impuesto_predeterminado);
            this.pnl_preferencias.Controls.Add(
                this.lbl_simbolo_porcentaje);
            this.pnl_preferencias.Location =
                new System.Drawing.Point(30, 445);
            this.pnl_preferencias.Name =
                "pnl_preferencias";
            this.pnl_preferencias.Padding =
                new System.Windows.Forms.Padding(20);
            this.pnl_preferencias.Size =
                new System.Drawing.Size(840, 150);
            this.pnl_preferencias.TabIndex = 3;

            // 
            // lbl_preferencias
            // 
            this.lbl_preferencias.AutoSize = true;
            this.lbl_preferencias.Font =
                new System.Drawing.Font(
                    "Lexend",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_preferencias.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_preferencias.Location =
                new System.Drawing.Point(20, 15);
            this.lbl_preferencias.Name =
                "lbl_preferencias";
            this.lbl_preferencias.Size =
                new System.Drawing.Size(225, 30);
            this.lbl_preferencias.TabIndex = 0;
            this.lbl_preferencias.Text =
                "Preferencias generales";

            // 
            // lbl_descripcion_preferencias
            // 
            this.lbl_descripcion_preferencias.AutoSize = true;
            this.lbl_descripcion_preferencias.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8.5F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_descripcion_preferencias.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.lbl_descripcion_preferencias.Location =
                new System.Drawing.Point(22, 43);
            this.lbl_descripcion_preferencias.Name =
                "lbl_descripcion_preferencias";
            this.lbl_descripcion_preferencias.Size =
                new System.Drawing.Size(452, 23);
            this.lbl_descripcion_preferencias.TabIndex = 1;
            this.lbl_descripcion_preferencias.Text =
                "Valores utilizados como referencia en el sistema.";

            // 
            // lbl_moneda
            // 
            this.lbl_moneda.AutoSize = true;
            this.lbl_moneda.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_moneda.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_moneda.Location =
                new System.Drawing.Point(20, 76);
            this.lbl_moneda.Name =
                "lbl_moneda";
            this.lbl_moneda.Size =
                new System.Drawing.Size(75, 24);
            this.lbl_moneda.TabIndex = 2;
            this.lbl_moneda.Text =
                "Moneda:";

            // 
            // cbo_moneda
            // 
            this.cbo_moneda.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_moneda.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.cbo_moneda.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.cbo_moneda.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.cbo_moneda.FormattingEnabled = true;
            this.cbo_moneda.Items.AddRange(
                new object[]
                {
                    "Peso dominicano (RD$)"
                });
            this.cbo_moneda.Location =
                new System.Drawing.Point(20, 102);
            this.cbo_moneda.Name =
                "cbo_moneda";
            this.cbo_moneda.Size =
                new System.Drawing.Size(240, 35);
            this.cbo_moneda.TabIndex = 0;

            // 
            // lbl_formato_fecha
            // 
            this.lbl_formato_fecha.AutoSize = true;
            this.lbl_formato_fecha.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_formato_fecha.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_formato_fecha.Location =
                new System.Drawing.Point(298, 76);
            this.lbl_formato_fecha.Name =
                "lbl_formato_fecha";
            this.lbl_formato_fecha.Size =
                new System.Drawing.Size(142, 24);
            this.lbl_formato_fecha.TabIndex = 4;
            this.lbl_formato_fecha.Text =
                "Formato de fecha:";

            // 
            // cbo_formato_fecha
            // 
            this.cbo_formato_fecha.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_formato_fecha.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.cbo_formato_fecha.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.cbo_formato_fecha.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.cbo_formato_fecha.FormattingEnabled = true;
            this.cbo_formato_fecha.Items.AddRange(
                new object[]
                {
                    "dd/MM/yyyy"
                });
            this.cbo_formato_fecha.Location =
                new System.Drawing.Point(298, 102);
            this.cbo_formato_fecha.Name =
                "cbo_formato_fecha";
            this.cbo_formato_fecha.Size =
                new System.Drawing.Size(220, 35);
            this.cbo_formato_fecha.TabIndex = 1;

            // 
            // lbl_impuesto_predeterminado
            // 
            this.lbl_impuesto_predeterminado.AutoSize = true;
            this.lbl_impuesto_predeterminado.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_impuesto_predeterminado.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_impuesto_predeterminado.Location =
                new System.Drawing.Point(560, 76);
            this.lbl_impuesto_predeterminado.Name =
                "lbl_impuesto_predeterminado";
            this.lbl_impuesto_predeterminado.Size =
                new System.Drawing.Size(208, 24);
            this.lbl_impuesto_predeterminado.TabIndex = 6;
            this.lbl_impuesto_predeterminado.Text =
                "ITBIS predeterminado:";

            // 
            // nud_impuesto_predeterminado
            // 
            this.nud_impuesto_predeterminado.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_impuesto_predeterminado.DecimalPlaces = 2;
            this.nud_impuesto_predeterminado.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.nud_impuesto_predeterminado.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.nud_impuesto_predeterminado.Location =
                new System.Drawing.Point(560, 104);
            this.nud_impuesto_predeterminado.Maximum =
                new decimal(new int[]
                {
                    100,
                    0,
                    0,
                    0
                });
            this.nud_impuesto_predeterminado.Name =
                "nud_impuesto_predeterminado";
            this.nud_impuesto_predeterminado.Size =
                new System.Drawing.Size(120, 28);
            this.nud_impuesto_predeterminado.TabIndex = 2;
            this.nud_impuesto_predeterminado.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // lbl_simbolo_porcentaje
            // 
            this.lbl_simbolo_porcentaje.AutoSize = true;
            this.lbl_simbolo_porcentaje.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_simbolo_porcentaje.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.lbl_simbolo_porcentaje.Location =
                new System.Drawing.Point(687, 104);
            this.lbl_simbolo_porcentaje.Name =
                "lbl_simbolo_porcentaje";
            this.lbl_simbolo_porcentaje.Size =
                new System.Drawing.Size(26, 27);
            this.lbl_simbolo_porcentaje.TabIndex = 8;
            this.lbl_simbolo_porcentaje.Text =
                "%";

            // 
            // pnl_seguridad
            // 
            this.pnl_seguridad.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_seguridad.BackColor =
                System.Drawing.Color.White;
            this.pnl_seguridad.Controls.Add(
                this.lbl_seguridad);
            this.pnl_seguridad.Controls.Add(
                this.lbl_descripcion_seguridad);
            this.pnl_seguridad.Controls.Add(
                this.btn_roles_y_permisos);
            this.pnl_seguridad.Location =
                new System.Drawing.Point(30, 607);
            this.pnl_seguridad.Name =
                "pnl_seguridad";
            this.pnl_seguridad.Padding =
                new System.Windows.Forms.Padding(20);
            this.pnl_seguridad.Size =
                new System.Drawing.Size(840, 100);
            this.pnl_seguridad.TabIndex = 4;

            // 
            // lbl_seguridad
            // 
            this.lbl_seguridad.AutoSize = true;
            this.lbl_seguridad.Font =
                new System.Drawing.Font(
                    "Lexend",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_seguridad.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);
            this.lbl_seguridad.Location =
                new System.Drawing.Point(20, 14);
            this.lbl_seguridad.Name =
                "lbl_seguridad";
            this.lbl_seguridad.Size =
                new System.Drawing.Size(220, 30);
            this.lbl_seguridad.TabIndex = 0;
            this.lbl_seguridad.Text =
                "Seguridad y acceso";

            // 
            // lbl_descripcion_seguridad
            // 
            this.lbl_descripcion_seguridad.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8.5F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.lbl_descripcion_seguridad.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);
            this.lbl_descripcion_seguridad.Location =
                new System.Drawing.Point(22, 45);
            this.lbl_descripcion_seguridad.Name =
                "lbl_descripcion_seguridad";
            this.lbl_descripcion_seguridad.Size =
                new System.Drawing.Size(510, 42);
            this.lbl_descripcion_seguridad.TabIndex = 1;
            this.lbl_descripcion_seguridad.Text =
                "Administre los roles y permisos asignados a los usuarios del sistema.";

            // 
            // btn_roles_y_permisos
            // 
            this.btn_roles_y_permisos.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));
            this.btn_roles_y_permisos.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);
            this.btn_roles_y_permisos.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btn_roles_y_permisos.FlatAppearance.BorderSize = 0;
            this.btn_roles_y_permisos.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btn_roles_y_permisos.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            this.btn_roles_y_permisos.ForeColor =
                System.Drawing.Color.White;
            this.btn_roles_y_permisos.Location =
                new System.Drawing.Point(590, 30);
            this.btn_roles_y_permisos.Name =
                "btn_roles_y_permisos";
            this.btn_roles_y_permisos.Size =
                new System.Drawing.Size(226, 42);
            this.btn_roles_y_permisos.TabIndex = 0;
            this.btn_roles_y_permisos.Text =
                "Roles y permisos";
            this.btn_roles_y_permisos.UseVisualStyleBackColor =
                false;

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
                new System.Drawing.Point(30, 719);
            this.pnl_acciones.Name =
                "pnl_acciones";
            this.pnl_acciones.Padding =
                new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size =
                new System.Drawing.Size(840, 70);
            this.pnl_acciones.TabIndex = 5;

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
                new System.Drawing.Size(185, 40);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text =
                "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor =
                false;

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
            this.btn_cancelar.UseVisualStyleBackColor =
                false;

            // 
            // modulo_de_configuracion_general
            // 
            this.AcceptButton =
                this.btn_guardar;
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);
            this.CancelButton =
                this.btn_cancelar;
            this.ClientSize =
                new System.Drawing.Size(900, 812);
            this.Controls.Add(
                this.pnl_acciones);
            this.Controls.Add(
                this.pnl_seguridad);
            this.Controls.Add(
                this.pnl_preferencias);
            this.Controls.Add(
                this.pnl_datos_empresa);
            this.Controls.Add(
                this.lbl_subtitulo);
            this.Controls.Add(
                this.lbl_titulo);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name =
                "modulo_de_configuracion_general";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text =
                "Configuración General - Go Fitness Gym";

            this.pnl_datos_empresa.ResumeLayout(false);
            this.pnl_datos_empresa.PerformLayout();

            this.pnl_preferencias.ResumeLayout(false);
            this.pnl_preferencias.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.nud_impuesto_predeterminado)).EndInit();

            this.pnl_seguridad.ResumeLayout(false);
            this.pnl_seguridad.PerformLayout();

            this.pnl_acciones.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.Panel pnl_datos_empresa;
        private System.Windows.Forms.Label lbl_datos_empresa;
        private System.Windows.Forms.Label
            lbl_descripcion_empresa;

        private System.Windows.Forms.Label
            lbl_nombre_empresa;
        private System.Windows.Forms.Label
            lbl_nombre_empresa_obligatorio;
        private System.Windows.Forms.TextBox
            txt_nombre_empresa;

        private System.Windows.Forms.Label lbl_rnc;
        private System.Windows.Forms.TextBox txt_rnc;

        private System.Windows.Forms.Label
            lbl_telefono_empresa;
        private System.Windows.Forms.Label
            lbl_telefono_empresa_obligatorio;
        private System.Windows.Forms.TextBox
            txt_telefono_empresa;

        private System.Windows.Forms.Label
            lbl_correo_empresa;
        private System.Windows.Forms.Label
            lbl_correo_empresa_obligatorio;
        private System.Windows.Forms.TextBox
            txt_correo_empresa;

        private System.Windows.Forms.Label
            lbl_direccion_empresa;
        private System.Windows.Forms.Label
            lbl_direccion_empresa_obligatoria;
        private System.Windows.Forms.TextBox
            txt_direccion_empresa;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios;

        private System.Windows.Forms.Panel pnl_preferencias;
        private System.Windows.Forms.Label lbl_preferencias;
        private System.Windows.Forms.Label
            lbl_descripcion_preferencias;

        private System.Windows.Forms.Label lbl_moneda;
        private System.Windows.Forms.ComboBox cbo_moneda;

        private System.Windows.Forms.Label
            lbl_formato_fecha;
        private System.Windows.Forms.ComboBox
            cbo_formato_fecha;

        private System.Windows.Forms.Label
            lbl_impuesto_predeterminado;
        private System.Windows.Forms.NumericUpDown
            nud_impuesto_predeterminado;
        private System.Windows.Forms.Label
            lbl_simbolo_porcentaje;

        private System.Windows.Forms.Panel pnl_seguridad;
        private System.Windows.Forms.Label lbl_seguridad;
        private System.Windows.Forms.Label
            lbl_descripcion_seguridad;
        private System.Windows.Forms.Button
            btn_roles_y_permisos;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}