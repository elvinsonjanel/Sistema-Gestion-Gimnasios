
namespace GoFitnessGym
{
    partial class modulo_de_reportes
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
            this.tlp_reportes = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_clientes = new System.Windows.Forms.Panel();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.lbl_descripcion_clientes = new System.Windows.Forms.Label();
            this.btn_consultar_clientes = new System.Windows.Forms.Button();
            this.pnl_clientes_morosos = new System.Windows.Forms.Panel();
            this.lbl_clientes_morosos = new System.Windows.Forms.Label();
            this.lbl_descripcion_clientes_morosos = new System.Windows.Forms.Label();
            this.btn_clientes_morosos = new System.Windows.Forms.Button();
            this.pnl_vencimientos = new System.Windows.Forms.Panel();
            this.lbl_vencimientos = new System.Windows.Forms.Label();
            this.lbl_descripcion_vencimientos = new System.Windows.Forms.Label();
            this.btn_vencimientos = new System.Windows.Forms.Button();
            this.pnl_asistencia = new System.Windows.Forms.Panel();
            this.lbl_asistencia = new System.Windows.Forms.Label();
            this.lbl_descripcion_asistencia = new System.Windows.Forms.Label();
            this.btn_asistencia = new System.Windows.Forms.Button();
            this.pnl_cierres_de_caja = new System.Windows.Forms.Panel();
            this.lbl_cierres_de_caja = new System.Windows.Forms.Label();
            this.lbl_descripcion_cierres_de_caja = new System.Windows.Forms.Label();
            this.btn_cierres_de_caja = new System.Windows.Forms.Button();
            this.pnl_finanzas = new System.Windows.Forms.Panel();
            this.lbl_finanzas = new System.Windows.Forms.Label();
            this.lbl_descripcion_finanzas = new System.Windows.Forms.Label();
            this.btn_finanzas = new System.Windows.Forms.Button();
            this.pnl_nota = new System.Windows.Forms.Panel();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.tlp_reportes.SuspendLayout();
            this.pnl_clientes.SuspendLayout();
            this.pnl_clientes_morosos.SuspendLayout();
            this.pnl_vencimientos.SuspendLayout();
            this.pnl_asistencia.SuspendLayout();
            this.pnl_cierres_de_caja.SuspendLayout();
            this.pnl_finanzas.SuspendLayout();
            this.pnl_nota.SuspendLayout();
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
            this.lbl_titulo.Size = new System.Drawing.Size(141, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Reportes";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 59);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(490, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Seleccione la información que desea consultar o exportar";
            // 
            // tlp_reportes
            // 
            this.tlp_reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_reportes.ColumnCount = 3;
            this.tlp_reportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_reportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_reportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_reportes.Controls.Add(this.pnl_clientes, 0, 0);
            this.tlp_reportes.Controls.Add(this.pnl_clientes_morosos, 1, 0);
            this.tlp_reportes.Controls.Add(this.pnl_vencimientos, 2, 0);
            this.tlp_reportes.Controls.Add(this.pnl_asistencia, 0, 1);
            this.tlp_reportes.Controls.Add(this.pnl_cierres_de_caja, 1, 1);
            this.tlp_reportes.Controls.Add(this.pnl_finanzas, 2, 1);
            this.tlp_reportes.Location = new System.Drawing.Point(30, 105);
            this.tlp_reportes.Name = "tlp_reportes";
            this.tlp_reportes.RowCount = 2;
            this.tlp_reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_reportes.Size = new System.Drawing.Size(1140, 405);
            this.tlp_reportes.TabIndex = 2;
            // 
            // pnl_clientes
            // 
            this.pnl_clientes.BackColor = System.Drawing.Color.White;
            this.pnl_clientes.Controls.Add(this.lbl_clientes);
            this.pnl_clientes.Controls.Add(this.lbl_descripcion_clientes);
            this.pnl_clientes.Controls.Add(this.btn_consultar_clientes);
            this.pnl_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_clientes.Location = new System.Drawing.Point(0, 0);
            this.pnl_clientes.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnl_clientes.Name = "pnl_clientes";
            this.pnl_clientes.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_clientes.Size = new System.Drawing.Size(370, 192);
            this.pnl_clientes.TabIndex = 0;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_clientes.Location = new System.Drawing.Point(20, 18);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(206, 30);
            this.lbl_clientes.TabIndex = 0;
            this.lbl_clientes.Text = "Consulta de clientes";
            // 
            // lbl_descripcion_clientes
            // 
            this.lbl_descripcion_clientes.Font = new System.Drawing.Font("Lexend", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_descripcion_clientes.Location = new System.Drawing.Point(22, 57);
            this.lbl_descripcion_clientes.Name = "lbl_descripcion_clientes";
            this.lbl_descripcion_clientes.Size = new System.Drawing.Size(320, 55);
            this.lbl_descripcion_clientes.TabIndex = 1;
            this.lbl_descripcion_clientes.Text = "Busque clientes y consulte su membresía, estado, vencimiento y saldo.";
            // 
            // btn_consultar_clientes
            // 
            this.btn_consultar_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_consultar_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar_clientes.FlatAppearance.BorderSize = 0;
            this.btn_consultar_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar_clientes.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_clientes.ForeColor = System.Drawing.Color.White;
            this.btn_consultar_clientes.Location = new System.Drawing.Point(22, 130);
            this.btn_consultar_clientes.Name = "btn_consultar_clientes";
            this.btn_consultar_clientes.Size = new System.Drawing.Size(160, 40);
            this.btn_consultar_clientes.TabIndex = 2;
            this.btn_consultar_clientes.Text = "Consultar";
            this.btn_consultar_clientes.UseVisualStyleBackColor = false;
            // 
            // pnl_clientes_morosos
            // 
            this.pnl_clientes_morosos.BackColor = System.Drawing.Color.White;
            this.pnl_clientes_morosos.Controls.Add(this.lbl_clientes_morosos);
            this.pnl_clientes_morosos.Controls.Add(this.lbl_descripcion_clientes_morosos);
            this.pnl_clientes_morosos.Controls.Add(this.btn_clientes_morosos);
            this.pnl_clientes_morosos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_clientes_morosos.Location = new System.Drawing.Point(390, 0);
            this.pnl_clientes_morosos.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnl_clientes_morosos.Name = "pnl_clientes_morosos";
            this.pnl_clientes_morosos.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_clientes_morosos.Size = new System.Drawing.Size(360, 192);
            this.pnl_clientes_morosos.TabIndex = 1;
            // 
            // lbl_clientes_morosos
            // 
            this.lbl_clientes_morosos.AutoSize = true;
            this.lbl_clientes_morosos.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes_morosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_clientes_morosos.Location = new System.Drawing.Point(20, 18);
            this.lbl_clientes_morosos.Name = "lbl_clientes_morosos";
            this.lbl_clientes_morosos.Size = new System.Drawing.Size(176, 30);
            this.lbl_clientes_morosos.TabIndex = 0;
            this.lbl_clientes_morosos.Text = "Clientes morosos";
            // 
            // lbl_descripcion_clientes_morosos
            // 
            this.lbl_descripcion_clientes_morosos.Font = new System.Drawing.Font("Lexend", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_clientes_morosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_descripcion_clientes_morosos.Location = new System.Drawing.Point(22, 57);
            this.lbl_descripcion_clientes_morosos.Name = "lbl_descripcion_clientes_morosos";
            this.lbl_descripcion_clientes_morosos.Size = new System.Drawing.Size(310, 55);
            this.lbl_descripcion_clientes_morosos.TabIndex = 1;
            this.lbl_descripcion_clientes_morosos.Text = "Consulte clientes con facturas, deudas y saldos pendientes.";
            // 
            // btn_clientes_morosos
            // 
            this.btn_clientes_morosos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_clientes_morosos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientes_morosos.FlatAppearance.BorderSize = 0;
            this.btn_clientes_morosos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes_morosos.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes_morosos.ForeColor = System.Drawing.Color.White;
            this.btn_clientes_morosos.Location = new System.Drawing.Point(22, 130);
            this.btn_clientes_morosos.Name = "btn_clientes_morosos";
            this.btn_clientes_morosos.Size = new System.Drawing.Size(160, 40);
            this.btn_clientes_morosos.TabIndex = 2;
            this.btn_clientes_morosos.Text = "Consultar";
            this.btn_clientes_morosos.UseVisualStyleBackColor = false;
            // 
            // pnl_vencimientos
            // 
            this.pnl_vencimientos.BackColor = System.Drawing.Color.White;
            this.pnl_vencimientos.Controls.Add(this.lbl_vencimientos);
            this.pnl_vencimientos.Controls.Add(this.lbl_descripcion_vencimientos);
            this.pnl_vencimientos.Controls.Add(this.btn_vencimientos);
            this.pnl_vencimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_vencimientos.Location = new System.Drawing.Point(770, 0);
            this.pnl_vencimientos.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.pnl_vencimientos.Name = "pnl_vencimientos";
            this.pnl_vencimientos.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_vencimientos.Size = new System.Drawing.Size(370, 192);
            this.pnl_vencimientos.TabIndex = 2;
            // 
            // lbl_vencimientos
            // 
            this.lbl_vencimientos.AutoSize = true;
            this.lbl_vencimientos.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vencimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_vencimientos.Location = new System.Drawing.Point(20, 18);
            this.lbl_vencimientos.Name = "lbl_vencimientos";
            this.lbl_vencimientos.Size = new System.Drawing.Size(141, 30);
            this.lbl_vencimientos.TabIndex = 0;
            this.lbl_vencimientos.Text = "Vencimientos";
            // 
            // lbl_descripcion_vencimientos
            // 
            this.lbl_descripcion_vencimientos.Font = new System.Drawing.Font("Lexend", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_vencimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_descripcion_vencimientos.Location = new System.Drawing.Point(22, 57);
            this.lbl_descripcion_vencimientos.Name = "lbl_descripcion_vencimientos";
            this.lbl_descripcion_vencimientos.Size = new System.Drawing.Size(320, 55);
            this.lbl_descripcion_vencimientos.TabIndex = 1;
            this.lbl_descripcion_vencimientos.Text = "Genere reportes de membresías próximas a vencer o vencidas.";
            // 
            // btn_vencimientos
            // 
            this.btn_vencimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_vencimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vencimientos.FlatAppearance.BorderSize = 0;
            this.btn_vencimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vencimientos.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vencimientos.ForeColor = System.Drawing.Color.White;
            this.btn_vencimientos.Location = new System.Drawing.Point(22, 130);
            this.btn_vencimientos.Name = "btn_vencimientos";
            this.btn_vencimientos.Size = new System.Drawing.Size(160, 40);
            this.btn_vencimientos.TabIndex = 2;
            this.btn_vencimientos.Text = "Consultar";
            this.btn_vencimientos.UseVisualStyleBackColor = false;
            // 
            // pnl_asistencia
            // 
            this.pnl_asistencia.BackColor = System.Drawing.Color.White;
            this.pnl_asistencia.Controls.Add(this.lbl_asistencia);
            this.pnl_asistencia.Controls.Add(this.lbl_descripcion_asistencia);
            this.pnl_asistencia.Controls.Add(this.btn_asistencia);
            this.pnl_asistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_asistencia.Location = new System.Drawing.Point(0, 212);
            this.pnl_asistencia.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.pnl_asistencia.Name = "pnl_asistencia";
            this.pnl_asistencia.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_asistencia.Size = new System.Drawing.Size(370, 193);
            this.pnl_asistencia.TabIndex = 3;
            // 
            // lbl_asistencia
            // 
            this.lbl_asistencia.AutoSize = true;
            this.lbl_asistencia.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_asistencia.Location = new System.Drawing.Point(20, 18);
            this.lbl_asistencia.Name = "lbl_asistencia";
            this.lbl_asistencia.Size = new System.Drawing.Size(110, 30);
            this.lbl_asistencia.TabIndex = 0;
            this.lbl_asistencia.Text = "Asistencia";
            // 
            // lbl_descripcion_asistencia
            // 
            this.lbl_descripcion_asistencia.Font = new System.Drawing.Font("Lexend", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_asistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_descripcion_asistencia.Location = new System.Drawing.Point(22, 57);
            this.lbl_descripcion_asistencia.Name = "lbl_descripcion_asistencia";
            this.lbl_descripcion_asistencia.Size = new System.Drawing.Size(320, 55);
            this.lbl_descripcion_asistencia.TabIndex = 1;
            this.lbl_descripcion_asistencia.Text = "Consulte el historial de entradas y salidas de los clientes.";
            // 
            // btn_asistencia
            // 
            this.btn_asistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_asistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_asistencia.FlatAppearance.BorderSize = 0;
            this.btn_asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asistencia.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asistencia.ForeColor = System.Drawing.Color.White;
            this.btn_asistencia.Location = new System.Drawing.Point(22, 130);
            this.btn_asistencia.Name = "btn_asistencia";
            this.btn_asistencia.Size = new System.Drawing.Size(160, 40);
            this.btn_asistencia.TabIndex = 2;
            this.btn_asistencia.Text = "Consultar";
            this.btn_asistencia.UseVisualStyleBackColor = false;
            // 
            // pnl_cierres_de_caja
            // 
            this.pnl_cierres_de_caja.BackColor = System.Drawing.Color.White;
            this.pnl_cierres_de_caja.Controls.Add(this.lbl_cierres_de_caja);
            this.pnl_cierres_de_caja.Controls.Add(this.lbl_descripcion_cierres_de_caja);
            this.pnl_cierres_de_caja.Controls.Add(this.btn_cierres_de_caja);
            this.pnl_cierres_de_caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cierres_de_caja.Location = new System.Drawing.Point(390, 212);
            this.pnl_cierres_de_caja.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pnl_cierres_de_caja.Name = "pnl_cierres_de_caja";
            this.pnl_cierres_de_caja.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_cierres_de_caja.Size = new System.Drawing.Size(360, 193);
            this.pnl_cierres_de_caja.TabIndex = 4;
            // 
            // lbl_cierres_de_caja
            // 
            this.lbl_cierres_de_caja.AutoSize = true;
            this.lbl_cierres_de_caja.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cierres_de_caja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_cierres_de_caja.Location = new System.Drawing.Point(20, 18);
            this.lbl_cierres_de_caja.Name = "lbl_cierres_de_caja";
            this.lbl_cierres_de_caja.Size = new System.Drawing.Size(158, 30);
            this.lbl_cierres_de_caja.TabIndex = 0;
            this.lbl_cierres_de_caja.Text = "Cierres de caja";
            // 
            // lbl_descripcion_cierres_de_caja
            // 
            this.lbl_descripcion_cierres_de_caja.Font = new System.Drawing.Font("Lexend", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_cierres_de_caja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_descripcion_cierres_de_caja.Location = new System.Drawing.Point(22, 57);
            this.lbl_descripcion_cierres_de_caja.Name = "lbl_descripcion_cierres_de_caja";
            this.lbl_descripcion_cierres_de_caja.Size = new System.Drawing.Size(310, 55);
            this.lbl_descripcion_cierres_de_caja.TabIndex = 1;
            this.lbl_descripcion_cierres_de_caja.Text = "Consulte los cierres, cuadres y diferencias registradas.";
            // 
            // btn_cierres_de_caja
            // 
            this.btn_cierres_de_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_cierres_de_caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cierres_de_caja.FlatAppearance.BorderSize = 0;
            this.btn_cierres_de_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cierres_de_caja.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cierres_de_caja.ForeColor = System.Drawing.Color.White;
            this.btn_cierres_de_caja.Location = new System.Drawing.Point(22, 130);
            this.btn_cierres_de_caja.Name = "btn_cierres_de_caja";
            this.btn_cierres_de_caja.Size = new System.Drawing.Size(160, 40);
            this.btn_cierres_de_caja.TabIndex = 2;
            this.btn_cierres_de_caja.Text = "Consultar";
            this.btn_cierres_de_caja.UseVisualStyleBackColor = false;
            // 
            // pnl_finanzas
            // 
            this.pnl_finanzas.BackColor = System.Drawing.Color.White;
            this.pnl_finanzas.Controls.Add(this.lbl_finanzas);
            this.pnl_finanzas.Controls.Add(this.lbl_descripcion_finanzas);
            this.pnl_finanzas.Controls.Add(this.btn_finanzas);
            this.pnl_finanzas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_finanzas.Location = new System.Drawing.Point(770, 212);
            this.pnl_finanzas.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnl_finanzas.Name = "pnl_finanzas";
            this.pnl_finanzas.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_finanzas.Size = new System.Drawing.Size(370, 193);
            this.pnl_finanzas.TabIndex = 5;
            // 
            // lbl_finanzas
            // 
            this.lbl_finanzas.AutoSize = true;
            this.lbl_finanzas.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finanzas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_finanzas.Location = new System.Drawing.Point(20, 18);
            this.lbl_finanzas.Name = "lbl_finanzas";
            this.lbl_finanzas.Size = new System.Drawing.Size(210, 30);
            this.lbl_finanzas.TabIndex = 0;
            this.lbl_finanzas.Text = "Actividad financiera";
            // 
            // lbl_descripcion_finanzas
            // 
            this.lbl_descripcion_finanzas.Font = new System.Drawing.Font("Lexend", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_finanzas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_descripcion_finanzas.Location = new System.Drawing.Point(22, 57);
            this.lbl_descripcion_finanzas.Name = "lbl_descripcion_finanzas";
            this.lbl_descripcion_finanzas.Size = new System.Drawing.Size(320, 55);
            this.lbl_descripcion_finanzas.TabIndex = 1;
            this.lbl_descripcion_finanzas.Text = "Consulte las facturas, ventas e ingresos registrados.";
            // 
            // btn_finanzas
            // 
            this.btn_finanzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_finanzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finanzas.FlatAppearance.BorderSize = 0;
            this.btn_finanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finanzas.Font = new System.Drawing.Font("Lexend", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finanzas.ForeColor = System.Drawing.Color.White;
            this.btn_finanzas.Location = new System.Drawing.Point(22, 130);
            this.btn_finanzas.Name = "btn_finanzas";
            this.btn_finanzas.Size = new System.Drawing.Size(160, 40);
            this.btn_finanzas.TabIndex = 2;
            this.btn_finanzas.Text = "Consultar";
            this.btn_finanzas.UseVisualStyleBackColor = false;
            // 
            // pnl_nota
            // 
            this.pnl_nota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnl_nota.Controls.Add(this.lbl_nota);
            this.pnl_nota.Location = new System.Drawing.Point(30, 525);
            this.pnl_nota.Name = "pnl_nota";
            this.pnl_nota.Size = new System.Drawing.Size(1140, 58);
            this.pnl_nota.TabIndex = 3;
            // 
            // lbl_nota
            // 
            this.lbl_nota.Font = new System.Drawing.Font("Lexend", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.lbl_nota.Location = new System.Drawing.Point(20, 10);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(1095, 38);
            this.lbl_nota.TabIndex = 0;
            this.lbl_nota.Text = "Los datos se consultarán únicamente al abrir el reporte seleccionado.";
            this.lbl_nota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_cerrar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 595);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Size = new System.Drawing.Size(1140, 70);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(977, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(145, 40);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // modulo_de_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(1200, 690);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_nota);
            this.Controls.Add(this.tlp_reportes);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "modulo_de_reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes - Go Fitness Gym";
            this.tlp_reportes.ResumeLayout(false);
            this.pnl_clientes.ResumeLayout(false);
            this.pnl_clientes.PerformLayout();
            this.pnl_clientes_morosos.ResumeLayout(false);
            this.pnl_clientes_morosos.PerformLayout();
            this.pnl_vencimientos.ResumeLayout(false);
            this.pnl_vencimientos.PerformLayout();
            this.pnl_asistencia.ResumeLayout(false);
            this.pnl_asistencia.PerformLayout();
            this.pnl_cierres_de_caja.ResumeLayout(false);
            this.pnl_cierres_de_caja.PerformLayout();
            this.pnl_finanzas.ResumeLayout(false);
            this.pnl_finanzas.PerformLayout();
            this.pnl_nota.ResumeLayout(false);
            this.pnl_acciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.TableLayoutPanel tlp_reportes;

        private System.Windows.Forms.Panel pnl_clientes;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.Label lbl_descripcion_clientes;
        private System.Windows.Forms.Button btn_consultar_clientes;

        private System.Windows.Forms.Panel pnl_clientes_morosos;
        private System.Windows.Forms.Label lbl_clientes_morosos;
        private System.Windows.Forms.Label
            lbl_descripcion_clientes_morosos;
        private System.Windows.Forms.Button btn_clientes_morosos;

        private System.Windows.Forms.Panel pnl_vencimientos;
        private System.Windows.Forms.Label lbl_vencimientos;
        private System.Windows.Forms.Label
            lbl_descripcion_vencimientos;
        private System.Windows.Forms.Button btn_vencimientos;

        private System.Windows.Forms.Panel pnl_asistencia;
        private System.Windows.Forms.Label lbl_asistencia;
        private System.Windows.Forms.Label
            lbl_descripcion_asistencia;
        private System.Windows.Forms.Button btn_asistencia;

        private System.Windows.Forms.Panel pnl_cierres_de_caja;
        private System.Windows.Forms.Label lbl_cierres_de_caja;
        private System.Windows.Forms.Label
            lbl_descripcion_cierres_de_caja;
        private System.Windows.Forms.Button btn_cierres_de_caja;

        private System.Windows.Forms.Panel pnl_finanzas;
        private System.Windows.Forms.Label lbl_finanzas;
        private System.Windows.Forms.Label
            lbl_descripcion_finanzas;
        private System.Windows.Forms.Button btn_finanzas;

        private System.Windows.Forms.Panel pnl_nota;
        private System.Windows.Forms.Label lbl_nota;

        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_cerrar;
    }
}