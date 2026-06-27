namespace GoFitnessGym
{
    partial class modulo_de_inventario
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
            this.pnl_busqueda = new System.Windows.Forms.Panel();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.cbo_filtro = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.dgv_inventario = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stock_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stock_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_total_registros = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_ver_detalle = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).BeginInit();
            this.pnl_acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lbl_titulo.Location = new System.Drawing.Point(30, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(268, 31);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Gestionar Inventario";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 52);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(448, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Controle el stock y las existencias de productos del gimnasio";
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_busqueda.BackColor = System.Drawing.Color.White;
            this.pnl_busqueda.Controls.Add(this.lbl_buscar);
            this.pnl_busqueda.Controls.Add(this.txt_busqueda);
            this.pnl_busqueda.Controls.Add(this.lbl_filtro);
            this.pnl_busqueda.Controls.Add(this.cbo_filtro);
            this.pnl_busqueda.Controls.Add(this.btn_buscar);
            this.pnl_busqueda.Controls.Add(this.btn_limpiar);
            this.pnl_busqueda.Location = new System.Drawing.Point(30, 85);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_busqueda.Size = new System.Drawing.Size(940, 75);
            this.pnl_busqueda.TabIndex = 2;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_buscar.Location = new System.Drawing.Point(20, 20);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(67, 24);
            this.lbl_buscar.TabIndex = 0;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_busqueda.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_busqueda.Location = new System.Drawing.Point(120, 17);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(265, 28);
            this.txt_busqueda.TabIndex = 1;
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_filtro.Location = new System.Drawing.Point(405, 20);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(56, 24);
            this.lbl_filtro.TabIndex = 2;
            this.lbl_filtro.Text = "Filtro:";
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_filtro.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_filtro.FormattingEnabled = true;
            this.cbo_filtro.Items.AddRange(new object[] {
            "Todos",
            "Código",
            "Producto",
            "Categoría",
            "Ubicación",
            "Estado"});
            this.cbo_filtro.Location = new System.Drawing.Point(460, 16);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Size = new System.Drawing.Size(180, 35);
            this.cbo_filtro.TabIndex = 3;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(660, 14);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(110, 32);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(780, 14);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(110, 32);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // pnl_tabla
            // 
            this.pnl_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_tabla.BackColor = System.Drawing.Color.White;
            this.pnl_tabla.Controls.Add(this.dgv_inventario);
            this.pnl_tabla.Controls.Add(this.lbl_total_registros);
            this.pnl_tabla.Location = new System.Drawing.Point(30, 170);
            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_tabla.Size = new System.Drawing.Size(940, 370);
            this.pnl_tabla.TabIndex = 3;
            // 
            // dgv_inventario
            // 
            this.dgv_inventario.AllowUserToAddRows = false;
            this.dgv_inventario.AllowUserToDeleteRows = false;
            this.dgv_inventario.AllowUserToResizeRows = false;
            this.dgv_inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_inventario.BackgroundColor = System.Drawing.Color.White;
            this.dgv_inventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_inventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_producto,
            this.col_categoria,
            this.col_stock_actual,
            this.col_stock_minimo,
            this.col_ubicacion,
            this.col_estado});
            this.dgv_inventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_inventario.EnableHeadersVisualStyles = false;
            this.dgv_inventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_inventario.Location = new System.Drawing.Point(15, 15);
            this.dgv_inventario.MultiSelect = false;
            this.dgv_inventario.Name = "dgv_inventario";
            this.dgv_inventario.ReadOnly = true;
            this.dgv_inventario.RowHeadersVisible = false;
            this.dgv_inventario.RowHeadersWidth = 51;
            this.dgv_inventario.RowTemplate.Height = 35;
            this.dgv_inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_inventario.Size = new System.Drawing.Size(910, 310);
            this.dgv_inventario.TabIndex = 0;
            // 
            // col_codigo
            // 
            this.col_codigo.FillWeight = 60F;
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.MinimumWidth = 6;
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_producto
            // 
            this.col_producto.FillWeight = 130F;
            this.col_producto.HeaderText = "Producto";
            this.col_producto.MinimumWidth = 6;
            this.col_producto.Name = "col_producto";
            this.col_producto.ReadOnly = true;
            // 
            // col_categoria
            // 
            this.col_categoria.FillWeight = 100F;
            this.col_categoria.HeaderText = "Categoría";
            this.col_categoria.MinimumWidth = 6;
            this.col_categoria.Name = "col_categoria";
            this.col_categoria.ReadOnly = true;
            // 
            // col_stock_actual
            // 
            this.col_stock_actual.FillWeight = 80F;
            this.col_stock_actual.HeaderText = "Stock Actual";
            this.col_stock_actual.MinimumWidth = 6;
            this.col_stock_actual.Name = "col_stock_actual";
            this.col_stock_actual.ReadOnly = true;
            // 
            // col_stock_minimo
            // 
            this.col_stock_minimo.FillWeight = 80F;
            this.col_stock_minimo.HeaderText = "Stock Mín.";
            this.col_stock_minimo.MinimumWidth = 6;
            this.col_stock_minimo.Name = "col_stock_minimo";
            this.col_stock_minimo.ReadOnly = true;
            // 
            // col_ubicacion
            // 
            this.col_ubicacion.FillWeight = 100F;
            this.col_ubicacion.HeaderText = "Ubicación";
            this.col_ubicacion.MinimumWidth = 6;
            this.col_ubicacion.Name = "col_ubicacion";
            this.col_ubicacion.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.FillWeight = 90F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.MinimumWidth = 6;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_total_registros.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_total_registros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_total_registros.Location = new System.Drawing.Point(15, 325);
            this.lbl_total_registros.Name = "lbl_total_registros";
            this.lbl_total_registros.Size = new System.Drawing.Size(910, 30);
            this.lbl_total_registros.TabIndex = 1;
            this.lbl_total_registros.Text = "Total de registros: 0";
            this.lbl_total_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_nuevo);
            this.pnl_acciones.Controls.Add(this.btn_editar);
            this.pnl_acciones.Controls.Add(this.btn_ver_detalle);
            this.pnl_acciones.Controls.Add(this.btn_eliminar);
            this.pnl_acciones.Controls.Add(this.btn_cerrar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 555);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size = new System.Drawing.Size(940, 70);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Location = new System.Drawing.Point(20, 15);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(130, 40);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(160, 15);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(130, 40);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ver_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;
            this.btn_ver_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalle.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_detalle.ForeColor = System.Drawing.Color.White;
            this.btn_ver_detalle.Location = new System.Drawing.Point(300, 15);
            this.btn_ver_detalle.Name = "btn_ver_detalle";
            this.btn_ver_detalle.Size = new System.Drawing.Size(140, 40);
            this.btn_ver_detalle.TabIndex = 2;
            this.btn_ver_detalle.Text = "Ver Detalle";
            this.btn_ver_detalle.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(450, 15);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(130, 40);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(790, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(130, 40);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // modulo_de_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_tabla);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "modulo_de_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Inventario - Go Fitness";
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).EndInit();
            this.pnl_acciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel pnl_busqueda;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.ComboBox cbo_filtro;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Panel pnl_tabla;
        private System.Windows.Forms.DataGridView dgv_inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stock_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stock_minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_total_registros;
        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}