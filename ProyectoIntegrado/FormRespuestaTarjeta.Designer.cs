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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCodigoPedidoTarjeta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPagoEfectivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem,
            this.dgvCantidad,
            this.dgvPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
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
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(125, 78);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 49;
            this.pcbCarrito.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(499, 373);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 36);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCodigoPedidoTarjeta
            // 
            this.txtCodigoPedidoTarjeta.Enabled = false;
            this.txtCodigoPedidoTarjeta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPedidoTarjeta.Location = new System.Drawing.Point(126, 82);
            this.txtCodigoPedidoTarjeta.Name = "txtCodigoPedidoTarjeta";
            this.txtCodigoPedidoTarjeta.Size = new System.Drawing.Size(102, 26);
            this.txtCodigoPedidoTarjeta.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCodigoPedidoTarjeta);
            this.panel2.Location = new System.Drawing.Point(396, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 143);
            this.panel2.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tú código de pedido es el número:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 59);
            this.panel1.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(338, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 403);
            this.panel3.TabIndex = 56;
            // 
            // lblPagoEfectivo
            // 
            this.lblPagoEfectivo.AutoSize = true;
            this.lblPagoEfectivo.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoEfectivo.Location = new System.Drawing.Point(407, 120);
            this.lblPagoEfectivo.Name = "lblPagoEfectivo";
            this.lblPagoEfectivo.Size = new System.Drawing.Size(344, 43);
            this.lblPagoEfectivo.TabIndex = 57;
            this.lblPagoEfectivo.Text = "PAGO CON TARJETA";
            // 
            // FormRespuestaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPagoEfectivo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcbCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRespuestaTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRespuestaTarjeta";
            this.Load += new System.EventHandler(this.FormRespuestaTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCodigoPedidoTarjeta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPagoEfectivo;
    }
}