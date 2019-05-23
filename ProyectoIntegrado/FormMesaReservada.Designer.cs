namespace ProyectoIntegrado
{
    partial class FormMesaReservada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMesaReservada));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSiguienteDisponible = new System.Windows.Forms.Button();
            this.lblTituloReserva = new System.Windows.Forms.Label();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblReservaDia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbBarVader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(188, 393);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(94, 38);
            this.btnSiguienteDisponible.TabIndex = 23;
            this.btnSiguienteDisponible.Text = "SALIR";
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            this.btnSiguienteDisponible.Click += new System.EventHandler(this.BtnSiguienteDisponible_Click);
            // 
            // lblTituloReserva
            // 
            this.lblTituloReserva.AutoSize = true;
            this.lblTituloReserva.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReserva.Location = new System.Drawing.Point(81, 65);
            this.lblTituloReserva.Name = "lblTituloReserva";
            this.lblTituloReserva.Size = new System.Drawing.Size(619, 57);
            this.lblTituloReserva.TabIndex = 25;
            this.lblTituloReserva.Text = "Datos para la reserva mesa";
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacion.Location = new System.Drawing.Point(39, 172);
            this.lblNotificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(280, 57);
            this.lblNotificacion.TabIndex = 4;
            this.lblNotificacion.Text = "BAR VADER";
            this.lblNotificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(67, 132);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(202, 25);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Gracias por utilizar";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReservaDia
            // 
            this.lblReservaDia.AutoSize = true;
            this.lblReservaDia.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservaDia.Location = new System.Drawing.Point(51, 60);
            this.lblReservaDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReservaDia.Name = "lblReservaDia";
            this.lblReservaDia.Size = new System.Drawing.Size(244, 25);
            this.lblReservaDia.TabIndex = 2;
            this.lblReservaDia.Text = "confirmando tu reserva";
            this.lblReservaDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReservaDia.Click += new System.EventHandler(this.lblReservaDia_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 23);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(328, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Se enviará un correo electrónico";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblReservaDia);
            this.panel1.Controls.Add(this.lblNotificacion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(41, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 253);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "-----------------------------------";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.ptbBarVader);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 63);
            this.panel2.TabIndex = 60;
            // 
            // ptbBarVader
            // 
            this.ptbBarVader.Image = ((System.Drawing.Image)(resources.GetObject("ptbBarVader.Image")));
            this.ptbBarVader.Location = new System.Drawing.Point(2, 0);
            this.ptbBarVader.Margin = new System.Windows.Forms.Padding(2);
            this.ptbBarVader.Name = "ptbBarVader";
            this.ptbBarVader.Size = new System.Drawing.Size(75, 58);
            this.ptbBarVader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBarVader.TabIndex = 26;
            this.ptbBarVader.TabStop = false;
            // 
            // FormMesaReservada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.lblTituloReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMesaReservada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMesaReservada";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.Label lblTituloReserva;
        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblReservaDia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbBarVader;
    }
}