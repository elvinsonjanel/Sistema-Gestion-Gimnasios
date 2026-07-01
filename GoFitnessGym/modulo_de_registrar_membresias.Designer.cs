
namespace GoFitnessGym
{
    partial class modulo_de_registrar_membresias
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
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_precio_registrar_membresia = new System.Windows.Forms.TextBox();
            this.txt_duracion_registrar_membresia = new System.Windows.Forms.TextBox();
            this.txt_descripcion_registrar_membresia = new System.Windows.Forms.TextBox();
            this.txt_nombre_registrar_membresia = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.btn_guardar_regisrar_membresias = new System.Windows.Forms.Button();
            this.btn_cancelar_registrar_membresia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(528, 28);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(91, 32);
            this.lbl_precio.TabIndex = 0;
            this.lbl_precio.Text = "Precio *";
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duracion.Location = new System.Drawing.Point(28, 305);
            this.lbl_duracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(118, 32);
            this.lbl_duracion.TabIndex = 1;
            this.lbl_duracion.Text = "Duracion *";
            this.lbl_duracion.Click += new System.EventHandler(this.lbl_duracion_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(30, 154);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(108, 32);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre *";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(528, 154);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(145, 32);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "Descripcion *";
            this.lbl_descripcion.Click += new System.EventHandler(this.lbl_descripcion_Click);
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(40, 98);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(461, 45);
            this.lbl_subtitulo.TabIndex = 5;
            this.lbl_subtitulo.Text = "Registre las nuevas membresias ";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lbl_titulo.Location = new System.Drawing.Point(38, 45);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(676, 50);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Registrar Nuevos Planes de Membresias";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.txt_precio_registrar_membresia);
            this.panel1.Controls.Add(this.txt_duracion_registrar_membresia);
            this.panel1.Controls.Add(this.txt_descripcion_registrar_membresia);
            this.panel1.Controls.Add(this.txt_nombre_registrar_membresia);
            this.panel1.Controls.Add(this.lbl_codigo);
            this.panel1.Controls.Add(this.lbl_precio);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.lbl_descripcion);
            this.panel1.Controls.Add(this.lbl_duracion);
            this.panel1.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(46, 165);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 466);
            this.panel1.TabIndex = 6;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.txt_codigo.Location = new System.Drawing.Point(36, 69);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(383, 32);
            this.txt_codigo.TabIndex = 10;
            this.txt_codigo.Text = "Se generará automáticamente";
            // 
            // txt_precio_registrar_membresia
            // 
            this.txt_precio_registrar_membresia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_precio_registrar_membresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precio_registrar_membresia.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_registrar_membresia.Location = new System.Drawing.Point(534, 69);
            this.txt_precio_registrar_membresia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_precio_registrar_membresia.Name = "txt_precio_registrar_membresia";
            this.txt_precio_registrar_membresia.Size = new System.Drawing.Size(276, 32);
            this.txt_precio_registrar_membresia.TabIndex = 9;
            this.txt_precio_registrar_membresia.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_duracion_registrar_membresia
            // 
            this.txt_duracion_registrar_membresia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_duracion_registrar_membresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_duracion_registrar_membresia.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duracion_registrar_membresia.Location = new System.Drawing.Point(34, 342);
            this.txt_duracion_registrar_membresia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_duracion_registrar_membresia.Name = "txt_duracion_registrar_membresia";
            this.txt_duracion_registrar_membresia.Size = new System.Drawing.Size(289, 32);
            this.txt_duracion_registrar_membresia.TabIndex = 8;
            // 
            // txt_descripcion_registrar_membresia
            // 
            this.txt_descripcion_registrar_membresia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_descripcion_registrar_membresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion_registrar_membresia.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_registrar_membresia.Location = new System.Drawing.Point(520, 191);
            this.txt_descripcion_registrar_membresia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descripcion_registrar_membresia.Multiline = true;
            this.txt_descripcion_registrar_membresia.Name = "txt_descripcion_registrar_membresia";
            this.txt_descripcion_registrar_membresia.Size = new System.Drawing.Size(289, 186);
            this.txt_descripcion_registrar_membresia.TabIndex = 7;
            // 
            // txt_nombre_registrar_membresia
            // 
            this.txt_nombre_registrar_membresia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_nombre_registrar_membresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre_registrar_membresia.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_registrar_membresia.Location = new System.Drawing.Point(34, 191);
            this.txt_nombre_registrar_membresia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre_registrar_membresia.Name = "txt_nombre_registrar_membresia";
            this.txt_nombre_registrar_membresia.Size = new System.Drawing.Size(289, 32);
            this.txt_nombre_registrar_membresia.TabIndex = 5;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Lexend", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(28, 28);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(99, 32);
            this.lbl_codigo.TabIndex = 4;
            this.lbl_codigo.Text = "Codigo *";
            // 
            // btn_guardar_regisrar_membresias
            // 
            this.btn_guardar_regisrar_membresias.BackColor = System.Drawing.Color.Navy;
            this.btn_guardar_regisrar_membresias.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_regisrar_membresias.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_regisrar_membresias.Location = new System.Drawing.Point(758, 647);
            this.btn_guardar_regisrar_membresias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guardar_regisrar_membresias.Name = "btn_guardar_regisrar_membresias";
            this.btn_guardar_regisrar_membresias.Size = new System.Drawing.Size(150, 69);
            this.btn_guardar_regisrar_membresias.TabIndex = 7;
            this.btn_guardar_regisrar_membresias.Text = "Guardar";
            this.btn_guardar_regisrar_membresias.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar_registrar_membresia
            // 
            this.btn_cancelar_registrar_membresia.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar_registrar_membresia.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_registrar_membresia.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar_registrar_membresia.Location = new System.Drawing.Point(600, 647);
            this.btn_cancelar_registrar_membresia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancelar_registrar_membresia.Name = "btn_cancelar_registrar_membresia";
            this.btn_cancelar_registrar_membresia.Size = new System.Drawing.Size(150, 69);
            this.btn_cancelar_registrar_membresia.TabIndex = 8;
            this.btn_cancelar_registrar_membresia.Text = "Cancelar";
            this.btn_cancelar_registrar_membresia.UseVisualStyleBackColor = false;
            // 
            // modulo_de_registrar_membresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 740);
            this.Controls.Add(this.btn_cancelar_registrar_membresia);
            this.Controls.Add(this.btn_guardar_regisrar_membresias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_registrar_membresias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar membresias - Go fitnes";
            this.Load += new System.EventHandler(this.modulo_de_registrar_membresias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_precio_registrar_membresia;
        private System.Windows.Forms.TextBox txt_duracion_registrar_membresia;
        private System.Windows.Forms.TextBox txt_descripcion_registrar_membresia;
        private System.Windows.Forms.TextBox txt_nombre_registrar_membresia;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button btn_guardar_regisrar_membresias;
        private System.Windows.Forms.Button btn_cancelar_registrar_membresia;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}