using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrado
{
    public partial class FormBebida : Form
    {
        private Articulos articulo = null;
        public FormBebida()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();

            this.Close();
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
            if (articulo == null)
            {
                articulo = new Articulos(comboBox1.Text);
            }
            else
            {
                articulo.IncrementarCantidad();
            }
            Pedidos pedido = new Pedidos();
            pedido.AnyadirArticulo(articulo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPago pago = new FormPago();
            pago.Show();
        }
    }
}
