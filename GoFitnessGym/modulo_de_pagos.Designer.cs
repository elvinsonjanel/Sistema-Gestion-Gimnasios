
namespace GoFitnessGym
{
    partial class modulo_de_pagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_filtro = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_menbresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_metodo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrar los pagos registrados en el sistema ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(121, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Filtro";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbo_filtro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(22, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 85);
            this.panel1.TabIndex = 6;
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_filtro.BackColor = System.Drawing.SystemColors.Menu;
            this.cbo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_filtro.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_filtro.FormattingEnabled = true;
            this.cbo_filtro.Items.AddRange(new object[] {
            "Todos",
            "Codigo",
            "Cliente",
            "Menbresia",
            "Fecha",
            "Metodo de pago",
            "Monto",
            "Estado"});
            this.cbo_filtro.Location = new System.Drawing.Point(467, 30);
            this.cbo_filtro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Size = new System.Drawing.Size(202, 40);
            this.cbo_filtro.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_cliente,
            this.col_menbresia,
            this.Col_fecha,
            this.col_metodo_pago,
            this.col_monto,
            this.col_estado});
            this.dataGridView1.Location = new System.Drawing.Point(56, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(883, 292);
            this.dataGridView1.TabIndex = 7;
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Codigo";
            this.col_codigo.MinimumWidth = 8;
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_cliente
            // 
            this.col_cliente.HeaderText = "Cliente";
            this.col_cliente.MinimumWidth = 8;
            this.col_cliente.Name = "col_cliente";
            this.col_cliente.ReadOnly = true;
            // 
            // col_menbresia
            // 
            this.col_menbresia.HeaderText = "Menbresia";
            this.col_menbresia.MinimumWidth = 8;
            this.col_menbresia.Name = "col_menbresia";
            this.col_menbresia.ReadOnly = true;
            // 
            // Col_fecha
            // 
            this.Col_fecha.HeaderText = "Fecha";
            this.Col_fecha.MinimumWidth = 8;
            this.Col_fecha.Name = "Col_fecha";
            this.Col_fecha.ReadOnly = true;
            // 
            // col_metodo_pago
            // 
            this.col_metodo_pago.HeaderText = "Metodo de pago";
            this.col_metodo_pago.MinimumWidth = 8;
            this.col_metodo_pago.Name = "col_metodo_pago";
            this.col_metodo_pago.ReadOnly = true;
            this.col_metodo_pago.Width = 170;
            // 
            // col_monto
            // 
            this.col_monto.HeaderText = "Monto";
            this.col_monto.MinimumWidth = 8;
            this.col_monto.Name = "col_monto";
            this.col_monto.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.HeaderText = "Estado";
            this.col_estado.MinimumWidth = 8;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            this.col_estado.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(691, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(822, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(40, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Nuevo ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(184, 529);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 46);
            this.button4.TabIndex = 9;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(319, 528);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 47);
            this.button5.TabIndex = 10;
            this.button5.Text = "Ver detalle";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(477, 529);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 45);
            this.button6.TabIndex = 11;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(834, 529);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 46);
            this.button7.TabIndex = 12;
            this.button7.Text = "Cerrar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total de registros : 0";
            // 
            // modulo_de_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modulo_de_pagos";
            this.Text = "Gestionar Pagos - Go Fitness";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_filtro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_menbresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_metodo_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
    }
}