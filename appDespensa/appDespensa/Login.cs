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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tb1Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tb1Login.Text == "admin")
            {
                if(tb2Login.Text == "mariano")
                {
                    bienvenida abrir = new bienvenida();
                    abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("CONTRASEÑA INCORRECTA");
                }
            }
            else
            {
                MessageBox.Show("USUARIO INCORRECTO");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
