﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    public class Pedidos
    {
        //private List<Articulos> articulos = new List<Articulos>(); //Creo una lista de artículos
        //private static int idst; //Hago un id estático que sera el que va incrementando
        private int id; //Este id cojerá el valor de idst cada vez que se cree un pedido
        private int cantidadPedidos;
        private string proceso;
        private double precioPedido;
        private string hora;
        private int cantidadArticulos = 0;
        private bool creado = false;

        public bool Creado { get { return this.creado; } set { this.creado = value; } }

        public int Id { get { return this.id; } }
        //private string estado;

        //public List<Articulos> Articulos { get { return this.articulos; } }
        public double PrecioPedido { get{ return precioPedido; } }

        public Pedidos pedido { get { return this; } }





        public Pedidos(int cantidadPedidos, double precioPedido)
        {
            this.id = 1;
            this.cantidadPedidos = cantidadPedidos;
            this.precioPedido = precioPedido;
            this.proceso = "Por Hacer";
            this.hora = DateTime.Now.ToString("HH:mm");
            //this.estado = "Por hacer";
        }

        public Pedidos()
        {
            this.proceso = "Por Hacer";
            this.hora = DateTime.Now.ToString("HH:mm");
            //if (existente)
            //{
            //    ConexionBBDD conex = new ConexionBBDD();
            //    string consulta;
            //    MySqlCommand comando;
            //    MySqlDataReader reader;

            //    if (conex.AbrirConexion())
            //    {
            //        consulta = "SELECT id FROM pedidos";
            //        comando = new MySqlCommand(consulta, conex.Conexion);

            //        reader = comando.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            this.id = reader.GetInt32(0);
            //        }
            //        reader.Close();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Error conexión");
            //    }
            //}
            //else
            //{
            //    ConexionBBDD conex = new ConexionBBDD();
            //    string consulta;
            //    MySqlCommand comando;
            //    MySqlDataReader reader;

            //    if (conex.AbrirConexion())
            //    {
            //        consulta = "insert into pedidos values()";
            //        comando = new MySqlCommand(consulta, conex.Conexion);
            //        comando.ExecuteNonQuery();

            //        consulta = "SELECT id FROM pedidos";
            //        comando = new MySqlCommand(consulta, conex.Conexion);

            //        reader = comando.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            this.id = reader.GetInt32(0);
            //        }
            //        reader.Close();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Error conexión");
            //    }
            //}
        }

        //public Pedidos()
        //{
        //    ConexionBBDD conex = new ConexionBBDD();
        //    string consulta;
        //    MySqlCommand comando;
        //    MySqlDataReader reader;

        //    if (conex.AbrirConexion())
        //    {
        //        consulta = "insert into pedidos values()";
        //        comando = new MySqlCommand(consulta, conex.Conexion);
        //        comando.ExecuteNonQuery();

        //        consulta = "SELECT id FROM pedidos";
        //        comando = new MySqlCommand(consulta, conex.Conexion);

        //        reader = comando.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            this.id = reader.GetInt32(0);
        //        }
        //        reader.Close();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Error conexión");
        //    }

        //    //this.id = 1; //Asigno el id desde idst
        //}

        //Añade un articulo a la lista si no está ya
        public void AnyadirArticulo(Articulos articulo)
        {
            //ConexionBBDD conexion = new ConexionBBDD();
            //if (conexion.AbrirConexion())
            //{
            //    List<Articulos> articulos = new List<Articulos>();
            //    string consulta = "select nombre, idarticulo from articulospedido inner join Articulos on idarticulo=id";
            //    MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            //    MySqlDataReader reader = comando.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        articulos.Add(new Articulos(reader.GetString(0), reader.GetInt32(1)));
            //    }
            //    reader.Close();
            //    //Comprueba si el artículo está o no está en la lista
            //    bool esta = false;
            //    foreach (Articulos elem in articulos)
            //    {
            //        if (elem.Id == articulo.Id)
            //        {
            //            esta = true;
            //        }
            //    }

            //    if (esta == true)
            //    {
            //        consulta = String.Format("update articulospedido set cantidad = cantidad + 1");//si lo quiero utilizar añado estado
            //        comando = new MySqlCommand(consulta, conexion.Conexion);                                                                                                                                                           //this.articulos.Add(articulo); //Agrega el artículo a la lista si no esta
            //        comando.ExecuteNonQuery();
            //    }
            //    else
            //    {

            //        consulta = String.Format("insert into articulospedido (idpedido,idarticulo,cantidad) values({0}, {1}, {2})", this.id, articulo.Id, articulo.Cantidad);//si lo quiero utilizar añado estado
            //        comando = new MySqlCommand(consulta, conexion.Conexion);                                                                                                                                                           //this.articulos.Add(articulo); //Agrega el artículo a la lista si no esta
            //        comando.ExecuteNonQuery();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error al conectar con bd");
            //}

            ConexionBBDD conex = new ConexionBBDD();
            string consulta;
            MySqlCommand comando;
            MySqlDataReader reader;

            List<Articulos> articulos = new List<Articulos>();

            bool esta = false;
            if (conex.AbrirConexion())
            {

                consulta = String.Format("select nombre, articulos.id, articulos.precio from articulospedido inner join articulos on id = idarticulo inner join pedidos on pedidos.id=articulospedido.idpedido where pedidos.id = {0}", this.id);
                comando = new MySqlCommand(consulta, conex.Conexion);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    articulos.Add(new Articulos(reader.GetString(0), reader.GetDouble(2), reader.GetInt32(1)));
                }

                reader.Close();

                ////////////Articulos articul = articulo;
                consulta = String.Format("select precio from articulos where nombre = '{0}'", articulo.Nombre);
                comando = new MySqlCommand(consulta, conex.Conexion);
                reader = comando.ExecuteReader();
                reader.Read();
                articulo.Precio = reader.GetDouble(0);
                ////////////articul.Id = articulo.Id;
                reader.Close();

                foreach (Articulos elem in articulos)
                {
                    if (articulo.Nombre == elem.Nombre)
                    {
                        esta = true;
                    }
                    //articul = elem;
                    //articul = elem;
                    //else
                    //{
                    //    //esta = false;
                    //    articul = elem;
                    //}
                }
                if (esta == false)
                {
                    //MessageBox.Show("Voy a insertar en " + this.id +  " el articulo " + articul.Id);
                    consulta = String.Format("insert into articulospedido (idpedido, idarticulo, cantidad, precio) values({0}, {2}, {1}, '{3}')", this.id, articulo.Cantidad, articulo.Id, articulo.Precio);
                    comando = new MySqlCommand(consulta, conex.Conexion);
                    comando.ExecuteNonQuery();
                }
                else
                {
                    IncrementarCantidadArticulo(articulo);
                }
                reader.Close();
                //conex.CerrarConexion();
            }
            else
            {
                MessageBox.Show("Error al añadir articulo");
            }
        }

        public bool HacerPedido()
        {
            bool hecho = true;
            //List<Articulos> articulos = new List<Articulos>();
            ConexionBBDD conexion = new ConexionBBDD();
            if (conexion.AbrirConexion())
            {
                MySqlCommand comando;
                string consulta;
                consulta = "update pedidos set activo = false";
                comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error");
                hecho = false;
            }
            //foreach (Articulos elem in articulos) //Este for rellena los los artículos que tiene el pedido en la base de datos
            //{
            //    string consulta = String.Format("insert into articulospedido (idpedido) values('{0}')", this.id);
            //    comando = new MySqlCommand(consulta, conexion.Conexion);
            //    comando.ExecuteNonQuery();
            //}
            return hecho;

        }

        //Elimina un artículo de la lista segun id
        public bool EliminarArticulo(string nombre)
        {
            bool res = true;
            int idp = 0;
            double precio;
            ConexionBBDD conexion = new ConexionBBDD();
            if (conexion.AbrirConexion())
            {
                //bool esta = false;
                string consulta = "select nombre, cantidad, idarticulo from articulospedido inner join Articulos on idarticulo=id";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                Articulos articulo = null;
                int cantidad = 0;

                while (reader.Read())
                {
                    if (reader.GetString(0) == nombre)
                    {
                        //esta = true;
                        idp = reader.GetInt32(2);
                    }
                    cantidad = reader.GetInt32(1);
                    precio = reader.GetDouble(2);
                    articulo = new Articulos(nombre, cantidad, idp);
                }

                reader.Close();


                consulta = String.Format("select cantidad from articulospedido inner join Articulos on idarticulo=id inner join pedidos on pedidos.id = articulospedido.idpedido where idarticulo = {0} and pedidos.id = {1}", idp, this.id);
                comando = new MySqlCommand(consulta, conexion.Conexion);
                reader = comando.ExecuteReader();

                
                if (reader.HasRows)
                {
                    reader.Read();
                    cantidad = reader.GetInt32(0);
                    reader.Close();
                    if (cantidad >= 2)
                    {
                        DecrementarCantidadArticulo(articulo);
                    }
                    else
                    {
                        consulta = String.Format("delete from articulospedido where idarticulo in(select id from articulos where nombre = '{0}') and idpedido = {1}", nombre, this.id);
                        comando = new MySqlCommand(consulta, conexion.Conexion);
                        comando.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("No esta el artículo");
                    res = false;
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
            return res;


            //ConexionBBDD conexion = new ConexionBBDD();
            //List<Articulos> articulos = new List<Articulos>();
            //string consulta = "select id, nombre from articulospedido inner join Articulos on idarticulo=id";
            //MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            //MySqlDataReader reader = comando.ExecuteReader();

            //while (reader.Read())
            //{
            //    articulos.Add(new Articulos(reader.GetString(0)));
            //}
            //reader.Close();


            //consulta = String.Format("delete from articulospedido where id = {0}", id);
            //comando = new MySqlCommand(consulta, conexion.Conexion);
            //comando.ExecuteNonQuery();

            //Recorro la lista y cuando el id coincide lo borra
            //foreach (Articulos elem in articulos)
            //{
            //    if(elem.Id == id)
            //    {
            //        //articulos.Remove(elem);//cambiar por delete en bd
            //    }
            //}
        }

        //Calcula el precio total de este pedido
        public double CalcularPrecio()
        {
            double precio = 0;
            ConexionBBDD conexion = new ConexionBBDD();
            if (conexion.AbrirConexion())
            {
                List<Articulos> articulos = new List<Articulos>();
                string consulta = String.Format("select cantidad, articulospedido.precio from articulospedido inner join articulos on idarticulo=id where articulospedido.idpedido = {0}", this.id);
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    articulos.Add(new Articulos(reader.GetInt32(0), reader.GetDouble(1)));
                }
                reader.Close();
                precio = 0;
                foreach (Articulos articulo in articulos) //Sumo al precio el precio de cada artículo por su cantidad
                {
                    precio += articulo.Precio * articulo.Cantidad;
                }
                
            }
            else
            {
                MessageBox.Show("Error al conectar BBDD");
            }

            conexion.CerrarConexion();
            return precio;
        }


        //Muestra la lista de todos los articulos
        public List<Articulos> VerListaArticulos()
        {
            List<Articulos> lista = new List<Articulos>();

            ConexionBBDD conex = new ConexionBBDD();
            if (conex.AbrirConexion())
            {
                MySqlCommand comando;

                string consulta = String.Format("select nombre, cantidad, articulospedido.precio from articulospedido inner join articulos on id=idarticulo inner join pedidos on pedidos.id=articulospedido.idpedido where pedidos.id = {0} and pedidos.activo = true", this.id);
                comando = new MySqlCommand(consulta, conex.Conexion);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Articulos(reader.GetString(0), reader.GetInt32(1), reader.GetDouble(2)));
                }

                reader.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
            

            return lista;

        }

        void IncrementarCantidadArticulo(Articulos articulo)
        {
            ConexionBBDD conex = new ConexionBBDD();
            if (conex.AbrirConexion())
            {
                MySqlCommand comando;

                string consulta = String.Format("update articulospedido set cantidad = cantidad + 1 where idarticulo = {0}", articulo.Id);
                comando = new MySqlCommand(consulta, conex.Conexion);
                comando.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        void DecrementarCantidadArticulo(Articulos articulo)
        {
            ConexionBBDD conex = new ConexionBBDD();
            if (conex.AbrirConexion())
            {
                MySqlCommand comando;

                string consulta = String.Format("update articulospedido inner join pedidos on pedidos.id = articulospedido.idpedido set cantidad = cantidad - 1 where idarticulo = {0} and pedidos.id = {1}", articulo.Id, this.id);
                comando = new MySqlCommand(consulta, conex.Conexion);
                comando.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public void AbrirPedido()
        {
            ConexionBBDD conex = new ConexionBBDD();
            if (conex.AbrirConexion())
            {
                bool activo = false;
                string consulta = "select id, activo from pedidos";
                MySqlCommand comando = new MySqlCommand(consulta, conex.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        activo = reader.GetBoolean(1);
                        this.id = reader.GetInt32(0);
                    }
                    if (activo == false)
                    {
                        reader.Close();
                        consulta = string.Format("insert into pedidos (activo,hora) values(true,'{0}')", this.hora);
                        comando = new MySqlCommand(consulta, conex.Conexion);
                        comando.ExecuteNonQuery();
                    }
                }
                else
                {
                    reader.Close();
                    consulta = string.Format("insert into pedidos (activo,hora) values(true,'{0}')", this.hora);
                    comando = new MySqlCommand(consulta, conex.Conexion);
                    comando.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

    }
}
