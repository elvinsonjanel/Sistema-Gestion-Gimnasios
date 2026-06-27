
namespace GoFitnessGym
{
    partial class modulo_de_membresias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_gestionar_membresia = new System.Windows.Forms.Label();
            this.btn_buscar_membresias = new System.Windows.Forms.Button();
            this.lbl_buscar_membresias = new System.Windows.Forms.Label();
            this.txt_buscar_membresias = new System.Windows.Forms.TextBox();
            this.cbo_filtro_membresias = new System.Windows.Forms.ComboBox();
            this.lbl_filtro_membresias = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_acciones_membresias = new System.Windows.Forms.Panel();
            this.btn_nuevo_membresia = new System.Windows.Forms.Button();
            this.btn_editar_membresia = new System.Windows.Forms.Button();
            this.btn_ver_detalle_membresia = new System.Windows.Forms.Button();
            this.btn_eliminar_membresia = new System.Windows.Forms.Button();
            this.btn_cerrar_membresia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_acciones_membresias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_gestionar_membresia
            // 
            this.lbl_gestionar_membresia.AutoSize = true;
            this.lbl_gestionar_membresia.Font = new System.Drawing.Font("Lexend SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestionar_membresia.Location = new System.Drawing.Point(24, 9);
            this.lbl_gestionar_membresia.Name = "lbl_gestionar_membresia";
            this.lbl_gestionar_membresia.Size = new System.Drawing.Size(287, 38);
            this.lbl_gestionar_membresia.TabIndex = 3;
            this.lbl_gestionar_membresia.Text = "Gestionar Membresias";
            // 
            // btn_buscar_membresias
            // 
            this.btn_buscar_membresias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_membresias.Font = new System.Drawing.Font("Lexend Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_membresias.Location = new System.Drawing.Point(278, 85);
            this.btn_buscar_membresias.Name = "btn_buscar_membresias";
            this.btn_buscar_membresias.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_membresias.TabIndex = 4;
            this.btn_buscar_membresias.Text = "Buscar";
            this.btn_buscar_membresias.UseVisualStyleBackColor = true;
            this.btn_buscar_membresias.Click += new System.EventHandler(this.btn_buscar_membresias_Click);
            // 
            // lbl_buscar_membresias
            // 
            this.lbl_buscar_membresias.AutoSize = true;
            this.lbl_buscar_membresias.Location = new System.Drawing.Point(28, 91);
            this.lbl_buscar_membresias.Name = "lbl_buscar_membresias";
            this.lbl_buscar_membresias.Size = new System.Drawing.Size(40, 13);
            this.lbl_buscar_membresias.TabIndex = 5;
            this.lbl_buscar_membresias.Text = "Buscar";
            // 
            // txt_buscar_membresias
            // 
            this.txt_buscar_membresias.Location = new System.Drawing.Point(74, 88);
            this.txt_buscar_membresias.Name = "txt_buscar_membresias";
            this.txt_buscar_membresias.Size = new System.Drawing.Size(198, 20);
            this.txt_buscar_membresias.TabIndex = 6;
            // 
            // cbo_filtro_membresias
            // 
            this.cbo_filtro_membresias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtro_membresias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_filtro_membresias.Font = new System.Drawing.Font("Lexend", 10F);
            this.cbo_filtro_membresias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.cbo_filtro_membresias.FormattingEnabled = true;
            this.cbo_filtro_membresias.Items.AddRange(new object[] {
            "Codigo",
            "Nombres",
            "Descripcion",
            "Duracion",
            "Precio",
            "Estado"});
            this.cbo_filtro_membresias.Location = new System.Drawing.Point(443, 83);
            this.cbo_filtro_membresias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_filtro_membresias.Name = "cbo_filtro_membresias";
            this.cbo_filtro_membresias.Size = new System.Drawing.Size(136, 29);
            this.cbo_filtro_membresias.TabIndex = 7;
            // 
            // lbl_filtro_membresias
            // 
            this.lbl_filtro_membresias.AutoSize = true;
            this.lbl_filtro_membresias.Font = new System.Drawing.Font("Lexend Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_membresias.Location = new System.Drawing.Point(388, 87);
            this.lbl_filtro_membresias.Name = "lbl_filtro_membresias";
            this.lbl_filtro_membresias.Size = new System.Drawing.Size(50, 21);
            this.lbl_filtro_membresias.TabIndex = 8;
            this.lbl_filtro_membresias.Text = "Filtro";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lexend Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.fecha,
            this.temporal,
            this.Tipos,
            this.Precios,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(31, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(753, 247);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Nombre";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            // 
            // temporal
            // 
            this.temporal.HeaderText = "Descripcion";
            this.temporal.MinimumWidth = 6;
            this.temporal.Name = "temporal";
            // 
            // Tipos
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lexend Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipos.HeaderText = "Duracion";
            this.Tipos.MinimumWidth = 10;
            this.Tipos.Name = "Tipos";
            // 
            // Precios
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Precios.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precios.HeaderText = "Precio";
            this.Precios.MinimumWidth = 6;
            this.Precios.Name = "Precios";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administre los planes de membresias disponibles";
            // 
            // pnl_acciones_membresias
            // 
            this.pnl_acciones_membresias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones_membresias.BackColor = System.Drawing.Color.White;
            this.pnl_acciones_membresias.Controls.Add(this.btn_nuevo_membresia);
            this.pnl_acciones_membresias.Controls.Add(this.btn_editar_membresia);
            this.pnl_acciones_membresias.Controls.Add(this.btn_ver_detalle_membresia);
            this.pnl_acciones_membresias.Controls.Add(this.btn_eliminar_membresia);
            this.pnl_acciones_membresias.Controls.Add(this.btn_cerrar_membresia);
            this.pnl_acciones_membresias.Location = new System.Drawing.Point(31, 380);
            this.pnl_acciones_membresias.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_acciones_membresias.Name = "pnl_acciones_membresias";
            this.pnl_acciones_membresias.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnl_acciones_membresias.Size = new System.Drawing.Size(753, 57);
            this.pnl_acciones_membresias.TabIndex = 13;
            // 
            // btn_nuevo_membresia
            // 
            this.btn_nuevo_membresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_nuevo_membresia.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_membresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_membresia.Font = new System.Drawing.Font("Lexend Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_membresia.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo_membresia.Location = new System.Drawing.Point(15, 12);
            this.btn_nuevo_membresia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nuevo_membresia.Name = "btn_nuevo_membresia";
            this.btn_nuevo_membresia.Size = new System.Drawing.Size(98, 32);
            this.btn_nuevo_membresia.TabIndex = 0;
            this.btn_nuevo_membresia.Text = "Nuevo";
            this.btn_nuevo_membresia.UseVisualStyleBackColor = false;
            // 
            // btn_editar_membresia
            // 
            this.btn_editar_membresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_editar_membresia.FlatAppearance.BorderSize = 0;
            this.btn_editar_membresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_membresia.Font = new System.Drawing.Font("Lexend Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_membresia.ForeColor = System.Drawing.Color.White;
            this.btn_editar_membresia.Location = new System.Drawing.Point(120, 12);
            this.btn_editar_membresia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editar_membresia.Name = "btn_editar_membresia";
            this.btn_editar_membresia.Size = new System.Drawing.Size(98, 32);
            this.btn_editar_membresia.TabIndex = 1;
            this.btn_editar_membresia.Text = "Editar";
            this.btn_editar_membresia.UseVisualStyleBackColor = false;
            // 
            // btn_ver_detalle_membresia
            // 
            this.btn_ver_detalle_membresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_ver_detalle_membresia.FlatAppearance.BorderSize = 0;
            this.btn_ver_detalle_membresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalle_membresia.Font = new System.Drawing.Font("Lexend Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_detalle_membresia.ForeColor = System.Drawing.Color.White;
            this.btn_ver_detalle_membresia.Location = new System.Drawing.Point(225, 12);
            this.btn_ver_detalle_membresia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ver_detalle_membresia.Name = "btn_ver_detalle_membresia";
            this.btn_ver_detalle_membresia.Size = new System.Drawing.Size(105, 32);
            this.btn_ver_detalle_membresia.TabIndex = 2;
            this.btn_ver_detalle_membresia.Text = "Ver Detalle";
            this.btn_ver_detalle_membresia.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar_membresia
            // 
            this.btn_eliminar_membresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_eliminar_membresia.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_membresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_membresia.Font = new System.Drawing.Font("Lexend Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_membresia.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_membresia.Location = new System.Drawing.Point(338, 12);
            this.btn_eliminar_membresia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar_membresia.Name = "btn_eliminar_membresia";
            this.btn_eliminar_membresia.Size = new System.Drawing.Size(98, 32);
            this.btn_eliminar_membresia.TabIndex = 3;
            this.btn_eliminar_membresia.Text = "Eliminar";
            this.btn_eliminar_membresia.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar_membresia
            // 
            this.btn_cerrar_membresia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_membresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cerrar_membresia.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_membresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_membresia.Font = new System.Drawing.Font("Lexend Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_membresia.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar_membresia.Location = new System.Drawing.Point(640, 12);
            this.btn_cerrar_membresia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar_membresia.Name = "btn_cerrar_membresia";
            this.btn_cerrar_membresia.Size = new System.Drawing.Size(98, 32);
            this.btn_cerrar_membresia.TabIndex = 4;
            this.btn_cerrar_membresia.Text = "Cerrar";
            this.btn_cerrar_membresia.UseVisualStyleBackColor = false;
            // 
            // modulo_de_membresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.pnl_acciones_membresias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_filtro_membresias);
            this.Controls.Add(this.cbo_filtro_membresias);
            this.Controls.Add(this.txt_buscar_membresias);
            this.Controls.Add(this.lbl_buscar_membresias);
            this.Controls.Add(this.btn_buscar_membresias);
            this.Controls.Add(this.lbl_gestionar_membresia);
            this.Name = "modulo_de_membresias";
            this.Text = "Gestionar Membresias - Go Fitness";
            this.Load += new System.EventHandler(this.Gesionar_Membresias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_acciones_membresias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_gestionar_membresia;
        private System.Windows.Forms.Button btn_buscar_membresias;
        private System.Windows.Forms.Label lbl_buscar_membresias;
        private System.Windows.Forms.TextBox txt_buscar_membresias;
        private System.Windows.Forms.ComboBox cbo_filtro_membresias;
        private System.Windows.Forms.Label lbl_filtro_membresias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precios;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Panel pnl_acciones_membresias;
        private System.Windows.Forms.Button btn_nuevo_membresia;
        private System.Windows.Forms.Button btn_editar_membresia;
        private System.Windows.Forms.Button btn_ver_detalle_membresia;
        private System.Windows.Forms.Button btn_eliminar_membresia;
        private System.Windows.Forms.Button btn_cerrar_membresia;
    }
}