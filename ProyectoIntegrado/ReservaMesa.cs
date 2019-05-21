using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrado
{
    class ReservaMesa
    {
        private int id;
        private DateTime dia;
        private int numComensales;
        private string nombre;
        private string apellidos;
        private string correo;
        private string hora;

        public int IdReservaMesa { get { return id; } }
        public DateTime Dia { get { return dia; } }
        private int NumComensales { get { return numComensales; } set { numComensales = value; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }
        public string Correo { get { return correo; } }
        public string Hora { get { return hora; } }

        public ReservaMesa(DateTime fecha, int numCom, string nom, string ape, string email, string Horas)
        {
            dia = fecha;
            numComensales = numCom;
            nombre = nom;
            apellidos = ape;
            correo = email;
            hora = Horas;
        }
        /// <summary>
        /// Ejecuta en la base de datos una reserva de la mesa
        /// </summary>
        /// <returns> 1 si se ha ejecutado una linea de codigo 0 si no se ha ejecutado ninguna </returns>
        public int ReservarMesa()
        {
            ConexionBBDD conexi = new ConexionBBDD();
            conexi.AbrirConexion();
            int retorno;
            //Ejecuta en la base de datos una reserva
            String consulta = "INSERT INTO reservaMesa (id,dia,numComensales,nombre,apellidos,correo,hora) " +
                              "VALUES (@id,@dia,@num,@nom,@ape,@corr,@hor)";
            MySqlCommand comando = new MySqlCommand(consulta, conexi.Conexion);
            comando.Parameters.AddWithValue("id", null);
            comando.Parameters.AddWithValue("dia", this.Dia.ToString("yyyy/MM/dd"));
            comando.Parameters.AddWithValue("num", this.numComensales);
            comando.Parameters.AddWithValue("nom", this.nombre);
            comando.Parameters.AddWithValue("ape", this.apellidos);
            comando.Parameters.AddWithValue("corr", this.correo);
            comando.Parameters.AddWithValue("hor", this.hora);

            retorno = comando.ExecuteNonQuery();
            conexi.CerrarConexion();
            return retorno;
        }
    }

}

