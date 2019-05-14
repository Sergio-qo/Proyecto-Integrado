using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    class Reservas
    {
        private int id;
        private DateTime fecha;
        private Pedidos pedido;
        public int Id { get { return id; } }

        public Reservas(Pedidos pedido)
        {
            this.pedido = pedido;
        }


        public void HacerReserva()
        {
            ConexionBBDD conexion = new ConexionBBDD();
            MySqlCommand comando;
            foreach (Articulos elem in pedido.Articulos) //Este for rellena los los artículos que tiene la reserva en la base de datos
            {
                string consulta = String.Format("insert into articulosreserva (idreserva, idarticulo) values('{0}', '{1}')", this.id, elem.Id);
                comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.ExecuteNonQuery();
            }
        }
    }
}

