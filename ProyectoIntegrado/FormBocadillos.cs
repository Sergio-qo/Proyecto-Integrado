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
    public partial class FormBocadillos : Form
    {
        Pedidos pedido = new Pedidos();
        public FormBocadillos()
        {
            InitializeComponent();
            ConexionBBDD conexion = new ConexionBBDD();
            if (conexion.AbrirConexion())
            {
                string consulta = "select nombre from articulos where tipo = 'Comida'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                List<string> lista = new List<string>();
                while (reader.Read())
                {
                    lista.Add(reader.GetString(0));
                }
                cmbItems.DataSource = lista;
            }
            else
            {
                MessageBox.Show("error");
            }

            //Pedidos pedido = new Pedidos();
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

        private void btnEliArt_Click(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            pedido.EliminarArticulo(cmbItems.Text);

            List<Articulos> articulos = pedido.VerListaArticulos();

            dataGridView1.Rows.Clear();

            foreach (Articulos articulo in articulos)
            {
                dataGridView1.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pedido.AnyadirArticulo(new Articulos(cmbItems.Text));
            List<Articulos> lista = pedido.VerListaArticulos();
            dataGridView1.Rows.Clear();
            foreach (Articulos articulo in lista)
            {
                dataGridView1.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }

        }

        private void FormBocadillos_Load(object sender, EventArgs e)
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
