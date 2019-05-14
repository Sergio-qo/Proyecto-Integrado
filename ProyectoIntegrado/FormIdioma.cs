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
    public partial class FormIdioma : Form
    {
        public FormIdioma()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal formPortada = new FormPrincipal();
            formPortada.Show();
            

            this.Close();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            FormPrincipal formPortada = new FormPrincipal();
            formPortada.Show();


            this.Close();
        }

        private void FormIdioma_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptarIdioma_Click(object sender, EventArgs e)
        {
            if (rdbSpanish.Checked == true)
            {
                MessageBox.Show("El idioma ha sido cambiado");
            }
            else
            {
                MessageBox.Show("Language has been changed");
            }
            
        }
    }
}
