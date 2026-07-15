
namespace GoFitnessGym
{
    partial class modulo_de_registrar_roles
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
            this.pnl_informacion_rol = new System.Windows.Forms.Panel();
            this.lbl_informacion_rol = new System.Windows.Forms.Label();
            this.lbl_codigo_rol = new System.Windows.Forms.Label();
            this.txt_codigo_rol = new System.Windows.Forms.TextBox();
            this.lbl_nombre_rol = new System.Windows.Forms.Label();
            this.txt_nombre_rol = new System.Windows.Forms.TextBox();
            this.lbl_descripcion_rol = new System.Windows.Forms.Label();
            this.txt_descripcion_rol = new System.Windows.Forms.TextBox();
            this.lbl_campos_obligatorios =
                new System.Windows.Forms.Label();
            this.lbl_nota_permisos = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();

            this.pnl_informacion_rol.SuspendLayout();
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
                new System.Drawing.Size(297, 43);

            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Registrar Nuevo Rol";

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
                new System.Drawing.Point(32, 61);

            this.lbl_subtitulo.Name = "lbl_subtitulo";

            this.lbl_subtitulo.Size =
                new System.Drawing.Size(388, 27);

            this.lbl_subtitulo.TabIndex = 1;

            this.lbl_subtitulo.Text =
                "Complete la información básica del rol";

