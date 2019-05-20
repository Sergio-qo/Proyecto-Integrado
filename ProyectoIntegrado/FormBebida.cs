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
    public partial class FormBebida : Form
    {
        private Articulos articulo = null;

        Pedidos pedido = new Pedidos();

        public FormBebida()
        {
            InitializeComponent();
            ConexionBBDD conexion = new ConexionBBDD();
            if (conexion.AbrirConexion())
            {
                string consulta = "select nombre from articulos where tipo = 'Bebida'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                List<string> lista = new List<string>();
                while (reader.Read())
                {
                    lista.Add(reader.GetString(0));
                }
                comboBox1.DataSource = lista;
            }
            else
            {
                MessageBox.Show("error");
            }

            Pedidos pedido = new Pedidos();
            List<Articulos> articulos = pedido.VerListaArticulos();

            foreach (Articulos articulo in articulos)
            {
                dataGridView2.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            //List<Articulos> articulos = new List<Articulos>();

            //articulo = new Articulos(comboBox1.Text);
            //MessageBox.Show("Añado a "+articulo.Nombre);
            //if (articulo == null)
            //{
            //    articulo = new Articulos(comboBox1.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Entro en incrementar de " + articulo.Nombre);
            //    articulo.IncrementarCantidad();
            //}

            ConexionBBDD conex = new ConexionBBDD();
            string consulta;
            MySqlCommand comando;
            MySqlDataReader reader;

            pedido.AnyadirArticulo(new Articulos(comboBox1.Text));

            //bool esta = false;

            //if (conex.AbrirConexion())
            //{

            //    consulta = String.Format("select nombre, id from articulos");
            //    comando = new MySqlCommand(consulta, conex.Conexion);

            //    reader = comando.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        articulos.Add(new Articulos(reader.GetString(0), reader.GetInt32(1)));
            //    }

            //    foreach (Articulos articulo in articulos)
            //    {
            //        if (articulo.Nombre == comboBox1.Text)
            //        {
            //            esta = true;
            //        }
            //        else
            //        {
            //            esta = false;
            //        }
            //    }
            //    if (esta == false)
            //    {
            //        pedido.AnyadirArticulo(new Articulos(comboBox1.Text));
            //    }
            //    else
            //    {
            //        pedido.IncrementarCantidadArticulo(articulo);
            //    }
            //    reader.Close();
            //    conex.CerrarConexion();
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}

            //pedido.AnyadirArticulo(articulo);

            List<Articulos> lista = new List<Articulos>();

            if (conex.AbrirConexion())
            {
                consulta = String.Format("select nombre, cantidad, articulospedido.precio from articulospedido inner join articulos on id=idarticulo");
                comando = new MySqlCommand(consulta, conex.Conexion);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Articulos(reader.GetString(0), reader.GetInt32(1), reader.GetDouble(2)));
                }

                reader.Close();
                dataGridView2.Rows.Clear();
                foreach (Articulos articulo in lista)
                {
                    dataGridView2.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPago pago = new FormPago();
            pago.Show();
        }

        private void FormBebida_Load(object sender, EventArgs e)
        {

        }

        private void btnEliArt_Click(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            pedido.EliminarArticulo(comboBox1.Text);

            List<Articulos> articulos = pedido.VerListaArticulos();

            dataGridView2.Rows.Clear();

            foreach(Articulos articulo in articulos)
            {
                dataGridView2.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }
        }
    }
}
