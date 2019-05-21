using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using System.Net.Mail;

namespace ProyectoIngegradoBackEnd
{
    public partial class FormBackEnd : Form
    {
        public FormBackEnd()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConexionBD.AbrirConexion();
            string Id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            ListaProductos.Rows.Clear();
            ActualizarProductos(Id);
            ConexionBD.CerrarConexion();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConexionBD.AbrirConexion();
            string Id = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            ListaProductos.Rows.Clear();
            ActualizarProductos(Id);
            ConexionBD.CerrarConexion();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConexionBD.AbrirConexion();
            string Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ListaProductos.Rows.Clear();
            ActualizarProductos(Id);
            ConexionBD.CerrarConexion();
        }

        private void aceptarMesa_Click(object sender, EventArgs e)
        {

            ConexionBD.AbrirConexion();
            string email = dataGridView5.SelectedRows[0].Cells[4].Value.ToString();
            string Idstr = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
            string consulta = string.Format("select correo from reservamesa where id ='{0}'", Idstr);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            string correo = reader.GetString(0);
            reader.Close();
            string correoProp = "barvaderenterprise@gmail.com";
            string contraseña = "paco123T";
            string mensaje = "Tu reserva ha sido aprobada";
            MailMessage mail = new MailMessage(correoProp, correo, "Reserva numero #" + Idstr + "", mensaje);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(correoProp, contraseña);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Email Enviado");
            string consulta2 = string.Format("delete from reservamesa where id ='{0}'", Idstr);
            MySqlCommand comando2 = new MySqlCommand(consulta2, ConexionBD.Conexion);
            comando2.ExecuteNonQuery();
            dataGridView5.Rows.Clear();
            ActualizarEmpleados();
            ConexionBD.CerrarConexion();
        }
        public string getid()
        {
            string id = "";

            return id;
        }
        public void ActualizarEmpleados()
        {
            String consulta = "SELECT id,dia,hora,numComensales,correo FROM reservamesa";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows == true)
            {
                int count = 0;
                while (reader.Read())
                {
                    if (reader.GetString(4) != "")
                    {
                        dataGridView5.Rows.Add();
                        dataGridView5.Rows[count].Cells[0].Value = (reader.GetInt32(0));
                        dataGridView5.Rows[count].Cells[1].Value = (reader.GetDateTime(1));
                        dataGridView5.Rows[count].Cells[2].Value = (reader.GetString(2));
                        dataGridView5.Rows[count].Cells[3].Value = (reader.GetInt32(3));
                        dataGridView5.Rows[count].Cells[4].Value = (reader.GetString(4));
                        count++;
                    }
                }
            }
            reader.Close();
        }
        public void actualizarPorhacer()
        {
            String consulta = "SELECT IdPedido,HoraPedido,PrecioPedido FROM pedido where proceso='Por Hacer'";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows == true)
            {
                int count = 0;
                while (reader.Read())
                {
                    if (reader.GetString(1) != "")
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[count].Cells[0].Value = (reader.GetInt32(0));
                        dataGridView1.Rows[count].Cells[1].Value = (reader.GetString(1));
                        dataGridView1.Rows[count].Cells[2].Value = (reader.GetDouble(2));
                        count++;
                    }
                }
            }
            reader.Close();
        }
        public void actualizarHaciendo()
        {
            String consulta = "SELECT IdPedido,HoraPedido,PrecioPedido FROM pedido where proceso='Haciendo'";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows == true)
            {
                int count = 0;
                while (reader.Read())
                {
                    if (reader.GetString(1)!="")
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[count].Cells[0].Value = (reader.GetInt32(0));
                        dataGridView2.Rows[count].Cells[1].Value = (reader.GetString(1));
                        dataGridView2.Rows[count].Cells[2].Value = (reader.GetDouble(2));
                        count++;
                    }

                }
            }
            reader.Close();
        }
        public void actualizarHecho()
        {
            String consulta = "SELECT IdPedido,HoraPedido,PrecioPedido FROM pedido where proceso='Hecho'";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows==true)
            {
                int count = 0;
                while (reader.Read())
                {
                    if (reader.GetString(1) != "")
                    {
                        dataGridView3.Rows.Add();
                        dataGridView3.Rows[count].Cells[0].Value = (reader.GetInt32(0));
                        dataGridView3.Rows[count].Cells[1].Value = (reader.GetString(1));
                        dataGridView3.Rows[count].Cells[2].Value = (reader.GetDouble(2));
                        count++;
                    }
                }
            }
        
            reader.Close();
        }
        public void ActualizarProductos(string Id)
        {
            String consulta = string.Format("Select nombre,descripcion,cantidad from articulospedido where IdPedido ='{0}'", Id);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows == true)
            {
                int count = 0;
                while (reader.Read())
                {
                    if (reader.GetString(1) != "")
                    {
                        ListaProductos.Rows.Add();
                        ListaProductos.Rows[count].Cells[0].Value = (reader.GetString(0));
                        ListaProductos.Rows[count].Cells[1].Value = (reader.GetString(1));
                        ListaProductos.Rows[count].Cells[2].Value = (reader.GetInt32(2));

                        count++;
                    }
                }
            }

            reader.Close();
        }

        private void rechazarMesa_Click(object sender, EventArgs e)
        {
            ConexionBD.AbrirConexion();
            string email = dataGridView5.SelectedRows[0].Cells[4].Value.ToString();
            string Idstr = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
            string consulta = string.Format("select correo from reservamesa where id ='{0}'", Idstr);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            string correo = reader.GetString(0);
            reader.Close();
            string correoProp = "barvaderenterprise@gmail.com";
            string contraseña = "paco123T";
            string mensaje = "Tu reserva ha sido rechazada";
            MailMessage mail = new MailMessage(correoProp, correo, "Reserva numero #" + Idstr + "", mensaje);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(correoProp, contraseña);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Email Enviado");
            string consulta2 = string.Format("delete from reservamesa where id ='{0}'", Idstr);
            MySqlCommand comando2 = new MySqlCommand(consulta2, ConexionBD.Conexion);
            comando2.ExecuteNonQuery();
            dataGridView5.Rows.Clear();
            ActualizarEmpleados();
            ConexionBD.CerrarConexion();
        }

        private void FormBackEnd_Load(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                ActualizarEmpleados();
                actualizarPorhacer();
                actualizarHaciendo();
                actualizarHecho();
                ConexionBD.CerrarConexion();

            }
        }

        private void aHaciendo_Click(object sender, EventArgs e)
        {
            ConexionBD.AbrirConexion();
            string Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string consulta = string.Format("Update pedido set proceso='Haciendo' where IdPedido ='{0}'", Id);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            actualizarHaciendo();
            actualizarPorhacer();
            actualizarHecho();
            ConexionBD.CerrarConexion();
        }

        private void aHecho_Click(object sender, EventArgs e)
        {
            ConexionBD.AbrirConexion();
            string Id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            string consulta = string.Format("Update pedido set proceso='Hecho' where IdPedido ='{0}'", Id);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            actualizarHaciendo();
            actualizarPorhacer();
            actualizarHecho();
            ConexionBD.CerrarConexion();
        }

        private void volverHaciendo_Click(object sender, EventArgs e)
        {
            ConexionBD.AbrirConexion();
            string Id = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            string consulta = string.Format("Update pedido set proceso='Haciendo' where IdPedido ='{0}'", Id);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            actualizarHaciendo();
            actualizarPorhacer();
            actualizarHecho();
            ConexionBD.CerrarConexion();
        }

        private void volverPorHacer_Click(object sender, EventArgs e)
        {
            ConexionBD.AbrirConexion();
            string Id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            string consulta = string.Format("Update pedido set proceso='Por Hacer' where IdPedido ='{0}'", Id);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            actualizarHaciendo();
            actualizarPorhacer();
            actualizarHecho();
            ConexionBD.CerrarConexion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ConexionBD.AbrirConexion();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView5.Rows.Clear();
            ListaProductos.Rows.Clear();
            actualizarHaciendo();
            ActualizarEmpleados();
            actualizarPorhacer();
            actualizarHecho();
            ConexionBD.CerrarConexion();
        }
    }
}
