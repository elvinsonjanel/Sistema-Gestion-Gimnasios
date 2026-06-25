namespace GoFitnessGym
{
    partial class modulo_de_clientes
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_total_registros = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_ver_detalle = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_busqueda.SuspendLayout();
            this.pnl_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.pnl_acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lbl_titulo.Location = new System.Drawing.Point(34, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(271, 37);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Gestionar Clientes";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(36, 65);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(415, 25);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Administre los socios registrados en el sistema";
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
            this.pnl_busqueda.Location = new System.Drawing.Point(34, 106);
            this.pnl_busqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.pnl_busqueda.Size = new System.Drawing.Size(1058, 94);
            this.pnl_busqueda.TabIndex = 2;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_buscar.Location = new System.Drawing.Point(22, 25);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(78, 22);
            this.lbl_buscar.TabIndex = 0;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_busqueda.Location = new System.Drawing.Point(135, 21);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(298, 30);
            this.txt_busqueda.TabIndex = 1;
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_filtro.Location = new System.Drawing.Point(456, 25);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(62, 22);
            this.lbl_filtro.TabIndex = 2;
            this.lbl_filtro.Text = "Filtro:";
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_filtro.FormattingEnabled = true;
            this.cbo_filtro.Items.AddRange(new object[] {
            "Todos",
            "Nombre",
            "Apellido",
            "Código",
            "Documento",
            "Teléfono"});
            this.cbo_filtro.Location = new System.Drawing.Point(518, 20);
            this.cbo_filtro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Size = new System.Drawing.Size(202, 33);
            this.cbo_filtro.TabIndex = 3;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(742, 18);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(124, 40);
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
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(878, 18);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(124, 40);
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
            this.pnl_tabla.Controls.Add(this.dgv_clientes);
            this.pnl_tabla.Controls.Add(this.lbl_total_registros);
            this.pnl_tabla.Location = new System.Drawing.Point(34, 212);
            this.pnl_tabla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            this.pnl_tabla.Size = new System.Drawing.Size(1058, 330);
            this.pnl_tabla.TabIndex = 3;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AllowUserToResizeRows = false;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_nombre,
            this.col_apellido,
            this.col_telefono,
            this.col_documento,
            this.col_estado,
            this.col_membresia});
            this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_clientes.Location = new System.Drawing.Point(17, 19);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 35;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(1024, 254);
            this.dgv_clientes.TabIndex = 0;
            // 
            // col_codigo
            // 
            this.col_codigo.FillWeight = 60F;
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.MinimumWidth = 6;
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_nombre
            // 
            this.col_nombre.FillWeight = 120F;
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.MinimumWidth = 6;
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_apellido
            // 
            this.col_apellido.FillWeight = 120F;
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.MinimumWidth = 6;
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            // 
            // col_telefono
            // 
            this.col_telefono.FillWeight = 110F;
            this.col_telefono.HeaderText = "Teléfono";
            this.col_telefono.MinimumWidth = 6;
            this.col_telefono.Name = "col_telefono";
            this.col_telefono.ReadOnly = true;
            // 
            // col_documento
            // 
            this.col_documento.FillWeight = 120F;
            this.col_documento.HeaderText = "Documento";
            this.col_documento.MinimumWidth = 6;
            this.col_documento.Name = "col_documento";
            this.col_documento.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.FillWeight = 90F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.MinimumWidth = 6;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // col_membresia
            // 
            this.col_membresia.FillWeight = 110F;
            this.col_membresia.HeaderText = "Membresía";
            this.col_membresia.MinimumWidth = 6;
            this.col_membresia.Name = "col_membresia";
            this.col_membresia.ReadOnly = true;
            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_total_registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_total_registros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_total_registros.Location = new System.Drawing.Point(17, 273);
            this.lbl_total_registros.Name = "lbl_total_registros";
            this.lbl_total_registros.Size = new System.Drawing.Size(1024, 38);
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
            this.pnl_acciones.Location = new System.Drawing.Point(34, 562);
            this.pnl_acciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(17, 19, 17, 19);
            this.pnl_acciones.Size = new System.Drawing.Size(1058, 88);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Location = new System.Drawing.Point(22, 19);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(146, 50);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(180, 19);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(146, 50);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;
            this.btn_ver_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_detalle.ForeColor = System.Drawing.Color.White;
            this.btn_ver_detalle.Location = new System.Drawing.Point(338, 19);
            this.btn_ver_detalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ver_detalle.Name = "btn_ver_detalle";
            this.btn_ver_detalle.Size = new System.Drawing.Size(158, 50);
            this.btn_ver_detalle.TabIndex = 2;
            this.btn_ver_detalle.Text = "Ver Detalle";
            this.btn_ver_detalle.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(506, 19);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(146, 50);
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
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(889, 19);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(146, 50);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // modulo_de_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1125, 680);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_tabla);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(897, 736);
            this.Name = "modulo_de_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Clientes - Go Fitness";
            this.pnl_busqueda.ResumeLayout(false);
            this.pnl_busqueda.PerformLayout();
            this.pnl_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_membresia;
        private System.Windows.Forms.Label lbl_total_registros;
        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}