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
    public partial class FormPedidos : Form
    {
        


        public FormPedidos()
        {
            InitializeComponent();
            pedido.Creado = true;
            if (pedido.Creado == false)
            {
                pedido = new Pedidos();
            }
            //ConexionBBDD conexion = new ConexionBBDD();
            //if (conexion.AbrirConexion())
            //{
            //    string consulta = "insert into pedidos values()";
            //    MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            //    comando.ExecuteNonQuery();
            //}
            //else
            //{
            //    MessageBox.Show("Error al conectar con la base de datos");
            //}


            List<Articulos> articulos = pedido.VerListaArticulos();

            foreach (Articulos articulo in articulos)
            {
                dataGridView1.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal formPortada = new FormPrincipal();
            formPortada.Show();


            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenuDia formMenuDia = new FormMenuDia();
            formMenuDia.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormComida formComida = new FormComida();
            formComida.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBocadillos formBocadillos = new FormBocadillos();
            formBocadillos.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPostre formPostre = new FormPostre();
            formPostre.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBebida formBebida = new FormBebida();
            formBebida.Show();

            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Boton para minimizar la pagina
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Boton que hace que se cierre la pagina
        }

        private void grbBarraSuperior_Enter(object sender, EventArgs e)
        {

        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
