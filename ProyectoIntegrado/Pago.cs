using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    class Pago
    {
        public Pago()
        {

        }
     public double getPrecioTotal(Pedidos pedido)
        {
            String consulta = "SELECT precio FROM ArticulosPedido where id=$id";
            ConexionBBDD conexion = new ConexionBBDD();

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", pedido.PrecioPedido);
            MySqlDataReader reader = comando.ExecuteReader();
            double preciotot = reader.GetDouble(0);
           
            return preciotot;
        }

    }
}
