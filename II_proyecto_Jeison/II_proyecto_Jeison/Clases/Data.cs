using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace II_proyecto_Jeison
{
    /// <summary>
    /// Clase que se conecta con la base de datos
    /// Realiza las consultas y modificaciones de los datos
    /// </summary>
    class Data
    {
        private string stringConexion = "Data Source=.;Initial Catalog=baseDatosEECOMPSA;User ID=sa";

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
    }
}
