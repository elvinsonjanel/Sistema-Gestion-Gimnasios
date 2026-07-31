
namespace GoFitnessGym
{
    partial class modulo_de_historial_membresia_ofertas
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
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.lbl_total_notificaciones = new System.Windows.Forms.Label();
            this.btn_ver_detalle = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.dgv_auditoria = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo_aviso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_medio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_buscar_cliente = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.cmb_tipo_aviso = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_aviso = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_contenedor.Controls.Add(this.lbl_total_notificaciones);
            this.panel_contenedor.Controls.Add(this.btn_ver_detalle);
            this.panel_contenedor.Controls.Add(this.btn_exportar);
            this.panel_contenedor.Controls.Add(this.dgv_auditoria);
            this.panel_contenedor.Controls.Add(this.txt_buscar_cliente);
            this.panel_contenedor.Controls.Add(this.lbl_buscar);
            this.panel_contenedor.Controls.Add(this.cmb_tipo_aviso);
            this.panel_contenedor.Controls.Add(this.lbl_tipo_aviso);
            this.panel_contenedor.Controls.Add(this.dtp_fecha_fin);
            this.panel_contenedor.Controls.Add(this.lbl_hasta);
            this.panel_contenedor.Controls.Add(this.dtp_fecha_inicio);
            this.panel_contenedor.Controls.Add(this.lbl_desde);
            this.panel_contenedor.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_contenedor.Location = new System.Drawing.Point(11, 85);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(821, 449);
            this.panel_contenedor.TabIndex = 2;
            // 
            // lbl_total_notificaciones
            // 
            this.lbl_total_notificaciones.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_notificaciones.Location = new System.Drawing.Point(569, 406);
            this.lbl_total_notificaciones.Name = "lbl_total_notificaciones";
            this.lbl_total_notificaciones.Size = new System.Drawing.Size(197, 23);
            this.lbl_total_notificaciones.TabIndex = 13;
            this.lbl_total_notificaciones.Text = "Total de Avisos Enviados: 0";
            this.lbl_total_notificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;
            this.btn_ver_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalle.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_detalle.ForeColor = System.Drawing.Color.White;
            this.btn_ver_detalle.Location = new System.Drawing.Point(174, 397);
            this.btn_ver_detalle.Name = "btn_ver_detalle";
            this.btn_ver_detalle.Size = new System.Drawing.Size(150, 32);
            this.btn_ver_detalle.TabIndex = 12;
            this.btn_ver_detalle.Text = "Ver Mensaje Completo";
            this.btn_ver_detalle.UseVisualStyleBackColor = false;
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.ForeColor = System.Drawing.Color.White;
            this.btn_exportar.Location = new System.Drawing.Point(13, 397);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(140, 32);
            this.btn_exportar.TabIndex = 11;
            this.btn_exportar.Text = "Exportar Historial";
            this.btn_exportar.UseVisualStyleBackColor = false;
            // 
            // dgv_auditoria
            // 
            this.dgv_auditoria.AllowUserToAddRows = false;
            this.dgv_auditoria.AllowUserToDeleteRows = false;
            this.dgv_auditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_auditoria.BackgroundColor = System.Drawing.Color.White;
            this.dgv_auditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_auditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_auditoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_fecha_hora,
            this.col_cliente,
            this.col_tipo_aviso,
            this.col_medio,
            this.col_mensaje,
            this.col_estado});
            this.dgv_auditoria.Location = new System.Drawing.Point(3, 64);
            this.dgv_auditoria.Name = "dgv_auditoria";
            this.dgv_auditoria.ReadOnly = true;
            this.dgv_auditoria.RowHeadersVisible = false;
            this.dgv_auditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_auditoria.Size = new System.Drawing.Size(813, 321);
            this.dgv_auditoria.TabIndex = 10;
            // 
            // col_id
            // 
            this.col_id.FillWeight = 40F;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_fecha_hora
            // 
            this.col_fecha_hora.FillWeight = 90F;
            this.col_fecha_hora.HeaderText = "Fecha y Hora";
            this.col_fecha_hora.Name = "col_fecha_hora";
            this.col_fecha_hora.ReadOnly = true;
            // 
            // col_cliente
            // 
            this.col_cliente.HeaderText = "Cliente";
            this.col_cliente.Name = "col_cliente";
            this.col_cliente.ReadOnly = true;
            // 
            // col_tipo_aviso
            // 
            this.col_tipo_aviso.FillWeight = 110F;
            this.col_tipo_aviso.HeaderText = "Tipo Aviso";
            this.col_tipo_aviso.Name = "col_tipo_aviso";
            this.col_tipo_aviso.ReadOnly = true;
            // 
            // col_medio
            // 
            this.col_medio.FillWeight = 65F;
            this.col_medio.HeaderText = "Medio";
            this.col_medio.Name = "col_medio";
            this.col_medio.ReadOnly = true;
            // 
            // col_mensaje
            // 
            this.col_mensaje.FillWeight = 140F;
            this.col_mensaje.HeaderText = "Mensaje Enviado";
            this.col_mensaje.Name = "col_mensaje";
            this.col_mensaje.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.FillWeight = 65F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            // 
            // txt_buscar_cliente
            // 
            this.txt_buscar_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar_cliente.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_cliente.Location = new System.Drawing.Point(605, 24);
            this.txt_buscar_cliente.Name = "txt_buscar_cliente";
            this.txt_buscar_cliente.Size = new System.Drawing.Size(161, 22);
            this.txt_buscar_cliente.TabIndex = 9;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(547, 24);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(52, 19);
            this.lbl_buscar.TabIndex = 8;
            this.lbl_buscar.Text = "Cliente:";
            // 
            // cmb_tipo_aviso
            // 
            this.cmb_tipo_aviso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_aviso.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_aviso.FormattingEnabled = true;
            this.cmb_tipo_aviso.Items.AddRange(new object[] {
            "Todos",
            "Vencimiento Membresía",
            "Recordatorio Deuda"});
            this.cmb_tipo_aviso.Location = new System.Drawing.Point(373, 20);
            this.cmb_tipo_aviso.Name = "cmb_tipo_aviso";
            this.cmb_tipo_aviso.Size = new System.Drawing.Size(160, 27);
            this.cmb_tipo_aviso.TabIndex = 7;
            // 
            // lbl_tipo_aviso
            // 
            this.lbl_tipo_aviso.AutoSize = true;
            this.lbl_tipo_aviso.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_aviso.Location = new System.Drawing.Point(330, 25);
            this.lbl_tipo_aviso.Name = "lbl_tipo_aviso";
            this.lbl_tipo_aviso.Size = new System.Drawing.Size(37, 19);
            this.lbl_tipo_aviso.TabIndex = 6;
            this.lbl_tipo_aviso.Text = "Tipo:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(224, 23);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(100, 22);
            this.dtp_fecha_fin.TabIndex = 5;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Location = new System.Drawing.Point(170, 24);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(48, 19);
            this.lbl_hasta.TabIndex = 4;
            this.lbl_hasta.Text = "Hasta:";
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(64, 22);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(100, 22);
            this.dtp_fecha_inicio.TabIndex = 3;
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(9, 26);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(49, 19);
            this.lbl_desde.TabIndex = 2;
            this.lbl_desde.Text = "Desde:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(10, -28);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(437, 33);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Historial de Notificaciones Automáticas";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_subtitulo.Location = new System.Drawing.Point(12, 42);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(296, 19);
            this.lbl_subtitulo.TabIndex = 4;
            this.lbl_subtitulo.Text = "Registro de notificaciones  automáticas enviadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Historial De Los Planes Y Ofertas";
            // 
            // modulo_de_historial_membresia_ofertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_subtitulo);
            this.Name = "modulo_de_historial_membresia_ofertas";
            this.Text = "modulo_de_historial_membresia_ofertas";
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auditoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Label lbl_total_notificaciones;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.DataGridView dgv_auditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo_aviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.TextBox txt_buscar_cliente;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.ComboBox cmb_tipo_aviso;
        private System.Windows.Forms.Label lbl_tipo_aviso;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Label label1;
    }
}