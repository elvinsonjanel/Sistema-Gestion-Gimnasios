
namespace GoFitnessGym
{
    partial class modulo_de_editar_producto
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
            this.pnl_informacion_producto = new System.Windows.Forms.Panel();
            this.lbl_informacion_producto = new System.Windows.Forms.Label();
            this.lbl_codigo_producto = new System.Windows.Forms.Label();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.lbl_ayuda_codigo = new System.Windows.Forms.Label();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.lbl_nombre_obligatorio = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.lbl_proveedor_obligatorio = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_descripcion_obligatoria = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.pnl_inventario_precio = new System.Windows.Forms.Panel();
            this.lbl_inventario_precio = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_stock_obligatorio = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.lbl_itbis = new System.Windows.Forms.Label();
            this.lbl_itbis_obligatorio = new System.Windows.Forms.Label();
            this.txt_itbis = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_precio_obligatorio = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_campos_obligatorios = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.pnl_informacion_producto.SuspendLayout();
            this.pnl_inventario_precio.SuspendLayout();
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
            this.lbl_titulo.Size = new System.Drawing.Size(237, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Editar producto";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 59);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(442, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Modifique la información del producto seleccionado";
            // 
            // pnl_informacion_producto
            // 
            this.pnl_informacion_producto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_informacion_producto.BackColor = System.Drawing.Color.White;
            this.pnl_informacion_producto.Controls.Add(this.lbl_informacion_producto);
            this.pnl_informacion_producto.Controls.Add(this.lbl_codigo_producto);
            this.pnl_informacion_producto.Controls.Add(this.txt_codigo_producto);
            this.pnl_informacion_producto.Controls.Add(this.lbl_ayuda_codigo);
            this.pnl_informacion_producto.Controls.Add(this.lbl_nombre_producto);
            this.pnl_informacion_producto.Controls.Add(this.lbl_nombre_obligatorio);
            this.pnl_informacion_producto.Controls.Add(this.txt_nombre_producto);
            this.pnl_informacion_producto.Controls.Add(this.lbl_proveedor);
            this.pnl_informacion_producto.Controls.Add(this.lbl_proveedor_obligatorio);
            this.pnl_informacion_producto.Controls.Add(this.txt_proveedor);
            this.pnl_informacion_producto.Controls.Add(this.lbl_descripcion);
            this.pnl_informacion_producto.Controls.Add(this.lbl_descripcion_obligatoria);
            this.pnl_informacion_producto.Controls.Add(this.txt_descripcion);
            this.pnl_informacion_producto.Location = new System.Drawing.Point(30, 103);
            this.pnl_informacion_producto.Name = "pnl_informacion_producto";
            this.pnl_informacion_producto.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_informacion_producto.Size = new System.Drawing.Size(840, 285);
            this.pnl_informacion_producto.TabIndex = 2;
            // 
            // lbl_informacion_producto
            // 
            this.lbl_informacion_producto.AutoSize = true;
            this.lbl_informacion_producto.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacion_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_informacion_producto.Location = new System.Drawing.Point(20, 15);
            this.lbl_informacion_producto.Name = "lbl_informacion_producto";
            this.lbl_informacion_producto.Size = new System.Drawing.Size(264, 30);
            this.lbl_informacion_producto.TabIndex = 0;
            this.lbl_informacion_producto.Text = "Información del producto";
            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.AutoSize = true;
            this.lbl_codigo_producto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_codigo_producto.Location = new System.Drawing.Point(20, 57);
            this.lbl_codigo_producto.Name = "lbl_codigo_producto";
            this.lbl_codigo_producto.Size = new System.Drawing.Size(174, 24);
            this.lbl_codigo_producto.TabIndex = 1;
            this.lbl_codigo_producto.Text = "Código del producto:";
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_codigo_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo_producto.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.txt_codigo_producto.Location = new System.Drawing.Point(20, 84);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.ReadOnly = true;
            this.txt_codigo_producto.Size = new System.Drawing.Size(245, 28);
            this.txt_codigo_producto.TabIndex = 2;
            this.txt_codigo_producto.TabStop = false;
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
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_nombre_producto.Location = new System.Drawing.Point(298, 57);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(181, 24);
            this.lbl_nombre_producto.TabIndex = 4;
            this.lbl_nombre_producto.Text = "Nombre del producto:";
            // 
            // lbl_nombre_obligatorio
            // 
            this.lbl_nombre_obligatorio.AutoSize = true;
            this.lbl_nombre_obligatorio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_obligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_nombre_obligatorio.Location = new System.Drawing.Point(475, 57);
            this.lbl_nombre_obligatorio.Name = "lbl_nombre_obligatorio";
            this.lbl_nombre_obligatorio.Size = new System.Drawing.Size(17, 24);
            this.lbl_nombre_obligatorio.TabIndex = 5;
            this.lbl_nombre_obligatorio.Text = "*";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre_producto.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_nombre_producto.Location = new System.Drawing.Point(298, 84);
            this.txt_nombre_producto.MaxLength = 100;
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(245, 28);
            this.txt_nombre_producto.TabIndex = 0;
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_proveedor.Location = new System.Drawing.Point(576, 57);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(95, 24);
            this.lbl_proveedor.TabIndex = 7;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // lbl_proveedor_obligatorio
            // 
            this.lbl_proveedor_obligatorio.AutoSize = true;
            this.lbl_proveedor_obligatorio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor_obligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_proveedor_obligatorio.Location = new System.Drawing.Point(673, 57);
            this.lbl_proveedor_obligatorio.Name = "lbl_proveedor_obligatorio";
            this.lbl_proveedor_obligatorio.Size = new System.Drawing.Size(17, 24);
            this.lbl_proveedor_obligatorio.TabIndex = 8;
            this.lbl_proveedor_obligatorio.Text = "*";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proveedor.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_proveedor.Location = new System.Drawing.Point(576, 84);
            this.txt_proveedor.MaxLength = 100;
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(240, 28);
            this.txt_proveedor.TabIndex = 1;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(20, 153);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(105, 24);
            this.lbl_descripcion.TabIndex = 10;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // lbl_descripcion_obligatoria
            // 
            this.lbl_descripcion_obligatoria.AutoSize = true;
            this.lbl_descripcion_obligatoria.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_obligatoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_descripcion_obligatoria.Location = new System.Drawing.Point(126, 153);
            this.lbl_descripcion_obligatoria.Name = "lbl_descripcion_obligatoria";
            this.lbl_descripcion_obligatoria.Size = new System.Drawing.Size(17, 24);
            this.lbl_descripcion_obligatoria.TabIndex = 11;
            this.lbl_descripcion_obligatoria.Text = "*";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_descripcion.Location = new System.Drawing.Point(20, 180);
            this.txt_descripcion.MaxLength = 250;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descripcion.Size = new System.Drawing.Size(796, 80);
            this.txt_descripcion.TabIndex = 2;
            // 
            // pnl_inventario_precio
            // 
            this.pnl_inventario_precio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_inventario_precio.BackColor = System.Drawing.Color.White;
            this.pnl_inventario_precio.Controls.Add(this.lbl_inventario_precio);
            this.pnl_inventario_precio.Controls.Add(this.lbl_stock);
            this.pnl_inventario_precio.Controls.Add(this.lbl_stock_obligatorio);
            this.pnl_inventario_precio.Controls.Add(this.txt_stock);
            this.pnl_inventario_precio.Controls.Add(this.lbl_itbis);
            this.pnl_inventario_precio.Controls.Add(this.lbl_itbis_obligatorio);
            this.pnl_inventario_precio.Controls.Add(this.txt_itbis);
            this.pnl_inventario_precio.Controls.Add(this.lbl_precio);
            this.pnl_inventario_precio.Controls.Add(this.lbl_precio_obligatorio);
            this.pnl_inventario_precio.Controls.Add(this.txt_precio);
            this.pnl_inventario_precio.Controls.Add(this.lbl_campos_obligatorios);
            this.pnl_inventario_precio.Location = new System.Drawing.Point(30, 400);
            this.pnl_inventario_precio.Name = "pnl_inventario_precio";
            this.pnl_inventario_precio.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_inventario_precio.Size = new System.Drawing.Size(840, 175);
            this.pnl_inventario_precio.TabIndex = 3;
            // 
            // lbl_inventario_precio
            // 
            this.lbl_inventario_precio.AutoSize = true;
            this.lbl_inventario_precio.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventario_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_inventario_precio.Location = new System.Drawing.Point(20, 15);
            this.lbl_inventario_precio.Name = "lbl_inventario_precio";
            this.lbl_inventario_precio.Size = new System.Drawing.Size(203, 30);
            this.lbl_inventario_precio.TabIndex = 0;
            this.lbl_inventario_precio.Text = "Inventario y precio";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_stock.Location = new System.Drawing.Point(20, 57);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(57, 24);
            this.lbl_stock.TabIndex = 1;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_stock_obligatorio
            // 
            this.lbl_stock_obligatorio.AutoSize = true;
            this.lbl_stock_obligatorio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_obligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_stock_obligatorio.Location = new System.Drawing.Point(74, 57);
            this.lbl_stock_obligatorio.Name = "lbl_stock_obligatorio";
            this.lbl_stock_obligatorio.Size = new System.Drawing.Size(17, 24);
            this.lbl_stock_obligatorio.TabIndex = 2;
            this.lbl_stock_obligatorio.Text = "*";
            // 
            // txt_stock
            // 
            this.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stock.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_stock.Location = new System.Drawing.Point(20, 84);
            this.txt_stock.MaxLength = 10;
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(245, 28);
            this.txt_stock.TabIndex = 0;
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_itbis
            // 
            this.lbl_itbis.AutoSize = true;
            this.lbl_itbis.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itbis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_itbis.Location = new System.Drawing.Point(298, 57);
            this.lbl_itbis.Name = "lbl_itbis";
            this.lbl_itbis.Size = new System.Drawing.Size(61, 24);
            this.lbl_itbis.TabIndex = 4;
            this.lbl_itbis.Text = "ITBIS:";
            // 
            // lbl_itbis_obligatorio
            // 
            this.lbl_itbis_obligatorio.AutoSize = true;
            this.lbl_itbis_obligatorio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itbis_obligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_itbis_obligatorio.Location = new System.Drawing.Point(356, 57);
            this.lbl_itbis_obligatorio.Name = "lbl_itbis_obligatorio";
            this.lbl_itbis_obligatorio.Size = new System.Drawing.Size(17, 24);
            this.lbl_itbis_obligatorio.TabIndex = 5;
            this.lbl_itbis_obligatorio.Text = "*";
            // 
            // txt_itbis
            // 
            this.txt_itbis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itbis.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itbis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_itbis.Location = new System.Drawing.Point(298, 84);
            this.txt_itbis.MaxLength = 10;
            this.txt_itbis.Name = "txt_itbis";
            this.txt_itbis.Size = new System.Drawing.Size(245, 28);
            this.txt_itbis.TabIndex = 1;
            this.txt_itbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_precio.Location = new System.Drawing.Point(576, 57);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(63, 24);
            this.lbl_precio.TabIndex = 7;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_precio_obligatorio
            // 
            this.lbl_precio_obligatorio.AutoSize = true;
            this.lbl_precio_obligatorio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_obligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_precio_obligatorio.Location = new System.Drawing.Point(637, 57);
            this.lbl_precio_obligatorio.Name = "lbl_precio_obligatorio";
            this.lbl_precio_obligatorio.Size = new System.Drawing.Size(17, 24);
            this.lbl_precio_obligatorio.TabIndex = 8;
            this.lbl_precio_obligatorio.Text = "*";
            // 
            // txt_precio
            // 
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precio.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_precio.Location = new System.Drawing.Point(576, 84);
            this.txt_precio.MaxLength = 15;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(240, 28);
            this.txt_precio.TabIndex = 2;
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_campos_obligatorios
            // 
            this.lbl_campos_obligatorios.AutoSize = true;
            this.lbl_campos_obligatorios.Font = new System.Drawing.Font("Lexend", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campos_obligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_campos_obligatorios.Location = new System.Drawing.Point(20, 132);
            this.lbl_campos_obligatorios.Name = "lbl_campos_obligatorios";
            this.lbl_campos_obligatorios.Size = new System.Drawing.Size(164, 22);
            this.lbl_campos_obligatorios.TabIndex = 10;
            this.lbl_campos_obligatorios.Text = "* Campos obligatorios";
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_guardar);
            this.pnl_acciones.Controls.Add(this.btn_cancelar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 587);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size = new System.Drawing.Size(840, 70);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(18, 15);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(145, 40);
            this.btn_guardar.TabIndex = 0;
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
            this.btn_cancelar.Location = new System.Drawing.Point(677, 15);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(145, 40);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // modulo_de_editar_producto
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_inventario_precio);
            this.Controls.Add(this.pnl_informacion_producto);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_editar_producto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Producto - Go Fitness Gym";
            this.pnl_informacion_producto.ResumeLayout(false);
            this.pnl_informacion_producto.PerformLayout();
            this.pnl_inventario_precio.ResumeLayout(false);
            this.pnl_inventario_precio.PerformLayout();
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
            lbl_ayuda_codigo;

