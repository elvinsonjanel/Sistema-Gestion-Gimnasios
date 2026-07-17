
namespace GoFitnessGym
{
    partial class detalle_de_inventario
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
            this.lbl_titulo =
                new System.Windows.Forms.Label();

            this.lbl_subtitulo =
                new System.Windows.Forms.Label();

            this.pnl_informacion_producto =
                new System.Windows.Forms.Panel();

            this.lbl_informacion_producto =
                new System.Windows.Forms.Label();

            this.lbl_codigo_producto =
                new System.Windows.Forms.Label();

            this.txt_codigo_producto =
                new System.Windows.Forms.TextBox();

            this.lbl_nombre_producto =
                new System.Windows.Forms.Label();

            this.txt_nombre_producto =
                new System.Windows.Forms.TextBox();

            this.lbl_categoria =
                new System.Windows.Forms.Label();

            this.txt_categoria =
                new System.Windows.Forms.TextBox();

            this.lbl_ubicacion =
                new System.Windows.Forms.Label();

            this.txt_ubicacion =
                new System.Windows.Forms.TextBox();

            this.pnl_existencias =
                new System.Windows.Forms.Panel();

            this.lbl_existencias =
                new System.Windows.Forms.Label();

            this.lbl_stock_actual =
                new System.Windows.Forms.Label();

            this.txt_stock_actual =
                new System.Windows.Forms.TextBox();

            this.lbl_stock_minimo =
                new System.Windows.Forms.Label();

            this.txt_stock_minimo =
                new System.Windows.Forms.TextBox();

            this.lbl_estado =
                new System.Windows.Forms.Label();

            this.txt_estado =
                new System.Windows.Forms.TextBox();

            this.lbl_descripcion_estado =
                new System.Windows.Forms.Label();

            this.pnl_acciones =
                new System.Windows.Forms.Panel();

            this.btn_cerrar =
                new System.Windows.Forms.Button();

            this.pnl_informacion_producto.SuspendLayout();
            this.pnl_existencias.SuspendLayout();
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
                new System.Drawing.Size(302, 43);

            this.lbl_titulo.TabIndex = 0;

            this.lbl_titulo.Text =
                "Detalle de inventario";

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
                new System.Drawing.Size(534, 27);

            this.lbl_subtitulo.TabIndex = 1;

            this.lbl_subtitulo.Text =
                "Consulte la información y existencias del producto";

            // 
            // pnl_informacion_producto
            // 
            this.pnl_informacion_producto.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_informacion_producto.BackColor =
                System.Drawing.Color.White;

            this.pnl_informacion_producto.Controls.Add(
                this.lbl_informacion_producto);

            this.pnl_informacion_producto.Controls.Add(
                this.lbl_codigo_producto);

            this.pnl_informacion_producto.Controls.Add(
                this.txt_codigo_producto);

            this.pnl_informacion_producto.Controls.Add(
                this.lbl_nombre_producto);

            this.pnl_informacion_producto.Controls.Add(
                this.txt_nombre_producto);

            this.pnl_informacion_producto.Controls.Add(
                this.lbl_categoria);

            this.pnl_informacion_producto.Controls.Add(
                this.txt_categoria);

            this.pnl_informacion_producto.Controls.Add(
                this.lbl_ubicacion);

            this.pnl_informacion_producto.Controls.Add(
                this.txt_ubicacion);

            this.pnl_informacion_producto.Location =
                new System.Drawing.Point(30, 103);

            this.pnl_informacion_producto.Name =
                "pnl_informacion_producto";

            this.pnl_informacion_producto.Padding =
                new System.Windows.Forms.Padding(20);

            this.pnl_informacion_producto.Size =
                new System.Drawing.Size(840, 225);

            this.pnl_informacion_producto.TabIndex = 2;

            // 
            // lbl_informacion_producto
            // 
            this.lbl_informacion_producto.AutoSize = true;

