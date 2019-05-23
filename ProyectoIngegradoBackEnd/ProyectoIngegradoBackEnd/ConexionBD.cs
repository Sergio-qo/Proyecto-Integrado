﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIngegradoBackEnd
{
    class ConexionBD
    {
        private static MySqlConnection instancia = null;
        private static readonly object padlock = new object();

        private ConexionBD() { }

        public static MySqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        // Se define la cadena de conexión para la conexión.
                        string server = "server=127.0.0.1;";
                        string port = "port=3306;";
                        string database = "database=mydb;";
                        string usuario = "uid=root;";
                        string password = "pwd=;";
                        instancia.ConnectionString = server + port + database + usuario + password;

                        // Ejemplo de Conexión remota: db4free.net
                        //string server = "server=db4free.net;";
                        //string oldguids = "oldguids=true;";
                        //string database = "database=bdsalva;";
                        //string usuario = "uid=salvador;";
                        //string password = "pwd=;";
                        //string connectionstring = server + oldguids + database + usuario + password;
                    }
                    return instancia;
                }
            }
        }

        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }

        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }
    }
}
