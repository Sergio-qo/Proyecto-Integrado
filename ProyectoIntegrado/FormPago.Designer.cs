namespace ProyectoIntegrado
{
    partial class FormPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPago));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAñadirCodigo = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnPagoEfectivo = new System.Windows.Forms.Button();
            this.btnPagoTarjeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(479, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(159, 645);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 185);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 352);
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
            this.groupBox2.Location = new System.Drawing.Point(-17, 643);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1203, 63);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Controls.Add(this.btnMinimizar);
            this.grbBarraSuperior.Controls.Add(this.btnCerrar);
            this.grbBarraSuperior.Location = new System.Drawing.Point(-17, 0);
            this.grbBarraSuperior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBarraSuperior.Size = new System.Drawing.Size(1203, 72);
            this.grbBarraSuperior.TabIndex = 43;
            this.grbBarraSuperior.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1138, 18);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(26, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 28;
            this.btnMinimizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1170, 18);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.TabStop = false;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(860, 99);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(85, 29);
            this.lblPago.TabIndex = 50;
            this.lblPago.Text = "PAGO";
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(175, 99);
            this.pcbCarrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(93, 77);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 49;
            this.pcbCarrito.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(646, 573);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(205, 22);
            this.lblCodigo.TabIndex = 48;
            this.lblCodigo.Text = "Codigo de descuento:";
            // 
            // btnAñadirCodigo
            // 
            this.btnAñadirCodigo.BackColor = System.Drawing.Color.White;
            this.btnAñadirCodigo.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirCodigo.Image")));
            this.btnAñadirCodigo.Location = new System.Drawing.Point(1053, 559);
            this.btnAñadirCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadirCodigo.Name = "btnAñadirCodigo";
            this.btnAñadirCodigo.Size = new System.Drawing.Size(80, 44);
            this.btnAñadirCodigo.TabIndex = 47;
            this.btnAñadirCodigo.UseVisualStyleBackColor = false;
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(214, 578);
            this.lblAtras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(63, 25);
            this.lblAtras.TabIndex = 52;
            this.lblAtras.Text = "Atrás";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(99, 563);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(93, 58);
            this.btnAtras.TabIndex = 53;
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(892, 572);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(127, 26);
            this.txtDescuento.TabIndex = 54;
            // 
            // btnPagoEfectivo
            // 
            this.btnPagoEfectivo.Location = new System.Drawing.Point(682, 185);
            this.btnPagoEfectivo.Name = "btnPagoEfectivo";
            this.btnPagoEfectivo.Size = new System.Drawing.Size(198, 352);
            this.btnPagoEfectivo.TabIndex = 55;
            this.btnPagoEfectivo.UseVisualStyleBackColor = true;
            this.btnPagoEfectivo.Click += new System.EventHandler(this.BtnPagoEfectivo_Click);
            // 
            // btnPagoTarjeta
            // 
            this.btnPagoTarjeta.Location = new System.Drawing.Point(923, 185);
            this.btnPagoTarjeta.Name = "btnPagoTarjeta";
            this.btnPagoTarjeta.Size = new System.Drawing.Size(198, 352);
            this.btnPagoTarjeta.TabIndex = 56;
            this.btnPagoTarjeta.UseVisualStyleBackColor = true;
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 709);
            this.Controls.Add(this.btnPagoTarjeta);
            this.Controls.Add(this.btnPagoEfectivo);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbBarraSuperior);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnAñadirCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPago";
            this.Text = "FormPago";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
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
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAñadirCodigo;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button btnPagoEfectivo;
        private System.Windows.Forms.Button btnPagoTarjeta;
    }
}