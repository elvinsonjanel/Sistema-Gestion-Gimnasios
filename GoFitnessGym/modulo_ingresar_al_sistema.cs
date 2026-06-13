using System;
using System.Windows.Forms;

namespace GoFitnessGym
{
    public partial class modulo_ingresar_al_sistema : Form
    {
        public modulo_ingresar_al_sistema()
        {
            InitializeComponent();
        }

        // Cuando el formulario termina de cargar
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Pone el cursor parpadeando en el usuario apenas abres la app
            input_usuario.Focus();
        }
    }
}