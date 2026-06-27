namespace GoFitnessGym
{
    partial class consulta_de_asistencia
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
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.dgv_asistencia = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_total_registros = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_filtros.SuspendLayout();
            this.pnl_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asistencia)).BeginInit();
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
            this.lbl_titulo.Size = new System.Drawing.Size(287, 31);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Consulta de Asistencia";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 52);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(410, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Consulte el historial de asistencia de los clientes";
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
            this.pnl_filtros.Controls.Add(this.lbl_cliente);
            this.pnl_filtros.Controls.Add(this.txt_cliente);
            this.pnl_filtros.Controls.Add(this.btn_buscar);
            this.pnl_filtros.Controls.Add(this.btn_limpiar);
            this.pnl_filtros.Location = new System.Drawing.Point(30, 95);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_filtros.Size = new System.Drawing.Size(940, 85);
            this.pnl_filtros.TabIndex = 2;
            // 
            // lbl_fecha_desde
            // 
            this.lbl_fecha_desde.AutoSize = true;
            this.lbl_fecha_desde.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_fecha_desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_desde.Location = new System.Drawing.Point(20, 20);
            this.lbl_fecha_desde.Name = "lbl_fecha_desde";
            this.lbl_fecha_desde.Size = new System.Drawing.Size(110, 24);
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
            this.lbl_fecha_hasta.Size = new System.Drawing.Size(108, 24);
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
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_cliente.Location = new System.Drawing.Point(460, 20);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(68, 24);
            this.lbl_cliente.TabIndex = 4;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cliente.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_cliente.Location = new System.Drawing.Point(460, 47);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(213, 28);
            this.txt_cliente.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(694, 44);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(110, 32);
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
            this.btn_limpiar.Location = new System.Drawing.Point(812, 44);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(110, 32);
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
            this.pnl_tabla.Controls.Add(this.dgv_asistencia);
            this.pnl_tabla.Controls.Add(this.lbl_total_registros);
            this.pnl_tabla.Location = new System.Drawing.Point(30, 195);
            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_tabla.Size = new System.Drawing.Size(940, 380);
            this.pnl_tabla.TabIndex = 3;
            // 
            // dgv_asistencia
            // 
            this.dgv_asistencia.AllowUserToAddRows = false;
            this.dgv_asistencia.AllowUserToDeleteRows = false;
            this.dgv_asistencia.AllowUserToResizeRows = false;
            this.dgv_asistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_asistencia.BackgroundColor = System.Drawing.Color.White;
            this.dgv_asistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_asistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_asistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_nombre,
            this.col_fecha_entrada,
            this.col_hora_entrada,
            this.col_hora_salida,
            this.col_duracion});
            this.dgv_asistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_asistencia.EnableHeadersVisualStyles = false;
            this.dgv_asistencia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_asistencia.Location = new System.Drawing.Point(15, 15);
            this.dgv_asistencia.MultiSelect = false;
            this.dgv_asistencia.Name = "dgv_asistencia";
            this.dgv_asistencia.ReadOnly = true;
            this.dgv_asistencia.RowHeadersVisible = false;
            this.dgv_asistencia.RowHeadersWidth = 51;
            this.dgv_asistencia.RowTemplate.Height = 35;
            this.dgv_asistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_asistencia.Size = new System.Drawing.Size(910, 320);
            this.dgv_asistencia.TabIndex = 0;
            // 
            // col_codigo
            // 
            this.col_codigo.FillWeight = 80F;
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.MinimumWidth = 6;
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_nombre
            // 
            this.col_nombre.FillWeight = 150F;
            this.col_nombre.HeaderText = "Nombre Completo";
            this.col_nombre.MinimumWidth = 6;
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_fecha_entrada
            // 
            this.col_fecha_entrada.FillWeight = 120F;
            this.col_fecha_entrada.HeaderText = "Fecha Entrada";
            this.col_fecha_entrada.MinimumWidth = 6;
            this.col_fecha_entrada.Name = "col_fecha_entrada";
            this.col_fecha_entrada.ReadOnly = true;
            // 
            // col_hora_entrada
            // 
            this.col_hora_entrada.HeaderText = "Hora Entrada";
            this.col_hora_entrada.MinimumWidth = 6;
            this.col_hora_entrada.Name = "col_hora_entrada";
            this.col_hora_entrada.ReadOnly = true;
            // 
            // col_hora_salida
            // 
            this.col_hora_salida.HeaderText = "Hora Salida";
            this.col_hora_salida.MinimumWidth = 6;
            this.col_hora_salida.Name = "col_hora_salida";
            this.col_hora_salida.ReadOnly = true;
            // 
            // col_duracion
            // 
            this.col_duracion.HeaderText = "Duración";
            this.col_duracion.MinimumWidth = 6;
            this.col_duracion.Name = "col_duracion";
            this.col_duracion.ReadOnly = true;
            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_total_registros.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_total_registros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_total_registros.Location = new System.Drawing.Point(15, 335);
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
            this.pnl_acciones.Location = new System.Drawing.Point(30, 590);
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
            // consulta_de_asistencia
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
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "consulta_de_asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Asistencia - Go Fitness";
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            this.pnl_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asistencia)).EndInit();
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
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Panel pnl_tabla;
        private System.Windows.Forms.DataGridView dgv_asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hora_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duracion;
        private System.Windows.Forms.Label lbl_total_registros;
        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}