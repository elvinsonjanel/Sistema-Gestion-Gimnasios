using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFitnessGym
{
    public partial class modulo_consulta_facturas_ventas_y_ingresos : Form
    {
        // CONSTRUCTOR: Se ejecuta al abrir la pantalla por primera vez
        public modulo_consulta_facturas_ventas_y_ingresos()
        {
            InitializeComponent();

            // Al arrancar, mostramos Facturas por defecto
            ActivarPestana(panel_facturas, btn_facturas);
        }

        private void dgv_facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // ==========================================
        //  EVENTOS DE CLICK (Solucionan tus errores)
        // ==========================================

        // Al hacer clic en el botón de Facturas, mostramos su panel
        private void btn_facturas_Click(object sender, EventArgs e)
        {
            ActivarPestana(panel_facturas, btn_facturas);
        }

        // Al hacer clic en el botón de Ventas, mostramos su panel
        private void btn_ventas_Click(object sender, EventArgs e)
        {
            ActivarPestana(panel_ventas, btn_ventas);
        }

        // Al hacer clic en el botón de Ingresos, mostramos su panel
        private void btn_ingresos_Click(object sender, EventArgs e)
        {
            ActivarPestana(panel_ingresos, btn_ingresos);
        }

        // Evento Load del Formulario (lo dejamos vacío para que no dé error)
        private void modulo_consulta_facturas_ventas_y_ingresos_Load(object sender, EventArgs e)
        {
        }

        // ==========================================
        //  MÉTODO PARA MOSTRAR/OCULTAR PESTAÑAS
        // ==========================================
        private void ActivarPestana(Panel panelActivo, Button botonActivo)
        {
            // 1. Ocultamos todos los paneles
            panel_facturas.Visible = false;
            panel_ventas.Visible = false;
            panel_ingresos.Visible = false;

            // 2. Mostramos el panel seleccionado y lo traemos al frente
            panelActivo.Visible = true;
            panelActivo.BringToFront();

            // 3. Colores para el diseño de pestañas (Azul activo, Gris inactivo)
            Color azulReyActivo = Color.FromArgb(30, 64, 175);
            Color grisInactivo = Color.FromArgb(224, 224, 224);
            Color textoBlanco = Color.White;
            Color textoGrisOscuro = Color.DimGray;

            // 4. Reseteamos los tres botones al estado "Inactivo"
            btn_facturas.BackColor = grisInactivo;
            btn_facturas.ForeColor = textoGrisOscuro;

            btn_ventas.BackColor = grisInactivo;
            btn_ventas.ForeColor = textoGrisOscuro;

            btn_ingresos.BackColor = grisInactivo;
            btn_ingresos.ForeColor = textoGrisOscuro;

            // 5. Pintamos el botón seleccionado como "Activo"
            botonActivo.BackColor = azulReyActivo;
            botonActivo.ForeColor = textoBlanco;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}