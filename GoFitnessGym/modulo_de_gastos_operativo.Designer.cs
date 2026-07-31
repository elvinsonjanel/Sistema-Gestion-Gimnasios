
namespace GoFitnessGym
{
    partial class modulo_de_gastos_operativo
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
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dgv_gastos = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gastos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(6, 8);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(347, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Control de Gastos De la Empresa";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_subtitulo.Location = new System.Drawing.Point(9, 41);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(395, 17);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Consulta y registro de pagos de servicios, alquiler, mantenimiento y otros";
            // 
            // panel_filtros
            // 
            this.panel_filtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_filtros.Controls.Add(this.btn_buscar);
            this.panel_filtros.Controls.Add(this.txt_buscar);
            this.panel_filtros.Controls.Add(this.lbl_buscar);
            this.panel_filtros.Controls.Add(this.cmb_categoria);
            this.panel_filtros.Controls.Add(this.lbl_categoria);
            this.panel_filtros.Controls.Add(this.dtp_hasta);
            this.panel_filtros.Controls.Add(this.lbl_hasta);
            this.panel_filtros.Controls.Add(this.dtp_desde);
            this.panel_filtros.Controls.Add(this.lbl_desde);
            this.panel_filtros.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_filtros.Location = new System.Drawing.Point(12, 71);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(798, 55);
            this.panel_filtros.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(719, 14);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(70, 25);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(593, 16);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(120, 21);
            this.txt_buscar.TabIndex = 7;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(540, 18);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(47, 17);
            this.lbl_buscar.TabIndex = 6;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(388, 14);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(146, 25);
            this.cmb_categoria.TabIndex = 5;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(319, 18);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(63, 17);
            this.lbl_categoria.TabIndex = 4;
            this.lbl_categoria.Text = "Categoría:";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(213, 15);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(100, 21);
            this.dtp_hasta.TabIndex = 3;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Location = new System.Drawing.Point(165, 18);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(42, 17);
            this.lbl_hasta.TabIndex = 2;
            this.lbl_hasta.Text = "Hasta:";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(59, 15);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(100, 21);
            this.dtp_desde.TabIndex = 1;
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(10, 18);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(43, 17);
            this.lbl_desde.TabIndex = 0;
            this.lbl_desde.Text = "Desde:";
            // 
            // dgv_gastos
            // 
            this.dgv_gastos.AllowUserToAddRows = false;
            this.dgv_gastos.AllowUserToDeleteRows = false;
            this.dgv_gastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_gastos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_fecha,
            this.col_categoria,
            this.col_detalle,
            this.col_comprobante,
            this.col_forma_pago,
            this.col_monto});
            this.dgv_gastos.Location = new System.Drawing.Point(12, 135);
            this.dgv_gastos.Name = "dgv_gastos";
            this.dgv_gastos.ReadOnly = true;
            this.dgv_gastos.RowHeadersVisible = false;
            this.dgv_gastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gastos.Size = new System.Drawing.Size(798, 322);
            this.dgv_gastos.TabIndex = 3;
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_fecha
            // 
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
            // col_detalle
            // 
            this.col_detalle.HeaderText = "Detalle / Concepto";
            this.col_detalle.Name = "col_detalle";
            this.col_detalle.ReadOnly = true;
            // 
            // col_comprobante
            // 
            this.col_comprobante.HeaderText = "N° Comprobante";
            this.col_comprobante.Name = "col_comprobante";
            this.col_comprobante.ReadOnly = true;
            // 
            // col_forma_pago
            // 
            this.col_forma_pago.HeaderText = "Forma Pago";
            this.col_forma_pago.Name = "col_forma_pago";
            this.col_forma_pago.ReadOnly = true;
            // 
            // col_monto
            // 
            this.col_monto.HeaderText = "Monto";
            this.col_monto.Name = "col_monto";
            this.col_monto.ReadOnly = true;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Lexend SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(502, 468);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(308, 25);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total Gastos Operativos: RD$ 0.00";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(12, 462);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(109, 37);
            this.btn_registrar.TabIndex = 12;
            this.btn_registrar.Text = "Registrar Pago";
            this.btn_registrar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(139, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // modulo_de_gastos_operativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dgv_gastos);
            this.Controls.Add(this.panel_filtros);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "modulo_de_gastos_operativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control y Registro de Gastos Operativos - GO Fitness";
            this.Load += new System.EventHandler(this.modulo_de_gastos_Load);
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_gastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_forma_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button button1;
    }
}