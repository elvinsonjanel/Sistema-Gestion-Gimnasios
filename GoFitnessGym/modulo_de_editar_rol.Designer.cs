
namespace GoFitnessGym
{
    partial class modulo_de_editar_rol
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
            this.pnl_informacion_rol = new System.Windows.Forms.Panel();
            this.lbl_informacion_rol = new System.Windows.Forms.Label();
            this.lbl_codigo_rol = new System.Windows.Forms.Label();
            this.txt_codigo_rol = new System.Windows.Forms.TextBox();
            this.lbl_ayuda_codigo = new System.Windows.Forms.Label();
            this.lbl_nombre_rol = new System.Windows.Forms.Label();
            this.lbl_nombre_obligatorio = new System.Windows.Forms.Label();
            this.txt_nombre_rol = new System.Windows.Forms.TextBox();
            this.lbl_descripcion_rol = new System.Windows.Forms.Label();
            this.lbl_descripcion_obligatoria = new System.Windows.Forms.Label();
            this.txt_descripcion_rol = new System.Windows.Forms.TextBox();
            this.lbl_campos_obligatorios = new System.Windows.Forms.Label();
            this.pnl_nota = new System.Windows.Forms.Panel();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.lbl_nota_permisos = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.pnl_informacion_rol.SuspendLayout();
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
            this.lbl_titulo.Size = new System.Drawing.Size(149, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Editar rol";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 59);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(448, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Modifique la información básica del rol seleccionado";
            // 
            // pnl_informacion_rol
            // 
            this.pnl_informacion_rol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_informacion_rol.BackColor = System.Drawing.Color.White;
            this.pnl_informacion_rol.Controls.Add(this.lbl_informacion_rol);
            this.pnl_informacion_rol.Controls.Add(this.lbl_codigo_rol);
            this.pnl_informacion_rol.Controls.Add(this.txt_codigo_rol);
            this.pnl_informacion_rol.Controls.Add(this.lbl_ayuda_codigo);
            this.pnl_informacion_rol.Controls.Add(this.lbl_nombre_rol);
            this.pnl_informacion_rol.Controls.Add(this.lbl_nombre_obligatorio);
            this.pnl_informacion_rol.Controls.Add(this.txt_nombre_rol);
            this.pnl_informacion_rol.Controls.Add(this.lbl_descripcion_rol);
            this.pnl_informacion_rol.Controls.Add(this.lbl_descripcion_obligatoria);
            this.pnl_informacion_rol.Controls.Add(this.txt_descripcion_rol);
            this.pnl_informacion_rol.Controls.Add(this.lbl_campos_obligatorios);
            this.pnl_informacion_rol.Location = new System.Drawing.Point(30, 105);
            this.pnl_informacion_rol.Name = "pnl_informacion_rol";
            this.pnl_informacion_rol.Padding = new System.Windows.Forms.Padding(25);
            this.pnl_informacion_rol.Size = new System.Drawing.Size(640, 330);
            this.pnl_informacion_rol.TabIndex = 2;
            // 
            // lbl_informacion_rol
            // 
            this.lbl_informacion_rol.AutoSize = true;
            this.lbl_informacion_rol.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacion_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_informacion_rol.Location = new System.Drawing.Point(25, 18);
            this.lbl_informacion_rol.Name = "lbl_informacion_rol";
            this.lbl_informacion_rol.Size = new System.Drawing.Size(203, 30);
            this.lbl_informacion_rol.TabIndex = 0;
            this.lbl_informacion_rol.Text = "Información del rol";
            // 
            // lbl_codigo_rol
            // 
            this.lbl_codigo_rol.AutoSize = true;
            this.lbl_codigo_rol.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_codigo_rol.Location = new System.Drawing.Point(25, 60);
            this.lbl_codigo_rol.Name = "lbl_codigo_rol";
            this.lbl_codigo_rol.Size = new System.Drawing.Size(125, 24);
            this.lbl_codigo_rol.TabIndex = 1;
            this.lbl_codigo_rol.Text = "Código del rol:";
            // 
            // txt_codigo_rol
            // 
            this.txt_codigo_rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_codigo_rol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo_rol.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.txt_codigo_rol.Location = new System.Drawing.Point(25, 87);
            this.txt_codigo_rol.Name = "txt_codigo_rol";
            this.txt_codigo_rol.ReadOnly = true;
            this.txt_codigo_rol.Size = new System.Drawing.Size(180, 28);
            this.txt_codigo_rol.TabIndex = 2;
            this.txt_codigo_rol.TabStop = false;
            this.txt_codigo_rol.Text = "ROL-000";
            // 
            // lbl_ayuda_codigo
            // 
            this.lbl_ayuda_codigo.AutoSize = true;
            this.lbl_ayuda_codigo.Font = new System.Drawing.Font("Lexend", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ayuda_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_ayuda_codigo.Location = new System.Drawing.Point(25, 118);
            this.lbl_ayuda_codigo.Name = "lbl_ayuda_codigo";
            this.lbl_ayuda_codigo.Size = new System.Drawing.Size(229, 22);
            this.lbl_ayuda_codigo.TabIndex = 3;
            this.lbl_ayuda_codigo.Text = "El código no puede modificarse.";
            // 
            // lbl_nombre_rol
            // 
            this.lbl_nombre_rol.AutoSize = true;
            this.lbl_nombre_rol.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_nombre_rol.Location = new System.Drawing.Point(246, 60);
            this.lbl_nombre_rol.Name = "lbl_nombre_rol";
            this.lbl_nombre_rol.Size = new System.Drawing.Size(132, 24);
            this.lbl_nombre_rol.TabIndex = 4;
            this.lbl_nombre_rol.Text = "Nombre del rol:";
            // 
            // lbl_nombre_obligatorio
            // 
            this.lbl_nombre_obligatorio.AutoSize = true;
            this.lbl_nombre_obligatorio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_obligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_nombre_obligatorio.Location = new System.Drawing.Point(374, 60);
            this.lbl_nombre_obligatorio.Name = "lbl_nombre_obligatorio";
            this.lbl_nombre_obligatorio.Size = new System.Drawing.Size(17, 24);
            this.lbl_nombre_obligatorio.TabIndex = 5;
            this.lbl_nombre_obligatorio.Text = "*";
            // 
            // txt_nombre_rol
            // 
            this.txt_nombre_rol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre_rol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre_rol.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_nombre_rol.Location = new System.Drawing.Point(250, 87);
            this.txt_nombre_rol.MaxLength = 50;
            this.txt_nombre_rol.Name = "txt_nombre_rol";
            this.txt_nombre_rol.Size = new System.Drawing.Size(365, 28);
            this.txt_nombre_rol.TabIndex = 6;
            // 
            // lbl_descripcion_rol
            // 
            this.lbl_descripcion_rol.AutoSize = true;
            this.lbl_descripcion_rol.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lbl_descripcion_rol.Location = new System.Drawing.Point(25, 160);
            this.lbl_descripcion_rol.Name = "lbl_descripcion_rol";
            this.lbl_descripcion_rol.Size = new System.Drawing.Size(161, 24);
            this.lbl_descripcion_rol.TabIndex = 7;
            this.lbl_descripcion_rol.Text = "Descripción del rol:";
            // 
            // lbl_descripcion_obligatoria
            // 
            this.lbl_descripcion_obligatoria.AutoSize = true;
            this.lbl_descripcion_obligatoria.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_obligatoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_descripcion_obligatoria.Location = new System.Drawing.Point(183, 160);
            this.lbl_descripcion_obligatoria.Name = "lbl_descripcion_obligatoria";
            this.lbl_descripcion_obligatoria.Size = new System.Drawing.Size(17, 24);
            this.lbl_descripcion_obligatoria.TabIndex = 8;
            this.lbl_descripcion_obligatoria.Text = "*";
            // 
            // txt_descripcion_rol
            // 
            this.txt_descripcion_rol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion_rol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion_rol.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_descripcion_rol.Location = new System.Drawing.Point(25, 187);
            this.txt_descripcion_rol.MaxLength = 250;
            this.txt_descripcion_rol.Multiline = true;
            this.txt_descripcion_rol.Name = "txt_descripcion_rol";
            this.txt_descripcion_rol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descripcion_rol.Size = new System.Drawing.Size(590, 85);
            this.txt_descripcion_rol.TabIndex = 9;
            // 
            // lbl_campos_obligatorios
            // 
            this.lbl_campos_obligatorios.AutoSize = true;
            this.lbl_campos_obligatorios.Font = new System.Drawing.Font("Lexend", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campos_obligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_campos_obligatorios.Location = new System.Drawing.Point(25, 286);
            this.lbl_campos_obligatorios.Name = "lbl_campos_obligatorios";
            this.lbl_campos_obligatorios.Size = new System.Drawing.Size(164, 22);
            this.lbl_campos_obligatorios.TabIndex = 10;
            this.lbl_campos_obligatorios.Text = "* Campos obligatorios";
            // 
            // pnl_nota
            // 
            this.pnl_nota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnl_nota.Controls.Add(this.lbl_nota);
            this.pnl_nota.Controls.Add(this.lbl_nota_permisos);
            this.pnl_nota.Location = new System.Drawing.Point(30, 447);
            this.pnl_nota.Name = "pnl_nota";
            this.pnl_nota.Size = new System.Drawing.Size(640, 72);
            this.pnl_nota.TabIndex = 3;
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.lbl_nota.Location = new System.Drawing.Point(18, 10);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(52, 24);
            this.lbl_nota.TabIndex = 0;
            this.lbl_nota.Text = "Nota:";
            // 
            // lbl_nota_permisos
            // 
            this.lbl_nota_permisos.AutoSize = true;
            this.lbl_nota_permisos.Font = new System.Drawing.Font("Lexend", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota_permisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.lbl_nota_permisos.Location = new System.Drawing.Point(18, 36);
            this.lbl_nota_permisos.Name = "lbl_nota_permisos";
            this.lbl_nota_permisos.Size = new System.Drawing.Size(526, 24);
            this.lbl_nota_permisos.TabIndex = 1;
            this.lbl_nota_permisos.Text = "Los permisos y el estado del rol se administran desde Roles y permisos.";
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_guardar);
            this.pnl_acciones.Controls.Add(this.btn_cancelar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 531);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Size = new System.Drawing.Size(640, 70);
            this.pnl_acciones.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(20, 15);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(145, 40);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(475, 15);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(145, 40);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // modulo_de_editar_rol
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(700, 625);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.pnl_nota);
            this.Controls.Add(this.pnl_informacion_rol);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_editar_rol";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Rol - Go Fitness Gym";
            this.pnl_informacion_rol.ResumeLayout(false);
            this.pnl_informacion_rol.PerformLayout();
            this.pnl_nota.ResumeLayout(false);
            this.pnl_nota.PerformLayout();
            this.pnl_acciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.Panel
            pnl_informacion_rol;

        private System.Windows.Forms.Label
            lbl_informacion_rol;

        private System.Windows.Forms.Label
            lbl_codigo_rol;

        private System.Windows.Forms.TextBox
            txt_codigo_rol;

        private System.Windows.Forms.Label
            lbl_ayuda_codigo;

        private System.Windows.Forms.Label
            lbl_nombre_rol;

        private System.Windows.Forms.Label
            lbl_nombre_obligatorio;

        private System.Windows.Forms.TextBox
            txt_nombre_rol;

        private System.Windows.Forms.Label
            lbl_descripcion_rol;

        private System.Windows.Forms.Label
            lbl_descripcion_obligatoria;

        private System.Windows.Forms.TextBox
            txt_descripcion_rol;

        private System.Windows.Forms.Label
            lbl_campos_obligatorios;

        private System.Windows.Forms.Panel
            pnl_nota;

        private System.Windows.Forms.Label
            lbl_nota;

        private System.Windows.Forms.Label
            lbl_nota_permisos;

        private System.Windows.Forms.Panel
            pnl_acciones;

        private System.Windows.Forms.Button
            btn_guardar;

        private System.Windows.Forms.Button
            btn_cancelar;
    }
}