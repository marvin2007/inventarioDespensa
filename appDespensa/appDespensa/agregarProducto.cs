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
    public partial class agregarProducto : Form
    {
        private List<producto> mProductos;
        private productoConsultas mProductoConsultas;
        private producto mProducto;

        public agregarProducto()
        {
            InitializeComponent();
            mProductos = new List<producto>();
            mProductoConsultas = new productoConsultas();
            mProducto = new producto();

            cargarProductos();
        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida abrir = new bienvenida();
            abrir.Show();
        }

        private void agregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void cargarProductos(string filtro = "")
        {
            dgvproductos.Rows.Clear();
            dgvproductos.Refresh();
            mProductos.Clear();
            mProductos = mProductoConsultas.getProductos(filtro);

            for (int i = 0; i < mProductos.Count(); i++)
            {
                dgvproductos.RowTemplate.Height = 50;
                dgvproductos.Rows.Add(
                    mProductos[i].id,
                    mProductos[i].nombre,
                    mProductos[i].cantidad,
                    mProductos[i].precio);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbbusqueda_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(tbbusqueda.Text.Trim());
        }

        private bool datosCorrectos()
        {
            if (txtnombreagregar.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }

            if (txtcantidadagregar.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la cantidad");
                return false;
            }

            if (txtprecioagregar.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el precio");
                return false;
            }

            if (!float.TryParse(txtprecioagregar.Text.Trim(), out float precio))
            {
                MessageBox.Show("Ingrese un precio correcto");
                return false;
            }

            if (!int.TryParse(txtcantidadagregar.Text.Trim(), out int cant))
            {
                MessageBox.Show("Ingrese una cantidad correcta");
                return false;
            }

            return true;
        }

        private void limpiarCampos()
        {
            txtid.Text = "";
            txtnombreagregar.Text = "";
            txtcantidadagregar.Text = "";
            txtprecioagregar.Text = "";
        }

        private void cargarDatosProducto()
        {
            mProducto.id = getIdIfExist();
            mProducto.nombre = txtnombreagregar.Text.Trim();
            mProducto.precio = float.Parse(txtprecioagregar.Text.Trim());
            mProducto.cantidad = int.Parse(txtcantidadagregar.Text.Trim());
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


        private void btnagregar_Click(object sender, EventArgs e)
        {
            // Botón agregar
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosProducto();

            if (mProductoConsultas.agregarProducto(mProducto))
            {
                MessageBox.Show("Producto agregado");
                cargarProductos();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto");
            }
        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvproductos.Rows[e.RowIndex];
            txtid.Text = Convert.ToString(fila.Cells["ID"].Value);
            txtnombreagregar.Text = Convert.ToString(fila.Cells["NOMBRE"].Value);
            txtcantidadagregar.Text = Convert.ToString(fila.Cells["CANTIDAD"].Value);
            txtprecioagregar.Text = Convert.ToString(fila.Cells["PRECIO_UNIDAD"].Value);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // boton editar
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosProducto();

            if (mProductoConsultas.modificarProducto(mProducto))
            {
                MessageBox.Show("Producto modificdo");
                cargarProductos();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modficar el producto");
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            // boton eliminar
            if (getIdIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea eliminar el producto?", "Eliminar Producto",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosProducto();

                if (mProductoConsultas.eliminarProducto(mProducto))
                {
                    MessageBox.Show("PRODUCTO ELIMINADO");
                    cargarProductos();
                    limpiarCampos();
                }
            }
        }
    }
}

