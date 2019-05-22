namespace ProyectoIntegrado
{
    partial class FormRespuestaTarjeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRespuestaTarjeta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.lblPagoTarjeta = new System.Windows.Forms.Label();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbPago = new System.Windows.Forms.GroupBox();
            this.txtCodigoPedidoEfectivo = new System.Windows.Forms.TextBox();
            this.lblInformaCodigoPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.grbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(330, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 419);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem,
            this.dgvCantidad,
            this.dgvPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(13, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 229);
            this.dataGridView1.TabIndex = 46;
            // 
            // dgvItem
            // 
            this.dgvItem.HeaderText = "Item";
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.HeaderText = "Cantidad";
            this.dgvCantidad.Name = "dgvCantidad";
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.HeaderText = "Precio";
            this.dgvPrecio.Name = "dgvPrecio";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(-1, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 41);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Location = new System.Drawing.Point(-1, -3);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraSuperior.TabIndex = 43;
            this.grbBarraSuperior.TabStop = false;
            // 
            // lblPagoTarjeta
            // 
            this.lblPagoTarjeta.AutoSize = true;
            this.lblPagoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoTarjeta.Location = new System.Drawing.Point(535, 55);
            this.lblPagoTarjeta.Name = "lblPagoTarjeta";
            this.lblPagoTarjeta.Size = new System.Drawing.Size(142, 20);
            this.lblPagoTarjeta.TabIndex = 50;
            this.lblPagoTarjeta.Text = "PAGO TARJETA";
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(127, 55);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 49;
            this.pcbCarrito.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 345);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 23);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbPago
            // 
            this.grbPago.Controls.Add(this.txtCodigoPedidoEfectivo);
            this.grbPago.Controls.Add(this.lblInformaCodigoPedido);
            this.grbPago.Location = new System.Drawing.Point(461, 164);
            this.grbPago.Margin = new System.Windows.Forms.Padding(2);
            this.grbPago.Name = "grbPago";
            this.grbPago.Padding = new System.Windows.Forms.Padding(2);
            this.grbPago.Size = new System.Drawing.Size(307, 106);
            this.grbPago.TabIndex = 52;
            this.grbPago.TabStop = false;
            // 
            // txtCodigoPedidoEfectivo
            // 
            this.txtCodigoPedidoEfectivo.Enabled = false;
            this.txtCodigoPedidoEfectivo.Location = new System.Drawing.Point(93, 60);
            this.txtCodigoPedidoEfectivo.Name = "txtCodigoPedidoEfectivo";
            this.txtCodigoPedidoEfectivo.Size = new System.Drawing.Size(102, 20);
            this.txtCodigoPedidoEfectivo.TabIndex = 44;
            // 
            // lblInformaCodigoPedido
            // 
            this.lblInformaCodigoPedido.AutoSize = true;
            this.lblInformaCodigoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformaCodigoPedido.Location = new System.Drawing.Point(30, 24);
            this.lblInformaCodigoPedido.Name = "lblInformaCodigoPedido";
            this.lblInformaCodigoPedido.Size = new System.Drawing.Size(250, 16);
            this.lblInformaCodigoPedido.TabIndex = 43;
            this.lblInformaCodigoPedido.Text = "Tú código de pedido es el número:";
            // 
            // FormRespuestaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbBarraSuperior);
            this.Controls.Add(this.lblPagoTarjeta);
            this.Controls.Add(this.pcbCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRespuestaTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRespuestaTarjeta";
            this.Load += new System.EventHandler(this.FormRespuestaTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.grbPago.ResumeLayout(false);
            this.grbPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.Label lblPagoTarjeta;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbPago;
        private System.Windows.Forms.TextBox txtCodigoPedidoEfectivo;
        private System.Windows.Forms.Label lblInformaCodigoPedido;
    }
}