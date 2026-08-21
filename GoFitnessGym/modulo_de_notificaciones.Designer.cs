
namespace GoFitnessGym
{
    partial class modulo_de_notificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fallidos = new System.Windows.Forms.Label();
            this.lbl_cola = new System.Windows.Forms.Label();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_enviados = new System.Windows.Forms.Label();
            this.btn_limpiar_notificaciones = new System.Windows.Forms.Button();
            this.btn_configuracion = new System.Windows.Forms.Button();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Notificaciones Automáticas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, -22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_fallidos);
            this.panel1.Controls.Add(this.lbl_cola);
            this.panel1.Controls.Add(this.btn_refrescar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_enviados);
            this.panel1.Controls.Add(this.btn_limpiar_notificaciones);
            this.panel1.Controls.Add(this.btn_configuracion);
            this.panel1.Controls.Add(this.lbl_filtrar);
            this.panel1.Controls.Add(this.lbl_buscar);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 366);
            this.panel1.TabIndex = 2;
            // 
            // lbl_fallidos
            // 
            this.lbl_fallidos.AutoSize = true;
            this.lbl_fallidos.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fallidos.Location = new System.Drawing.Point(607, 336);
            this.lbl_fallidos.Name = "lbl_fallidos";
            this.lbl_fallidos.Size = new System.Drawing.Size(65, 17);
            this.lbl_fallidos.TabIndex = 21;
            this.lbl_fallidos.Text = "Fallidos: 0";
            // 
            // lbl_cola
            // 
            this.lbl_cola.AutoSize = true;
            this.lbl_cola.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cola.Location = new System.Drawing.Point(607, 317);
            this.lbl_cola.Name = "lbl_cola";
            this.lbl_cola.Size = new System.Drawing.Size(65, 17);
            this.lbl_cola.TabIndex = 20;
            this.lbl_cola.Text = "En Cola: 0";
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refrescar.ForeColor = System.Drawing.Color.White;
            this.btn_refrescar.Location = new System.Drawing.Point(483, 300);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(104, 28);
            this.btn_refrescar.TabIndex = 19;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Enviado",
            "En cola",
            "Fallido"});
            this.comboBox1.Location = new System.Drawing.Point(323, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 27);
            this.comboBox1.TabIndex = 17;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(71, 15);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(161, 22);
            this.txt_buscar.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Mora Notificada: RD$ 0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 13;
            // 
            // lbl_enviados
            // 
            this.lbl_enviados.AutoSize = true;
            this.lbl_enviados.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enviados.Location = new System.Drawing.Point(608, 300);
            this.lbl_enviados.Name = "lbl_enviados";
            this.lbl_enviados.Size = new System.Drawing.Size(100, 17);
            this.lbl_enviados.TabIndex = 12;
            this.lbl_enviados.Text = "Enviados Hoy: 0";
            // 
            // btn_limpiar_notificaciones
            // 
            this.btn_limpiar_notificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_limpiar_notificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar_notificaciones.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_notificaciones.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar_notificaciones.Location = new System.Drawing.Point(17, 300);
            this.btn_limpiar_notificaciones.Name = "btn_limpiar_notificaciones";
            this.btn_limpiar_notificaciones.Size = new System.Drawing.Size(165, 28);
            this.btn_limpiar_notificaciones.TabIndex = 11;
            this.btn_limpiar_notificaciones.Text = "Reintentar Fallidos";
            this.btn_limpiar_notificaciones.UseVisualStyleBackColor = false;
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracion.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configuracion.ForeColor = System.Drawing.Color.White;
            this.btn_configuracion.Location = new System.Drawing.Point(221, 300);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(180, 28);
            this.btn_configuracion.TabIndex = 9;
            this.btn_configuracion.Text = "Configurar Automatización";
            this.btn_configuracion.UseVisualStyleBackColor = false;
            // 
            // lbl_filtrar
            // 
            this.lbl_filtrar.AutoSize = true;
            this.lbl_filtrar.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrar.Location = new System.Drawing.Point(252, 18);
            this.lbl_filtrar.Name = "lbl_filtrar";
            this.lbl_filtrar.Size = new System.Drawing.Size(53, 19);
            this.lbl_filtrar.TabIndex = 8;
            this.lbl_filtrar.Text = "Estado:";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(13, 18);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(52, 19);
            this.lbl_buscar.TabIndex = 6;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lexend Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.estado,
            this.col_estado});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(7, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(766, 242);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "SMS/Correo/WhatsApp";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tipo de Alerta";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // estado
            // 
            this.estado.HeaderText = "Programado/Enviado";
            this.estado.Name = "estado";
            // 
            // col_estado
            // 
            this.col_estado.HeaderText = "Estado automático";
            this.col_estado.Name = "col_estado";
            // 
            // lbl_motor
            // 
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.Font = new System.Drawing.Font("Lexend SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motor.Location = new System.Drawing.Point(590, 24);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(177, 19);
            this.lbl_motor.TabIndex = 4;
            this.lbl_motor.Text = "Motor automático: ACTIVO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lexend Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ver notificaciones que se le enviarán al cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lexend SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ultimo lote: Hoy 12:15PM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(639, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ver Historial";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(485, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // modulo_de_notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_motor);
            this.Name = "modulo_de_notificaciones";
            this.Text = "Notificaciones Automáticas GO - Fitness";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_enviados;
        private System.Windows.Forms.Button btn_configuracion;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_limpiar_notificaciones;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_fallidos;
        private System.Windows.Forms.Label lbl_cola;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}