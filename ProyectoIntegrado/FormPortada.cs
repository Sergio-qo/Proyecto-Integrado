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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            FormIdioma formIdioma = new FormIdioma();
            formIdioma.Show();

            this.Hide();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            FormReservaMesa formReservas = new FormReservaMesa();
            formReservas.Show();

            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();

            this.Hide();
        }
    }
}
