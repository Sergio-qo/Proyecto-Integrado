﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
     class Pedidos
    {
        private List<Articulos> articulos = new List<Articulos>(); //Creo una lista de artículos
        private static int idst; //Hago un id estático que sera el que va incrementando
        private int id; //Este id cojerá el valor de idst cada vez que se cree un pedido
        private int cantidadPedidos;
        private double precioPedido;

        public List<Articulos> Articulos { get { return this.articulos; } }





        public Pedidos(int id, int cantidadPedidos, double precioPedido)
        {
            this.id = id;
            this.cantidadPedidos = cantidadPedidos;
            this.precioPedido = precioPedido;
        }
        

        public Pedidos()
        {
            this.id = idst; //Asigno el id desde idst
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
                MessageBox.Show("El artículo que se intenta añadir ya está");
            }
            else
            {
                this.articulos.Add(articulo); //Agrega el artículo a la lista si no esta
            }
        }

        public void HacerPedido()
        {
            ConexionBBDD conexion = new ConexionBBDD();
            MySqlCommand comando;
            foreach (Articulos elem in articulos) //Este for rellena los los artículos que tiene el pedido en la base de datos
            {
                string consulta = String.Format("insert into articulospedido (idpedido, idarticulo) values('{0}', '{1}')", this.id, elem.Id);
                comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.ExecuteNonQuery();
            }
        }

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

        //Calcula el precio total de este pedido
        public double CalcularPrecio()
        {
            double precio = 0;
            foreach (Articulos articulo in articulos) //Sumo al precio el precio de cada artículo por su cantidad
            {
                precio += articulo.Precio * articulo.Cantidad;
            }
            return precio;
        }


        //Muestra la lista de todos los pedidos
        //public List<Pedidos> VerListaPedidos()
        //{
        //    List<Pedidos> lista = new List<Pedidos>();

        //    ConexionBBDD conex = new ConexionBBDD();
        //    MySqlCommand comando;

        //    string consulta = String.Format("select * from articulospedido ");
        //    comando = new MySqlCommand(consulta, conex.Conexion);

        //    MySqlDataReader reader = comando.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        lista.Add(new Pedidos(reader.GetInt32(0), reader.GetInt32(2), reader.GetDouble(3)));
        //    }

        //    reader.Close();

        //    return lista;

        //}

    }
}
