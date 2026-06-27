namespace GoFitnessGym
{
    partial class consulta_de_clientes
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
            this.lbl_filtro_campo = new System.Windows.Forms.Label();
            this.cbo_filtro_campo = new System.Windows.Forms.ComboBox();
            this.lbl_filtro_estado = new System.Windows.Forms.Label();
            this.cbo_filtro_estado = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_total_registros = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_ver_detalle = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
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
            this.lbl_titulo.Location = new System.Drawing.Point(30, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(234, 31);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Consultar Clientes";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 52);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(498, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Busque y visualice la información de los socios registrados";
            // 
            // pnl_busqueda
            // 
            this.pnl_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_busqueda.BackColor = System.Drawing.Color.White;
            this.pnl_busqueda.Controls.Add(this.lbl_buscar);
            this.pnl_busqueda.Controls.Add(this.txt_busqueda);
            this.pnl_busqueda.Controls.Add(this.lbl_filtro_campo);
            this.pnl_busqueda.Controls.Add(this.cbo_filtro_campo);
            this.pnl_busqueda.Controls.Add(this.lbl_filtro_estado);
            this.pnl_busqueda.Controls.Add(this.cbo_filtro_estado);
            this.pnl_busqueda.Controls.Add(this.btn_buscar);
            this.pnl_busqueda.Controls.Add(this.btn_limpiar);
            this.pnl_busqueda.Location = new System.Drawing.Point(30, 85);
            this.pnl_busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_busqueda.Name = "pnl_busqueda";
            this.pnl_busqueda.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
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
            this.txt_busqueda.Location = new System.Drawing.Point(87, 17);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(196, 28);
            this.txt_busqueda.TabIndex = 1;
            // 
            // lbl_filtro_campo
            // 
            this.lbl_filtro_campo.AutoSize = true;
            this.lbl_filtro_campo.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_filtro_campo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_filtro_campo.Location = new System.Drawing.Point(293, 20);
            this.lbl_filtro_campo.Name = "lbl_filtro_campo";
            this.lbl_filtro_campo.Size = new System.Drawing.Size(68, 24);
            this.lbl_filtro_campo.TabIndex = 2;
            this.lbl_filtro_campo.Text = "Campo:";
            // 
            // cbo_filtro_campo
            // 
            this.cbo_filtro_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtro_campo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_filtro_campo.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_filtro_campo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_filtro_campo.FormattingEnabled = true;
            this.cbo_filtro_campo.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Apellido",
            "Documento",
            "Teléfono"});
            this.cbo_filtro_campo.Location = new System.Drawing.Point(356, 16);
            this.cbo_filtro_campo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_filtro_campo.Name = "cbo_filtro_campo";
            this.cbo_filtro_campo.Size = new System.Drawing.Size(134, 35);
            this.cbo_filtro_campo.TabIndex = 3;
            // 
            // lbl_filtro_estado
            // 
            this.lbl_filtro_estado.AutoSize = true;
            this.lbl_filtro_estado.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_filtro_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_filtro_estado.Location = new System.Drawing.Point(507, 20);
            this.lbl_filtro_estado.Name = "lbl_filtro_estado";
            this.lbl_filtro_estado.Size = new System.Drawing.Size(67, 24);
            this.lbl_filtro_estado.TabIndex = 4;
            this.lbl_filtro_estado.Text = "Estado:";
            // 
            // cbo_filtro_estado
            // 
            this.cbo_filtro_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_filtro_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtro_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_filtro_estado.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_filtro_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_filtro_estado.FormattingEnabled = true;
            this.cbo_filtro_estado.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Vencidos",
            "Con deuda",
            "Próximos a vencer"});
            this.cbo_filtro_estado.Location = new System.Drawing.Point(567, 16);
            this.cbo_filtro_estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_filtro_estado.Name = "cbo_filtro_estado";
            this.cbo_filtro_estado.Size = new System.Drawing.Size(152, 35);
            this.cbo_filtro_estado.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(733, 14);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 32);
            this.btn_buscar.TabIndex = 6;
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
            this.btn_limpiar.Location = new System.Drawing.Point(831, 14);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 32);
            this.btn_limpiar.TabIndex = 7;
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
            this.pnl_tabla.Location = new System.Drawing.Point(30, 170);
            this.pnl_tabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.pnl_tabla.Size = new System.Drawing.Size(940, 264);
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
            this.col_membresia,
            this.col_estado,
            this.col_vencimiento,
            this.col_saldo});
            this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_clientes.Location = new System.Drawing.Point(15, 15);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 35;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(910, 204);
            this.dgv_clientes.TabIndex = 0;
            // 
            // col_codigo
            // 
            this.col_codigo.FillWeight = 55F;
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.MinimumWidth = 6;
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.MinimumWidth = 6;
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.MinimumWidth = 6;
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            // 
            // col_telefono
            // 
            this.col_telefono.FillWeight = 95F;
            this.col_telefono.HeaderText = "Teléfono";
            this.col_telefono.MinimumWidth = 6;
            this.col_telefono.Name = "col_telefono";
            this.col_telefono.ReadOnly = true;
            // 
            // col_documento
            // 
            this.col_documento.HeaderText = "Documento";
            this.col_documento.MinimumWidth = 6;
            this.col_documento.Name = "col_documento";
            this.col_documento.ReadOnly = true;
            // 
            // col_membresia
            // 
            this.col_membresia.FillWeight = 95F;
            this.col_membresia.HeaderText = "Membresía";
            this.col_membresia.MinimumWidth = 6;
            this.col_membresia.Name = "col_membresia";
            this.col_membresia.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.FillWeight = 80F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.MinimumWidth = 6;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // col_vencimiento
            // 
            this.col_vencimiento.FillWeight = 95F;
            this.col_vencimiento.HeaderText = "Vencimiento";
            this.col_vencimiento.MinimumWidth = 6;
            this.col_vencimiento.Name = "col_vencimiento";
            this.col_vencimiento.ReadOnly = true;
            // 
            // col_saldo
            // 
            this.col_saldo.FillWeight = 80F;
            this.col_saldo.HeaderText = "Saldo";
            this.col_saldo.MinimumWidth = 6;
            this.col_saldo.Name = "col_saldo";
            this.col_saldo.ReadOnly = true;
            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_total_registros.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_total_registros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_total_registros.Location = new System.Drawing.Point(15, 219);
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
            this.pnl_acciones.Controls.Add(this.btn_ver_detalle);
            this.pnl_acciones.Controls.Add(this.btn_exportar);
            this.pnl_acciones.Controls.Add(this.btn_cerrar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 450);
            this.pnl_acciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.pnl_acciones.Size = new System.Drawing.Size(940, 70);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;
            this.btn_ver_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalle.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_detalle.ForeColor = System.Drawing.Color.White;
            this.btn_ver_detalle.Location = new System.Drawing.Point(20, 15);
            this.btn_ver_detalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ver_detalle.Name = "btn_ver_detalle";
            this.btn_ver_detalle.Size = new System.Drawing.Size(130, 40);
            this.btn_ver_detalle.TabIndex = 0;
            this.btn_ver_detalle.Text = "Ver Detalle";
            this.btn_ver_detalle.UseVisualStyleBackColor = false;
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.ForeColor = System.Drawing.Color.White;
            this.btn_exportar.Location = new System.Drawing.Point(160, 15);
            this.btn_exportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(130, 40);
            this.btn_exportar.TabIndex = 1;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = false;
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
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(130, 40);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // consulta_de_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 551);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_tabla);
            this.Controls.Add(this.pnl_busqueda);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(799, 598);
            this.Name = "consulta_de_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes - Go Fitness";
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
        private System.Windows.Forms.Label lbl_filtro_campo;
        private System.Windows.Forms.ComboBox cbo_filtro_campo;
        private System.Windows.Forms.Label lbl_filtro_estado;
        private System.Windows.Forms.ComboBox cbo_filtro_estado;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Panel pnl_tabla;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_saldo;
        private System.Windows.Forms.Label lbl_total_registros;
        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}