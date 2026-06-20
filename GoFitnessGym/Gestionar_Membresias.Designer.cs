
namespace GoFitnessGym
{
    partial class Gesionar_Membresias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_crear_membresia = new System.Windows.Forms.Button();
            this.btn_eliminar_membresia = new System.Windows.Forms.Button();
            this.btn_editar_membresia = new System.Windows.Forms.Button();
            this.lbl_gestionar_membresia = new System.Windows.Forms.Label();
            this.btn_buscar_membresias = new System.Windows.Forms.Button();
            this.lbl_buscar_membresias = new System.Windows.Forms.Label();
            this.txt_buscar_membresias = new System.Windows.Forms.TextBox();
            this.cbo_filtro_membresias = new System.Windows.Forms.ComboBox();
            this.lbl_filtro_membresias = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cerrar_membresias = new System.Windows.Forms.Button();
            this.btn_detalles_membresias = new System.Windows.Forms.Button();
            this.Tipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear_membresia
            // 
            this.btn_crear_membresia.Location = new System.Drawing.Point(31, 367);
            this.btn_crear_membresia.Name = "btn_crear_membresia";
            this.btn_crear_membresia.Size = new System.Drawing.Size(75, 23);
            this.btn_crear_membresia.TabIndex = 0;
            this.btn_crear_membresia.Text = "Crear";
            this.btn_crear_membresia.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_membresia
            // 
            this.btn_eliminar_membresia.Location = new System.Drawing.Point(257, 367);
            this.btn_eliminar_membresia.Name = "btn_eliminar_membresia";
            this.btn_eliminar_membresia.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_membresia.TabIndex = 1;
            this.btn_eliminar_membresia.Text = "Eliminar";
            this.btn_eliminar_membresia.UseVisualStyleBackColor = true;
            // 
            // btn_editar_membresia
            // 
            this.btn_editar_membresia.Location = new System.Drawing.Point(133, 367);
            this.btn_editar_membresia.Name = "btn_editar_membresia";
            this.btn_editar_membresia.Size = new System.Drawing.Size(75, 23);
            this.btn_editar_membresia.TabIndex = 2;
            this.btn_editar_membresia.Text = "Editar";
            this.btn_editar_membresia.UseVisualStyleBackColor = true;
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
            "Todos",
            "Nombre",
            "Apellido",
            "Código",
            "Documento",
            "Teléfono"});
            this.cbo_filtro_membresias.Location = new System.Drawing.Point(443, 83);
            this.cbo_filtro_membresias.Margin = new System.Windows.Forms.Padding(2);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipos,
            this.Precios,
            this.fecha,
            this.temporal,
            this.productos});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 229);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_cerrar_membresias
            // 
            this.btn_cerrar_membresias.Location = new System.Drawing.Point(642, 367);
            this.btn_cerrar_membresias.Name = "btn_cerrar_membresias";
            this.btn_cerrar_membresias.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar_membresias.TabIndex = 10;
            this.btn_cerrar_membresias.Text = "Cerrar";
            this.btn_cerrar_membresias.UseVisualStyleBackColor = true;
            // 
            // btn_detalles_membresias
            // 
            this.btn_detalles_membresias.Location = new System.Drawing.Point(363, 367);
            this.btn_detalles_membresias.Name = "btn_detalles_membresias";
            this.btn_detalles_membresias.Size = new System.Drawing.Size(75, 23);
            this.btn_detalles_membresias.TabIndex = 11;
            this.btn_detalles_membresias.Text = "Destalles";
            this.btn_detalles_membresias.UseVisualStyleBackColor = true;
            // 
            // Tipos
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lexend Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipos.HeaderText = "Tipos";
            this.Tipos.MinimumWidth = 10;
            this.Tipos.Name = "Tipos";
            this.Tipos.Width = 50;
            // 
            // Precios
            // 
            this.Precios.HeaderText = "Precios";
            this.Precios.Name = "Precios";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            // 
            // temporal
            // 
            this.temporal.HeaderText = "temporar";
            this.temporal.Name = "temporal";
            // 
            // productos
            // 
            this.productos.HeaderText = "Column1";
            this.productos.Name = "productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administres las membrecias que tendras los clientes";
            // 
            // Gesionar_Membresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_detalles_membresias);
            this.Controls.Add(this.btn_cerrar_membresias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_filtro_membresias);
            this.Controls.Add(this.cbo_filtro_membresias);
            this.Controls.Add(this.txt_buscar_membresias);
            this.Controls.Add(this.lbl_buscar_membresias);
            this.Controls.Add(this.btn_buscar_membresias);
            this.Controls.Add(this.lbl_gestionar_membresia);
            this.Controls.Add(this.btn_editar_membresia);
            this.Controls.Add(this.btn_eliminar_membresia);
            this.Controls.Add(this.btn_crear_membresia);
            this.Name = "Gesionar_Membresias";
            this.Text = "Gestionar_Membresias";
            this.Load += new System.EventHandler(this.Gesionar_Membresias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_membresia;
        private System.Windows.Forms.Button btn_eliminar_membresia;
        private System.Windows.Forms.Button btn_editar_membresia;
        private System.Windows.Forms.Label lbl_gestionar_membresia;
        private System.Windows.Forms.Button btn_buscar_membresias;
        private System.Windows.Forms.Label lbl_buscar_membresias;
        private System.Windows.Forms.TextBox txt_buscar_membresias;
        private System.Windows.Forms.ComboBox cbo_filtro_membresias;
        private System.Windows.Forms.Label lbl_filtro_membresias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precios;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporal;
        private System.Windows.Forms.DataGridViewTextBoxColumn productos;
        private System.Windows.Forms.Button btn_cerrar_membresias;
        private System.Windows.Forms.Button btn_detalles_membresias;
        private System.Windows.Forms.Label label1;
    }
}