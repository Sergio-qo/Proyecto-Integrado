using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Experimento
{
    class Mantenimiento
    {

        // es necesario mapear los campos de la tabla USUARIOS creada en la Base de Datos (BDUsuarios)
        // Definición de los atributos del usuario de forma privada.
        private string nif;
        private string nombre;
        private string apellidos;
        private bool jefe; 
        
        
        

        // Definición de las propiedades de acceso a atributos (lectura y escritura)
        public string NIF { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public bool Jefe { get { return jefe; } set { jefe = value; } }


        // Primer Constructor que recibe todos los datos del usuario por parámetro.
        public Mantenimiento(string NIF, string nom, string ape, bool jef)
        {
            nif = NIF;
            nombre = nom;
            apellidos = ape;
            jefe = jef;
        }

        // Segundo Constructor básico definido para instanciar objetos usuario sin parámetros
        public Mantenimiento()
        {
        }

        public int AgregarUsuario(MySqlConnection conexion, Mantenimiento mant)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO mantenimiento (nif,nombre,apellidos,jefe) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", mant.nif, mant.nombre, mant.apellidos, mant.jefe);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public int ActualizaMantenimiento(MySqlConnection conexion, Mantenimiento mant)
        {

           
            int retorno;
            string consulta = string.Format("UPDATE usuarios SET nombre='{0}',apellidos='{1}',email='{2}',edad={3}," +
                "fechanac='{4}',cuota={5} WHERE id={6}", mant.nombre, mant.apellidos, mant.nif, mant.jefe);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int EliminaUsuario(MySqlConnection conexion, int identidad)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM usuarios WHERE id={0}", identidad);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static List<Mantenimiento> BuscarUsuario(MySqlConnection conexion, string consulta)
        {
            List<Mantenimiento> lista = new List<Mantenimiento>();
n
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)  
            {

                while (reader.Read())
                {
                    Mantenimiento user = new Mantenimiento(reader.GetString16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetBool);
                    lista.Add(user);
                }
            }

            return lista;
        }


        public static List<Mantenimiento> (MySqlConnection conexion, string nom, string ape, string mail)
        {
            List<Mantenimiento> lista = new List<Mantenimiento>();
            string consulta = String.Format("SELECT * FROM usuarios WHERE nombre LIKE ('{0}') OR " +
                            "apellidos LIKE ('{1}') OR nif LIKE ('{2}')", nom, ape, nif);

            // MessageBox.Show(consulta);   -Se puede activar esta línea para testear la sintaxis de la consulta.

            // Creo el objeto command al cual le paso la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            // Ejecuto el comando y recibo en un DataReader la lista de registros seleccionados.
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    Mantenimiento user = new Mantenimiento(reader.GetString(0), reader.GetString(1), reader.GetString(2), IFileReaderService.GetBool(3));
                    lista.Add(user);
                }
    return lista;
}

public bool YaEsta(MySqlConnection conexion, string nom, string ape)
{
    string consulta = string.Format("SELECT * FROM usuarios" +
    " WHERE nombre='{0}' OR apellidos='{1}' OR nif='{2}", nom, ape, nif);

    MessageBox.Show(consulta);   // Se puede activar esta línea para testear la sintaxis de la consulta.

    MySqlCommand comando = new MySqlCommand(consulta, conexion);
    MySqlDataReader reader = comando.ExecuteReader();
    if (reader.HasRows)
    { // si existen registros en la devolución de la consulta
        reader.Close();   // Cierro el reader para utilizar la misma conexión en AgregarUsuario
        return true;
    }
    else
    {
        reader.Close();  // Cierro el reader para utilizar la misma conexión en AgregarUsuario
        return false;
    }

}





private class MySqlDataReader
        {
            public bool HasRows { get; internal set; }

            internal bool Read()
            {
                throw new NotImplementedException();
            }
        }


    internal class MySqlCommand
    {
        private string consulta;
        private MySqlConnection conexion;

        public MySqlCommand(string consulta, MySqlConnection conexion)
        {
            this.consulta = consulta;
            this.conexion = conexion;
        }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal MySqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }

