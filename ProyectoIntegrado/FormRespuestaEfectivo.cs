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
        public FormRespuestaEfectivo()
        {
            InitializeComponent();
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
    }
}
