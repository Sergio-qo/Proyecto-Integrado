using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    class ReservaPedido
    {
        private int idReservaPedido;
        private DateTime fecha;
        private string hora;
        private string nombre;
        private string apellido;
        private string situacion;
        public int IdReservaPedido { get{ return idReservaPedido; } }
        public DateTime Fecha { get { return fecha; } }
        public string Hora { get { return hora; } }
        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public string Situacion { get { return situacion; } }
        public ReservaPedido(int id,DateTime fec,string ho,string nom,string ape)
        {
            idReservaPedido = id;
            fecha = fec;
            hora = ho;
            nombre = nom;
            apellido = ape;
            situacion = "Por hacer";
        }
        public int ReservaPedidos()
        {
            int retorno;
            //Ejecuta en la base de datos una reserva
            String consulta = "INSERT INTO reservaPedido (idReservaPedido,nombre,apellido,hora,fecha,situacion) " +
                              "VALUES (@id,@nom,@ape,@ho,@fe,@sit)";
            ConexionBBDD conexion = new ConexionBBDD();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", null);
            comando.Parameters.AddWithValue("nom", this.nombre);
            comando.Parameters.AddWithValue("num", this.apellido);
            comando.Parameters.AddWithValue("nom", this.hora);
            comando.Parameters.AddWithValue("ape", this.fecha.ToString("yyyy/MM/dd"));
            comando.Parameters.AddWithValue("sit", this.situacion);

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public int PedidoHaciendo(string id)
        {
            int retorno;
            string consulta = "UPDATE fichaje SET situacion='Haciendo' WHERE idReservaPedido=@id";
            ConexionBBDD conexion = new ConexionBBDD();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", id);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public int PedidoHecho(string id)
        {
            int retorno;
            string consulta = "UPDATE fichaje SET situacion='Hecho' WHERE idReservaPedido=@id";
            ConexionBBDD conexion = new ConexionBBDD();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", id);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static List<ReservaPedido> VerReservas()
        {
            List<ReservaPedido> Reservastot = new List<ReservaPedido>();
            String consulta = "SELECT * FROM reservaPedido ";
            ConexionBBDD conexion = new ConexionBBDD();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ReservaPedido nuevo = new ReservaPedido(reader.GetInt16(0),reader.GetDateTime(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

                Reservastot.Add(nuevo);
            }
            return Reservastot;
        }
    }
}
