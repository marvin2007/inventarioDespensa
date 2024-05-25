using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDespensa
{
    internal class empleadoConsultas
    {
            private ConexionMySql conexionMySql;
            private List<empleado> mEmpleados;

            public empleadoConsultas()
            {
                conexionMySql = new ConexionMySql();
                mEmpleados = new List<empleado>();
            }

            public List<empleado> getEmpleados(string filtro)
            {
                string QUERY = "SELECT * FROM empleado ";
                MySqlDataReader mReader = null;
                try
                {
                    if (filtro != "")
                    {
                        QUERY += " WHERE " +
                            "id LIKE'%" + filtro + "%' OR " +
                            "nombre LIKE'%" + filtro + "%' OR " +
                            "apellido LIKE'%" + filtro + "%' OR " +
                            "carne LIKE'%" + filtro + "%' OR " +
                            "puesto LIKE'%" + filtro + "%';";
                    }
                    MySqlCommand mComando = new MySqlCommand(QUERY);
                    mComando.Connection = conexionMySql.GetConnection();
                    mReader = mComando.ExecuteReader();

                    empleado mEmpleado = null;
                    while (mReader.Read())
                    
                    {
                        mEmpleado = new empleado();
                        mEmpleado.id = mReader.GetInt16("id");
                        mEmpleado.nombre = mReader.GetString("nombre");
                        mEmpleado.apellido = mReader.GetString("apellido");
                        mEmpleado.carne = mReader.GetInt32("carne");
                        mEmpleado.puesto = mReader.GetString("puesto");
                        mEmpleados.Add(mEmpleado);
                    }
                    mReader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener empleados: " + ex.Message);
                    throw;
                }
                return mEmpleados;
            }

            internal bool agregarEmpleado(empleado mEmpleado)
            {
                string INSERT = "INSERT INTO empleado(nombre, apellido, carne, puesto) values (@nombre, @apellido, @carne, @puesto);";

                MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySql.GetConnection());

                mCommand.Parameters.Add(new MySqlParameter("@nombre", mEmpleado.nombre));
                mCommand.Parameters.Add(new MySqlParameter("@apellido", mEmpleado.apellido));
                mCommand.Parameters.Add(new MySqlParameter("@carne", mEmpleado.carne));
                mCommand.Parameters.Add(new MySqlParameter("@puesto", mEmpleado.puesto));


            return mCommand.ExecuteNonQuery() > 0;
            }

            internal bool modificarEmpleado(empleado mEmpleado)
            {
                string UPDATE = "UPDATE empleado SET " +
                    "nombre = @nombre, " +
                    "apellido = @apellido, " +
                    "carne = @carne, " +
                    "puesto = @puesto " +
                    "WHERE id = @id;";

                MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySql.GetConnection());

                mCommand.Parameters.Add(new MySqlParameter("@nombre", mEmpleado.nombre));
                mCommand.Parameters.Add(new MySqlParameter("@apellido", mEmpleado.apellido));
                mCommand.Parameters.Add(new MySqlParameter("@carne", mEmpleado.carne));
                mCommand.Parameters.Add(new MySqlParameter("@puesto", mEmpleado.puesto));
                mCommand.Parameters.Add(new MySqlParameter("@id", mEmpleado.id));


                return mCommand.ExecuteNonQuery() > 0;
            }

            internal bool eliminarEmpleado(empleado mEmpleado)
            {
                string DELETE = "DELETE FROM empleado WHERE id = @id;";

                MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySql.GetConnection());

                mCommand.Parameters.Add(new MySqlParameter("@id", mEmpleado.id));

                return mCommand.ExecuteNonQuery() > 0;
            }
        
    }
}
