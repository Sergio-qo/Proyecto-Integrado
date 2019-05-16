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
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        private void BtnPagoEfectivo_Click(object sender, EventArgs e)
        {
            FormPagoEfectivo formpagoefectivo = new FormPagoEfectivo();
            formpagoefectivo.Show();
            this.Hide();
        }
    }
}