            this.lbl_informacion_producto.Font =
                new System.Drawing.Font(
                    "Lexend",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_informacion_producto.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_informacion_producto.Location =
                new System.Drawing.Point(20, 15);

            this.lbl_informacion_producto.Name =
                "lbl_informacion_producto";

            this.lbl_informacion_producto.Size =
                new System.Drawing.Size(255, 30);

            this.lbl_informacion_producto.TabIndex = 0;

            this.lbl_informacion_producto.Text =
                "Información del producto";

            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.AutoSize = true;

            this.lbl_codigo_producto.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_codigo_producto.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_codigo_producto.Location =
                new System.Drawing.Point(20, 57);

            this.lbl_codigo_producto.Name =
                "lbl_codigo_producto";

            this.lbl_codigo_producto.Size =
                new System.Drawing.Size(171, 24);

            this.lbl_codigo_producto.TabIndex = 1;

            this.lbl_codigo_producto.Text =
                "Código del producto:";

            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.BackColor =
                System.Drawing.Color.FromArgb(247, 250, 252);

            this.txt_codigo_producto.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_codigo_producto.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_codigo_producto.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_codigo_producto.Location =
                new System.Drawing.Point(20, 84);

            this.txt_codigo_producto.Name =
                "txt_codigo_producto";

            this.txt_codigo_producto.ReadOnly = true;

            this.txt_codigo_producto.Size =
                new System.Drawing.Size(245, 28);

            this.txt_codigo_producto.TabIndex = 2;

            this.txt_codigo_producto.TabStop = false;

            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;

            this.lbl_nombre_producto.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_nombre_producto.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_nombre_producto.Location =
                new System.Drawing.Point(298, 57);

            this.lbl_nombre_producto.Name =
                "lbl_nombre_producto";

            this.lbl_nombre_producto.Size =
                new System.Drawing.Size(179, 24);

            this.lbl_nombre_producto.TabIndex = 3;

            this.lbl_nombre_producto.Text =
                "Nombre del producto:";

            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.BackColor =
                System.Drawing.Color.FromArgb(247, 250, 252);

            this.txt_nombre_producto.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_nombre_producto.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_nombre_producto.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_nombre_producto.Location =
                new System.Drawing.Point(298, 84);

            this.txt_nombre_producto.Name =
                "txt_nombre_producto";

            this.txt_nombre_producto.ReadOnly = true;

            this.txt_nombre_producto.Size =
                new System.Drawing.Size(518, 28);

            this.txt_nombre_producto.TabIndex = 4;

            this.txt_nombre_producto.TabStop = false;

            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;

            this.lbl_categoria.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_categoria.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_categoria.Location =
                new System.Drawing.Point(20, 140);

            this.lbl_categoria.Name =
                "lbl_categoria";

            this.lbl_categoria.Size =
                new System.Drawing.Size(91, 24);

            this.lbl_categoria.TabIndex = 5;

            this.lbl_categoria.Text =
                "Categoría:";

            // 
            // txt_categoria
            // 
            this.txt_categoria.BackColor =
                System.Drawing.Color.FromArgb(247, 250, 252);

            this.txt_categoria.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_categoria.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_categoria.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_categoria.Location =
                new System.Drawing.Point(20, 167);

            this.txt_categoria.Name =
                "txt_categoria";

            this.txt_categoria.ReadOnly = true;

            this.txt_categoria.Size =
                new System.Drawing.Size(380, 28);

            this.txt_categoria.TabIndex = 6;

            this.txt_categoria.TabStop = false;

            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;

            this.lbl_ubicacion.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_ubicacion.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_ubicacion.Location =
                new System.Drawing.Point(436, 140);

            this.lbl_ubicacion.Name =
                "lbl_ubicacion";

            this.lbl_ubicacion.Size =
                new System.Drawing.Size(89, 24);

            this.lbl_ubicacion.TabIndex = 7;

            this.lbl_ubicacion.Text =
                "Ubicación:";

            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.BackColor =
                System.Drawing.Color.FromArgb(247, 250, 252);

            this.txt_ubicacion.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_ubicacion.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_ubicacion.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_ubicacion.Location =
                new System.Drawing.Point(436, 167);

            this.txt_ubicacion.Name =
                "txt_ubicacion";

            this.txt_ubicacion.ReadOnly = true;

            this.txt_ubicacion.Size =
                new System.Drawing.Size(380, 28);

            this.txt_ubicacion.TabIndex = 8;

            this.txt_ubicacion.TabStop = false;

            // 
            // pnl_existencias
            // 
            this.pnl_existencias.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_existencias.BackColor =
                System.Drawing.Color.White;

            this.pnl_existencias.Controls.Add(
                this.lbl_existencias);

            this.pnl_existencias.Controls.Add(
                this.lbl_stock_actual);

            this.pnl_existencias.Controls.Add(
                this.txt_stock_actual);

            this.pnl_existencias.Controls.Add(
                this.lbl_stock_minimo);

            this.pnl_existencias.Controls.Add(
                this.txt_stock_minimo);

            this.pnl_existencias.Controls.Add(
                this.lbl_estado);

            this.pnl_existencias.Controls.Add(
                this.txt_estado);

            this.pnl_existencias.Controls.Add(
                this.lbl_descripcion_estado);

            this.pnl_existencias.Location =
                new System.Drawing.Point(30, 340);

            this.pnl_existencias.Name =
                "pnl_existencias";

            this.pnl_existencias.Padding =
                new System.Windows.Forms.Padding(20);

            this.pnl_existencias.Size =
                new System.Drawing.Size(840, 185);

            this.pnl_existencias.TabIndex = 3;

            // 
            // lbl_existencias
            // 
            this.lbl_existencias.AutoSize = true;

            this.lbl_existencias.Font =
                new System.Drawing.Font(
                    "Lexend",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_existencias.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_existencias.Location =
                new System.Drawing.Point(20, 15);

            this.lbl_existencias.Name =
                "lbl_existencias";

            this.lbl_existencias.Size =
                new System.Drawing.Size(213, 30);

            this.lbl_existencias.TabIndex = 0;

            this.lbl_existencias.Text =
                "Control de existencias";

            // 
            // lbl_stock_actual
            // 
            this.lbl_stock_actual.AutoSize = true;

            this.lbl_stock_actual.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_stock_actual.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_stock_actual.Location =
                new System.Drawing.Point(20, 57);

            this.lbl_stock_actual.Name =
                "lbl_stock_actual";

            this.lbl_stock_actual.Size =
                new System.Drawing.Size(108, 24);

            this.lbl_stock_actual.TabIndex = 1;

            this.lbl_stock_actual.Text =
                "Stock actual:";

            // 
            // txt_stock_actual
            // 
            this.txt_stock_actual.BackColor =
                System.Drawing.Color.FromArgb(239, 246, 255);

            this.txt_stock_actual.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_stock_actual.Font =
                new System.Drawing.Font(
                    "Lexend",
                    12F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_stock_actual.ForeColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.txt_stock_actual.Location =
                new System.Drawing.Point(20, 84);

            this.txt_stock_actual.Name =
                "txt_stock_actual";

            this.txt_stock_actual.ReadOnly = true;

            this.txt_stock_actual.Size =
                new System.Drawing.Size(245, 33);

            this.txt_stock_actual.TabIndex = 2;

            this.txt_stock_actual.TabStop = false;

            this.txt_stock_actual.Text =
                "0";

            this.txt_stock_actual.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // lbl_stock_minimo
            // 
            this.lbl_stock_minimo.AutoSize = true;

            this.lbl_stock_minimo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_stock_minimo.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_stock_minimo.Location =
                new System.Drawing.Point(298, 57);

            this.lbl_stock_minimo.Name =
                "lbl_stock_minimo";

            this.lbl_stock_minimo.Size =
                new System.Drawing.Size(115, 24);

            this.lbl_stock_minimo.TabIndex = 3;

            this.lbl_stock_minimo.Text =
                "Stock mínimo:";

            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.BackColor =
                System.Drawing.Color.FromArgb(255, 251, 235);

            this.txt_stock_minimo.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_stock_minimo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    12F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_stock_minimo.ForeColor =
                System.Drawing.Color.FromArgb(217, 119, 6);

            this.txt_stock_minimo.Location =
                new System.Drawing.Point(298, 84);

            this.txt_stock_minimo.Name =
                "txt_stock_minimo";

            this.txt_stock_minimo.ReadOnly = true;

            this.txt_stock_minimo.Size =
                new System.Drawing.Size(245, 33);

            this.txt_stock_minimo.TabIndex = 4;

            this.txt_stock_minimo.TabStop = false;

            this.txt_stock_minimo.Text =
                "0";

            this.txt_stock_minimo.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;

            this.lbl_estado.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_estado.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_estado.Location =
                new System.Drawing.Point(576, 57);

            this.lbl_estado.Name =
                "lbl_estado";

            this.lbl_estado.Size =
                new System.Drawing.Size(67, 24);

            this.lbl_estado.TabIndex = 5;

            this.lbl_estado.Text =
                "Estado:";

            // 
            // txt_estado
            // 
            this.txt_estado.BackColor =
                System.Drawing.Color.FromArgb(240, 253, 244);

            this.txt_estado.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_estado.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_estado.ForeColor =
                System.Drawing.Color.FromArgb(16, 124, 65);

            this.txt_estado.Location =
                new System.Drawing.Point(576, 84);

            this.txt_estado.Name =
                "txt_estado";

            this.txt_estado.ReadOnly = true;

            this.txt_estado.Size =
                new System.Drawing.Size(240, 28);

            this.txt_estado.TabIndex = 6;

            this.txt_estado.TabStop = false;

            this.txt_estado.Text =
                "Disponible";

            this.txt_estado.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // lbl_descripcion_estado
            // 
            this.lbl_descripcion_estado.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_descripcion_estado.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.lbl_descripcion_estado.Location =
                new System.Drawing.Point(20, 132);

            this.lbl_descripcion_estado.Name =
                "lbl_descripcion_estado";

            this.lbl_descripcion_estado.Size =
                new System.Drawing.Size(796, 32);

            this.lbl_descripcion_estado.TabIndex = 7;

            this.lbl_descripcion_estado.Text =
                "El estado del inventario depende de la relación entre el stock actual y el stock mínimo.";

            this.lbl_descripcion_estado.TextAlign =
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

            this.pnl_acciones.Controls.Add(
                this.btn_cerrar);

            this.pnl_acciones.Location =
                new System.Drawing.Point(30, 537);

            this.pnl_acciones.Name =
                "pnl_acciones";

            this.pnl_acciones.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_acciones.Size =
                new System.Drawing.Size(840, 70);

            this.pnl_acciones.TabIndex = 4;

            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_cerrar.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_cerrar.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btn_cerrar.DialogResult =
                System.Windows.Forms.DialogResult.Cancel;

            this.btn_cerrar.FlatAppearance.BorderSize = 0;

            this.btn_cerrar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_cerrar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_cerrar.ForeColor =
                System.Drawing.Color.White;

            this.btn_cerrar.Location =
                new System.Drawing.Point(677, 15);

            this.btn_cerrar.Name =
                "btn_cerrar";

            this.btn_cerrar.Size =
                new System.Drawing.Size(145, 40);

            this.btn_cerrar.TabIndex = 0;

            this.btn_cerrar.Text =
                "Cerrar";

            this.btn_cerrar.UseVisualStyleBackColor =
                false;

            // 
            // detalle_de_inventario
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            this.CancelButton =
                this.btn_cerrar;

            this.ClientSize =
                new System.Drawing.Size(900, 630);

            this.Controls.Add(
                this.pnl_acciones);

            this.Controls.Add(
                this.pnl_existencias);

            this.Controls.Add(
                this.pnl_informacion_producto);

            this.Controls.Add(
                this.lbl_subtitulo);

            this.Controls.Add(
                this.lbl_titulo);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name =
                "detalle_de_inventario";

            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Detalle de Inventario - Go Fitness Gym";

            this.pnl_informacion_producto.ResumeLayout(false);
            this.pnl_informacion_producto.PerformLayout();

            this.pnl_existencias.ResumeLayout(false);
            this.pnl_existencias.PerformLayout();

            this.pnl_acciones.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.Panel
            pnl_informacion_producto;

        private System.Windows.Forms.Label
            lbl_informacion_producto;

        private System.Windows.Forms.Label
            lbl_codigo_producto;

        private System.Windows.Forms.TextBox
            txt_codigo_producto;

        private System.Windows.Forms.Label
            lbl_nombre_producto;

        private System.Windows.Forms.TextBox
            txt_nombre_producto;

        private System.Windows.Forms.Label
            lbl_categoria;

        private System.Windows.Forms.TextBox
            txt_categoria;

        private System.Windows.Forms.Label
            lbl_ubicacion;

        private System.Windows.Forms.TextBox
            txt_ubicacion;

        private System.Windows.Forms.Panel
            pnl_existencias;

        private System.Windows.Forms.Label
            lbl_existencias;

        private System.Windows.Forms.Label
            lbl_stock_actual;

        private System.Windows.Forms.TextBox
            txt_stock_actual;

        private System.Windows.Forms.Label
            lbl_stock_minimo;

        private System.Windows.Forms.TextBox
            txt_stock_minimo;

        private System.Windows.Forms.Label
            lbl_estado;

        private System.Windows.Forms.TextBox
            txt_estado;

        private System.Windows.Forms.Label
            lbl_descripcion_estado;

        private System.Windows.Forms.Panel
            pnl_acciones;

        private System.Windows.Forms.Button
            btn_cerrar;
    }
}