        private System.Windows.Forms.Label
            lbl_nombre_producto;

        private System.Windows.Forms.Label
            lbl_nombre_obligatorio;

        private System.Windows.Forms.TextBox
            txt_nombre_producto;

        private System.Windows.Forms.Label
            lbl_proveedor;

        private System.Windows.Forms.Label
            lbl_proveedor_obligatorio;

        private System.Windows.Forms.TextBox
            txt_proveedor;

        private System.Windows.Forms.Label
            lbl_descripcion;

        private System.Windows.Forms.Label
            lbl_descripcion_obligatoria;

        private System.Windows.Forms.TextBox
            txt_descripcion;

        private System.Windows.Forms.Panel
            pnl_inventario_precio;

        private System.Windows.Forms.Label
            lbl_inventario_precio;

        private System.Windows.Forms.Label
            lbl_stock;

        private System.Windows.Forms.Label
            lbl_stock_obligatorio;

        private System.Windows.Forms.TextBox
            txt_stock;

        private System.Windows.Forms.Label
            lbl_itbis;

        private System.Windows.Forms.Label
            lbl_itbis_obligatorio;

        private System.Windows.Forms.TextBox
            txt_itbis;

        private System.Windows.Forms.Label
            lbl_precio;

        private System.Windows.Forms.Label
            lbl_precio_obligatorio;

        private System.Windows.Forms.TextBox
            txt_precio;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios;

        private System.Windows.Forms.Panel
            pnl_acciones;

        private System.Windows.Forms.Button
            btn_guardar;

        private System.Windows.Forms.Button
            btn_cancelar;
    }
}