namespace GoFitnessGym
{
    partial class modulo_de_cierre_de_caja
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
            this.panel_card = new System.Windows.Forms.Panel();
            this.grp_resumen_sistema = new System.Windows.Forms.GroupBox();
            this.lbl_ingresos_totales = new System.Windows.Forms.Label();
            this.txt_ingresos_totales = new System.Windows.Forms.TextBox();
            this.lbl_pagos_electronicos = new System.Windows.Forms.Label();
            this.txt_pagos_electronicos = new System.Windows.Forms.TextBox();
            this.lbl_efectivo_sistema = new System.Windows.Forms.Label();
            this.txt_efectivo_sistema = new System.Windows.Forms.TextBox();
            this.grp_conteo_fisico = new System.Windows.Forms.GroupBox();
            this.lbl_efectivo_caja = new System.Windows.Forms.Label();
            this.txt_efectivo_caja = new System.Windows.Forms.TextBox();
            this.lbl_diferencia = new System.Windows.Forms.Label();
            this.txt_diferencia = new System.Windows.Forms.TextBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.pnl_acciones = new System.Windows.Forms.Panel();
            this.btn_confirmar_cierre = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fecha_ultimo_cuadre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fecha_actual = new System.Windows.Forms.Label();
            this.panel_card.SuspendLayout();
            this.grp_resumen_sistema.SuspendLayout();
            this.grp_conteo_fisico.SuspendLayout();
            this.pnl_acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lbl_titulo.Location = new System.Drawing.Point(30, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(352, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cierre de Caja y Cuadre";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Lexend", 10F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(32, 60);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(534, 27);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Compare el efectivo físico en caja con los registros del sistema";
            // 
            // panel_card
            // 
            this.panel_card.BackColor = System.Drawing.Color.White;
            this.panel_card.Controls.Add(this.lbl_fecha_actual);
            this.panel_card.Controls.Add(this.label2);
            this.panel_card.Controls.Add(this.lbl_fecha_ultimo_cuadre);
            this.panel_card.Controls.Add(this.label1);
            this.panel_card.Controls.Add(this.grp_resumen_sistema);
            this.panel_card.Controls.Add(this.grp_conteo_fisico);
            this.panel_card.Location = new System.Drawing.Point(30, 100);
            this.panel_card.Name = "panel_card";
            this.panel_card.Padding = new System.Windows.Forms.Padding(20);
            this.panel_card.Size = new System.Drawing.Size(940, 404);
            this.panel_card.TabIndex = 2;
            // 
            // grp_resumen_sistema
            // 
            this.grp_resumen_sistema.Controls.Add(this.lbl_ingresos_totales);
            this.grp_resumen_sistema.Controls.Add(this.txt_ingresos_totales);
            this.grp_resumen_sistema.Controls.Add(this.lbl_pagos_electronicos);
            this.grp_resumen_sistema.Controls.Add(this.txt_pagos_electronicos);
            this.grp_resumen_sistema.Controls.Add(this.lbl_efectivo_sistema);
            this.grp_resumen_sistema.Controls.Add(this.txt_efectivo_sistema);
            this.grp_resumen_sistema.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.grp_resumen_sistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.grp_resumen_sistema.Location = new System.Drawing.Point(17, 71);
            this.grp_resumen_sistema.Name = "grp_resumen_sistema";
            this.grp_resumen_sistema.Size = new System.Drawing.Size(430, 310);
            this.grp_resumen_sistema.TabIndex = 0;
            this.grp_resumen_sistema.TabStop = false;
            this.grp_resumen_sistema.Text = "Resumen del Sistema";
            // 
            // lbl_ingresos_totales
            // 
            this.lbl_ingresos_totales.AutoSize = true;
            this.lbl_ingresos_totales.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_ingresos_totales.Location = new System.Drawing.Point(20, 50);
            this.lbl_ingresos_totales.Name = "lbl_ingresos_totales";
            this.lbl_ingresos_totales.Size = new System.Drawing.Size(133, 24);
            this.lbl_ingresos_totales.TabIndex = 0;
            this.lbl_ingresos_totales.Text = "Ingresos Totales:";
            // 
            // txt_ingresos_totales
            // 
            this.txt_ingresos_totales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_ingresos_totales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ingresos_totales.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_ingresos_totales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.txt_ingresos_totales.Location = new System.Drawing.Point(20, 80);
            this.txt_ingresos_totales.Name = "txt_ingresos_totales";
            this.txt_ingresos_totales.ReadOnly = true;
            this.txt_ingresos_totales.Size = new System.Drawing.Size(390, 28);
            this.txt_ingresos_totales.TabIndex = 1;
            // 
            // lbl_pagos_electronicos
            // 
            this.lbl_pagos_electronicos.AutoSize = true;
            this.lbl_pagos_electronicos.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_pagos_electronicos.Location = new System.Drawing.Point(20, 130);
            this.lbl_pagos_electronicos.Name = "lbl_pagos_electronicos";
            this.lbl_pagos_electronicos.Size = new System.Drawing.Size(237, 24);
            this.lbl_pagos_electronicos.TabIndex = 2;
            this.lbl_pagos_electronicos.Text = "Tarjetas / Transferencias (RD$):";
            // 
            // txt_pagos_electronicos
            // 
            this.txt_pagos_electronicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_pagos_electronicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pagos_electronicos.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_pagos_electronicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.txt_pagos_electronicos.Location = new System.Drawing.Point(20, 160);
            this.txt_pagos_electronicos.Name = "txt_pagos_electronicos";
            this.txt_pagos_electronicos.ReadOnly = true;
            this.txt_pagos_electronicos.Size = new System.Drawing.Size(390, 28);
            this.txt_pagos_electronicos.TabIndex = 3;
            // 
            // lbl_efectivo_sistema
            // 
            this.lbl_efectivo_sistema.AutoSize = true;
            this.lbl_efectivo_sistema.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_efectivo_sistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.lbl_efectivo_sistema.Location = new System.Drawing.Point(20, 210);
            this.lbl_efectivo_sistema.Name = "lbl_efectivo_sistema";
            this.lbl_efectivo_sistema.Size = new System.Drawing.Size(205, 24);
            this.lbl_efectivo_sistema.TabIndex = 4;
            this.lbl_efectivo_sistema.Text = "Efectivo Esperado (RD$):";
            // 
            // txt_efectivo_sistema
            // 
            this.txt_efectivo_sistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.txt_efectivo_sistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_efectivo_sistema.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold);
            this.txt_efectivo_sistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.txt_efectivo_sistema.Location = new System.Drawing.Point(20, 240);
            this.txt_efectivo_sistema.Name = "txt_efectivo_sistema";
            this.txt_efectivo_sistema.ReadOnly = true;
            this.txt_efectivo_sistema.Size = new System.Drawing.Size(390, 32);
            this.txt_efectivo_sistema.TabIndex = 5;
            this.txt_efectivo_sistema.Text = "0.00";
            // 
            // grp_conteo_fisico
            // 
            this.grp_conteo_fisico.Controls.Add(this.lbl_efectivo_caja);
            this.grp_conteo_fisico.Controls.Add(this.txt_efectivo_caja);
            this.grp_conteo_fisico.Controls.Add(this.lbl_diferencia);
            this.grp_conteo_fisico.Controls.Add(this.txt_diferencia);
            this.grp_conteo_fisico.Controls.Add(this.lbl_observaciones);
            this.grp_conteo_fisico.Controls.Add(this.txt_observaciones);
            this.grp_conteo_fisico.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.grp_conteo_fisico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.grp_conteo_fisico.Location = new System.Drawing.Point(487, 71);
            this.grp_conteo_fisico.Name = "grp_conteo_fisico";
            this.grp_conteo_fisico.Size = new System.Drawing.Size(430, 310);
            this.grp_conteo_fisico.TabIndex = 1;
            this.grp_conteo_fisico.TabStop = false;
            this.grp_conteo_fisico.Text = "Conteo Físico";
            // 
            // lbl_efectivo_caja
            // 
            this.lbl_efectivo_caja.AutoSize = true;
            this.lbl_efectivo_caja.Font = new System.Drawing.Font("Lexend", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_efectivo_caja.Location = new System.Drawing.Point(20, 50);
            this.lbl_efectivo_caja.Name = "lbl_efectivo_caja";
            this.lbl_efectivo_caja.Size = new System.Drawing.Size(187, 24);
            this.lbl_efectivo_caja.TabIndex = 0;
            this.lbl_efectivo_caja.Text = "Efectivo Físico (RD$) *:";
            // 
            // txt_efectivo_caja
            // 
            this.txt_efectivo_caja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_efectivo_caja.Font = new System.Drawing.Font("Lexend", 12F, System.Drawing.FontStyle.Bold);
            this.txt_efectivo_caja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_efectivo_caja.Location = new System.Drawing.Point(20, 80);
            this.txt_efectivo_caja.Name = "txt_efectivo_caja";
            this.txt_efectivo_caja.Size = new System.Drawing.Size(390, 32);
            this.txt_efectivo_caja.TabIndex = 1;
            // 
            // lbl_diferencia
            // 
            this.lbl_diferencia.AutoSize = true;
            this.lbl_diferencia.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_diferencia.Location = new System.Drawing.Point(20, 130);
            this.lbl_diferencia.Name = "lbl_diferencia";
            this.lbl_diferencia.Size = new System.Drawing.Size(237, 24);
            this.lbl_diferencia.TabIndex = 2;
            this.lbl_diferencia.Text = "Diferencia (Sobrante/Faltante):";
            // 
            // txt_diferencia
            // 
            this.txt_diferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_diferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diferencia.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold);
            this.txt_diferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.txt_diferencia.Location = new System.Drawing.Point(20, 160);
            this.txt_diferencia.Name = "txt_diferencia";
            this.txt_diferencia.ReadOnly = true;
            this.txt_diferencia.Size = new System.Drawing.Size(390, 28);
            this.txt_diferencia.TabIndex = 3;
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Font = new System.Drawing.Font("Lexend", 9F);
            this.lbl_observaciones.Location = new System.Drawing.Point(20, 210);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(121, 24);
            this.lbl_observaciones.TabIndex = 4;
            this.lbl_observaciones.Text = "Observaciones:";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_observaciones.Font = new System.Drawing.Font("Lexend", 10F);
            this.txt_observaciones.Location = new System.Drawing.Point(20, 240);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(390, 50);
            this.txt_observaciones.TabIndex = 5;
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_acciones.BackColor = System.Drawing.Color.White;
            this.pnl_acciones.Controls.Add(this.btn_confirmar_cierre);
            this.pnl_acciones.Controls.Add(this.btn_imprimir);
            this.pnl_acciones.Controls.Add(this.btn_cerrar);
            this.pnl_acciones.Location = new System.Drawing.Point(30, 517);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_acciones.Size = new System.Drawing.Size(943, 70);
            this.pnl_acciones.TabIndex = 3;
            // 
            // btn_confirmar_cierre
            // 
            this.btn_confirmar_cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btn_confirmar_cierre.FlatAppearance.BorderSize = 0;
            this.btn_confirmar_cierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar_cierre.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_confirmar_cierre.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar_cierre.Location = new System.Drawing.Point(20, 15);
            this.btn_confirmar_cierre.Name = "btn_confirmar_cierre";
            this.btn_confirmar_cierre.Size = new System.Drawing.Size(180, 40);
            this.btn_confirmar_cierre.TabIndex = 0;
            this.btn_confirmar_cierre.Text = "Confirmar Cierre";
            this.btn_confirmar_cierre.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(139)))));
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Location = new System.Drawing.Point(220, 15);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(160, 40);
            this.btn_imprimir.TabIndex = 1;
            this.btn_imprimir.Text = "Imprimir Reporte";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Lexend", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(793, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(130, 40);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "Cancelar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lexend Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Último cuadre:";
            // 
            // lbl_fecha_ultimo_cuadre
            // 
            this.lbl_fecha_ultimo_cuadre.AutoSize = true;
            this.lbl_fecha_ultimo_cuadre.Font = new System.Drawing.Font("Lexend Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_ultimo_cuadre.Location = new System.Drawing.Point(206, 20);
            this.lbl_fecha_ultimo_cuadre.Name = "lbl_fecha_ultimo_cuadre";
            this.lbl_fecha_ultimo_cuadre.Size = new System.Drawing.Size(206, 27);
            this.lbl_fecha_ultimo_cuadre.TabIndex = 7;
            this.lbl_fecha_ultimo_cuadre.Text = "07/07/2026 00:00:00 PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lexend Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Actual:";
            // 
            // lbl_fecha_actual
            // 
            this.lbl_fecha_actual.AutoSize = true;
            this.lbl_fecha_actual.Font = new System.Drawing.Font("Lexend Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_actual.Location = new System.Drawing.Point(636, 20);
            this.lbl_fecha_actual.Name = "lbl_fecha_actual";
            this.lbl_fecha_actual.Size = new System.Drawing.Size(206, 27);
            this.lbl_fecha_actual.TabIndex = 9;
            this.lbl_fecha_actual.Text = "07/07/2026 00:00:00 PM";
            // 
            // modulo_de_cierre_de_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1003, 618);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.panel_card);
            this.Controls.Add(this.lbl_subtitulo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modulo_de_cierre_de_caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Caja - Go Fitness";
            this.panel_card.ResumeLayout(false);
            this.panel_card.PerformLayout();
            this.grp_resumen_sistema.ResumeLayout(false);
            this.grp_resumen_sistema.PerformLayout();
            this.grp_conteo_fisico.ResumeLayout(false);
            this.grp_conteo_fisico.PerformLayout();
            this.pnl_acciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel panel_card;
        private System.Windows.Forms.GroupBox grp_resumen_sistema;
        private System.Windows.Forms.Label lbl_ingresos_totales;
        private System.Windows.Forms.TextBox txt_ingresos_totales;
        private System.Windows.Forms.Label lbl_pagos_electronicos;
        private System.Windows.Forms.TextBox txt_pagos_electronicos;
        private System.Windows.Forms.Label lbl_efectivo_sistema;
        private System.Windows.Forms.TextBox txt_efectivo_sistema;
        private System.Windows.Forms.GroupBox grp_conteo_fisico;
        private System.Windows.Forms.Label lbl_efectivo_caja;
        private System.Windows.Forms.TextBox txt_efectivo_caja;
        private System.Windows.Forms.Label lbl_diferencia;
        private System.Windows.Forms.TextBox txt_diferencia;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.Panel pnl_acciones;
        private System.Windows.Forms.Button btn_confirmar_cierre;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_fecha_actual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fecha_ultimo_cuadre;
        private System.Windows.Forms.Label label1;
    }
}