            // 
            // pnl_informacion_rol
            // 
            this.pnl_informacion_rol.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom) |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_informacion_rol.BackColor =
                System.Drawing.Color.White;

            this.pnl_informacion_rol.Controls.Add(
                this.lbl_informacion_rol);

            this.pnl_informacion_rol.Controls.Add(
                this.lbl_codigo_rol);

            this.pnl_informacion_rol.Controls.Add(
                this.txt_codigo_rol);

            this.pnl_informacion_rol.Controls.Add(
                this.lbl_nombre_rol);

            this.pnl_informacion_rol.Controls.Add(
                this.txt_nombre_rol);

            this.pnl_informacion_rol.Controls.Add(
                this.lbl_descripcion_rol);

            this.pnl_informacion_rol.Controls.Add(
                this.txt_descripcion_rol);

            this.pnl_informacion_rol.Controls.Add(
                this.lbl_campos_obligatorios);

            this.pnl_informacion_rol.Controls.Add(
                this.lbl_nota_permisos);

            this.pnl_informacion_rol.Location =
                new System.Drawing.Point(30, 105);

            this.pnl_informacion_rol.Name =
                "pnl_informacion_rol";

            this.pnl_informacion_rol.Padding =
                new System.Windows.Forms.Padding(25);

            this.pnl_informacion_rol.Size =
                new System.Drawing.Size(640, 385);

            this.pnl_informacion_rol.TabIndex = 2;

            // 
            // lbl_informacion_rol
            // 
            this.lbl_informacion_rol.AutoSize = true;
            this.lbl_informacion_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_informacion_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_informacion_rol.Location =
                new System.Drawing.Point(25, 18);

            this.lbl_informacion_rol.Name =
                "lbl_informacion_rol";

            this.lbl_informacion_rol.Size =
                new System.Drawing.Size(190, 29);

            this.lbl_informacion_rol.TabIndex = 0;

            this.lbl_informacion_rol.Text =
                "Información del rol";

            // 
            // lbl_codigo_rol
            // 
            this.lbl_codigo_rol.AutoSize = true;
            this.lbl_codigo_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_codigo_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_codigo_rol.Location =
                new System.Drawing.Point(25, 67);

            this.lbl_codigo_rol.Name =
                "lbl_codigo_rol";

            this.lbl_codigo_rol.Size =
                new System.Drawing.Size(118, 24);

            this.lbl_codigo_rol.TabIndex = 1;
            this.lbl_codigo_rol.Text = "Código del rol";

            // 
            // txt_codigo_rol
            // 
            this.txt_codigo_rol.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.txt_codigo_rol.BackColor =
                System.Drawing.Color.FromArgb(247, 250, 252);

            this.txt_codigo_rol.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_codigo_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_codigo_rol.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.txt_codigo_rol.Location =
                new System.Drawing.Point(25, 94);

            this.txt_codigo_rol.Name =
                "txt_codigo_rol";

            this.txt_codigo_rol.ReadOnly = true;

            this.txt_codigo_rol.Size =
                new System.Drawing.Size(590, 28);

            this.txt_codigo_rol.TabIndex = 2;

            this.txt_codigo_rol.Text =
                "Se generará automáticamente";

            // 
            // lbl_nombre_rol
            // 
            this.lbl_nombre_rol.AutoSize = true;
            this.lbl_nombre_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_nombre_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_nombre_rol.Location =
                new System.Drawing.Point(25, 143);

            this.lbl_nombre_rol.Name =
                "lbl_nombre_rol";

            this.lbl_nombre_rol.Size =
                new System.Drawing.Size(139, 24);

            this.lbl_nombre_rol.TabIndex = 3;
            this.lbl_nombre_rol.Text = "Nombre del rol *";

            // 
            // txt_nombre_rol
            // 
            this.txt_nombre_rol.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.txt_nombre_rol.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_nombre_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_nombre_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_nombre_rol.Location =
                new System.Drawing.Point(25, 170);

            this.txt_nombre_rol.MaxLength = 50;
            this.txt_nombre_rol.Name = "txt_nombre_rol";

            this.txt_nombre_rol.Size =
                new System.Drawing.Size(590, 28);

            this.txt_nombre_rol.TabIndex = 4;

            // 
            // lbl_descripcion_rol
            // 
            this.lbl_descripcion_rol.AutoSize = true;
            this.lbl_descripcion_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_descripcion_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_descripcion_rol.Location =
                new System.Drawing.Point(25, 219);

            this.lbl_descripcion_rol.Name =
                "lbl_descripcion_rol";

            this.lbl_descripcion_rol.Size =
                new System.Drawing.Size(122, 24);

            this.lbl_descripcion_rol.TabIndex = 5;
            this.lbl_descripcion_rol.Text = "Descripción *";

            // 
            // txt_descripcion_rol
            // 
            this.txt_descripcion_rol.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom) |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.txt_descripcion_rol.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_descripcion_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_descripcion_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_descripcion_rol.Location =
                new System.Drawing.Point(25, 246);

            this.txt_descripcion_rol.MaxLength = 250;
            this.txt_descripcion_rol.Multiline = true;
            this.txt_descripcion_rol.Name =
                "txt_descripcion_rol";

            this.txt_descripcion_rol.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txt_descripcion_rol.Size =
                new System.Drawing.Size(590, 64);

            this.txt_descripcion_rol.TabIndex = 6;

            // 
            // lbl_campos_obligatorios
            // 
            this.lbl_campos_obligatorios.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left)));

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
                new System.Drawing.Point(25, 326);

            this.lbl_campos_obligatorios.Name =
                "lbl_campos_obligatorios";

            this.lbl_campos_obligatorios.Size =
                new System.Drawing.Size(168, 21);

            this.lbl_campos_obligatorios.TabIndex = 7;

            this.lbl_campos_obligatorios.Text =
                "* Campos obligatorios";

            // 
            // lbl_nota_permisos
            // 
            this.lbl_nota_permisos.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.lbl_nota_permisos.BackColor =
                System.Drawing.Color.FromArgb(239, 246, 255);

            this.lbl_nota_permisos.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.lbl_nota_permisos.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_nota_permisos.ForeColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.lbl_nota_permisos.Location =
                new System.Drawing.Point(209, 320);

            this.lbl_nota_permisos.Name =
                "lbl_nota_permisos";

            this.lbl_nota_permisos.Padding =
                new System.Windows.Forms.Padding(10, 0, 10, 0);

            this.lbl_nota_permisos.Size =
                new System.Drawing.Size(406, 38);

            this.lbl_nota_permisos.TabIndex = 8;

            this.lbl_nota_permisos.Text =
                "Los permisos podrán asignarse después de registrar el rol.";

            this.lbl_nota_permisos.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

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

            this.pnl_acciones.Controls.Add(this.btn_guardar);
            this.pnl_acciones.Controls.Add(this.btn_cancelar);

            this.pnl_acciones.Location =
                new System.Drawing.Point(30, 502);

            this.pnl_acciones.Name = "pnl_acciones";

            this.pnl_acciones.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_acciones.Size =
                new System.Drawing.Size(640, 70);

            this.pnl_acciones.TabIndex = 3;

            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

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

            this.btn_guardar.Name = "btn_guardar";

            this.btn_guardar.Size =
                new System.Drawing.Size(140, 40);

            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
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
                new System.Drawing.Point(482, 15);

            this.btn_cancelar.Name = "btn_cancelar";

            this.btn_cancelar.Size =
                new System.Drawing.Size(140, 40);

            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;

            // 
            // modulo_de_registrar_roles
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
                new System.Drawing.Size(700, 595);

            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_informacion_rol);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name = "modulo_de_registrar_roles";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Registrar Rol - Go Fitness Gym";

            this.pnl_informacion_rol.ResumeLayout(false);
            this.pnl_informacion_rol.PerformLayout();

            this.pnl_acciones.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.Panel pnl_informacion_rol;
        private System.Windows.Forms.Label lbl_informacion_rol;

        private System.Windows.Forms.Label lbl_codigo_rol;
        private System.Windows.Forms.TextBox txt_codigo_rol;

        private System.Windows.Forms.Label lbl_nombre_rol;
        private System.Windows.Forms.TextBox txt_nombre_rol;

        private System.Windows.Forms.Label lbl_descripcion_rol;
        private System.Windows.Forms.TextBox txt_descripcion_rol;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios;

        private System.Windows.Forms.Label lbl_nota_permisos;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}