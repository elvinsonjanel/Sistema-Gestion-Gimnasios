namespace GoFitnessGym
{
    partial class consulta_de_clientes_morosos
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
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_antiguedad_deuda = new System.Windows.Forms.Label();
            this.cbo_antiguedad_deuda = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();

            this.pnl_resumen = new System.Windows.Forms.Panel();

            this.pnl_total_clientes_morosos =
                new System.Windows.Forms.Panel();
            this.lbl_total_clientes_morosos_titulo =
                new System.Windows.Forms.Label();
            this.lbl_total_clientes_morosos =
                new System.Windows.Forms.Label();

            this.pnl_deuda_total =
                new System.Windows.Forms.Panel();
            this.lbl_deuda_total_titulo =
                new System.Windows.Forms.Label();
            this.lbl_deuda_total =
                new System.Windows.Forms.Label();

            this.pnl_facturas_pendientes =
                new System.Windows.Forms.Panel();
            this.lbl_facturas_pendientes_titulo =
                new System.Windows.Forms.Label();
            this.lbl_facturas_pendientes =
                new System.Windows.Forms.Label();

            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.dgv_clientes_morosos =
                new System.Windows.Forms.DataGridView();

            this.col_codigo_cliente =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre_cliente =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono_cliente =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_facturas_pendientes =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_factura_mas_antigua =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dias_atraso =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_pendiente =
                new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado_deuda =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.lbl_total_registros =
                new System.Windows.Forms.Label();

            this.pnl_acciones =
                new System.Windows.Forms.Panel();
            this.btn_ver_detalle =
                new System.Windows.Forms.Button();
            this.btn_gestionar_pago =
                new System.Windows.Forms.Button();
            this.btn_imprimir =
                new System.Windows.Forms.Button();
            this.btn_exportar =
                new System.Windows.Forms.Button();
            this.btn_cerrar =
                new System.Windows.Forms.Button();

            this.pnl_filtros.SuspendLayout();
            this.pnl_resumen.SuspendLayout();

            this.pnl_total_clientes_morosos.SuspendLayout();
            this.pnl_deuda_total.SuspendLayout();
            this.pnl_facturas_pendientes.SuspendLayout();

            this.pnl_tabla.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgv_clientes_morosos)).BeginInit();

            this.pnl_acciones.SuspendLayout();
            this.SuspendLayout();

            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font(
                "Lexend",
                16F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lbl_titulo.ForeColor =
                System.Drawing.Color.FromArgb(26, 32, 44);

            this.lbl_titulo.Location =
                new System.Drawing.Point(30, 18);

            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size =
                new System.Drawing.Size(402, 42);

            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text =
                "Reporte de Clientes Morosos";

            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font(
                "Lexend",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lbl_subtitulo.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.lbl_subtitulo.Location =
                new System.Drawing.Point(32, 59);

            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size =
                new System.Drawing.Size(660, 27);

            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text =
                "Consulte los clientes con facturas y saldos pendientes de pago";

            // 
            // pnl_filtros
            // 
            this.pnl_filtros.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_filtros.BackColor =
                System.Drawing.Color.White;

            this.pnl_filtros.Controls.Add(this.lbl_busqueda);
            this.pnl_filtros.Controls.Add(this.txt_busqueda);
            this.pnl_filtros.Controls.Add(this.lbl_antiguedad_deuda);
            this.pnl_filtros.Controls.Add(this.cbo_antiguedad_deuda);
            this.pnl_filtros.Controls.Add(this.btn_buscar);
            this.pnl_filtros.Controls.Add(this.btn_limpiar);

            this.pnl_filtros.Location =
                new System.Drawing.Point(30, 98);

            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Padding =
                new System.Windows.Forms.Padding(18);

            this.pnl_filtros.Size =
                new System.Drawing.Size(1140, 92);

            this.pnl_filtros.TabIndex = 2;

            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.AutoSize = true;
            this.lbl_busqueda.Font = new System.Drawing.Font(
                "Lexend",
                9F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lbl_busqueda.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_busqueda.Location =
                new System.Drawing.Point(18, 12);

            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size =
                new System.Drawing.Size(117, 24);

            this.lbl_busqueda.TabIndex = 0;
            this.lbl_busqueda.Text = "Buscar cliente:";

            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_busqueda.Font = new System.Drawing.Font(
                "Lexend",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.txt_busqueda.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_busqueda.Location =
                new System.Drawing.Point(18, 39);

            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size =
                new System.Drawing.Size(430, 28);

            this.txt_busqueda.TabIndex = 1;

            // 
            // lbl_antiguedad_deuda
            // 
            this.lbl_antiguedad_deuda.AutoSize = true;
            this.lbl_antiguedad_deuda.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_antiguedad_deuda.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_antiguedad_deuda.Location =
                new System.Drawing.Point(470, 12);

            this.lbl_antiguedad_deuda.Name =
                "lbl_antiguedad_deuda";

            this.lbl_antiguedad_deuda.Size =
                new System.Drawing.Size(176, 24);

            this.lbl_antiguedad_deuda.TabIndex = 2;
            this.lbl_antiguedad_deuda.Text =
                "Antigüedad de deuda:";

            // 
            // cbo_antiguedad_deuda
            // 
            this.cbo_antiguedad_deuda.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbo_antiguedad_deuda.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.cbo_antiguedad_deuda.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.cbo_antiguedad_deuda.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.cbo_antiguedad_deuda.FormattingEnabled = true;

            this.cbo_antiguedad_deuda.Items.AddRange(
                new object[]
                {
                    "Todas",
                    "De 1 a 7 días",
                    "De 8 a 15 días",
                    "De 16 a 30 días",
                    "Más de 30 días"
                });

            this.cbo_antiguedad_deuda.Location =
                new System.Drawing.Point(470, 36);

            this.cbo_antiguedad_deuda.Name =
                "cbo_antiguedad_deuda";

            this.cbo_antiguedad_deuda.Size =
                new System.Drawing.Size(235, 35);

            this.cbo_antiguedad_deuda.TabIndex = 3;

            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_buscar.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_buscar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_buscar.ForeColor =
                System.Drawing.Color.White;

            this.btn_buscar.Location =
                new System.Drawing.Point(880, 31);

            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size =
                new System.Drawing.Size(115, 40);

            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;

            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_limpiar.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_limpiar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_limpiar.ForeColor =
                System.Drawing.Color.White;

            this.btn_limpiar.Location =
                new System.Drawing.Point(1005, 31);

            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size =
                new System.Drawing.Size(115, 40);

            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;

            // 
            // pnl_resumen
            // 
            this.pnl_resumen.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_resumen.BackColor =
                System.Drawing.Color.Transparent;

            this.pnl_resumen.Controls.Add(
                this.pnl_total_clientes_morosos);

            this.pnl_resumen.Controls.Add(
                this.pnl_deuda_total);

            this.pnl_resumen.Controls.Add(
                this.pnl_facturas_pendientes);

            this.pnl_resumen.Location =
                new System.Drawing.Point(30, 202);

            this.pnl_resumen.Name = "pnl_resumen";
            this.pnl_resumen.Size =
                new System.Drawing.Size(1140, 83);

            this.pnl_resumen.TabIndex = 3;

            // 
            // pnl_total_clientes_morosos
            // 
            this.pnl_total_clientes_morosos.BackColor =
                System.Drawing.Color.White;

            this.pnl_total_clientes_morosos.Controls.Add(
                this.lbl_total_clientes_morosos_titulo);

            this.pnl_total_clientes_morosos.Controls.Add(
                this.lbl_total_clientes_morosos);

            this.pnl_total_clientes_morosos.Location =
                new System.Drawing.Point(0, 0);

            this.pnl_total_clientes_morosos.Name =
                "pnl_total_clientes_morosos";

            this.pnl_total_clientes_morosos.Size =
                new System.Drawing.Size(360, 83);

            this.pnl_total_clientes_morosos.TabIndex = 0;

            // 
            // lbl_total_clientes_morosos_titulo
            // 
            this.lbl_total_clientes_morosos_titulo.AutoSize = true;

            this.lbl_total_clientes_morosos_titulo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_total_clientes_morosos_titulo.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.lbl_total_clientes_morosos_titulo.Location =
                new System.Drawing.Point(18, 12);

            this.lbl_total_clientes_morosos_titulo.Name =
                "lbl_total_clientes_morosos_titulo";

            this.lbl_total_clientes_morosos_titulo.Size =
                new System.Drawing.Size(126, 24);

            this.lbl_total_clientes_morosos_titulo.TabIndex = 0;
            this.lbl_total_clientes_morosos_titulo.Text =
                "Clientes morosos";

            // 
            // lbl_total_clientes_morosos
            // 
            this.lbl_total_clientes_morosos.AutoSize = true;

            this.lbl_total_clientes_morosos.Font =
                new System.Drawing.Font(
                    "Lexend",
                    16F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_total_clientes_morosos.ForeColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.lbl_total_clientes_morosos.Location =
                new System.Drawing.Point(16, 35);

            this.lbl_total_clientes_morosos.Name =
                "lbl_total_clientes_morosos";

            this.lbl_total_clientes_morosos.Size =
                new System.Drawing.Size(31, 42);

            this.lbl_total_clientes_morosos.TabIndex = 1;
            this.lbl_total_clientes_morosos.Text = "0";

            // 
            // pnl_deuda_total
            // 
            this.pnl_deuda_total.BackColor =
                System.Drawing.Color.White;

            this.pnl_deuda_total.Controls.Add(
                this.lbl_deuda_total_titulo);

            this.pnl_deuda_total.Controls.Add(
                this.lbl_deuda_total);

            this.pnl_deuda_total.Location =
                new System.Drawing.Point(390, 0);

            this.pnl_deuda_total.Name =
                "pnl_deuda_total";

            this.pnl_deuda_total.Size =
                new System.Drawing.Size(360, 83);

            this.pnl_deuda_total.TabIndex = 1;

            // 
            // lbl_deuda_total_titulo
            // 
            this.lbl_deuda_total_titulo.AutoSize = true;

            this.lbl_deuda_total_titulo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_deuda_total_titulo.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.lbl_deuda_total_titulo.Location =
                new System.Drawing.Point(18, 12);

            this.lbl_deuda_total_titulo.Name =
                "lbl_deuda_total_titulo";

            this.lbl_deuda_total_titulo.Size =
                new System.Drawing.Size(96, 24);

            this.lbl_deuda_total_titulo.TabIndex = 0;
            this.lbl_deuda_total_titulo.Text =
                "Deuda total";

            // 
            // lbl_deuda_total
            // 
            this.lbl_deuda_total.AutoSize = true;

            this.lbl_deuda_total.Font =
                new System.Drawing.Font(
                    "Lexend",
                    14F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_deuda_total.ForeColor =
                System.Drawing.Color.FromArgb(217, 119, 6);

            this.lbl_deuda_total.Location =
                new System.Drawing.Point(16, 38);

            this.lbl_deuda_total.Name =
                "lbl_deuda_total";

            this.lbl_deuda_total.Size =
                new System.Drawing.Size(128, 37);

            this.lbl_deuda_total.TabIndex = 1;
            this.lbl_deuda_total.Text = "RD$ 0.00";

            // 
            // pnl_facturas_pendientes
            // 
            this.pnl_facturas_pendientes.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.pnl_facturas_pendientes.BackColor =
                System.Drawing.Color.White;

            this.pnl_facturas_pendientes.Controls.Add(
                this.lbl_facturas_pendientes_titulo);

            this.pnl_facturas_pendientes.Controls.Add(
                this.lbl_facturas_pendientes);

            this.pnl_facturas_pendientes.Location =
                new System.Drawing.Point(780, 0);

            this.pnl_facturas_pendientes.Name =
                "pnl_facturas_pendientes";

            this.pnl_facturas_pendientes.Size =
                new System.Drawing.Size(360, 83);

            this.pnl_facturas_pendientes.TabIndex = 2;

            // 
            // lbl_facturas_pendientes_titulo
            // 
            this.lbl_facturas_pendientes_titulo.AutoSize = true;

            this.lbl_facturas_pendientes_titulo.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_facturas_pendientes_titulo.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.lbl_facturas_pendientes_titulo.Location =
                new System.Drawing.Point(18, 12);

            this.lbl_facturas_pendientes_titulo.Name =
                "lbl_facturas_pendientes_titulo";

            this.lbl_facturas_pendientes_titulo.Size =
                new System.Drawing.Size(143, 24);

            this.lbl_facturas_pendientes_titulo.TabIndex = 0;
            this.lbl_facturas_pendientes_titulo.Text =
                "Facturas pendientes";

            // 
            // lbl_facturas_pendientes
            // 
            this.lbl_facturas_pendientes.AutoSize = true;

            this.lbl_facturas_pendientes.Font =
                new System.Drawing.Font(
                    "Lexend",
                    16F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_facturas_pendientes.ForeColor =
                System.Drawing.Color.FromArgb(109, 40, 217);

            this.lbl_facturas_pendientes.Location =
                new System.Drawing.Point(16, 35);

            this.lbl_facturas_pendientes.Name =
                "lbl_facturas_pendientes";

            this.lbl_facturas_pendientes.Size =
                new System.Drawing.Size(31, 42);

            this.lbl_facturas_pendientes.TabIndex = 1;
            this.lbl_facturas_pendientes.Text = "0";

            // 
            // pnl_tabla
            // 
            this.pnl_tabla.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom) |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_tabla.BackColor =
                System.Drawing.Color.White;

            this.pnl_tabla.Controls.Add(
                this.dgv_clientes_morosos);

            this.pnl_tabla.Controls.Add(
                this.lbl_total_registros);

            this.pnl_tabla.Location =
                new System.Drawing.Point(30, 297);

            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_tabla.Size =
                new System.Drawing.Size(1140, 345);

            this.pnl_tabla.TabIndex = 4;

            // 
            // dgv_clientes_morosos
            // 
            this.dgv_clientes_morosos.AllowUserToAddRows = false;
            this.dgv_clientes_morosos.AllowUserToDeleteRows = false;
            this.dgv_clientes_morosos.AllowUserToResizeRows = false;

            this.dgv_clientes_morosos.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgv_clientes_morosos.BackgroundColor =
                System.Drawing.Color.White;

            this.dgv_clientes_morosos.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgv_clientes_morosos.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgv_clientes_morosos.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgv_clientes_morosos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgv_clientes_morosos.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.col_codigo_cliente,
                    this.col_nombre_cliente,
                    this.col_telefono_cliente,
                    this.col_facturas_pendientes,
                    this.col_factura_mas_antigua,
                    this.col_dias_atraso,
                    this.col_total_pendiente,
                    this.col_estado_deuda
                });

            this.dgv_clientes_morosos.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgv_clientes_morosos.EnableHeadersVisualStyles =
                false;

            this.dgv_clientes_morosos.GridColor =
                System.Drawing.Color.FromArgb(226, 232, 240);

            this.dgv_clientes_morosos.Location =
                new System.Drawing.Point(15, 15);

            this.dgv_clientes_morosos.MultiSelect = false;

            this.dgv_clientes_morosos.Name =
                "dgv_clientes_morosos";

            this.dgv_clientes_morosos.ReadOnly = true;
            this.dgv_clientes_morosos.RowHeadersVisible = false;
            this.dgv_clientes_morosos.RowHeadersWidth = 51;
            this.dgv_clientes_morosos.RowTemplate.Height = 35;

            this.dgv_clientes_morosos.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgv_clientes_morosos.Size =
                new System.Drawing.Size(1110, 285);

            this.dgv_clientes_morosos.TabIndex = 0;

            // 
            // col_codigo_cliente
            // 
            this.col_codigo_cliente.FillWeight = 55F;
            this.col_codigo_cliente.HeaderText = "Código";
            this.col_codigo_cliente.MinimumWidth = 60;
            this.col_codigo_cliente.Name =
                "col_codigo_cliente";
            this.col_codigo_cliente.ReadOnly = true;

            // 
            // col_nombre_cliente
            // 
            this.col_nombre_cliente.FillWeight = 135F;
            this.col_nombre_cliente.HeaderText = "Cliente";
            this.col_nombre_cliente.MinimumWidth = 160;
            this.col_nombre_cliente.Name =
                "col_nombre_cliente";
            this.col_nombre_cliente.ReadOnly = true;

            // 
            // col_telefono_cliente
            // 
            this.col_telefono_cliente.FillWeight = 90F;
            this.col_telefono_cliente.HeaderText = "Teléfono";
            this.col_telefono_cliente.MinimumWidth = 100;
            this.col_telefono_cliente.Name =
                "col_telefono_cliente";
            this.col_telefono_cliente.ReadOnly = true;

            // 
            // col_facturas_pendientes
            // 
            this.col_facturas_pendientes.FillWeight = 80F;
            this.col_facturas_pendientes.HeaderText =
                "Facturas pendientes";
            this.col_facturas_pendientes.MinimumWidth = 100;
            this.col_facturas_pendientes.Name =
                "col_facturas_pendientes";
            this.col_facturas_pendientes.ReadOnly = true;

            // 
            // col_factura_mas_antigua
            // 
            this.col_factura_mas_antigua.FillWeight = 95F;
            this.col_factura_mas_antigua.HeaderText =
                "Factura más antigua";
            this.col_factura_mas_antigua.MinimumWidth = 115;
            this.col_factura_mas_antigua.Name =
                "col_factura_mas_antigua";
            this.col_factura_mas_antigua.ReadOnly = true;

            // 
            // col_dias_atraso
            // 
            this.col_dias_atraso.FillWeight = 70F;
            this.col_dias_atraso.HeaderText =
                "Días de atraso";
            this.col_dias_atraso.MinimumWidth = 85;
            this.col_dias_atraso.Name =
                "col_dias_atraso";
            this.col_dias_atraso.ReadOnly = true;

            // 
            // col_total_pendiente
            // 
            this.col_total_pendiente.FillWeight = 95F;
            this.col_total_pendiente.HeaderText =
                "Total pendiente";
            this.col_total_pendiente.MinimumWidth = 110;
            this.col_total_pendiente.Name =
                "col_total_pendiente";
            this.col_total_pendiente.ReadOnly = true;

            // 
            // col_estado_deuda
            // 
            this.col_estado_deuda.FillWeight = 80F;
            this.col_estado_deuda.HeaderText = "Estado";
            this.col_estado_deuda.MinimumWidth = 95;
            this.col_estado_deuda.Name =
                "col_estado_deuda";
            this.col_estado_deuda.ReadOnly = true;

            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.lbl_total_registros.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_total_registros.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.lbl_total_registros.Location =
                new System.Drawing.Point(15, 300);

            this.lbl_total_registros.Name =
                "lbl_total_registros";

            this.lbl_total_registros.Size =
                new System.Drawing.Size(1110, 30);

            this.lbl_total_registros.TabIndex = 1;
            this.lbl_total_registros.Text =
                "Total de clientes encontrados: 0";

            this.lbl_total_registros.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_acciones.BackColor =
                System.Drawing.Color.White;

            this.pnl_acciones.Controls.Add(
                this.btn_ver_detalle);

            this.pnl_acciones.Controls.Add(
                this.btn_gestionar_pago);

            this.pnl_acciones.Controls.Add(
                this.btn_imprimir);

            this.pnl_acciones.Controls.Add(
                this.btn_exportar);

            this.pnl_acciones.Controls.Add(
                this.btn_cerrar);

            this.pnl_acciones.Location =
                new System.Drawing.Point(30, 654);

            this.pnl_acciones.Name =
                "pnl_acciones";

            this.pnl_acciones.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_acciones.Size =
                new System.Drawing.Size(1140, 70);

            this.pnl_acciones.TabIndex = 5;

            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;

            this.btn_ver_detalle.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_ver_detalle.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_ver_detalle.ForeColor =
                System.Drawing.Color.White;

            this.btn_ver_detalle.Location =
                new System.Drawing.Point(18, 15);

            this.btn_ver_detalle.Name =
                "btn_ver_detalle";

            this.btn_ver_detalle.Size =
                new System.Drawing.Size(145, 40);

            this.btn_ver_detalle.TabIndex = 0;
            this.btn_ver_detalle.Text = "Ver detalle";
            this.btn_ver_detalle.UseVisualStyleBackColor = false;

            // 
            // btn_gestionar_pago
            // 
            this.btn_gestionar_pago.BackColor =
                System.Drawing.Color.FromArgb(16, 124, 65);

            this.btn_gestionar_pago.FlatAppearance.BorderSize = 0;

            this.btn_gestionar_pago.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_gestionar_pago.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_gestionar_pago.ForeColor =
                System.Drawing.Color.White;

            this.btn_gestionar_pago.Location =
                new System.Drawing.Point(173, 15);

            this.btn_gestionar_pago.Name =
                "btn_gestionar_pago";

            this.btn_gestionar_pago.Size =
                new System.Drawing.Size(165, 40);

            this.btn_gestionar_pago.TabIndex = 1;
            this.btn_gestionar_pago.Text =
                "Gestionar pago";

            this.btn_gestionar_pago.UseVisualStyleBackColor = false;

            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_imprimir.FlatAppearance.BorderSize = 0;

            this.btn_imprimir.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_imprimir.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_imprimir.ForeColor =
                System.Drawing.Color.White;

            this.btn_imprimir.Location =
                new System.Drawing.Point(348, 15);

            this.btn_imprimir.Name =
                "btn_imprimir";

            this.btn_imprimir.Size =
                new System.Drawing.Size(125, 40);

            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;

            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_exportar.FlatAppearance.BorderSize = 0;

            this.btn_exportar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_exportar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_exportar.ForeColor =
                System.Drawing.Color.White;

            this.btn_exportar.Location =
                new System.Drawing.Point(483, 15);

            this.btn_exportar.Name =
                "btn_exportar";

            this.btn_exportar.Size =
                new System.Drawing.Size(125, 40);

            this.btn_exportar.TabIndex = 3;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = false;

            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_cerrar.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_cerrar.FlatAppearance.BorderSize = 0;

            this.btn_cerrar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_cerrar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_cerrar.ForeColor =
                System.Drawing.Color.White;

            this.btn_cerrar.Location =
                new System.Drawing.Point(995, 15);

            this.btn_cerrar.Name =
                "btn_cerrar";

            this.btn_cerrar.Size =
                new System.Drawing.Size(125, 40);

            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;

            // 
            // consulta_de_clientes_morosos
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            this.ClientSize =
                new System.Drawing.Size(1200, 745);

            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_tabla);
            this.Controls.Add(this.pnl_resumen);
            this.Controls.Add(this.pnl_filtros);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.Sizable;

            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.MinimumSize =
                new System.Drawing.Size(1050, 700);

            this.Name =
                "consulta_de_clientes_morosos";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Reporte de Clientes Morosos - Go Fitness Gym";

            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();

            this.pnl_resumen.ResumeLayout(false);

            this.pnl_total_clientes_morosos.ResumeLayout(false);
            this.pnl_total_clientes_morosos.PerformLayout();

            this.pnl_deuda_total.ResumeLayout(false);
            this.pnl_deuda_total.PerformLayout();

            this.pnl_facturas_pendientes.ResumeLayout(false);
            this.pnl_facturas_pendientes.PerformLayout();

            this.pnl_tabla.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgv_clientes_morosos)).EndInit();

            this.pnl_acciones.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.Panel pnl_filtros;
        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_antiguedad_deuda;
        private System.Windows.Forms.ComboBox cbo_antiguedad_deuda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;

        private System.Windows.Forms.Panel pnl_resumen;

        private System.Windows.Forms.Panel
            pnl_total_clientes_morosos;

        private System.Windows.Forms.Label
            lbl_total_clientes_morosos_titulo;

        private System.Windows.Forms.Label
            lbl_total_clientes_morosos;

        private System.Windows.Forms.Panel
            pnl_deuda_total;

        private System.Windows.Forms.Label
            lbl_deuda_total_titulo;

        private System.Windows.Forms.Label
            lbl_deuda_total;

        private System.Windows.Forms.Panel
            pnl_facturas_pendientes;

        private System.Windows.Forms.Label
            lbl_facturas_pendientes_titulo;

        private System.Windows.Forms.Label
            lbl_facturas_pendientes;

        private System.Windows.Forms.Panel pnl_tabla;

        private System.Windows.Forms.DataGridView
            dgv_clientes_morosos;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_codigo_cliente;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_nombre_cliente;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_telefono_cliente;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_facturas_pendientes;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_factura_mas_antigua;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_dias_atraso;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_total_pendiente;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_estado_deuda;

        private System.Windows.Forms.Label
            lbl_total_registros;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.Button btn_gestionar_pago;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}