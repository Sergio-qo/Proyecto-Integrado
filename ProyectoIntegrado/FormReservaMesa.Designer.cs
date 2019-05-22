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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservaMesa));
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
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.btnSiguienteDisponible = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbBarVader = new System.Windows.Forms.PictureBox();
            this.lblTituloReserva = new System.Windows.Forms.Label();
            this.lblAtras = new System.Windows.Forms.Label();
            this.grbReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).BeginInit();
            this.SuspendLayout();
            // 
            // grbReserva
            // 
            this.grbReserva.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.grbReserva.Location = new System.Drawing.Point(215, 128);
            this.grbReserva.Name = "grbReserva";
            this.grbReserva.Size = new System.Drawing.Size(326, 264);
            this.grbReserva.TabIndex = 4;
            this.grbReserva.TabStop = false;
            // 
            // txtNumeroComensales
            // 
            this.txtNumeroComensales.Location = new System.Drawing.Point(176, 142);
            this.txtNumeroComensales.Multiline = true;
            this.txtNumeroComensales.Name = "txtNumeroComensales";
            this.txtNumeroComensales.Size = new System.Drawing.Size(124, 22);
            this.txtNumeroComensales.TabIndex = 4;
            // 
            // txtEmailReserva
            // 
            this.txtEmailReserva.Location = new System.Drawing.Point(176, 104);
            this.txtEmailReserva.Multiline = true;
            this.txtEmailReserva.Name = "txtEmailReserva";
            this.txtEmailReserva.Size = new System.Drawing.Size(124, 23);
            this.txtEmailReserva.TabIndex = 3;
            // 
            // txtApellidosReserva
            // 
            this.txtApellidosReserva.Location = new System.Drawing.Point(176, 62);
            this.txtApellidosReserva.Multiline = true;
            this.txtApellidosReserva.Name = "txtApellidosReserva";
            this.txtApellidosReserva.Size = new System.Drawing.Size(124, 23);
            this.txtApellidosReserva.TabIndex = 2;
            // 
            // txtNombreReserva
            // 
            this.txtNombreReserva.Location = new System.Drawing.Point(176, 19);
            this.txtNombreReserva.Multiline = true;
            this.txtNombreReserva.Name = "txtNombreReserva";
            this.txtNombreReserva.Size = new System.Drawing.Size(124, 24);
            this.txtNombreReserva.TabIndex = 1;
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
            this.cmbHoraReserva.Location = new System.Drawing.Point(176, 220);
            this.cmbHoraReserva.Name = "cmbHoraReserva";
            this.cmbHoraReserva.Size = new System.Drawing.Size(124, 21);
            this.cmbHoraReserva.TabIndex = 6;
            // 
            // lblHoraReserva
            // 
            this.lblHoraReserva.AutoSize = true;
            this.lblHoraReserva.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraReserva.Location = new System.Drawing.Point(19, 220);
            this.lblHoraReserva.Name = "lblHoraReserva";
            this.lblHoraReserva.Size = new System.Drawing.Size(59, 22);
            this.lblHoraReserva.TabIndex = 7;
            this.lblHoraReserva.Text = "Hora:";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.Location = new System.Drawing.Point(20, 181);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(44, 22);
            this.lblFechaReserva.TabIndex = 6;
            this.lblFechaReserva.Text = "Día:";
            // 
            // dtDiaReserva
            // 
            this.dtDiaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiaReserva.Location = new System.Drawing.Point(176, 181);
            this.dtDiaReserva.Name = "dtDiaReserva";
            this.dtDiaReserva.Size = new System.Drawing.Size(124, 20);
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
            this.lblNumeroComensalesReserva.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComensalesReserva.Location = new System.Drawing.Point(19, 142);
            this.lblNumeroComensalesReserva.Name = "lblNumeroComensalesReserva";
            this.lblNumeroComensalesReserva.Size = new System.Drawing.Size(144, 22);
            this.lblNumeroComensalesReserva.TabIndex = 3;
            this.lblNumeroComensalesReserva.Text = "Nº Comensales:";
            // 
            // lblCorreoReserva
            // 
            this.lblCorreoReserva.AutoSize = true;
            this.lblCorreoReserva.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoReserva.Location = new System.Drawing.Point(20, 104);
            this.lblCorreoReserva.Name = "lblCorreoReserva";
            this.lblCorreoReserva.Size = new System.Drawing.Size(71, 22);
            this.lblCorreoReserva.TabIndex = 2;
            this.lblCorreoReserva.Text = "E-mail:";
            // 
            // lblApellidoReserva
            // 
            this.lblApellidoReserva.AutoSize = true;
            this.lblApellidoReserva.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoReserva.Location = new System.Drawing.Point(20, 62);
            this.lblApellidoReserva.Name = "lblApellidoReserva";
            this.lblApellidoReserva.Size = new System.Drawing.Size(97, 22);
            this.lblApellidoReserva.TabIndex = 1;
            this.lblApellidoReserva.Text = "Apellidos:";
            // 
            // lblNombreReserva
            // 
            this.lblNombreReserva.AutoSize = true;
            this.lblNombreReserva.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreReserva.Location = new System.Drawing.Point(20, 19);
            this.lblNombreReserva.Name = "lblNombreReserva";
            this.lblNombreReserva.Size = new System.Drawing.Size(86, 22);
            this.lblNombreReserva.TabIndex = 0;
            this.lblNombreReserva.Text = "Nombre:";
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiguiente.Location = new System.Drawing.Point(514, 399);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(205, 22);
            this.lblSiguiente.TabIndex = 13;
            this.lblSiguiente.Text = "Siguiente (Disponible)";
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDisponible.Image")));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(723, 395);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(46, 36);
            this.btnSiguienteDisponible.TabIndex = 7;
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            this.btnSiguienteDisponible.Click += new System.EventHandler(this.btnSiguienteDisponible_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(21, 395);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(51, 37);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.ptbBarVader);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 58);
            this.panel1.TabIndex = 25;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(775, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(753, 8);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(17, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 27;
            this.btnMinimizar.TabStop = false;
            // 
            // ptbBarVader
            // 
            this.ptbBarVader.Image = ((System.Drawing.Image)(resources.GetObject("ptbBarVader.Image")));
            this.ptbBarVader.Location = new System.Drawing.Point(2, 0);
            this.ptbBarVader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbBarVader.Name = "ptbBarVader";
            this.ptbBarVader.Size = new System.Drawing.Size(75, 58);
            this.ptbBarVader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBarVader.TabIndex = 26;
            this.ptbBarVader.TabStop = false;
            // 
            // lblTituloReserva
            // 
            this.lblTituloReserva.AutoSize = true;
            this.lblTituloReserva.Font = new System.Drawing.Font("Britannic Bold", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReserva.Location = new System.Drawing.Point(143, 76);
            this.lblTituloReserva.Name = "lblTituloReserva";
            this.lblTituloReserva.Size = new System.Drawing.Size(499, 38);
            this.lblTituloReserva.TabIndex = 9;
            this.lblTituloReserva.Text = "DATOS PARA LA RESERVA MESA";
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(77, 399);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(57, 22);
            this.lblAtras.TabIndex = 26;
            this.lblAtras.Text = "Atrás";
            // 
            // FormReservaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.lblTituloReserva);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.lblSiguiente);
            this.Controls.Add(this.grbReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservaMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva mesa";
            this.Load += new System.EventHandler(this.FormReservaMesa_Load);
            this.grbReserva.ResumeLayout(false);
            this.grbReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloReserva;
        private System.Windows.Forms.PictureBox ptbBarVader;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}