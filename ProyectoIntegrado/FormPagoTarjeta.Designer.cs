namespace ProyectoIntegrado
{
    partial class FormPagoTarjeta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoTarjeta));
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtCaducidadTarjeta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaTarjeta = new System.Windows.Forms.Label();
            this.txtApellidosReserva = new System.Windows.Forms.TextBox();
            this.txtNombreReserva = new System.Windows.Forms.TextBox();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecioAPagarEfectivo = new System.Windows.Forms.TextBox();
            this.lblInformaPrecio = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbBarVader = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPagoEfectivo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAtras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(131, 76);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 44;
            this.pcbCarrito.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(487, 393);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(148, 38);
            this.btnPagar.TabIndex = 32;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.HeaderText = "Precio";
            this.dgvPrecio.Name = "dgvPrecio";
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.HeaderText = "Cantidad";
            this.dgvCantidad.Name = "dgvCantidad";
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 221);
            this.dataGridView1.TabIndex = 41;
            // 
            // dtCaducidadTarjeta
            // 
            this.dtCaducidadTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCaducidadTarjeta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCaducidadTarjeta.Location = new System.Drawing.Point(194, 130);
            this.dtCaducidadTarjeta.Name = "dtCaducidadTarjeta";
            this.dtCaducidadTarjeta.Size = new System.Drawing.Size(140, 26);
            this.dtCaducidadTarjeta.TabIndex = 16;
            // 
            // lblFechaTarjeta
            // 
            this.lblFechaTarjeta.AutoSize = true;
            this.lblFechaTarjeta.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTarjeta.Location = new System.Drawing.Point(6, 131);
            this.lblFechaTarjeta.Name = "lblFechaTarjeta";
            this.lblFechaTarjeta.Size = new System.Drawing.Size(182, 25);
            this.lblFechaTarjeta.TabIndex = 15;
            this.lblFechaTarjeta.Text = "Fecha Caducidad:";
            // 
            // txtApellidosReserva
            // 
            this.txtApellidosReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosReserva.Location = new System.Drawing.Point(194, 22);
            this.txtApellidosReserva.Name = "txtApellidosReserva";
            this.txtApellidosReserva.Size = new System.Drawing.Size(140, 26);
            this.txtApellidosReserva.TabIndex = 14;
            // 
            // txtNombreReserva
            // 
            this.txtNombreReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreReserva.Location = new System.Drawing.Point(194, 76);
            this.txtNombreReserva.Name = "txtNombreReserva";
            this.txtNombreReserva.Size = new System.Drawing.Size(140, 26);
            this.txtNombreReserva.TabIndex = 13;
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(6, 77);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(170, 25);
            this.lblNumeroTarjeta.TabIndex = 12;
            this.lblNumeroTarjeta.Text = "Número Tarjeta:";
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTitular.Location = new System.Drawing.Point(11, 23);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(169, 25);
            this.lblNombreTitular.TabIndex = 11;
            this.lblNombreTitular.Text = "Nombre Titular:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecioAPagarEfectivo);
            this.groupBox2.Controls.Add(this.lblInformaPrecio);
            this.groupBox2.Location = new System.Drawing.Point(412, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 58);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // txtPrecioAPagarEfectivo
            // 
            this.txtPrecioAPagarEfectivo.Enabled = false;
            this.txtPrecioAPagarEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioAPagarEfectivo.Location = new System.Drawing.Point(199, 24);
            this.txtPrecioAPagarEfectivo.Name = "txtPrecioAPagarEfectivo";
            this.txtPrecioAPagarEfectivo.Size = new System.Drawing.Size(110, 22);
            this.txtPrecioAPagarEfectivo.TabIndex = 13;
            // 
            // lblInformaPrecio
            // 
            this.lblInformaPrecio.AutoSize = true;
            this.lblInformaPrecio.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformaPrecio.Location = new System.Drawing.Point(6, 24);
            this.lblInformaPrecio.Name = "lblInformaPrecio";
            this.lblInformaPrecio.Size = new System.Drawing.Size(187, 22);
            this.lblInformaPrecio.TabIndex = 11;
            this.lblInformaPrecio.Text = "El precio a pagar es: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ptbBarVader);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 60);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(317, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 387);
            this.panel2.TabIndex = 27;
            // 
            // ptbBarVader
            // 
            this.ptbBarVader.Image = ((System.Drawing.Image)(resources.GetObject("ptbBarVader.Image")));
            this.ptbBarVader.Location = new System.Drawing.Point(2, 0);
            this.ptbBarVader.Margin = new System.Windows.Forms.Padding(2);
            this.ptbBarVader.Name = "ptbBarVader";
            this.ptbBarVader.Size = new System.Drawing.Size(75, 60);
            this.ptbBarVader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBarVader.TabIndex = 26;
            this.ptbBarVader.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lblNombreTitular);
            this.panel3.Controls.Add(this.dtCaducidadTarjeta);
            this.panel3.Controls.Add(this.txtApellidosReserva);
            this.panel3.Controls.Add(this.lblNumeroTarjeta);
            this.panel3.Controls.Add(this.txtNombreReserva);
            this.panel3.Controls.Add(this.lblFechaTarjeta);
            this.panel3.Location = new System.Drawing.Point(396, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 188);
            this.panel3.TabIndex = 57;
            // 
            // lblPagoEfectivo
            // 
            this.lblPagoEfectivo.AutoSize = true;
            this.lblPagoEfectivo.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoEfectivo.Location = new System.Drawing.Point(531, 58);
            this.lblPagoEfectivo.Name = "lblPagoEfectivo";
            this.lblPagoEfectivo.Size = new System.Drawing.Size(112, 43);
            this.lblPagoEfectivo.TabIndex = 58;
            this.lblPagoEfectivo.Text = "PAGO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(334, 47);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 404);
            this.panel4.TabIndex = 59;
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(66, 402);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(57, 22);
            this.lblAtras.TabIndex = 16;
            this.lblAtras.Text = "Atrás";
            // 
            // FormPagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblPagoEfectivo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagoTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPagoTarjeta";
            this.Load += new System.EventHandler(this.FormPagoTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFechaTarjeta;
        private System.Windows.Forms.TextBox txtApellidosReserva;
        private System.Windows.Forms.TextBox txtNombreReserva;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.DateTimePicker dtCaducidadTarjeta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecioAPagarEfectivo;
        private System.Windows.Forms.Label lblInformaPrecio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbBarVader;
        private System.Windows.Forms.Label lblPagoEfectivo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAtras;
    }
}