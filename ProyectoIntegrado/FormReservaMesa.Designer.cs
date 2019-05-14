namespace ProyectoIntegrado
{
    partial class FormReservaMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservaMesa));
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.grbBarraInferior = new System.Windows.Forms.GroupBox();
            this.grbReserva = new System.Windows.Forms.GroupBox();
            this.txtNumeroComensales = new System.Windows.Forms.TextBox();
            this.txtEmailReserva = new System.Windows.Forms.TextBox();
            this.txtApellidosReserva = new System.Windows.Forms.TextBox();
            this.txtNombreReserva = new System.Windows.Forms.TextBox();
            this.cmbHoraReserva = new System.Windows.Forms.ComboBox();
            this.lblHoraReserva = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtDiaReserva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroComensalesReserva = new System.Windows.Forms.Label();
            this.lblCorreoReserva = new System.Windows.Forms.Label();
            this.lblApellidoReserva = new System.Windows.Forms.Label();
            this.lblNombreReserva = new System.Windows.Forms.Label();
            this.lblTituloReserva = new System.Windows.Forms.Label();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.btnSiguienteDisponible = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.grbReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Location = new System.Drawing.Point(-1, 0);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraSuperior.TabIndex = 2;
            this.grbBarraSuperior.TabStop = false;
            // 
            // grbBarraInferior
            // 
            this.grbBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraInferior.Location = new System.Drawing.Point(-1, 409);
            this.grbBarraInferior.Name = "grbBarraInferior";
            this.grbBarraInferior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraInferior.TabIndex = 3;
            this.grbBarraInferior.TabStop = false;
            // 
            // grbReserva
            // 
            this.grbReserva.Controls.Add(this.txtNumeroComensales);
            this.grbReserva.Controls.Add(this.txtEmailReserva);
            this.grbReserva.Controls.Add(this.txtApellidosReserva);
            this.grbReserva.Controls.Add(this.txtNombreReserva);
            this.grbReserva.Controls.Add(this.cmbHoraReserva);
            this.grbReserva.Controls.Add(this.lblHoraReserva);
            this.grbReserva.Controls.Add(this.lblFechaReserva);
            this.grbReserva.Controls.Add(this.dtDiaReserva);
            this.grbReserva.Controls.Add(this.label1);
            this.grbReserva.Controls.Add(this.lblNumeroComensalesReserva);
            this.grbReserva.Controls.Add(this.lblCorreoReserva);
            this.grbReserva.Controls.Add(this.lblApellidoReserva);
            this.grbReserva.Controls.Add(this.lblNombreReserva);
            this.grbReserva.Location = new System.Drawing.Point(229, 81);
            this.grbReserva.Name = "grbReserva";
            this.grbReserva.Size = new System.Drawing.Size(301, 235);
            this.grbReserva.TabIndex = 4;
            this.grbReserva.TabStop = false;
            // 
            // txtNumeroComensales
            // 
            this.txtNumeroComensales.Location = new System.Drawing.Point(154, 109);
            this.txtNumeroComensales.Name = "txtNumeroComensales";
            this.txtNumeroComensales.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroComensales.TabIndex = 12;
            // 
            // txtEmailReserva
            // 
            this.txtEmailReserva.Location = new System.Drawing.Point(154, 77);
            this.txtEmailReserva.Name = "txtEmailReserva";
            this.txtEmailReserva.Size = new System.Drawing.Size(100, 20);
            this.txtEmailReserva.TabIndex = 11;
            // 
            // txtApellidosReserva
            // 
            this.txtApellidosReserva.Location = new System.Drawing.Point(154, 45);
            this.txtApellidosReserva.Name = "txtApellidosReserva";
            this.txtApellidosReserva.Size = new System.Drawing.Size(100, 20);
            this.txtApellidosReserva.TabIndex = 10;
            // 
            // txtNombreReserva
            // 
            this.txtNombreReserva.Location = new System.Drawing.Point(154, 15);
            this.txtNombreReserva.Name = "txtNombreReserva";
            this.txtNombreReserva.Size = new System.Drawing.Size(100, 20);
            this.txtNombreReserva.TabIndex = 9;
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
            this.cmbHoraReserva.Location = new System.Drawing.Point(154, 183);
            this.cmbHoraReserva.Name = "cmbHoraReserva";
            this.cmbHoraReserva.Size = new System.Drawing.Size(102, 21);
            this.cmbHoraReserva.TabIndex = 8;
            // 
            // lblHoraReserva
            // 
            this.lblHoraReserva.AutoSize = true;
            this.lblHoraReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraReserva.Location = new System.Drawing.Point(20, 183);
            this.lblHoraReserva.Name = "lblHoraReserva";
            this.lblHoraReserva.Size = new System.Drawing.Size(46, 16);
            this.lblHoraReserva.TabIndex = 7;
            this.lblHoraReserva.Text = "Hora:";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.Location = new System.Drawing.Point(20, 146);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(36, 16);
            this.lblFechaReserva.TabIndex = 6;
            this.lblFechaReserva.Text = "Día:";
            // 
            // dtDiaReserva
            // 
            this.dtDiaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiaReserva.Location = new System.Drawing.Point(154, 146);
            this.dtDiaReserva.Name = "dtDiaReserva";
            this.dtDiaReserva.Size = new System.Drawing.Size(102, 20);
            this.dtDiaReserva.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // lblNumeroComensalesReserva
            // 
            this.lblNumeroComensalesReserva.AutoSize = true;
            this.lblNumeroComensalesReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComensalesReserva.Location = new System.Drawing.Point(20, 113);
            this.lblNumeroComensalesReserva.Name = "lblNumeroComensalesReserva";
            this.lblNumeroComensalesReserva.Size = new System.Drawing.Size(119, 16);
            this.lblNumeroComensalesReserva.TabIndex = 3;
            this.lblNumeroComensalesReserva.Text = "Nº Comensales:";
            // 
            // lblCorreoReserva
            // 
            this.lblCorreoReserva.AutoSize = true;
            this.lblCorreoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoReserva.Location = new System.Drawing.Point(20, 81);
            this.lblCorreoReserva.Name = "lblCorreoReserva";
            this.lblCorreoReserva.Size = new System.Drawing.Size(56, 16);
            this.lblCorreoReserva.TabIndex = 2;
            this.lblCorreoReserva.Text = "E-mail:";
            // 
            // lblApellidoReserva
            // 
            this.lblApellidoReserva.AutoSize = true;
            this.lblApellidoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoReserva.Location = new System.Drawing.Point(20, 49);
            this.lblApellidoReserva.Name = "lblApellidoReserva";
            this.lblApellidoReserva.Size = new System.Drawing.Size(78, 16);
            this.lblApellidoReserva.TabIndex = 1;
            this.lblApellidoReserva.Text = "Apellidos:";
            // 
            // lblNombreReserva
            // 
            this.lblNombreReserva.AutoSize = true;
            this.lblNombreReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreReserva.Location = new System.Drawing.Point(20, 20);
            this.lblNombreReserva.Name = "lblNombreReserva";
            this.lblNombreReserva.Size = new System.Drawing.Size(67, 16);
            this.lblNombreReserva.TabIndex = 0;
            this.lblNombreReserva.Text = "Nombre:";
            // 
            // lblTituloReserva
            // 
            this.lblTituloReserva.AutoSize = true;
            this.lblTituloReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReserva.Location = new System.Drawing.Point(302, 44);
            this.lblTituloReserva.Name = "lblTituloReserva";
            this.lblTituloReserva.Size = new System.Drawing.Size(181, 20);
            this.lblTituloReserva.TabIndex = 13;
            this.lblTituloReserva.Text = "Datos para la reserva";
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiguiente.Location = new System.Drawing.Point(317, 367);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(162, 16);
            this.lblSiguiente.TabIndex = 13;
            this.lblSiguiente.Text = "Siguiente (Disponible)";
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDisponible.Image")));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(252, 345);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(53, 38);
            this.btnSiguienteDisponible.TabIndex = 15;
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(71, 376);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(44, 16);
            this.lblAtras.TabIndex = 18;
            this.lblAtras.Text = "Atrás";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(-1, 365);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(62, 38);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormReservaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.lblSiguiente);
            this.Controls.Add(this.lblTituloReserva);
            this.Controls.Add(this.grbReserva);
            this.Controls.Add(this.grbBarraInferior);
            this.Controls.Add(this.grbBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservaMesa";
            this.Text = "FormReservas";
            this.grbReserva.ResumeLayout(false);
            this.grbReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.GroupBox grbBarraInferior;
        private System.Windows.Forms.GroupBox grbReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroComensalesReserva;
        private System.Windows.Forms.Label lblCorreoReserva;
        private System.Windows.Forms.Label lblApellidoReserva;
        private System.Windows.Forms.Label lblNombreReserva;
        private System.Windows.Forms.Label lblHoraReserva;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtDiaReserva;
        private System.Windows.Forms.ComboBox cmbHoraReserva;
        private System.Windows.Forms.TextBox txtNumeroComensales;
        private System.Windows.Forms.TextBox txtEmailReserva;
        private System.Windows.Forms.TextBox txtApellidosReserva;
        private System.Windows.Forms.TextBox txtNombreReserva;
        private System.Windows.Forms.Label lblTituloReserva;
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Button btnAtras;
    }
}