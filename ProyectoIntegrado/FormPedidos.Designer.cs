namespace ProyectoIntegrado
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.grbBarraInferior = new System.Windows.Forms.GroupBox();
            this.grbMenuLateral = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.Label();
            this.lblFinalizar = new System.Windows.Forms.Label();
            this.grbMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Location = new System.Drawing.Point(-1, 0);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraSuperior.TabIndex = 1;
            this.grbBarraSuperior.TabStop = false;
            // 
            // grbBarraInferior
            // 
            this.grbBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraInferior.Location = new System.Drawing.Point(-1, 409);
            this.grbBarraInferior.Name = "grbBarraInferior";
            this.grbBarraInferior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraInferior.TabIndex = 2;
            this.grbBarraInferior.TabStop = false;
            // 
            // grbMenuLateral
            // 
            this.grbMenuLateral.Controls.Add(this.btnAtras);
            this.grbMenuLateral.Controls.Add(this.pcbCarrito);
            this.grbMenuLateral.Controls.Add(this.btnCarrito);
            this.grbMenuLateral.Controls.Add(this.lblAtras);
            this.grbMenuLateral.Controls.Add(this.lblFinalizar);
            this.grbMenuLateral.Location = new System.Drawing.Point(-1, 48);
            this.grbMenuLateral.Name = "grbMenuLateral";
            this.grbMenuLateral.Size = new System.Drawing.Size(204, 355);
            this.grbMenuLateral.TabIndex = 3;
            this.grbMenuLateral.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(6, 311);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(62, 38);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(6, 19);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 16;
            this.pcbCarrito.TabStop = false;
            // 
            // btnCarrito
            // 
            this.btnCarrito.AutoSize = true;
            this.btnCarrito.BackColor = System.Drawing.Color.White;
            this.btnCarrito.Image = ((System.Drawing.Image)(resources.GetObject("btnCarrito.Image")));
            this.btnCarrito.Location = new System.Drawing.Point(9, 235);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(59, 59);
            this.btnCarrito.TabIndex = 5;
            this.btnCarrito.UseVisualStyleBackColor = false;
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(83, 322);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(44, 16);
            this.lblAtras.TabIndex = 15;
            this.lblAtras.Text = "Atrás";
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizar.Location = new System.Drawing.Point(83, 256);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(67, 16);
            this.lblFinalizar.TabIndex = 14;
            this.lblFinalizar.Text = "Finalizar";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbMenuLateral);
            this.Controls.Add(this.grbBarraInferior);
            this.Controls.Add(this.grbBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedidos";
            this.grbMenuLateral.ResumeLayout(false);
            this.grbMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.GroupBox grbBarraInferior;
        private System.Windows.Forms.GroupBox grbMenuLateral;
        private System.Windows.Forms.Label lblFinalizar;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Button btnAtras;
    }
}