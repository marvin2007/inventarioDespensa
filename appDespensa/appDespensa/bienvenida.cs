using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDespensa
{
    public partial class bienvenida : Form
    {
        public bienvenida()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //salir
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cerrar sesion
            this.Hide();
            Login abrir = new Login();
            abrir.Show();
        }

        private void btagregarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarProducto abrir = new agregarProducto();
            abrir.Show();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            empleados abrir = new empleados();
            abrir.Show();
        }

        private void bienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
