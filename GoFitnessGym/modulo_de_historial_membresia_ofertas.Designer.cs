namespace GoFitnessGym
{
    partial class modulo_de_historial_membresia_ofertas
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
            this.btn_ver_detalle = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.lbl_total_registros = new System.Windows.Forms.Label();
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_ofe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inicio_ofe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fin_ofe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_contenedor.Controls.Add(this.btn_cerrar);
            this.panel_contenedor.Controls.Add(this.btn_ver_detalle);
            this.panel_contenedor.Controls.Add(this.btn_exportar);
            this.panel_contenedor.Controls.Add(this.lbl_total_registros);
            this.panel_contenedor.Controls.Add(this.dgv_historial);
            this.panel_contenedor.Controls.Add(this.btn_limpiar);
            this.panel_contenedor.Controls.Add(this.btn_buscar);
            this.panel_contenedor.Controls.Add(this.dtp_hasta);
            this.panel_contenedor.Controls.Add(this.lbl_hasta);
            this.panel_contenedor.Controls.Add(this.dtp_desde);
            this.panel_contenedor.Controls.Add(this.lbl_desde);
            this.panel_contenedor.Controls.Add(this.cmb_filtro);
            this.panel_contenedor.Controls.Add(this.lbl_filtro);
            this.panel_contenedor.Controls.Add(this.txt_buscar);
            this.panel_contenedor.Controls.Add(this.lbl_buscar);
            this.panel_contenedor.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_contenedor.Location = new System.Drawing.Point(12, 73);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(801, 411);
            this.panel_contenedor.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(681, 361);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(100, 32);
            this.btn_cerrar.TabIndex = 16;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;
            this.btn_ver_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalle.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_detalle.ForeColor = System.Drawing.Color.White;
            this.btn_ver_detalle.Location = new System.Drawing.Point(143, 361);
            this.btn_ver_detalle.Name = "btn_ver_detalle";
            this.btn_ver_detalle.Size = new System.Drawing.Size(120, 32);
            this.btn_ver_detalle.TabIndex = 15;
            this.btn_ver_detalle.Text = "Ver Detalle";
            this.btn_ver_detalle.UseVisualStyleBackColor = false;
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.ForeColor = System.Drawing.Color.White;
            this.btn_exportar.Location = new System.Drawing.Point(7, 361);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(130, 32);
            this.btn_exportar.TabIndex = 14;
            this.btn_exportar.Text = "Exportar Reporte";
            this.btn_exportar.UseVisualStyleBackColor = false;
            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.AutoSize = true;
            this.lbl_total_registros.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_registros.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_total_registros.Location = new System.Drawing.Point(4, 334);
            this.lbl_total_registros.Name = "lbl_total_registros";
            this.lbl_total_registros.Size = new System.Drawing.Size(111, 17);
            this.lbl_total_registros.TabIndex = 13;
            this.lbl_total_registros.Text = "Total de registros: 0";
            // 
            // dgv_historial
            // 
            this.dgv_historial.AllowUserToAddRows = false;
            this.dgv_historial.AllowUserToDeleteRows = false;
            this.dgv_historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_historial.BackgroundColor = System.Drawing.Color.White;
            this.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_nombre,
            this.col_tipo,
            this.col_duracion,
            this.col_precio_reg,
            this.col_precio_ofe,
            this.col_inicio_ofe,
            this.col_fin_ofe,
            this.col_estado});
            this.dgv_historial.Location = new System.Drawing.Point(3, 71);
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.ReadOnly = true;
            this.dgv_historial.RowHeadersVisible = false;
            this.dgv_historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historial.Size = new System.Drawing.Size(793, 260);
            this.dgv_historial.TabIndex = 12;
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
            // col_precio_reg
            // 
            this.col_precio_reg.FillWeight = 80F;
            this.col_precio_reg.HeaderText = "Precio Reg.";
            this.col_precio_reg.Name = "col_precio_reg";
            this.col_precio_reg.ReadOnly = true;
            // 
            // col_precio_ofe
            // 
            this.col_precio_ofe.FillWeight = 80F;
            this.col_precio_ofe.HeaderText = "Precio Ofe.";
            this.col_precio_ofe.Name = "col_precio_ofe";
            this.col_precio_ofe.ReadOnly = true;
            // 
            // col_inicio_ofe
            // 
            this.col_inicio_ofe.FillWeight = 75F;
            this.col_inicio_ofe.HeaderText = "Inicio Ofe.";
            this.col_inicio_ofe.Name = "col_inicio_ofe";
            this.col_inicio_ofe.ReadOnly = true;
            // 
            // col_fin_ofe
            // 
            this.col_fin_ofe.FillWeight = 75F;
            this.col_fin_ofe.HeaderText = "Fin Ofe.";
            this.col_fin_ofe.Name = "col_fin_ofe";
            this.col_fin_ofe.ReadOnly = true;
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
            this.btn_limpiar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(726, 25);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(55, 25);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(665, 25);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(55, 25);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(564, 29);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(95, 21);
            this.dtp_hasta.TabIndex = 9;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Location = new System.Drawing.Point(516, 31);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(42, 17);
            this.lbl_hasta.TabIndex = 8;
            this.lbl_hasta.Text = "Hasta:";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(417, 29);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(95, 21);
            this.dtp_desde.TabIndex = 7;
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(368, 29);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(43, 17);
            this.lbl_desde.TabIndex = 6;
            this.lbl_desde.Text = "Desde:";
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "Todos",
            "Membresías Regulares",
            "Ofertas Vencidas",
            "Ofertas Vigentes"});
            this.cmb_filtro.Location = new System.Drawing.Point(233, 25);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(125, 25);
            this.cmb_filtro.TabIndex = 5;
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(190, 29);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(39, 17);
            this.lbl_filtro.TabIndex = 4;
            this.lbl_filtro.Text = "Filtro:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(57, 29);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(125, 21);
            this.txt_buscar.TabIndex = 3;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(4, 29);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(47, 17);
            this.lbl_buscar.TabIndex = 2;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_subtitulo.Location = new System.Drawing.Point(15, 42);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(398, 17);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Registro  de vigencias, cambios de tarifa y ofertas promocionales pasadas";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(378, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Historial de Membresías y Ofertas";
            // 
            // modulo_de_historial_membresia_ofertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 500);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_subtitulo);
            this.Name = "modulo_de_historial_membresia_ofertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Membresías y Ofertas";
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
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
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView dgv_historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_ofe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inicio_ofe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fin_ofe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_total_registros;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.Button btn_cerrar;
    }
}