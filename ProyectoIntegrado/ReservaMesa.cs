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
        private int idReservaMesa;
        private DateTime dia;
        private int numComensales;
        private string nombre;
        private string apellidos;
        private string correo;
        private string hora;
        private bool aprobado;
        public int IdReservaMesa { get { return idReservaMesa; } }
        public DateTime Dia { get { return dia; } }
        private int NumComensales { get{ return numComensales; }set { numComensales = value; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }
        public string Correo { get { return correo; } }
        public string Hora { get { return hora; } }
        public bool Aprobado { get { return aprobado; } }

        public ReservaMesa(DateTime fecha,int numCom,string nom,string ape,string email, string Horas)
        {
            dia = fecha;
            numComensales = numCom;
            nombre = nom;
            apellidos = ape;
            correo = email;
            hora = Horas;
            aprobado = false;
        }
        /// <summary>
        /// Ejecuta en la base de datos una reserva de la mesa
        /// </summary>
        /// <returns> 1 si se ha ejecutado una linea de codigo 0 si no se ha ejecutado ninguna </returns>
        public int ReservarMesa()
        {
            int retorno;
            //Ejecuta en la base de datos una reserva
            String consulta = "INSERT INTO reservaMesa (idReservaMesa,dia,numComensales,nombre,apellidos,correo,aprobado) " +
                              "VALUES (@id,@dia,@num,@nom,@ape,@corr,@apro)";
            ConexionBBDD conexion = new ConexionBBDD();
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", null);
            comando.Parameters.AddWithValue("dia", this.Dia.ToString("yyyy/MM/dd"));
            comando.Parameters.AddWithValue("num", this.numComensales);
            comando.Parameters.AddWithValue("nom", this.nombre);
            comando.Parameters.AddWithValue("ape", this.apellidos);
            comando.Parameters.AddWithValue("corr", this.correo);
            comando.Parameters.AddWithValue("apro", "0");

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        /// <summary>
        /// El dueño del hotel elegiría si quiere confirmar la mesa manualmente
        /// </summary>
        /// <param name="ID">Recibe el id de la mesa</param>
        /// <returns>1 si se ha ejecutado una linea de codigo 0 si no se ha ejecutado ninguna</returns>
        public int confirmarMesa(string ID)
        {
            int retorno;
            String consulta = "UPDATE fichaje SET aprobado=@apro WHERE idReservaMesa=@id AND aprobado='0'";
            ConexionBBDD conexion = new ConexionBBDD();

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("id", ID);
            comando.Parameters.AddWithValue("apro", "1");

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }        
    }
}

