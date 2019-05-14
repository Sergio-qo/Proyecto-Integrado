using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Experimento
{
    class GenerarBD
    {

        private MySqlConnection conexion;


        // Propiedad para acceder a la conexión
        public MySqlConnection Conexion { get{ return conexion; } }

        // Constructor que instancia la conexión, definiendo la cadena de conexión (ConnectionString)
        public GenerarBD()
        {
            // Conexión Local
            string server = "server=127.0.0.1;";
            string port = "port=3306;";
            string database = "database=ap17usuarios;";
            string usuario = "uid=root;";
            string password = "pwd=;";
            string convert = "Convert Zero Datetime=True;";
            string connectionstring = server + port + database + usuario + password + convert;

            conexion = new MySqlConnection(connectionstring);

        }
        // Método que se encarga de abrir la conexión
        // Devuelve true/false dependiendo si la conexión se ha abierto con éxito o no
        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch   // Inicialmente no es necesario utilizar el objeto ex
            {
                return false;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch   // Inicialmente no es necesario utilizar el objeto ex
            {
                return false;
            }
        }


    }
}
