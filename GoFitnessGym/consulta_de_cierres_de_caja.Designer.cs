namespace GoFitnessGym
{
    partial class consulta_de_cierres_de_caja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.pnl_filtros = new System.Windows.Forms.Panel();
            this.lbl_fecha_desde = new System.Windows.Forms.Label();
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_hasta = new System.Windows.Forms.Label();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_cajero = new System.Windows.Forms.Label();
            this.cbo_cajero = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.pnl_resumen = new System.Windows.Forms.Panel();
            this.pnl_total_cierres = new System.Windows.Forms.Panel();
            this.lbl_total_cierres_titulo = new System.Windows.Forms.Label();
            this.lbl_total_cierres = new System.Windows.Forms.Label();
            this.pnl_cierres_cuadrados = new System.Windows.Forms.Panel();
            this.lbl_cierres_cuadrados_titulo = new System.Windows.Forms.Label();
            this.lbl_cierres_cuadrados = new System.Windows.Forms.Label();
            this.pnl_cierres_con_diferencia = new System.Windows.Forms.Panel();
            this.lbl_cierres_con_diferencia_titulo = new System.Windows.Forms.Label();
            this.lbl_cierres_con_diferencia = new System.Windows.Forms.Label();
            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.dgv_cierres_de_caja = new System.Windows.Forms.DataGridView();
            this.col_numero_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ingresos_sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_efectivo_esperado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_efectivo_contado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_total_registros = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_ver_detalle = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_filtros.SuspendLayout();
            this.pnl_resumen.SuspendLayout();
            this.pnl_total_cierres.SuspendLayout();
            this.pnl_cierres_cuadrados.SuspendLayout();
            this.pnl_cierres_con_diferencia.SuspendLayout();
            this.pnl_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cierres_de_caja)).BeginInit();
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
            this.lbl_titulo.Size = new System.Drawing.Size(403, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Consulta de Cierres de Caja";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 59);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(539, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Consulte los cierres y cuadres de caja realizados anteriormente";
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
            this.pnl_filtros.Controls.Add(this.lbl_cajero);
            this.pnl_filtros.Controls.Add(this.cbo_cajero);
            this.pnl_filtros.Controls.Add(this.lbl_estado);
            this.pnl_filtros.Controls.Add(this.cbo_estado);
            this.pnl_filtros.Controls.Add(this.btn_buscar);
            this.pnl_filtros.Controls.Add(this.btn_limpiar);
            this.pnl_filtros.Location = new System.Drawing.Point(30, 98);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Padding = new System.Windows.Forms.Padding(18);
            this.pnl_filtros.Size = new System.Drawing.Size(1140, 92);
            this.pnl_filtros.TabIndex = 2;
            // 
            // lbl_fecha_desde
            // 
            this.lbl_fecha_desde.AutoSize = true;
            this.lbl_fecha_desde.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_desde.Location = new System.Drawing.Point(18, 12);
            this.lbl_fecha_desde.Name = "lbl_fecha_desde";
            this.lbl_fecha_desde.Size = new System.Drawing.Size(110, 24);
            this.lbl_fecha_desde.TabIndex = 0;
            this.lbl_fecha_desde.Text = "Fecha desde:";
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.CalendarFont = new System.Drawing.Font("Lexend", 9F);
            this.dtp_fecha_desde.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_desde.Font = new System.Drawing.Font("Lexend", 10F);
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(18, 39);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(165, 28);
            this.dtp_fecha_desde.TabIndex = 1;
            // 
            // lbl_fecha_hasta
            // 
            this.lbl_fecha_hasta.AutoSize = true;
            this.lbl_fecha_hasta.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_fecha_hasta.Location = new System.Drawing.Point(200, 12);
            this.lbl_fecha_hasta.Name = "lbl_fecha_hasta";
            this.lbl_fecha_hasta.Size = new System.Drawing.Size(108, 24);
            this.lbl_fecha_hasta.TabIndex = 2;
            this.lbl_fecha_hasta.Text = "Fecha hasta:";
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.CalendarFont = new System.Drawing.Font("Lexend", 9F);
            this.dtp_fecha_hasta.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_hasta.Font = new System.Drawing.Font("Lexend", 10F);
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(200, 39);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(165, 28);
            this.dtp_fecha_hasta.TabIndex = 3;
            // 
            // lbl_cajero
            // 
            this.lbl_cajero.AutoSize = true;
            this.lbl_cajero.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_cajero.Location = new System.Drawing.Point(382, 12);
            this.lbl_cajero.Name = "lbl_cajero";
            this.lbl_cajero.Size = new System.Drawing.Size(65, 24);
            this.lbl_cajero.TabIndex = 4;
            this.lbl_cajero.Text = "Cajero:";
            // 
            // cbo_cajero
            // 
            this.cbo_cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cajero.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_cajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_cajero.FormattingEnabled = true;
            this.cbo_cajero.Items.AddRange(new object[] {
            "Todos"});
            this.cbo_cajero.Location = new System.Drawing.Point(382, 36);
            this.cbo_cajero.Name = "cbo_cajero";
            this.cbo_cajero.Size = new System.Drawing.Size(210, 35);
            this.cbo_cajero.TabIndex = 5;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_estado.Location = new System.Drawing.Point(609, 12);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(67, 24);
            this.lbl_estado.TabIndex = 6;
            this.lbl_estado.Text = "Estado:";
            // 
            // cbo_estado
            // 
            this.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Items.AddRange(new object[] {
            "Todos",
            "Sin diferencia",
            "Con diferencia"});
            this.cbo_estado.Location = new System.Drawing.Point(609, 36);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(180, 35);
            this.cbo_estado.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(881, 31);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(115, 40);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(1006, 31);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(115, 40);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // pnl_resumen
            // 
            this.pnl_resumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_resumen.BackColor = System.Drawing.Color.Transparent;
            this.pnl_resumen.Controls.Add(this.pnl_total_cierres);
            this.pnl_resumen.Controls.Add(this.pnl_cierres_cuadrados);
            this.pnl_resumen.Controls.Add(this.pnl_cierres_con_diferencia);
            this.pnl_resumen.Location = new System.Drawing.Point(30, 202);
            this.pnl_resumen.Name = "pnl_resumen";
            this.pnl_resumen.Size = new System.Drawing.Size(1140, 83);
            this.pnl_resumen.TabIndex = 3;
            // 
            // pnl_total_cierres
            // 
            this.pnl_total_cierres.BackColor = System.Drawing.Color.White;
            this.pnl_total_cierres.Controls.Add(this.lbl_total_cierres_titulo);
            this.pnl_total_cierres.Controls.Add(this.lbl_total_cierres);
            this.pnl_total_cierres.Location = new System.Drawing.Point(0, 0);
            this.pnl_total_cierres.Name = "pnl_total_cierres";
            this.pnl_total_cierres.Size = new System.Drawing.Size(360, 83);
            this.pnl_total_cierres.TabIndex = 0;
            // 
            // lbl_total_cierres_titulo
            // 
            this.lbl_total_cierres_titulo.AutoSize = true;
            this.lbl_total_cierres_titulo.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_total_cierres_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_total_cierres_titulo.Location = new System.Drawing.Point(18, 12);
            this.lbl_total_cierres_titulo.Name = "lbl_total_cierres_titulo";
            this.lbl_total_cierres_titulo.Size = new System.Drawing.Size(122, 24);
            this.lbl_total_cierres_titulo.TabIndex = 0;
            this.lbl_total_cierres_titulo.Text = "Total de cierres";
            // 
            // lbl_total_cierres
            // 
            this.lbl_total_cierres.AutoSize = true;
            this.lbl_total_cierres.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_total_cierres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.lbl_total_cierres.Location = new System.Drawing.Point(16, 35);
            this.lbl_total_cierres.Name = "lbl_total_cierres";
            this.lbl_total_cierres.Size = new System.Drawing.Size(37, 43);
            this.lbl_total_cierres.TabIndex = 1;
            this.lbl_total_cierres.Text = "0";
            // 
            // pnl_cierres_cuadrados
            // 
            this.pnl_cierres_cuadrados.BackColor = System.Drawing.Color.White;
            this.pnl_cierres_cuadrados.Controls.Add(this.lbl_cierres_cuadrados_titulo);
            this.pnl_cierres_cuadrados.Controls.Add(this.lbl_cierres_cuadrados);
            this.pnl_cierres_cuadrados.Location = new System.Drawing.Point(390, 0);
            this.pnl_cierres_cuadrados.Name = "pnl_cierres_cuadrados";
            this.pnl_cierres_cuadrados.Size = new System.Drawing.Size(360, 83);
            this.pnl_cierres_cuadrados.TabIndex = 1;
            // 
            // lbl_cierres_cuadrados_titulo
            // 
            this.lbl_cierres_cuadrados_titulo.AutoSize = true;
            this.lbl_cierres_cuadrados_titulo.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_cierres_cuadrados_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_cierres_cuadrados_titulo.Location = new System.Drawing.Point(18, 12);
            this.lbl_cierres_cuadrados_titulo.Name = "lbl_cierres_cuadrados_titulo";
            this.lbl_cierres_cuadrados_titulo.Size = new System.Drawing.Size(163, 24);
            this.lbl_cierres_cuadrados_titulo.TabIndex = 0;
            this.lbl_cierres_cuadrados_titulo.Text = "Cierres sin diferencia";
            // 
            // lbl_cierres_cuadrados
            // 
            this.lbl_cierres_cuadrados.AutoSize = true;
            this.lbl_cierres_cuadrados.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_cierres_cuadrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.lbl_cierres_cuadrados.Location = new System.Drawing.Point(16, 35);
            this.lbl_cierres_cuadrados.Name = "lbl_cierres_cuadrados";
            this.lbl_cierres_cuadrados.Size = new System.Drawing.Size(37, 43);
            this.lbl_cierres_cuadrados.TabIndex = 1;
            this.lbl_cierres_cuadrados.Text = "0";
            // 
            // pnl_cierres_con_diferencia
            // 
            this.pnl_cierres_con_diferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_cierres_con_diferencia.BackColor = System.Drawing.Color.White;
            this.pnl_cierres_con_diferencia.Controls.Add(this.lbl_cierres_con_diferencia_titulo);
            this.pnl_cierres_con_diferencia.Controls.Add(this.lbl_cierres_con_diferencia);
            this.pnl_cierres_con_diferencia.Location = new System.Drawing.Point(780, 0);
            this.pnl_cierres_con_diferencia.Name = "pnl_cierres_con_diferencia";
            this.pnl_cierres_con_diferencia.Size = new System.Drawing.Size(360, 83);
            this.pnl_cierres_con_diferencia.TabIndex = 2;
            // 
            // lbl_cierres_con_diferencia_titulo
            // 
            this.lbl_cierres_con_diferencia_titulo.AutoSize = true;
            this.lbl_cierres_con_diferencia_titulo.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_cierres_con_diferencia_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_cierres_con_diferencia_titulo.Location = new System.Drawing.Point(18, 12);
            this.lbl_cierres_con_diferencia_titulo.Name = "lbl_cierres_con_diferencia_titulo";
            this.lbl_cierres_con_diferencia_titulo.Size = new System.Drawing.Size(169, 24);
            this.lbl_cierres_con_diferencia_titulo.TabIndex = 0;
            this.lbl_cierres_con_diferencia_titulo.Text = "Cierres con diferencia";
            // 
            // lbl_cierres_con_diferencia
            // 
            this.lbl_cierres_con_diferencia.AutoSize = true;
            this.lbl_cierres_con_diferencia.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_cierres_con_diferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lbl_cierres_con_diferencia.Location = new System.Drawing.Point(16, 35);
            this.lbl_cierres_con_diferencia.Name = "lbl_cierres_con_diferencia";
            this.lbl_cierres_con_diferencia.Size = new System.Drawing.Size(37, 43);
            this.lbl_cierres_con_diferencia.TabIndex = 1;
            this.lbl_cierres_con_diferencia.Text = "0";
            // 
            // pnl_tabla
            // 
            this.pnl_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_tabla.BackColor = System.Drawing.Color.White;
            this.pnl_tabla.Controls.Add(this.dgv_cierres_de_caja);
            this.pnl_tabla.Controls.Add(this.lbl_total_registros);
            this.pnl_tabla.Location = new System.Drawing.Point(30, 297);
            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_tabla.Size = new System.Drawing.Size(1140, 345);
            this.pnl_tabla.TabIndex = 4;
            // 
            // dgv_cierres_de_caja
            // 
            this.dgv_cierres_de_caja.AllowUserToAddRows = false;
            this.dgv_cierres_de_caja.AllowUserToDeleteRows = false;
            this.dgv_cierres_de_caja.AllowUserToResizeRows = false;
            this.dgv_cierres_de_caja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cierres_de_caja.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cierres_de_caja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cierres_de_caja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cierres_de_caja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cierres_de_caja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cierres_de_caja.ColumnHeadersHeight = 44;
            this.dgv_cierres_de_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_cierres_de_caja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_numero_cierre,
            this.col_fecha_cierre,
            this.col_encargado,
            this.col_ingresos_sistema,
            this.col_efectivo_esperado,
            this.col_efectivo_contado,
            this.col_diferencia,
            this.col_estado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lexend", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cierres_de_caja.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_cierres_de_caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cierres_de_caja.EnableHeadersVisualStyles = false;
            this.dgv_cierres_de_caja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_cierres_de_caja.Location = new System.Drawing.Point(15, 15);
            this.dgv_cierres_de_caja.MultiSelect = false;
            this.dgv_cierres_de_caja.Name = "dgv_cierres_de_caja";
            this.dgv_cierres_de_caja.ReadOnly = true;
            this.dgv_cierres_de_caja.RowHeadersVisible = false;
            this.dgv_cierres_de_caja.RowHeadersWidth = 51;
            this.dgv_cierres_de_caja.RowTemplate.Height = 35;
            this.dgv_cierres_de_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cierres_de_caja.Size = new System.Drawing.Size(1110, 285);
            this.dgv_cierres_de_caja.TabIndex = 0;
            // 
            // col_numero_cierre
            // 
            this.col_numero_cierre.FillWeight = 60F;
            this.col_numero_cierre.HeaderText = "Número";
            this.col_numero_cierre.MinimumWidth = 70;
            this.col_numero_cierre.Name = "col_numero_cierre";
            this.col_numero_cierre.ReadOnly = true;
            // 
            // col_fecha_cierre
            // 
            this.col_fecha_cierre.FillWeight = 75F;
            this.col_fecha_cierre.HeaderText = "Fecha";
            this.col_fecha_cierre.MinimumWidth = 85;
            this.col_fecha_cierre.Name = "col_fecha_cierre";
            this.col_fecha_cierre.ReadOnly = true;
            // 
            // col_encargado
            // 
            this.col_encargado.FillWeight = 115F;
            this.col_encargado.HeaderText = "Encargado";
            this.col_encargado.MinimumWidth = 140;
            this.col_encargado.Name = "col_encargado";
            this.col_encargado.ReadOnly = true;
            // 
            // col_ingresos_sistema
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.col_ingresos_sistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_ingresos_sistema.FillWeight = 95F;
            this.col_ingresos_sistema.HeaderText = "Ingresos del sistema";
            this.col_ingresos_sistema.MinimumWidth = 115;
            this.col_ingresos_sistema.Name = "col_ingresos_sistema";
            this.col_ingresos_sistema.ReadOnly = true;
            // 
            // col_efectivo_esperado
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.col_efectivo_esperado.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_efectivo_esperado.FillWeight = 90F;
            this.col_efectivo_esperado.HeaderText = "Efectivo esperado";
            this.col_efectivo_esperado.MinimumWidth = 110;
            this.col_efectivo_esperado.Name = "col_efectivo_esperado";
            this.col_efectivo_esperado.ReadOnly = true;
            // 
            // col_efectivo_contado
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.col_efectivo_contado.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_efectivo_contado.FillWeight = 90F;
            this.col_efectivo_contado.HeaderText = "Efectivo contado";
            this.col_efectivo_contado.MinimumWidth = 110;
            this.col_efectivo_contado.Name = "col_efectivo_contado";
            this.col_efectivo_contado.ReadOnly = true;
            // 
            // col_diferencia
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.col_diferencia.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_diferencia.FillWeight = 80F;
            this.col_diferencia.HeaderText = "Diferencia";
            this.col_diferencia.MinimumWidth = 95;
            this.col_diferencia.Name = "col_diferencia";
            this.col_diferencia.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.FillWeight = 85F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.MinimumWidth = 105;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_total_registros.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_total_registros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_total_registros.Location = new System.Drawing.Point(15, 300);
            this.lbl_total_registros.Name = "lbl_total_registros";
            this.lbl_total_registros.Size = new System.Drawing.Size(1110, 30);
            this.lbl_total_registros.TabIndex = 1;
            this.lbl_total_registros.Text = "Total de cierres encontrados: 0";
            this.lbl_total_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_ver_detalle);
            this.pnl_acciones.Controls.Add(this.btn_imprimir);
            this.pnl_acciones.Controls.Add(this.btn_exportar);
            this.pnl_acciones.Controls.Add(this.btn_cerrar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 654);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size = new System.Drawing.Size(1140, 70);
            this.pnl_acciones.TabIndex = 5;
            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;
            this.btn_ver_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalle.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ver_detalle.ForeColor = System.Drawing.Color.White;
            this.btn_ver_detalle.Location = new System.Drawing.Point(18, 15);
            this.btn_ver_detalle.Name = "btn_ver_detalle";
            this.btn_ver_detalle.Size = new System.Drawing.Size(145, 40);
            this.btn_ver_detalle.TabIndex = 0;
            this.btn_ver_detalle.Text = "Ver detalle";
            this.btn_ver_detalle.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Location = new System.Drawing.Point(173, 15);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(125, 40);
            this.btn_imprimir.TabIndex = 1;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.btn_exportar.ForeColor = System.Drawing.Color.White;
            this.btn_exportar.Location = new System.Drawing.Point(308, 15);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(125, 40);
            this.btn_exportar.TabIndex = 2;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(995, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(125, 40);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // consulta_de_cierres_de_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1200, 745);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_tabla);
            this.Controls.Add(this.pnl_resumen);
            this.Controls.Add(this.pnl_filtros);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "consulta_de_cierres_de_caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cierres de Caja - Go Fitness Gym";
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            this.pnl_resumen.ResumeLayout(false);
            this.pnl_total_cierres.ResumeLayout(false);
            this.pnl_total_cierres.PerformLayout();
            this.pnl_cierres_cuadrados.ResumeLayout(false);
            this.pnl_cierres_cuadrados.PerformLayout();
            this.pnl_cierres_con_diferencia.ResumeLayout(false);
            this.pnl_cierres_con_diferencia.PerformLayout();
            this.pnl_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cierres_de_caja)).EndInit();
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

        private System.Windows.Forms.Label lbl_cajero;
        private System.Windows.Forms.ComboBox cbo_cajero;

        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cbo_estado;

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;

        private System.Windows.Forms.Panel pnl_resumen;

        private System.Windows.Forms.Panel pnl_total_cierres;
        private System.Windows.Forms.Label lbl_total_cierres_titulo;
        private System.Windows.Forms.Label lbl_total_cierres;

        private System.Windows.Forms.Panel pnl_cierres_cuadrados;

        private System.Windows.Forms.Label
            lbl_cierres_cuadrados_titulo;

        private System.Windows.Forms.Label
            lbl_cierres_cuadrados;

        private System.Windows.Forms.Panel
            pnl_cierres_con_diferencia;

        private System.Windows.Forms.Label
            lbl_cierres_con_diferencia_titulo;

        private System.Windows.Forms.Label
            lbl_cierres_con_diferencia;

        private System.Windows.Forms.Panel pnl_tabla;

        private System.Windows.Forms.DataGridView
            dgv_cierres_de_caja;

        private System.Windows.Forms.Label lbl_total_registros;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numero_cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ingresos_sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_efectivo_esperado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_efectivo_contado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_diferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
    }
}