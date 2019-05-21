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
    public partial class FormMesaReservada : Form
    {
        public FormMesaReservada()
        {
            InitializeComponent();
        }

        //Vuelve al inicio de la aplicación
        private void BtnSiguienteDisponible_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();

            this.Dispose();
        }

        private void lblReservaDia_Click(object sender, EventArgs e)
        {

        }
    }
}
