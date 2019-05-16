using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    class PagoEfectivo:Pago
    {
        public int GetNumPedido(Pedidos pedido)
        {
            return pedido.Id;
        }

        public override void EfectuarPago(Pedidos pedido)
        {
            String consulta = String.Format("insert into pagos (precio) {0}", pedido.PrecioPedido);
            ConexionBBDD conexion = new ConexionBBDD();

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.ExecuteNonQuery();
        }
    }
}
