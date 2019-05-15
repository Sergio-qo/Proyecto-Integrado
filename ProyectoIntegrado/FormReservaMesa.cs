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
    public partial class FormReservaMesa : Form
    {
        public FormReservaMesa()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal formPortada = new FormPrincipal();
            formPortada.Show();


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

        private void btnSiguienteDisponible_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if(txtNombreReserva.Text == "")
            {
                errorProvider1.SetError(txtNombreReserva, "Introduce nombre");
            }

            if (txtApellidosReserva.Text == "")
            {
                errorProvider1.SetError(txtApellidosReserva, "Introduce apellidos");
            }

            if (txtEmailReserva.Text == "")
            {
                errorProvider1.SetError(txtEmailReserva, "Introduce email");
            }

            if (txtNumeroComensales.Text == "")
            {
                errorProvider1.SetError(txtNumeroComensales, "Indica número de comensales");
            }

            if (cmbHoraReserva.Text == "")
            {
                errorProvider1.SetError(cmbHoraReserva, "Indica hora");
            }



        }
    }
}
