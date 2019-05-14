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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoTarjeta));
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.lblAtras = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.grpBarraInferior = new System.Windows.Forms.GroupBox();
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbPagoTarjeta = new System.Windows.Forms.GroupBox();
            this.txtApellidosReserva = new System.Windows.Forms.TextBox();
            this.txtNombreReserva = new System.Windows.Forms.TextBox();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.lblFechaTarjeta = new System.Windows.Forms.Label();
            this.dtCaducidadTarjeta = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTituloPago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.grbBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbPagoTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(13, 47);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 44;
            this.pcbCarrito.TabStop = false;
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Location = new System.Drawing.Point(81, 372);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(31, 13);
            this.lblAtras.TabIndex = 42;
            this.lblAtras.Text = "Atras";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(13, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(540, 301);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(148, 23);
            this.btnPagar.TabIndex = 32;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // grpBarraInferior
            // 
            this.grpBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpBarraInferior.Location = new System.Drawing.Point(0, 410);
            this.grpBarraInferior.Name = "grpBarraInferior";
            this.grpBarraInferior.Size = new System.Drawing.Size(802, 41);
            this.grpBarraInferior.TabIndex = 27;
            this.grpBarraInferior.TabStop = false;
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Controls.Add(this.btnMinimizar);
            this.grbBarraSuperior.Controls.Add(this.btnCerrar);
            this.grbBarraSuperior.Location = new System.Drawing.Point(-1, 0);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraSuperior.TabIndex = 26;
            this.grbBarraSuperior.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(340, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 388);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 221);
            this.dataGridView1.TabIndex = 41;
            // 
            // grbPagoTarjeta
            // 
            this.grbPagoTarjeta.Controls.Add(this.dtCaducidadTarjeta);
            this.grbPagoTarjeta.Controls.Add(this.lblFechaTarjeta);
            this.grbPagoTarjeta.Controls.Add(this.txtApellidosReserva);
            this.grbPagoTarjeta.Controls.Add(this.txtNombreReserva);
            this.grbPagoTarjeta.Controls.Add(this.lblNumeroTarjeta);
            this.grbPagoTarjeta.Controls.Add(this.lblNombreTitular);
            this.grbPagoTarjeta.Location = new System.Drawing.Point(464, 80);
            this.grbPagoTarjeta.Name = "grbPagoTarjeta";
            this.grbPagoTarjeta.Size = new System.Drawing.Size(288, 167);
            this.grbPagoTarjeta.TabIndex = 45;
            this.grbPagoTarjeta.TabStop = false;
            // 
            // txtApellidosReserva
            // 
            this.txtApellidosReserva.Location = new System.Drawing.Point(170, 48);
            this.txtApellidosReserva.Name = "txtApellidosReserva";
            this.txtApellidosReserva.Size = new System.Drawing.Size(102, 20);
            this.txtApellidosReserva.TabIndex = 14;
            // 
            // txtNombreReserva
            // 
            this.txtNombreReserva.Location = new System.Drawing.Point(170, 19);
            this.txtNombreReserva.Name = "txtNombreReserva";
            this.txtNombreReserva.Size = new System.Drawing.Size(102, 20);
            this.txtNombreReserva.TabIndex = 13;
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(6, 52);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(120, 16);
            this.lblNumeroTarjeta.TabIndex = 12;
            this.lblNumeroTarjeta.Text = "Número Tarjeta:";
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTitular.Location = new System.Drawing.Point(6, 23);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(115, 16);
            this.lblNombreTitular.TabIndex = 11;
            this.lblNombreTitular.Text = "Nombre Titular:";
            // 
            // lblFechaTarjeta
            // 
            this.lblFechaTarjeta.AutoSize = true;
            this.lblFechaTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTarjeta.Location = new System.Drawing.Point(6, 83);
            this.lblFechaTarjeta.Name = "lblFechaTarjeta";
            this.lblFechaTarjeta.Size = new System.Drawing.Size(134, 16);
            this.lblFechaTarjeta.TabIndex = 15;
            this.lblFechaTarjeta.Text = "Fecha Caducidad:";
            // 
            // dtCaducidadTarjeta
            // 
            this.dtCaducidadTarjeta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCaducidadTarjeta.Location = new System.Drawing.Point(170, 79);
            this.dtCaducidadTarjeta.Name = "dtCaducidadTarjeta";
            this.dtCaducidadTarjeta.Size = new System.Drawing.Size(102, 20);
            this.dtCaducidadTarjeta.TabIndex = 16;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(780, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 46;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(759, 11);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(17, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 46;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTituloPago
            // 
            this.lblTituloPago.AutoSize = true;
            this.lblTituloPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPago.Location = new System.Drawing.Point(545, 57);
            this.lblTituloPago.Name = "lblTituloPago";
            this.lblTituloPago.Size = new System.Drawing.Size(59, 20);
            this.lblTituloPago.TabIndex = 17;
            this.lblTituloPago.Text = "PAGO";
            // 
            // FormPagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituloPago);
            this.Controls.Add(this.grbPagoTarjeta);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.grpBarraInferior);
            this.Controls.Add(this.grbBarraSuperior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagoTarjeta";
            this.Text = "FormPagoTarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.grbBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbPagoTarjeta.ResumeLayout(false);
            this.grbPagoTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox grpBarraInferior;
        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbPagoTarjeta;
        private System.Windows.Forms.Label lblFechaTarjeta;
        private System.Windows.Forms.TextBox txtApellidosReserva;
        private System.Windows.Forms.TextBox txtNombreReserva;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.DateTimePicker dtCaducidadTarjeta;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblTituloPago;
    }
}