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
    public partial class FormPago : Form
    {
        Pedidos pedido = new Pedidos();
        public FormPago()
        {
            InitializeComponent();
            pedido.AbrirPedido();
            List<Articulos> articulos = pedido.VerListaArticulos();

            foreach (Articulos articulo in articulos)
            {
                dataGridView1.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }


            lblResultadoPrecio.Text = Convert.ToString(pedido.CalcularPrecio());
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

            

        }

        private void BtnPagoEfectivo_Click(object sender, EventArgs e)
        {

            if(lblResultadoPrecio.Text == "0")
            {
                MessageBox.Show("No hay artículos");
            }
            else
            {
                FormPagoEfectivo formpagoefectivo = new FormPagoEfectivo();
                formpagoefectivo.Show();
                this.Hide();
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Boton que hace que se cierre la pagina
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Boton para minimizar la pagina
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();

            this.Dispose();
        }

        private void FormPago_Load(object sender, EventArgs e)
        {

        }

        private void btnPagoTarjeta_Click(object sender, EventArgs e)
        {
            if (lblResultadoPrecio.Text == "0")
            {
                MessageBox.Show("No hay artículos");
            }
            else
            {
                FormPagoTarjeta formTarjeta = new FormPagoTarjeta();
                formTarjeta.Show();
                this.Dispose();
            }


            
        }
    }
}
