using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    class Pedidos
    {
        List<Articulos> articulos = new List<Articulos>(); //Creo una lista de artículos
        public List<Articulos> Articulos { get {return this.articulos; } }
        int id;

        public Pedidos()
        {

        }

        //Añade un articulo a la lista si no está ya
        public void AnyadirArticulo(Articulos articulo)
        {

            //Comprueba si el artículo está o no está en la lista
            bool esta = false;
            foreach (Articulos elem in articulos)
            {
                if (elem.Id == articulo.Id)
                {
                    esta = true;
                }
            }

            if (esta == true)
            {

            }
            else
            {
                this.articulos.Add(articulo); //Agrega el artículo a la lista si no esta
            }
        }

        //public void HacerPedido()
        //{
        //    ConexionBBDD conexion = new ConexionBBDD();
        //    MySqlCommando comando;
        //    foreach (Articulos elem in articulos) //Este for rellena los los artículos que tiene el pedido en la base de datos
        //    {
        //        string consulta = String.Format("insert into articulospedido (idpedido, idarticulo) values('{0}', '{1}')", this.id, elem.Id);
        //        comando = new MySqlCommand(consulta, conexion.Conexion);
        //        comando.ExecuteNonQuery();
        //    }
        //}

        //Elimina un artículo de la lista segun id
        public void EliminarArticulo(int id)
        {
            //Recorro la lista y cuando el id coincide lo borra
            foreach(Articulos elem in articulos)
            {
                if(elem.Id == id)
                {
                    articulos.Remove(elem);
                }
            }
        }
    }
}
