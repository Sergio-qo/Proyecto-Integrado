using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //Importamos libreria para poder deslizar la ventana (1)

namespace Experimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Visualizar la ventana. Copiado de internet porque son palabras reservadas de la libreria(Runtime.InteropServices)(1)

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparaam);




        private void BtnOpciones_Click(object sender, EventArgs e)   //Boton que hace que se abra la barra lateral o se cierre
        {
            if (pnlPrincipal.Width == 250)
            {                                   //Si el panel lateral esta abierto, entonces se apreta y se vuelve pequeño
                pnlPrincipal.Width = 70;
            }
            else
            {
                pnlPrincipal.Width = 250;       //Sino, si apretamos la barra lateral se pone en grande
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Boton que hace que se cierre la pagina
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized; //Variable para Maximizar la pagina
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;                    //Cuando este maximizada el btn de restaurar se mostrara
            btnMaximizar.Visible = false;                   //Cuando este maximizada el btn maximizar no se muestra

        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal; //Variable que representa un objeto Applicacion. 
            this.Size = new Size(1120,570);
            btnRestaurar.Visible = false;               //Tenemos la pagina en modo normal por lo que no se puede restaurar(false)
            btnMaximizar.Visible = true;                    //Solo puede maximizar

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Boton para minimizar la pagina

        }

        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e) //Funcion para mover la ventana
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);       //Llamamos a las funciones  anteriormente escritas (1)
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMantenimiento());
        }
    }
    
}
