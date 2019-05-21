using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIngegradoBackEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entrarButt_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "paco")
            {
                if (textBox2.Text == "paco")
                {
                    this.Hide();
                    FormBackEnd patata = new FormBackEnd();
                    patata.Show();
                }
                else {
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario es incorrecto");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
