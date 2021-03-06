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
    public partial class FormPagoEfectivo : Form
    {
        Pedidos pedido = new Pedidos();
        public FormPagoEfectivo()
        {
            InitializeComponent();
            pedido.AbrirPedido();
            List<Articulos> articulos = pedido.VerListaArticulos();

            foreach (Articulos articulo in articulos)
            {
                dataGridView1.Rows.Add(articulo.Nombre, articulo.Cantidad, articulo.Precio);
            }

            txtPrecioAPagarEfectivo.Text = Convert.ToString(pedido.CalcularPrecio());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Boton que hace que se cierre la pagina
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Boton para minimizar la pagina
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormRespuestaEfectivo formRespuestaEfectivo = new FormRespuestaEfectivo();
            formRespuestaEfectivo.Show();

            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPago formPago = new FormPago();
            formPago.Show();

            this.Dispose();
        }

        private void FormPagoEfectivo_Load(object sender, EventArgs e)
        {

        }
    }
}
