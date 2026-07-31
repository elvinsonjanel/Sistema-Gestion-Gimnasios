namespace GoFitnessGym
{
    partial class modulo_de_membresias
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
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ver_detalle = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lbl_total_registros = new System.Windows.Forms.Label();
            this.dgv_membresias = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_regular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_membresias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_contenedor.Controls.Add(this.btn_cerrar);
            this.panel_contenedor.Controls.Add(this.btn_eliminar);
            this.panel_contenedor.Controls.Add(this.btn_ver_detalle);
            this.panel_contenedor.Controls.Add(this.btn_editar);
            this.panel_contenedor.Controls.Add(this.btn_nuevo);
            this.panel_contenedor.Controls.Add(this.lbl_total_registros);
            this.panel_contenedor.Controls.Add(this.dgv_membresias);
            this.panel_contenedor.Controls.Add(this.btn_limpiar);
            this.panel_contenedor.Controls.Add(this.btn_buscar);
            this.panel_contenedor.Controls.Add(this.cmb_filtro);
            this.panel_contenedor.Controls.Add(this.lbl_filtro);
            this.panel_contenedor.Controls.Add(this.txt_buscar);
            this.panel_contenedor.Controls.Add(this.lbl_buscar);
            this.panel_contenedor.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_contenedor.Location = new System.Drawing.Point(12, 62);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(742, 386);
            this.panel_contenedor.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(620, 339);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(100, 31);
            this.btn_cerrar.TabIndex = 14;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(326, 339);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 31);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;
            this.btn_ver_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalle.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_detalle.ForeColor = System.Drawing.Color.White;
            this.btn_ver_detalle.Location = new System.Drawing.Point(220, 339);
            this.btn_ver_detalle.Name = "btn_ver_detalle";
            this.btn_ver_detalle.Size = new System.Drawing.Size(100, 31);
            this.btn_ver_detalle.TabIndex = 12;
            this.btn_ver_detalle.Text = "Ver Detalle";
            this.btn_ver_detalle.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(114, 339);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 31);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Location = new System.Drawing.Point(8, 337);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 31);
            this.btn_nuevo.TabIndex = 10;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.AutoSize = true;
            this.lbl_total_registros.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_registros.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_total_registros.Location = new System.Drawing.Point(5, 317);
            this.lbl_total_registros.Name = "lbl_total_registros";
            this.lbl_total_registros.Size = new System.Drawing.Size(111, 17);
            this.lbl_total_registros.TabIndex = 9;
            this.lbl_total_registros.Text = "Total de registros: 0";
            // 
            // dgv_membresias
            // 
            this.dgv_membresias.AllowUserToAddRows = false;
            this.dgv_membresias.AllowUserToDeleteRows = false;
            this.dgv_membresias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_membresias.BackgroundColor = System.Drawing.Color.White;
            this.dgv_membresias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_membresias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_membresias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_nombre,
            this.col_tipo,
            this.col_duracion,
            this.col_precio_regular,
            this.col_precio_oferta,
            this.col_fecha_inicio,
            this.col_fecha_fin,
            this.col_estado});
            this.dgv_membresias.Location = new System.Drawing.Point(2, 66);
            this.dgv_membresias.Name = "dgv_membresias";
            this.dgv_membresias.ReadOnly = true;
            this.dgv_membresias.RowHeadersVisible = false;
            this.dgv_membresias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_membresias.Size = new System.Drawing.Size(735, 248);
            this.dgv_membresias.TabIndex = 8;
            // 
            // col_codigo
            // 
            this.col_codigo.FillWeight = 65F;
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_nombre
            // 
            this.col_nombre.FillWeight = 120F;
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_tipo
            // 
            this.col_tipo.FillWeight = 60F;
            this.col_tipo.HeaderText = "Tipo";
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.ReadOnly = true;
            // 
            // col_duracion
            // 
            this.col_duracion.FillWeight = 65F;
            this.col_duracion.HeaderText = "Duración";
            this.col_duracion.Name = "col_duracion";
            this.col_duracion.ReadOnly = true;
            // 
            // col_precio_regular
            // 
            this.col_precio_regular.FillWeight = 80F;
            this.col_precio_regular.HeaderText = "Precio Reg.";
            this.col_precio_regular.Name = "col_precio_regular";
            this.col_precio_regular.ReadOnly = true;
            // 
            // col_precio_oferta
            // 
            this.col_precio_oferta.FillWeight = 80F;
            this.col_precio_oferta.HeaderText = "Precio Ofe.";
            this.col_precio_oferta.Name = "col_precio_oferta";
            this.col_precio_oferta.ReadOnly = true;
            // 
            // col_fecha_inicio
            // 
            this.col_fecha_inicio.FillWeight = 75F;
            this.col_fecha_inicio.HeaderText = "Inicio Ofe.";
            this.col_fecha_inicio.Name = "col_fecha_inicio";
            this.col_fecha_inicio.ReadOnly = true;
            // 
            // col_fecha_fin
            // 
            this.col_fecha_fin.FillWeight = 75F;
            this.col_fecha_fin.HeaderText = "Fin Ofe.";
            this.col_fecha_fin.Name = "col_fecha_fin";
            this.col_fecha_fin.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.FillWeight = 65F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(630, 17);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(90, 26);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(530, 17);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(90, 26);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "Todos",
            "Membresías Regulares",
            "Ofertas Temporales",
            "Activos",
            "Vencidos"});
            this.cmb_filtro.Location = new System.Drawing.Point(355, 19);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(160, 23);
            this.cmb_filtro.TabIndex = 5;
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(310, 23);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(39, 15);
            this.lbl_filtro.TabIndex = 4;
            this.lbl_filtro.Text = "Filtro:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(70, 19);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(220, 23);
            this.txt_buscar.TabIndex = 3;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(16, 22);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(47, 15);
            this.lbl_buscar.TabIndex = 2;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_subtitulo.Location = new System.Drawing.Point(12, 42);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(312, 17);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Administre los planes regulares y las ofertas promocionales";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(7, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(357, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Gestionar Membresías y Ofertas";
            // 
            // modulo_de_membresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 460);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_subtitulo);
            this.Name = "modulo_de_membresias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Membresías y Ofertas";
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_membresias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView dgv_membresias;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_regular;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_total_registros;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}