using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    class Articulos
    {
        private static int idst; //Hago un id estático que sera el que va incrementando
        private int id; //Este id cojerá el valor de idst cada vez que se cree un pedido
        private string nombre;
        private string descripcion;
        public int Id{ get { return id; } }

        public Articulos(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.id = idst; //Asigno el id desde idst
        }
    }
}
