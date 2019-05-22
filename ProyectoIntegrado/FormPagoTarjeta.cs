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
    public partial class FormPagoTarjeta : Form
    {
        public FormPagoTarjeta()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Boton que hace que se cierre la pagina
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Boton para minimizar la pagina
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FormRespuestaTarjeta formRespuestaTarjeta = new FormRespuestaTarjeta();
            formRespuestaTarjeta.Show();

            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPago formPago = new FormPago();
            formPago.Show();

            this.Dispose();
        }

        private void lblAtras_Click(object sender, EventArgs e)
        {

        }
    }
}
