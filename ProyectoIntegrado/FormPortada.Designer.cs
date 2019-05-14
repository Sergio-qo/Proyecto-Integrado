namespace ProyectoIntegrado
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.pcbPortada = new System.Windows.Forms.PictureBox();
            this.grbBarraInferior = new System.Windows.Forms.GroupBox();
            this.lblTituloReserva = new System.Windows.Forms.Label();
            this.lblTituloComida = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.grbBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Controls.Add(this.btnMinimizar);
            this.grbBarraSuperior.Controls.Add(this.btnCerrar);
            this.grbBarraSuperior.Location = new System.Drawing.Point(-2, 0);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraSuperior.TabIndex = 0;
            this.grbBarraSuperior.TabStop = false;
            // 
            // btnReserva
            // 
            this.btnReserva.AutoSize = true;
            this.btnReserva.BackColor = System.Drawing.Color.White;
            this.btnReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnReserva.Image")));
            this.btnReserva.Location = new System.Drawing.Point(234, 260);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(134, 134);
            this.btnReserva.TabIndex = 2;
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.AutoSize = true;
            this.btnPedidos.BackColor = System.Drawing.Color.White;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.Location = new System.Drawing.Point(405, 260);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(134, 134);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.AutoSize = true;
            this.btnAjustes.BackColor = System.Drawing.Color.White;
            this.btnAjustes.Image = ((System.Drawing.Image)(resources.GetObject("btnAjustes.Image")));
            this.btnAjustes.Location = new System.Drawing.Point(12, 47);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(59, 59);
            this.btnAjustes.TabIndex = 4;
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // pcbPortada
            // 
            this.pcbPortada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbPortada.BackgroundImage")));
            this.pcbPortada.Location = new System.Drawing.Point(119, 41);
            this.pcbPortada.Name = "pcbPortada";
            this.pcbPortada.Size = new System.Drawing.Size(564, 180);
            this.pcbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPortada.TabIndex = 5;
            this.pcbPortada.TabStop = false;
            // 
            // grbBarraInferior
            // 
            this.grbBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraInferior.Location = new System.Drawing.Point(-2, 409);
            this.grbBarraInferior.Name = "grbBarraInferior";
            this.grbBarraInferior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraInferior.TabIndex = 1;
            this.grbBarraInferior.TabStop = false;
            // 
            // lblTituloReserva
            // 
            this.lblTituloReserva.AutoSize = true;
            this.lblTituloReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReserva.Location = new System.Drawing.Point(253, 239);
            this.lblTituloReserva.Name = "lblTituloReserva";
            this.lblTituloReserva.Size = new System.Drawing.Size(96, 18);
            this.lblTituloReserva.TabIndex = 6;
            this.lblTituloReserva.Text = "RESERVAS";
            // 
            // lblTituloComida
            // 
            this.lblTituloComida.AutoSize = true;
            this.lblTituloComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloComida.Location = new System.Drawing.Point(423, 239);
            this.lblTituloComida.Name = "lblTituloComida";
            this.lblTituloComida.Size = new System.Drawing.Size(84, 18);
            this.lblTituloComida.TabIndex = 7;
            this.lblTituloComida.Text = "COMIDAS";
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
            this.btnCerrar.TabIndex = 8;
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
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituloComida);
            this.Controls.Add(this.lblTituloReserva);
            this.Controls.Add(this.grbBarraInferior);
            this.Controls.Add(this.pcbPortada);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.grbBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarVeider";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.grbBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.PictureBox pcbPortada;
        private System.Windows.Forms.GroupBox grbBarraInferior;
        private System.Windows.Forms.Label lblTituloReserva;
        private System.Windows.Forms.Label lblTituloComida;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}

