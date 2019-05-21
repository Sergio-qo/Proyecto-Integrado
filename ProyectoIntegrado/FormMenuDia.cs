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

namespace ProyectoIntegrado
{
    public partial class FormMenuDia : Form
    {
        Pedidos pedido = new Pedidos();
        public FormMenuDia()
        {
            InitializeComponent();
            ConexionBBDD conexion = new ConexionBBDD();
            if (conexion.AbrirConexion())
            {
                string consulta = "select nombre from articulos where tipo = 'Menu' and nombre = 'Pasta' or nombre = 'Plato paella' or nombre = 'Ensalada'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                List<string> listaPrimero = new List<string>();
                while (reader.Read())
                {
                    listaPrimero.Add(reader.GetString(0));
                }
                reader.Close();
                cmbPrimer.DataSource = listaPrimero;


                consulta = "select nombre from articulos where tipo = 'Menu' and nombre = 'Ternera' or nombre = 'Pollo'";
                comando = new MySqlCommand(consulta, conexion.Conexion);
                reader = comando.ExecuteReader();
                List<string> listaSegundo = new List<string>();
                while (reader.Read())
                {
                    listaSegundo.Add(reader.GetString(0));
                }
                reader.Close();
                cmbSegundo.DataSource = listaSegundo;


                consulta = "select nombre from articulos where tipo = 'Bebida'";
                comando = new MySqlCommand(consulta, conexion.Conexion);
                reader = comando.ExecuteReader();
                List<string> listaBebida = new List<string>();
                while (reader.Read())
                {
                    listaBebida.Add(reader.GetString(0));
                }
                reader.Close();
                cmbBebida.DataSource = listaBebida;
            }
            else
            {
                MessageBox.Show("error");
            }

            List<Articulos> articulos = pedido.VerListaArticulos();

            foreach (Articulos articulo in articulos)
            {
                dataGridView1.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();

            this.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Boton que hace que se cierre la pagina
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Boton para minimizar la pagina
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            pedido.AnyadirArticulo(new Articulos(cmbPrimer.Text));
            pedido.AnyadirArticulo(new Articulos(cmbSegundo.Text));
            pedido.AnyadirArticulo(new Articulos(cmbBebida.Text));


            List<Articulos> lista = pedido.VerListaArticulos();
            dataGridView1.Rows.Clear();
            foreach (Articulos articulo in lista)
            {
                dataGridView1.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }

            
        }

        private void FormMenuDia_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguienteDisponible_Click(object sender, EventArgs e)
        {
            FormPago pago = new FormPago();
            pago.Show();

            this.Dispose();
        }
    }
}
