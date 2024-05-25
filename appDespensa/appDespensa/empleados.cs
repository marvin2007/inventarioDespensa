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
    public partial class empleados : Form
    {
        private List<empleado> mEmpleados;
        private empleadoConsultas mEmpleadoConsultas;
        private empleado mEmpleado;

        public empleados()
        {
            InitializeComponent();

            mEmpleados = new List<empleado>();
            mEmpleadoConsultas = new empleadoConsultas();
            mEmpleado = new empleado();

            cargarEmpleados();
        }

        private void cargarEmpleados(string filtro = "")
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            mEmpleados.Clear();
            mEmpleados = mEmpleadoConsultas.getEmpleados(filtro);

            for (int i = 0; i < mEmpleados.Count(); i++)
            {
                dgvEmpleados.RowTemplate.Height = 50;
                dgvEmpleados.Rows.Add(
                    mEmpleados[i].id,
                    mEmpleados[i].nombre,
                    mEmpleados[i].apellido,
                    mEmpleados[i].carne,
                    mEmpleados[i].puesto);
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida abrir = new bienvenida();
            abrir.Show();
        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida abrir = new bienvenida();
            abrir.Show();
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // boton eliminar
            if (getIdIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea eliminar al Empleado?", "Eliminar Empleado",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosEmpleado();

                if (mEmpleadoConsultas.eliminarEmpleado(mEmpleado))
                {
                    MessageBox.Show("EMPLEADO ELIMINADO");
                    cargarEmpleados();
                    limpiarCampos();
                }
            }
        }

       

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            cargarEmpleados(txtbusqueda.Text.Trim());
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // Botón agregar
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosEmpleado();

            if (mEmpleadoConsultas.agregarEmpleado(mEmpleado))
            {
                MessageBox.Show("Empleado agregado");
                cargarEmpleados();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto");
            }
        }

        private void cargarDatosEmpleado()
        {
            mEmpleado.id = getIdIfExist();
            mEmpleado.nombre = txtnombreempleado.Text.Trim();
            mEmpleado.apellido = txtapellidoempleado.Text.Trim();
            mEmpleado.carne = int.Parse(txtcarne.Text.Trim());
            mEmpleado.puesto = txtpuesto.Text.Trim();
        }

        private int getIdIfExist()
        {
            if (!txtid.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtid.Text.Trim(), out int id))
                {
                    return id;
                }
                else return -1;
            }
            else return -1;
        }

        private void limpiarCampos()
        {
            txtid.Text = "";
            txtnombreempleado.Text = "";
            txtapellidoempleado.Text = "";
            txtcarne.Text = "";
            txtpuesto.Text = "";
        }

        private bool datosCorrectos()
        {
            if (txtnombreempleado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }

            if (txtapellidoempleado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el apellido");
                return false;
            }

            if (txtcarne.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el carne");
                return false;
            }

            if (txtpuesto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el puesto");
                return false;
            }


            return true;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosEmpleado();

            if (mEmpleadoConsultas.modificarEmpleado(mEmpleado))
            {
                MessageBox.Show("Empleado modificdo");
                cargarEmpleados();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modficar el empleado");
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];
            txtid.Text = Convert.ToString(fila.Cells["ID"].Value);
            txtnombreempleado.Text = Convert.ToString(fila.Cells["NOMBRE"].Value);
            txtapellidoempleado.Text = Convert.ToString(fila.Cells["APELLIDO"].Value);
            txtcarne.Text = Convert.ToString(fila.Cells["CARNÉ"].Value);
            txtpuesto.Text = Convert.ToString(fila.Cells["PUESTO"].Value);
        }
    }
}
