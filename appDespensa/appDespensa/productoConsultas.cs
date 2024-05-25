using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDespensa
{
    internal class productoConsultas
    {
        private ConexionMySql conexionMySql;
        private List<producto> mProductos;

        public productoConsultas()
        {
            conexionMySql = new ConexionMySql();
            mProductos = new List<producto>();
        }

        public List<producto> getProductos(string filtro)
        {
            string QUERY = "SELECT * FROM producto ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "id LIKE'%" + filtro + "%' OR " +
                        "nombre LIKE'%" + filtro + "%' OR " +
                        "cantidad LIKE'%" + filtro + "%' OR " +
                        "precio LIKE'%" + filtro + "%';";
                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.GetConnection();
                mReader = mComando.ExecuteReader();

                producto mProducto = null;
                while (mReader.Read())
                {
                    mProducto = new producto();
                    mProducto.id = mReader.GetInt16("Id");
                    mProducto.nombre = mReader.GetString("nombre");
                    mProducto.cantidad = mReader.GetInt16("cantidad");
                    mProducto.precio = mReader.GetInt16("precio");
                    mProductos.Add(mProducto);
                }
                mReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener productos: " + ex.Message);
                throw;
            }
            return mProductos;
        }

        internal bool agregarProducto(producto mProducto)
        {
            string INSERT = "INSERT INTO producto(nombre, cantidad, precio) values (@nombre, @cantidad, @precio);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nombre));
            mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.cantidad));
            mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));

            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarProducto(producto mProducto)
        {
            string UPDATE = "UPDATE producto SET " +
                "nombre = @nombre, " +
                "cantidad = @cantidad, " +
                "precio = @precio " +
                "WHERE id = @id;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nombre));
            mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.cantidad));
            mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));
            mCommand.Parameters.Add(new MySqlParameter("@id", mProducto.id));


            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarProducto(producto mProducto)
        {
            string DELETE = "DELETE FROM producto WHERE id = @id;";

            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySql.GetConnection());

            mCommand.Parameters.Add(new MySqlParameter("@id", mProducto.id));

            return mCommand.ExecuteNonQuery() > 0;
        }
    }
}
