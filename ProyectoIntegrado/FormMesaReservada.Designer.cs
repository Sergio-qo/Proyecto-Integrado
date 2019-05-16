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
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblTituloReserva = new System.Windows.Forms.Label();
            this.grbReserva = new System.Windows.Forms.GroupBox();
            this.grbBarraInferior = new System.Windows.Forms.GroupBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblReservaDia = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNotificacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grbReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.grbBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDisponible.Image")));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(490, 535);
            this.btnSiguienteDisponible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(80, 58);
            this.btnSiguienteDisponible.TabIndex = 23;
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(596, 550);
            this.lblSalir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(56, 25);
            this.lblSalir.TabIndex = 24;
            this.lblSalir.Text = "Salir";
            // 
            // lblTituloReserva
            // 
            this.lblTituloReserva.AutoSize = true;
            this.lblTituloReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReserva.Location = new System.Drawing.Point(432, 88);
            this.lblTituloReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloReserva.Name = "lblTituloReserva";
            this.lblTituloReserva.Size = new System.Drawing.Size(331, 29);
            this.lblTituloReserva.TabIndex = 25;
            this.lblTituloReserva.Text = "Datos para la reserva mesa";
            // 
            // grbReserva
            // 
            this.grbReserva.Controls.Add(this.lblNotificacion);
            this.grbReserva.Controls.Add(this.lblCodigo);
            this.grbReserva.Controls.Add(this.lblReservaDia);
            this.grbReserva.Controls.Add(this.lblNombre);
            this.grbReserva.Controls.Add(this.lblMesa);
            this.grbReserva.Location = new System.Drawing.Point(301, 131);
            this.grbReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbReserva.Name = "grbReserva";
            this.grbReserva.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbReserva.Size = new System.Drawing.Size(556, 365);
            this.grbReserva.TabIndex = 22;
            this.grbReserva.TabStop = false;
            // 
            // grbBarraInferior
            // 
            this.grbBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraInferior.Location = new System.Drawing.Point(-2, 633);
            this.grbBarraInferior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBarraInferior.Name = "grbBarraInferior";
            this.grbBarraInferior.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBarraInferior.Size = new System.Drawing.Size(1171, 69);
            this.grbBarraInferior.TabIndex = 21;
            this.grbBarraInferior.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1138, 17);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(26, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1170, 17);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.TabStop = false;
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Controls.Add(this.btnMinimizar);
            this.grbBarraSuperior.Controls.Add(this.btnCerrar);
            this.grbBarraSuperior.Location = new System.Drawing.Point(-37, 1);
            this.grbBarraSuperior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBarraSuperior.Size = new System.Drawing.Size(1203, 66);
            this.grbBarraSuperior.TabIndex = 20;
            this.grbBarraSuperior.TabStop = false;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(111, 46);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(337, 29);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "Se ha reservado la mesa \'X\'";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(131, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(280, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "A nombre de: \'Nombre\'";
            // 
            // lblReservaDia
            // 
            this.lblReservaDia.AutoSize = true;
            this.lblReservaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservaDia.Location = new System.Drawing.Point(111, 167);
            this.lblReservaDia.Name = "lblReservaDia";
            this.lblReservaDia.Size = new System.Drawing.Size(353, 29);
            this.lblReservaDia.TabIndex = 2;
            this.lblReservaDia.Text = "Reserva para el \'dia\' de \'mes\'";
            this.lblReservaDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(69, 233);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(437, 29);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "El codigon de reserva es el: \'codigo\'";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacion.Location = new System.Drawing.Point(91, 288);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(373, 29);
            this.lblNotificacion.TabIndex = 4;
            this.lblNotificacion.Text = "Se enviara el codigo a tu email";
            this.lblNotificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMesaReservada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 699);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblTituloReserva);
            this.Controls.Add(this.grbReserva);
            this.Controls.Add(this.grbBarraInferior);
            this.Controls.Add(this.grbBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMesaReservada";
            this.Text = "FormMesaReservada";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grbReserva.ResumeLayout(false);
            this.grbReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.grbBarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblTituloReserva;
        private System.Windows.Forms.GroupBox grbReserva;
        private System.Windows.Forms.GroupBox grbBarraInferior;
        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblReservaDia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMesa;
    }
}