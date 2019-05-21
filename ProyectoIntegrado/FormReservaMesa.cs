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

        private void btnSiguienteDisponible_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool bien = true;
         
                if (txtNombreReserva.Text == "")
                {
                    errorProvider1.SetError(txtNombreReserva, "Introduce nombre");
                    bien = false;
                }

                if (txtApellidosReserva.Text == "")
                {
                    errorProvider1.SetError(txtApellidosReserva, "Introduce apellidos");
                    bien = false;
                }

                if (txtEmailReserva.Text == "")
                {
                    errorProvider1.SetError(txtEmailReserva, "Introduce email");
                    bien = false;
                }

                if (txtNumeroComensales.Text == "")
                {
                    errorProvider1.SetError(txtNumeroComensales, "Indica número de comensales");
                    bien = false;
                }

                if (cmbHoraReserva.Text == "")
                {
                    errorProvider1.SetError(cmbHoraReserva, "Indica hora");
                    bien = false;
                }



            if (bien)
            {



                ReservaMesa reserva = new ReservaMesa(dtDiaReserva.Value, Convert.ToInt32(txtNumeroComensales.Text), txtNombreReserva.Text, txtApellidosReserva.Text, txtEmailReserva.Text, cmbHoraReserva.Text);
                if (reserva.ReservarMesa() == 1)
                {
                    FormMesaReservada mesaReservada = new FormMesaReservada();
                    mesaReservada.Show();

                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("No se ha podido reservar la mesa, intentalo con otras fechas");

                    FormPrincipal formPortada = new FormPrincipal();
                    formPortada.Show();


                    this.Dispose();
                }
            }
            
            


        }
    }
}
