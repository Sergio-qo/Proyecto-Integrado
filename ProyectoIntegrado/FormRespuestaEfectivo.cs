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
    public partial class FormRespuestaEfectivo : Form
    {
        Pedidos pedido = new Pedidos();
        public FormRespuestaEfectivo()
        {
            InitializeComponent();
            pedido.AbrirPedido();
            List<Articulos> articulos = pedido.VerListaArticulos();

            foreach (Articulos articulo in articulos)
            {
                dataGridView1.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }

            pedido.HacerPedido();

            Random rnd = new Random();
            //rnd.Next();

            txtCodigoPedidoEfectivo.Text = Convert.ToString(rnd.Next(9999));
        }

        //Vuelve al inicio de la aplicación
        private void btnSiguienteDisponible_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();

            this.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();

            this.Dispose();
        }

        private void FormRespuestaEfectivo_Load(object sender, EventArgs e)
        {

        }
    }
}
