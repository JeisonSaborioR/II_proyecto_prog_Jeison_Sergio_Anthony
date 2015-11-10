using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace II_proyecto_Jeison.Clases
{
    /// <summary>
    /// Clase que se conecta con la base de datos
    /// Realiza las consultas y modificaciones de los datos
    /// </summary>
    public class Data
    {
        private string stringConexion = "Data Source=.;Initial Catalog=baseDatosEECOMPSA;User ID=sa;Password=12345";

        /// <summary>
        /// Establece la conexion con la base de datos
        /// </summary>
        /// <returns>Conexion Abierta</returns>
        private SqlConnection conectarDB()
        {
            SqlConnection conexion = new SqlConnection(this.stringConexion);
            try
            {
                conexion.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error en la conexión " + e.Message);
            }
            return conexion;
        }


        /// <summary>
        /// Busca el registro completo de una persona a partir de un número de cédula
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader buscarPersona(string cedula)
        {
            SqlConnection conexion = conectarDB();
            string query = string.Format("SELECT * FROM personas WHERE cedula = '{0}'", cedula);
            SqlCommand cmd = new SqlCommand(query, conexion);
            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error en la consulta " + e.Message);
                return null;
            }
        }


        /// <summary>
        /// Busca el cliente con el número de cedula mandado por parametro
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader buscarClientes(string cedula)
        {
            SqlConnection conexion = conectarDB();
            string query = string.Format("SELECT * FROM clientes WHERE cedula = '{0}'", cedula);
            SqlCommand cmd = new SqlCommand(query, conexion);
            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error en la consulta " + e.Message);
                return null;
            }
        }

        /// <summary>
        /// Inserta los nuevos préstamos a la base de datos
        /// </summary>
        public void insertarPrestamo(string cedula, int cuotaMensual, int plazo, int monto, int interes)
        {
            SqlConnection conexion = conectarDB();
            string query = string.Format("INSERT INTO prestamos (cedCliente,cuotaMensual, plazo, monto , tasa)" +
                "VALUES('{0}',{1},{2},{3},{4})", cedula, cuotaMensual, plazo, monto, interes);
            SqlCommand cmd = new SqlCommand(query, conexion);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error de SQL " + e.Message);
            }
        }


        /// <summary>
        /// Busca los prestamos en base al numero de cedula del cliente o el codigo del prestamo
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns>SqlDataAdapter</returns>
        public SqlDataAdapter buscarPrestamo(string cedula, string codPrestamo)
        {
            int cp = 0;
            string query = null;
            SqlConnection conexion = conectarDB();
            if (!codPrestamo.Equals("null")) cp = Convert.ToInt16(codPrestamo);
            if (cedula.Equals("null") && !codPrestamo.Equals("null"))
            {
                query = string.Format("EXEC selectPrestamos {0} , null", cp);
            }
            else if (!cedula.Equals("null") && codPrestamo.Equals("null"))
            {
                query = string.Format("EXEC selectPrestamos null , '{0}'", cedula);
            }
            else if (cedula.Equals("null") && codPrestamo.Equals("null"))
            {
                query = "EXEC selectPrestamos null , null";
            }
            else query = string.Format("EXEC selectPrestamos {1} , '{0}'", cedula, cp);
            SqlCommand cmd = new SqlCommand(query, conexion);
            try
            {
                return new SqlDataAdapter(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error de SQL " + e.Message);
                return null;
            }
        }
    }
}
