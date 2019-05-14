namespace ProyectoIntegrado
{
    partial class FormIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIdioma));
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.grbBarraInferior = new System.Windows.Forms.GroupBox();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.rdbSpanish = new System.Windows.Forms.RadioButton();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.Label();
            this.btnAceptarIdioma = new System.Windows.Forms.Button();
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
            // lblAjustes
            // 
            this.lblAjustes.AutoSize = true;
            this.lblAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjustes.Location = new System.Drawing.Point(312, 68);
            this.lblAjustes.Name = "lblAjustes";
            this.lblAjustes.Size = new System.Drawing.Size(128, 29);
            this.lblAjustes.TabIndex = 3;
            this.lblAjustes.Text = "AJUSTES";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(335, 156);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(60, 16);
            this.lblIdioma.TabIndex = 5;
            this.lblIdioma.Text = "IDIOMA";
            // 
            // rdbSpanish
            // 
            this.rdbSpanish.AutoSize = true;
            this.rdbSpanish.Checked = true;
            this.rdbSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSpanish.Location = new System.Drawing.Point(338, 205);
            this.rdbSpanish.Name = "rdbSpanish";
            this.rdbSpanish.Size = new System.Drawing.Size(85, 24);
            this.rdbSpanish.TabIndex = 6;
            this.rdbSpanish.TabStop = true;
            this.rdbSpanish.Text = "Español";
            this.rdbSpanish.UseVisualStyleBackColor = true;
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.AutoSize = true;
            this.rdbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnglish.Location = new System.Drawing.Point(338, 246);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(70, 24);
            this.rdbEnglish.TabIndex = 7;
            this.rdbEnglish.Text = "Inglés";
            this.rdbEnglish.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(12, 356);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(62, 38);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(89, 367);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(44, 16);
            this.lblAtras.TabIndex = 19;
            this.lblAtras.Text = "Atrás";
            // 
            // btnAceptarIdioma
            // 
            this.btnAceptarIdioma.Location = new System.Drawing.Point(338, 317);
            this.btnAceptarIdioma.Name = "btnAceptarIdioma";
            this.btnAceptarIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarIdioma.TabIndex = 21;
            this.btnAceptarIdioma.Text = "Cambiar";
            this.btnAceptarIdioma.UseVisualStyleBackColor = true;
            this.btnAceptarIdioma.Click += new System.EventHandler(this.btnAceptarIdioma_Click);
            // 
            // FormIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptarIdioma);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.rdbEnglish);
            this.Controls.Add(this.rdbSpanish);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblAjustes);
            this.Controls.Add(this.grbBarraInferior);
            this.Controls.Add(this.grbBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIdioma";
            this.Load += new System.EventHandler(this.FormIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.GroupBox grbBarraInferior;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.RadioButton rdbSpanish;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Button btnAceptarIdioma;
    }
}