using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoIntegrado
{
    public class Articulos
    {
        //private static int idst; //Hago un id estático que sera el que va incrementando
        private int id; //Este id cojerá el valor de idst cada vez que se cree un pedido
        private string nombre;
        private int cantidad = 1;
        private double precio;

        public int Id{ get { return id; } set { this.id = value; } }
        public int Cantidad { get {return this.cantidad; } set {this.cantidad = value; } }
        public double Precio { get { return this.precio; } set { this.precio = value; } }
        public string Nombre { get { return this.nombre; } }

        public Articulos(string nombre, double precio, int id)
        {
            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
        }

        public Articulos(int cantidad, double precio)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }


        public Articulos(string nombre, int cantidad, double precio)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public Articulos(string nombre, int cantidad, int id)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.id = id;
        }

        public Articulos(string nombre)
        {
            //this.id = id;
            ConexionBBDD conexion = new ConexionBBDD();
            if (conexion.AbrirConexion())
            {
                string consulta = String.Format("select id from articulos where nombre = '{0}'", nombre);
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                this.id = reader.GetInt32(0);
                reader.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
            this.nombre = nombre;
        }

        public Articulos(string nombre, int id)
        {
            //ConexionBBDD conexion = new ConexionBBDD();
            //if (conexion.AbrirConexion())
            //{
            //    string consulta = String.Format("select id from articulos where nombre = '{0}'", nombre);
            //    MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            //    MySqlDataReader reader = comando.ExecuteReader();
            //    reader.Read();
            //    this.id = reader.GetInt32(0);
            //    reader.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Error al cargar articulo");
            //}
            this.id = id;
            this.nombre = nombre;
        }

        //public Articulos(int cantidad, string nombre)
        //{
        //    this.cantidad = cantidad;
        //    this.nombre = nombre;
        //}

        //public Articulos(string nombre)
        //{
        //    this.id = idst; //Asigno el id desde idst
        //}

        public void IncrementarCantidad()
        {
            System.Windows.Forms.MessageBox.Show("Estoy en " + Nombre);
            this.cantidad++;
        }
    }
}
