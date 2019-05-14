namespace ProyectoIntegrado
{
    partial class FormPagoReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoReserva));
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBarraInferior = new System.Windows.Forms.GroupBox();
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.grbNombreApellido = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnSiguienteDisponible = new System.Windows.Forms.Button();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.cmbHoraReserva = new System.Windows.Forms.ComboBox();
            this.txtNombreRserva = new System.Windows.Forms.TextBox();
            this.txtApellidoReserva = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.grbBarraSuperior.SuspendLayout();
            this.grbNombreApellido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(13, 104);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(148, 135);
            this.dgvItems.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(167, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 387);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // grpBarraInferior
            // 
            this.grpBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpBarraInferior.Location = new System.Drawing.Point(-1, 409);
            this.grpBarraInferior.Name = "grpBarraInferior";
            this.grpBarraInferior.Size = new System.Drawing.Size(802, 41);
            this.grpBarraInferior.TabIndex = 22;
            this.grpBarraInferior.TabStop = false;
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Controls.Add(this.btnCerrar);
            this.grbBarraSuperior.Controls.Add(this.btnMinimizar);
            this.grbBarraSuperior.Location = new System.Drawing.Point(-1, 1);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraSuperior.TabIndex = 21;
            this.grbBarraSuperior.TabStop = false;
            // 
            // grbNombreApellido
            // 
            this.grbNombreApellido.Controls.Add(this.txtApellidoReserva);
            this.grbNombreApellido.Controls.Add(this.txtNombreRserva);
            this.grbNombreApellido.Controls.Add(this.cmbHoraReserva);
            this.grbNombreApellido.Controls.Add(this.lblHora);
            this.grbNombreApellido.Controls.Add(this.lblApellido);
            this.grbNombreApellido.Controls.Add(this.lblNombre);
            this.grbNombreApellido.Location = new System.Drawing.Point(385, 127);
            this.grbNombreApellido.Name = "grbNombreApellido";
            this.grbNombreApellido.Size = new System.Drawing.Size(213, 160);
            this.grbNombreApellido.TabIndex = 27;
            this.grbNombreApellido.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 47);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 16);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(6, 81);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(46, 16);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora:";
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDisponible.Image")));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(372, 353);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(53, 38);
            this.btnSiguienteDisponible.TabIndex = 29;
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiguiente.Location = new System.Drawing.Point(437, 375);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(162, 16);
            this.lblSiguiente.TabIndex = 28;
            this.lblSiguiente.Text = "Siguiente (Disponible)";
            // 
            // cmbHoraReserva
            // 
            this.cmbHoraReserva.FormattingEnabled = true;
            this.cmbHoraReserva.Items.AddRange(new object[] {
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00"});
            this.cmbHoraReserva.Location = new System.Drawing.Point(105, 81);
            this.cmbHoraReserva.Name = "cmbHoraReserva";
            this.cmbHoraReserva.Size = new System.Drawing.Size(102, 21);
            this.cmbHoraReserva.TabIndex = 9;
            // 
            // txtNombreRserva
            // 
            this.txtNombreRserva.Location = new System.Drawing.Point(105, 16);
            this.txtNombreRserva.Name = "txtNombreRserva";
            this.txtNombreRserva.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRserva.TabIndex = 10;
            // 
            // txtApellidoReserva
            // 
            this.txtApellidoReserva.Location = new System.Drawing.Point(105, 47);
            this.txtApellidoReserva.Name = "txtApellidoReserva";
            this.txtApellidoReserva.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoReserva.TabIndex = 11;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(-1, 365);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(62, 38);
            this.btnAtras.TabIndex = 31;
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(71, 376);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(44, 16);
            this.lblAtras.TabIndex = 30;
            this.lblAtras.Text = "Atrás";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(759, 10);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(17, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 32;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(780, 10);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(13, 48);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 32;
            this.pcbCarrito.TabStop = false;
            // 
            // FormPagoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.lblSiguiente);
            this.Controls.Add(this.grbNombreApellido);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.grpBarraInferior);
            this.Controls.Add(this.grbBarraSuperior);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagoReserva";
            this.Text = "FormPagoReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.grbBarraSuperior.ResumeLayout(false);
            this.grbNombreApellido.ResumeLayout(false);
            this.grbNombreApellido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBarraInferior;
        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.GroupBox grbNombreApellido;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.ComboBox cmbHoraReserva;
        private System.Windows.Forms.TextBox txtApellidoReserva;
        private System.Windows.Forms.TextBox txtNombreRserva;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pcbCarrito;
    }
}