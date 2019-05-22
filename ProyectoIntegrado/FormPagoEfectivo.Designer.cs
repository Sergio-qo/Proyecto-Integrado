namespace ProyectoIntegrado
{
    partial class FormPagoEfectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoEfectivo));
            this.lblTituloPago = new System.Windows.Forms.Label();
            this.txtPrecioAPagarEfectivo = new System.Windows.Forms.TextBox();
            this.lblInformaPrecio = new System.Windows.Forms.Label();
            this.grbPagoTarjeta = new System.Windows.Forms.GroupBox();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grpBarraInferior = new System.Windows.Forms.GroupBox();
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAtras = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbPagoTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPago
            // 
            this.lblTituloPago.AutoSize = true;
            this.lblTituloPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPago.Location = new System.Drawing.Point(545, 57);
            this.lblTituloPago.Name = "lblTituloPago";
            this.lblTituloPago.Size = new System.Drawing.Size(59, 20);
            this.lblTituloPago.TabIndex = 46;
            this.lblTituloPago.Text = "PAGO";
            // 
            // txtPrecioAPagarEfectivo
            // 
            this.txtPrecioAPagarEfectivo.Enabled = false;
            this.txtPrecioAPagarEfectivo.Location = new System.Drawing.Point(161, 12);
            this.txtPrecioAPagarEfectivo.Name = "txtPrecioAPagarEfectivo";
            this.txtPrecioAPagarEfectivo.Size = new System.Drawing.Size(102, 20);
            this.txtPrecioAPagarEfectivo.TabIndex = 13;
            // 
            // lblInformaPrecio
            // 
            this.lblInformaPrecio.AutoSize = true;
            this.lblInformaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformaPrecio.Location = new System.Drawing.Point(-3, 16);
            this.lblInformaPrecio.Name = "lblInformaPrecio";
            this.lblInformaPrecio.Size = new System.Drawing.Size(157, 16);
            this.lblInformaPrecio.TabIndex = 11;
            this.lblInformaPrecio.Text = "El precio a pagar es: ";
            // 
            // grbPagoTarjeta
            // 
            this.grbPagoTarjeta.Controls.Add(this.txtPrecioAPagarEfectivo);
            this.grbPagoTarjeta.Controls.Add(this.lblInformaPrecio);
            this.grbPagoTarjeta.Location = new System.Drawing.Point(462, 171);
            this.grbPagoTarjeta.Name = "grbPagoTarjeta";
            this.grbPagoTarjeta.Size = new System.Drawing.Size(288, 46);
            this.grbPagoTarjeta.TabIndex = 55;
            this.grbPagoTarjeta.TabStop = false;
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(13, 47);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 54;
            this.pcbCarrito.TabStop = false;
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
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(540, 301);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(148, 23);
            this.btnContinuar.TabIndex = 50;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpBarraInferior
            // 
            this.grpBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpBarraInferior.Location = new System.Drawing.Point(0, 410);
            this.grpBarraInferior.Name = "grpBarraInferior";
            this.grpBarraInferior.Size = new System.Drawing.Size(802, 41);
            this.grpBarraInferior.TabIndex = 48;
            this.grpBarraInferior.TabStop = false;
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Location = new System.Drawing.Point(-1, 0);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraSuperior.TabIndex = 47;
            this.grbBarraSuperior.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(340, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 388);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // dgvItem
            // 
            this.dgvItem.HeaderText = "Item";
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem,
            this.dgvCantidad,
            this.dgvPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(13, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 221);
            this.dataGridView1.TabIndex = 52;
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Location = new System.Drawing.Point(81, 379);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(31, 13);
            this.lblAtras.TabIndex = 57;
            this.lblAtras.Text = "Atras";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(13, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPagoEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTituloPago);
            this.Controls.Add(this.grbPagoTarjeta);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.grpBarraInferior);
            this.Controls.Add(this.grbBarraSuperior);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagoEfectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPagoEfectivo";
            this.grbPagoTarjeta.ResumeLayout(false);
            this.grbPagoTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPago;
        private System.Windows.Forms.TextBox txtPrecioAPagarEfectivo;
        private System.Windows.Forms.Label lblInformaPrecio;
        private System.Windows.Forms.GroupBox grbPagoTarjeta;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox grpBarraInferior;
        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Button button1;
    }
}