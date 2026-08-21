namespace GoFitnessGym
{
    partial class modulo_de_registrar_gastos_inventario
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
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_precio_unitario = new System.Windows.Forms.Label();
            this.txt_precio_unitario = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.txt_comprobante = new System.Windows.Forms.TextBox();
            this.lbl_metodo_pago = new System.Windows.Forms.Label();
            this.cmb_metodo_pago = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(330, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Registrar Compra Inventario";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(22, 65);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(145, 19);
            this.lbl_categoria.TabIndex = 1;
            this.lbl_categoria.Text = "Categoría de Producto:";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(25, 85);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(430, 27);
            this.cmb_categoria.TabIndex = 2;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(22, 122);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(145, 19);
            this.lbl_producto.TabIndex = 3;
            this.lbl_producto.Text = "Producto / Descripción:";
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(25, 142);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(430, 22);
            this.txt_producto.TabIndex = 4;
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.Location = new System.Drawing.Point(22, 180);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(73, 19);
            this.lbl_proveedor.TabIndex = 5;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedor.Location = new System.Drawing.Point(25, 200);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(430, 22);
            this.txt_proveedor.TabIndex = 6;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(22, 238);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(67, 19);
            this.lbl_cantidad.TabIndex = 7;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // num_cantidad
            // 
            this.num_cantidad.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_cantidad.Location = new System.Drawing.Point(25, 258);
            this.num_cantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.Size = new System.Drawing.Size(120, 22);
            this.num_cantidad.TabIndex = 8;
            this.num_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_precio_unitario
            // 
            this.lbl_precio_unitario.AutoSize = true;
            this.lbl_precio_unitario.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_unitario.Location = new System.Drawing.Point(162, 238);
            this.lbl_precio_unitario.Name = "lbl_precio_unitario";
            this.lbl_precio_unitario.Size = new System.Drawing.Size(95, 19);
            this.lbl_precio_unitario.TabIndex = 9;
            this.lbl_precio_unitario.Text = "Costo Unitario:";
            // 
            // txt_precio_unitario
            // 
            this.txt_precio_unitario.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_unitario.Location = new System.Drawing.Point(165, 258);
            this.txt_precio_unitario.Name = "txt_precio_unitario";
            this.txt_precio_unitario.Size = new System.Drawing.Size(130, 22);
            this.txt_precio_unitario.TabIndex = 10;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(312, 238);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(68, 19);
            this.lbl_total.TabIndex = 11;
            this.lbl_total.Text = "Total RD$:";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.LightGray;
            this.txt_total.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(315, 258);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(140, 22);
            this.txt_total.TabIndex = 12;
            this.txt_total.Text = "0.00";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(22, 298);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(115, 19);
            this.lbl_fecha.TabIndex = 13;
            this.lbl_fecha.Text = "Fecha de Compra:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(25, 318);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(130, 22);
            this.dtp_fecha.TabIndex = 14;
            // 
            // lbl_comprobante
            // 
            this.lbl_comprobante.AutoSize = true;
            this.lbl_comprobante.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comprobante.Location = new System.Drawing.Point(172, 298);
            this.lbl_comprobante.Name = "lbl_comprobante";
            this.lbl_comprobante.Size = new System.Drawing.Size(115, 19);
            this.lbl_comprobante.TabIndex = 15;
            this.lbl_comprobante.Text = "N° Factura / NCF:";
            // 
            // txt_comprobante
            // 
            this.txt_comprobante.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comprobante.Location = new System.Drawing.Point(175, 318);
            this.txt_comprobante.Name = "txt_comprobante";
            this.txt_comprobante.Size = new System.Drawing.Size(130, 22);
            this.txt_comprobante.TabIndex = 16;
            // 
            // lbl_metodo_pago
            // 
            this.lbl_metodo_pago.AutoSize = true;
            this.lbl_metodo_pago.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_metodo_pago.Location = new System.Drawing.Point(312, 298);
            this.lbl_metodo_pago.Name = "lbl_metodo_pago";
            this.lbl_metodo_pago.Size = new System.Drawing.Size(108, 19);
            this.lbl_metodo_pago.TabIndex = 17;
            this.lbl_metodo_pago.Text = "Método de Pago:";
            // 
            // cmb_metodo_pago
            // 
            this.cmb_metodo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_metodo_pago.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_metodo_pago.FormattingEnabled = true;
            this.cmb_metodo_pago.Location = new System.Drawing.Point(315, 318);
            this.cmb_metodo_pago.Name = "cmb_metodo_pago";
            this.cmb_metodo_pago.Size = new System.Drawing.Size(140, 27);
            this.cmb_metodo_pago.TabIndex = 18;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(335, 370);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 35);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(206, 370);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 35);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // modulo_de_registrar_gastos_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 425);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmb_metodo_pago);
            this.Controls.Add(this.lbl_metodo_pago);
            this.Controls.Add(this.txt_comprobante);
            this.Controls.Add(this.lbl_comprobante);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_precio_unitario);
            this.Controls.Add(this.lbl_precio_unitario);
            this.Controls.Add(this.num_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_registrar_gastos_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Compra de Inventario - GO Fitness";
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.NumericUpDown num_cantidad;
        private System.Windows.Forms.Label lbl_precio_unitario;
        private System.Windows.Forms.TextBox txt_precio_unitario;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.TextBox txt_comprobante;
        private System.Windows.Forms.Label lbl_metodo_pago;
        private System.Windows.Forms.ComboBox cmb_metodo_pago;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}