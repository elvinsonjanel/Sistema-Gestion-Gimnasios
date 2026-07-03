
namespace GoFitnessGym
{
    partial class modulo_de_control_de_acceso
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
            this.panel_acceso2 = new System.Windows.Forms.Panel();
            this.panel_acceso1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_acceso2
            // 
            this.panel_acceso2.BackColor = System.Drawing.Color.White;
            this.panel_acceso2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_acceso2.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_acceso2.Location = new System.Drawing.Point(433, 106);
            this.panel_acceso2.Name = "panel_acceso2";
            this.panel_acceso2.Size = new System.Drawing.Size(355, 421);
            this.panel_acceso2.TabIndex = 9;
            // 
            // panel_acceso1
            // 
            this.panel_acceso1.BackColor = System.Drawing.Color.White;
            this.panel_acceso1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_acceso1.Font = new System.Drawing.Font("Lexend", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_acceso1.Location = new System.Drawing.Point(12, 106);
            this.panel_acceso1.Name = "panel_acceso1";
            this.panel_acceso1.Size = new System.Drawing.Size(381, 421);
            this.panel_acceso1.TabIndex = 10;
            // 
            // modulo_de_control_de_acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.panel_acceso1);
            this.Controls.Add(this.panel_acceso2);
            this.Name = "modulo_de_control_de_acceso";
            this.Text = "Controlar acceso - Go Fitness";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_acceso2;
        private System.Windows.Forms.Panel panel_acceso1;
    }
}