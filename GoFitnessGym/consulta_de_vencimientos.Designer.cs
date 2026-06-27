namespace GoFitnessGym
{
    partial class consulta_de_vencimientos
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
            this.pnl_filtros = new System.Windows.Forms.Panel();
            this.lbl_fecha_desde = new System.Windows.Forms.Label();
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_hasta = new System.Windows.Forms.Label();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_membresia = new System.Windows.Forms.Label();
            this.cbo_tipo_membresia = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.dgv_vencimientos = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo_membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dias_restantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_total_registros = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_filtros.SuspendLayout();
            this.pnl_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vencimientos)).BeginInit();
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
            this.lbl_titulo.Size = new System.Drawing.Size(320, 31);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Consulta de Vencimientos";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 52);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(450, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Consulte las membresías próximas a vencer y vencidas";
            // 
            // pnl_filtros
            // 
            this.pnl_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_filtros.BackColor = System.Drawing.Color.White;
            this.pnl_filtros.Controls.Add(this.lbl_fecha_desde);
            this.pnl_filtros.Controls.Add(this.dtp_fecha_desde);
            this.pnl_filtros.Controls.Add(this.lbl_fecha_hasta);
            this.pnl_filtros.Controls.Add(this.dtp_fecha_hasta);
            this.pnl_filtros.Controls.Add(this.lbl_estado);
            this.pnl_filtros.Controls.Add(this.cbo_estado);
            this.pnl_filtros.Controls.Add(this.lbl_tipo_membresia);
            this.pnl_filtros.Controls.Add(this.cbo_tipo_membresia);
            this.pnl_filtros.Controls.Add(this.btn_buscar);
            this.pnl_filtros.Controls.Add(this.btn_limpiar);
            this.pnl_filtros.Location = new System.Drawing.Point(30, 95);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_filtros.Size = new System.Drawing.Size(940, 120);
            this.pnl_filtros.TabIndex = 2;
            // 
            // lbl_fecha_desde
            // 
            this.lbl_fecha_desde.AutoSize = true;
            this.lbl_fecha_desde.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_fecha_desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_desde.Location = new System.Drawing.Point(20, 20);
            this.lbl_fecha_desde.Name = "lbl_fecha_desde";
            this.lbl_fecha_desde.Size = new System.Drawing.Size(100, 24);
            this.lbl_fecha_desde.TabIndex = 0;
            this.lbl_fecha_desde.Text = "Fecha desde:";
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_desde.Font = new System.Drawing.Font("Lexend", 10F);
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(20, 47);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(200, 28);
            this.dtp_fecha_desde.TabIndex = 1;
            // 
            // lbl_fecha_hasta
            // 
            this.lbl_fecha_hasta.AutoSize = true;
            this.lbl_fecha_hasta.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_fecha_hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_hasta.Location = new System.Drawing.Point(240, 20);
            this.lbl_fecha_hasta.Name = "lbl_fecha_hasta";
            this.lbl_fecha_hasta.Size = new System.Drawing.Size(95, 24);
            this.lbl_fecha_hasta.TabIndex = 2;
            this.lbl_fecha_hasta.Text = "Fecha hasta:";
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_hasta.Font = new System.Drawing.Font("Lexend", 10F);
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(240, 47);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(200, 28);
            this.dtp_fecha_hasta.TabIndex = 3;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_estado.Location = new System.Drawing.Point(460, 20);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(60, 24);
            this.lbl_estado.TabIndex = 4;
            this.lbl_estado.Text = "Estado:";
            // 
            // cbo_estado
            // 
            this.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_estado.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Items.AddRange(new object[] {
            "Todos",
            "Próximos a vencer (7 días)",
            "Próximos a vencer (15 días)",
            "Próximos a vencer (30 días)",
            "Vencidos"});
            this.cbo_estado.Location = new System.Drawing.Point(460, 47);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(200, 33);
            this.cbo_estado.TabIndex = 5;
            // 
            // lbl_tipo_membresia
            // 
            this.lbl_tipo_membresia.AutoSize = true;
            this.lbl_tipo_membresia.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_tipo_membresia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_tipo_membresia.Location = new System.Drawing.Point(680, 20);
            this.lbl_tipo_membresia.Name = "lbl_tipo_membresia";
            this.lbl_tipo_membresia.Size = new System.Drawing.Size(130, 24);
            this.lbl_tipo_membresia.TabIndex = 6;
            this.lbl_tipo_membresia.Text = "Tipo membresía:";
            // 
            // cbo_tipo_membresia
            // 
            this.cbo_tipo_membresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_membresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_tipo_membresia.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_tipo_membresia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_tipo_membresia.FormattingEnabled = true;
            this.cbo_tipo_membresia.Items.AddRange(new object[] {
            "Todas",
            "Diaria",
            "Semanal",
            "Quincenal",
            "Mensual",
            "Suscripción"});
            this.cbo_tipo_membresia.Location = new System.Drawing.Point(680, 47);
            this.cbo_tipo_membresia.Name = "cbo_tipo_membresia";
            this.cbo_tipo_membresia.Size = new System.Drawing.Size(150, 33);
            this.cbo_tipo_membresia.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(720, 85);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(110, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(840, 85);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(110, 32);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // pnl_tabla
            // 
            this.pnl_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_tabla.BackColor = System.Drawing.Color.White;
            this.pnl_tabla.Controls.Add(this.dgv_vencimientos);
            this.pnl_tabla.Controls.Add(this.lbl_total_registros);
            this.pnl_tabla.Location = new System.Drawing.Point(30, 230);
            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_tabla.Size = new System.Drawing.Size(940, 350);
            this.pnl_tabla.TabIndex = 3;
            // 
            // dgv_vencimientos
            // 
            this.dgv_vencimientos.AllowUserToAddRows = false;
            this.dgv_vencimientos.AllowUserToDeleteRows = false;
            this.dgv_vencimientos.AllowUserToResizeRows = false;
            this.dgv_vencimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vencimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_vencimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_vencimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_vencimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_vencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vencimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_nombre,
            this.col_tipo_membresia,
            this.col_fecha_vencimiento,
            this.col_dias_restantes,
            this.col_estado,
            this.col_telefono});
            this.dgv_vencimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vencimientos.EnableHeadersVisualStyles = false;
            this.dgv_vencimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_vencimientos.Location = new System.Drawing.Point(15, 15);
            this.dgv_vencimientos.MultiSelect = false;
            this.dgv_vencimientos.Name = "dgv_vencimientos";
            this.dgv_vencimientos.ReadOnly = true;
            this.dgv_vencimientos.RowHeadersVisible = false;
            this.dgv_vencimientos.RowHeadersWidth = 51;
            this.dgv_vencimientos.RowTemplate.Height = 35;
            this.dgv_vencimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vencimientos.Size = new System.Drawing.Size(910, 290);
            this.dgv_vencimientos.TabIndex = 0;
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
            this.col_nombre.FillWeight = 140F;
            this.col_nombre.HeaderText = "Nombre Completo";
            this.col_nombre.MinimumWidth = 6;
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_tipo_membresia
            // 
            this.col_tipo_membresia.FillWeight = 100F;
            this.col_tipo_membresia.HeaderText = "Tipo Membresía";
            this.col_tipo_membresia.MinimumWidth = 6;
            this.col_tipo_membresia.Name = "col_tipo_membresia";
            this.col_tipo_membresia.ReadOnly = true;
            // 
            // col_fecha_vencimiento
            // 
            this.col_fecha_vencimiento.FillWeight = 110F;
            this.col_fecha_vencimiento.HeaderText = "Fecha Vencimiento";
            this.col_fecha_vencimiento.MinimumWidth = 6;
            this.col_fecha_vencimiento.Name = "col_fecha_vencimiento";
            this.col_fecha_vencimiento.ReadOnly = true;
            // 
            // col_dias_restantes
            // 
            this.col_dias_restantes.FillWeight = 80F;
            this.col_dias_restantes.HeaderText = "Días Restantes";
            this.col_dias_restantes.MinimumWidth = 6;
            this.col_dias_restantes.Name = "col_dias_restantes";
            this.col_dias_restantes.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.FillWeight = 90F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.MinimumWidth = 6;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // col_telefono
            // 
            this.col_telefono.FillWeight = 100F;
            this.col_telefono.HeaderText = "Teléfono";
            this.col_telefono.MinimumWidth = 6;
            this.col_telefono.Name = "col_telefono";
            this.col_telefono.ReadOnly = true;
            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_total_registros.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_total_registros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_total_registros.Location = new System.Drawing.Point(15, 305);
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
            this.pnl_acciones.Controls.Add(this.btn_exportar);
            this.pnl_acciones.Controls.Add(this.btn_cerrar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 595);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size = new System.Drawing.Size(940, 70);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.ForeColor = System.Drawing.Color.White;
            this.btn_exportar.Location = new System.Drawing.Point(20, 15);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(130, 40);
            this.btn_exportar.TabIndex = 0;
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
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(130, 40);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // consulta_de_vencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_tabla);
            this.Controls.Add(this.pnl_filtros);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "consulta_de_vencimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vencimientos - Go Fitness";
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            this.pnl_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vencimientos)).EndInit();
            this.pnl_acciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel pnl_filtros;
        private System.Windows.Forms.Label lbl_fecha_desde;
        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.Label lbl_fecha_hasta;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cbo_estado;
        private System.Windows.Forms.Label lbl_tipo_membresia;
        private System.Windows.Forms.ComboBox cbo_tipo_membresia;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Panel pnl_tabla;
        private System.Windows.Forms.DataGridView dgv_vencimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo_membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dias_restantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telefono;
        private System.Windows.Forms.Label lbl_total_registros;
        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}