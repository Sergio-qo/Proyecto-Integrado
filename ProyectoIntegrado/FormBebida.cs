﻿using System;
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
    public partial class FormBebida : Form
    {
        private Articulos articulo;
        public FormBebida()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();

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

        private void button4_Click(object sender, EventArgs e)
        {
            articulo = new Articulos(cmbItems.Text, cmbItems.Text);
            Pedidos pedido = new Pedidos();
            pedido.AnyadirArticulo(articulo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPago pago = new FormPago();
            pago.Show();
        }
    }
}
