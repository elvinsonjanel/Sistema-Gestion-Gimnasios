
namespace GoFitnessGym
{
    partial class modulo_de_registrar_gastos_operativo
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
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.txt_comprobante = new System.Windows.Forms.TextBox();
            this.lbl_metodo_pago = new System.Windows.Forms.Label();
            this.cmb_metodo_pago = new System.Windows.Forms.ComboBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(19, 19);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(298, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Registrar Gasto Operativo";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(22, 65);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(130, 19);
            this.lbl_categoria.TabIndex = 1;
            this.lbl_categoria.Text = "Categoría del Gasto:";
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
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_concepto.Location = new System.Drawing.Point(22, 122);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(147, 19);
            this.lbl_concepto.TabIndex = 3;
            this.lbl_concepto.Text = "Concepto / Descripción:";
            // 
            // txt_concepto
            // 
            this.txt_concepto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_concepto.Location = new System.Drawing.Point(25, 142);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(430, 22);
            this.txt_concepto.TabIndex = 4;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(22, 180);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(83, 19);
            this.lbl_monto.TabIndex = 5;
            this.lbl_monto.Text = "Monto (RD$):";
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(25, 200);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(200, 22);
            this.txt_monto.TabIndex = 6;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(250, 180);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(99, 19);
            this.lbl_fecha.TabIndex = 7;
            this.lbl_fecha.Text = "Fecha de Pago:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(253, 200);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(202, 22);
            this.dtp_fecha.TabIndex = 8;
            // 
            // lbl_comprobante
            // 
            this.lbl_comprobante.AutoSize = true;
            this.lbl_comprobante.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comprobante.Location = new System.Drawing.Point(22, 238);
            this.lbl_comprobante.Name = "lbl_comprobante";
            this.lbl_comprobante.Size = new System.Drawing.Size(150, 19);
            this.lbl_comprobante.TabIndex = 9;
            this.lbl_comprobante.Text = "N° Comprobante / NCF:";
            // 
            // txt_comprobante
            // 
            this.txt_comprobante.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comprobante.Location = new System.Drawing.Point(25, 258);
            this.txt_comprobante.Name = "txt_comprobante";
            this.txt_comprobante.Size = new System.Drawing.Size(200, 22);
            this.txt_comprobante.TabIndex = 10;
            // 
            // lbl_metodo_pago
            // 
            this.lbl_metodo_pago.AutoSize = true;
            this.lbl_metodo_pago.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_metodo_pago.Location = new System.Drawing.Point(250, 238);
            this.lbl_metodo_pago.Name = "lbl_metodo_pago";
            this.lbl_metodo_pago.Size = new System.Drawing.Size(108, 19);
            this.lbl_metodo_pago.TabIndex = 11;
            this.lbl_metodo_pago.Text = "Método de Pago:";
            // 
            // cmb_metodo_pago
            // 
            this.cmb_metodo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_metodo_pago.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_metodo_pago.FormattingEnabled = true;
            this.cmb_metodo_pago.Location = new System.Drawing.Point(253, 258);
            this.cmb_metodo_pago.Name = "cmb_metodo_pago";
            this.cmb_metodo_pago.Size = new System.Drawing.Size(202, 27);
            this.cmb_metodo_pago.TabIndex = 12;
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observaciones.Location = new System.Drawing.Point(22, 298);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(99, 19);
            this.lbl_observaciones.TabIndex = 13;
            this.lbl_observaciones.Text = "Observaciones:";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observaciones.Location = new System.Drawing.Point(25, 318);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(430, 60);
            this.txt_observaciones.TabIndex = 14;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(345, 401);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 35);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar ";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(218, 401);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 35);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // modulo_de_registrar_gastos_operativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 448);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.lbl_observaciones);
            this.Controls.Add(this.cmb_metodo_pago);
            this.Controls.Add(this.lbl_metodo_pago);
            this.Controls.Add(this.txt_comprobante);
            this.Controls.Add(this.lbl_comprobante);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.txt_concepto);
            this.Controls.Add(this.lbl_concepto);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_registrar_gastos_operativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Gasto Operativo - GO Fitness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.TextBox txt_comprobante;
        private System.Windows.Forms.Label lbl_metodo_pago;
        private System.Windows.Forms.ComboBox cmb_metodo_pago;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}