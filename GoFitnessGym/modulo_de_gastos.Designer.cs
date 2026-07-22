
namespace GoFitnessGym
{
    partial class modulo_de_gastos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lebel1 = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio_gastos = new System.Windows.Forms.DateTimePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_fecha_fin_gastos = new System.Windows.Forms.DateTimePicker();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.cmb_filtro_origen = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar_gasto = new System.Windows.Forms.TextBox();
            this.panel_gastos = new System.Windows.Forms.DataGridView();
            this.btn_nuevo_gasto = new System.Windows.Forms.Button();
            this.btn_exportar_gastos = new System.Windows.Forms.Button();
            this.lbl_total_gastos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.col_gastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel_gastos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(14, 8);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(320, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Control y Registro de Gastos";
            // 
            // lebel1
            // 
            this.lebel1.AutoSize = true;
            this.lebel1.Font = new System.Drawing.Font("Lexend Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebel1.ForeColor = System.Drawing.Color.DimGray;
            this.lebel1.Location = new System.Drawing.Point(17, 41);
            this.lebel1.Name = "lebel1";
            this.lebel1.Size = new System.Drawing.Size(116, 17);
            this.lebel1.TabIndex = 1;
            this.lebel1.Text = "Gestiónar los gastos ";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(13, 18);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(43, 17);
            this.lbl_desde.TabIndex = 2;
            this.lbl_desde.Text = "Desde:";
            // 
            // dtp_fecha_inicio_gastos
            // 
            this.dtp_fecha_inicio_gastos.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio_gastos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio_gastos.Location = new System.Drawing.Point(62, 18);
            this.dtp_fecha_inicio_gastos.Name = "dtp_fecha_inicio_gastos";
            this.dtp_fecha_inicio_gastos.Size = new System.Drawing.Size(100, 21);
            this.dtp_fecha_inicio_gastos.TabIndex = 3;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Location = new System.Drawing.Point(183, 18);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(42, 17);
            this.lbl_hasta.TabIndex = 4;
            this.lbl_hasta.Text = "Hasta:";
            // 
            // dtp_fecha_fin_gastos
            // 
            this.dtp_fecha_fin_gastos.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_fin_gastos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin_gastos.Location = new System.Drawing.Point(231, 18);
            this.dtp_fecha_fin_gastos.Name = "dtp_fecha_fin_gastos";
            this.dtp_fecha_fin_gastos.Size = new System.Drawing.Size(100, 21);
            this.dtp_fecha_fin_gastos.TabIndex = 5;
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_origen.Location = new System.Drawing.Point(349, 18);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(47, 17);
            this.lbl_origen.TabIndex = 6;
            this.lbl_origen.Text = "Origen:";
            this.lbl_origen.Click += new System.EventHandler(this.lbl_origen_Click);
            // 
            // cmb_filtro_origen
            // 
            this.cmb_filtro_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro_origen.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filtro_origen.FormattingEnabled = true;
            this.cmb_filtro_origen.Items.AddRange(new object[] {
            "Todos",
            "Manuales",
            "Inventario"});
            this.cmb_filtro_origen.Location = new System.Drawing.Point(402, 14);
            this.cmb_filtro_origen.Name = "cmb_filtro_origen";
            this.cmb_filtro_origen.Size = new System.Drawing.Size(155, 25);
            this.cmb_filtro_origen.TabIndex = 7;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(568, 18);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(47, 17);
            this.lbl_buscar.TabIndex = 8;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_buscar_gasto
            // 
            this.txt_buscar_gasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar_gasto.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_gasto.Location = new System.Drawing.Point(621, 18);
            this.txt_buscar_gasto.Name = "txt_buscar_gasto";
            this.txt_buscar_gasto.Size = new System.Drawing.Size(117, 21);
            this.txt_buscar_gasto.TabIndex = 9;
            // 
            // panel_gastos
            // 
            this.panel_gastos.AllowUserToAddRows = false;
            this.panel_gastos.AllowUserToDeleteRows = false;
            this.panel_gastos.AllowUserToOrderColumns = true;
            this.panel_gastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.panel_gastos.BackgroundColor = System.Drawing.Color.White;
            this.panel_gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panel_gastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_gastos,
            this.col_fecha,
            this.col_categoria,
            this.col_concepto,
            this.col_origen,
            this.col_forma_pago,
            this.col_monto});
            this.panel_gastos.GridColor = System.Drawing.SystemColors.Control;
            this.panel_gastos.Location = new System.Drawing.Point(3, 60);
            this.panel_gastos.Name = "panel_gastos";
            this.panel_gastos.ReadOnly = true;
            this.panel_gastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.panel_gastos.RowHeadersVisible = false;
            this.panel_gastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.panel_gastos.ShowCellErrors = false;
            this.panel_gastos.Size = new System.Drawing.Size(774, 260);
            this.panel_gastos.TabIndex = 10;
            this.panel_gastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.panel_gastos_CellContentClick);
            // 
            // btn_nuevo_gasto
            // 
            this.btn_nuevo_gasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_nuevo_gasto.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_gasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_gasto.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_gasto.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo_gasto.Location = new System.Drawing.Point(9, 326);
            this.btn_nuevo_gasto.Name = "btn_nuevo_gasto";
            this.btn_nuevo_gasto.Size = new System.Drawing.Size(156, 32);
            this.btn_nuevo_gasto.TabIndex = 11;
            this.btn_nuevo_gasto.Text = "Registrar Gasto Manual";
            this.btn_nuevo_gasto.UseVisualStyleBackColor = false;
            // 
            // btn_exportar_gastos
            // 
            this.btn_exportar_gastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_exportar_gastos.FlatAppearance.BorderSize = 0;
            this.btn_exportar_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_gastos.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar_gastos.ForeColor = System.Drawing.Color.White;
            this.btn_exportar_gastos.Location = new System.Drawing.Point(200, 326);
            this.btn_exportar_gastos.Name = "btn_exportar_gastos";
            this.btn_exportar_gastos.Size = new System.Drawing.Size(134, 32);
            this.btn_exportar_gastos.TabIndex = 12;
            this.btn_exportar_gastos.Text = "Exportar Reporte";
            this.btn_exportar_gastos.UseVisualStyleBackColor = false;
            // 
            // lbl_total_gastos
            // 
            this.lbl_total_gastos.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_gastos.Location = new System.Drawing.Point(582, 333);
            this.lbl_total_gastos.Name = "lbl_total_gastos";
            this.lbl_total_gastos.Size = new System.Drawing.Size(180, 25);
            this.lbl_total_gastos.TabIndex = 13;
            this.lbl_total_gastos.Text = "Total Gastos del Mes: RD$ 0.00";
            this.lbl_total_gastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_filtro_origen);
            this.panel1.Controls.Add(this.lbl_desde);
            this.panel1.Controls.Add(this.dtp_fecha_inicio_gastos);
            this.panel1.Controls.Add(this.lbl_hasta);
            this.panel1.Controls.Add(this.dtp_fecha_fin_gastos);
            this.panel1.Controls.Add(this.txt_buscar_gasto);
            this.panel1.Controls.Add(this.lbl_origen);
            this.panel1.Controls.Add(this.lbl_buscar);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(774, 49);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lbl_total_gastos);
            this.panel2.Controls.Add(this.btn_exportar_gastos);
            this.panel2.Controls.Add(this.btn_nuevo_gasto);
            this.panel2.Controls.Add(this.panel_gastos);
            this.panel2.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 367);
            this.panel2.TabIndex = 0;
            // 
            // col_gastos
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lexend Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_gastos.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_gastos.HeaderText = "Código Gasto";
            this.col_gastos.Name = "col_gastos";
            this.col_gastos.ReadOnly = true;
            // 
            // col_fecha
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lexend Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_fecha.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_fecha.HeaderText = "Fecha";
            this.col_fecha.Name = "col_fecha";
            this.col_fecha.ReadOnly = true;
            // 
            // col_categoria
            // 
            this.col_categoria.HeaderText = "Categoría";
            this.col_categoria.Name = "col_categoria";
            this.col_categoria.ReadOnly = true;
            // 
            // col_concepto
            // 
            this.col_concepto.HeaderText = "Detalle";
            this.col_concepto.Name = "col_concepto";
            this.col_concepto.ReadOnly = true;
            // 
            // col_origen
            // 
            this.col_origen.HeaderText = "Origen";
            this.col_origen.Name = "col_origen";
            this.col_origen.ReadOnly = true;
            // 
            // col_forma_pago
            // 
            this.col_forma_pago.HeaderText = "Forma Pago";
            this.col_forma_pago.Name = "col_forma_pago";
            this.col_forma_pago.ReadOnly = true;
            // 
            // col_monto
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lexend Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_monto.DefaultCellStyle = dataGridViewCellStyle9;
            this.col_monto.HeaderText = "Monto";
            this.col_monto.Name = "col_monto";
            this.col_monto.ReadOnly = true;
            // 
            // modulo_de_gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lebel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "modulo_de_gastos";
            this.Text = "modulo_de_gastos";
            ((System.ComponentModel.ISupportInitialize)(this.panel_gastos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lebel1;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio_gastos;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin_gastos;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.ComboBox cmb_filtro_origen;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar_gasto;
        private System.Windows.Forms.DataGridView panel_gastos;
        private System.Windows.Forms.Button btn_nuevo_gasto;
        private System.Windows.Forms.Button btn_exportar_gastos;
        private System.Windows.Forms.Label lbl_total_gastos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_forma_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
    }
}