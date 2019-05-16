using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    class PagoTarjeta:Pago
    {
        string nombreTitular;
        int numeroTarjeta;
        DateTime fcaducidad;

        public PagoTarjeta(string nomtit, int numtar, DateTime fc)
        {
            this.nombreTitular = nomtit;
            this.numeroTarjeta = numtar;
            this.fcaducidad = fc;
        }

        public override void EfectuarPago(Pedidos pedido)
        {
            string fechcad = this.fcaducidad.ToShortDateString();
            DateTime fc = DateTime.Parse(fechcad);
            String consulta = String.Format("insert into pagos (precio) {0}, '{1}', {2}, '{3}'", pedido.PrecioPedido, this.nombreTitular, this.numeroTarjeta, fc);
            ConexionBBDD conexion = new ConexionBBDD();

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.ExecuteNonQuery();
        }
    }
}
