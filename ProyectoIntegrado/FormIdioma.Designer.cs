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
            this.lblAjustes = new System.Windows.Forms.Label();
            this.rdbSpanish = new System.Windows.Forms.RadioButton();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.Label();
            this.btnAceptarIdioma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbBarVader = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAjustes
            // 
            this.lblAjustes.AutoSize = true;
            this.lblAjustes.Font = new System.Drawing.Font("Britannic Bold", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjustes.Location = new System.Drawing.Point(238, 82);
            this.lblAjustes.Name = "lblAjustes";
            this.lblAjustes.Size = new System.Drawing.Size(322, 38);
            this.lblAjustes.TabIndex = 3;
            this.lblAjustes.Text = "AJUSTES DE IDIOMA";
            // 
            // rdbSpanish
            // 
            this.rdbSpanish.AutoSize = true;
            this.rdbSpanish.Checked = true;
            this.rdbSpanish.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSpanish.Location = new System.Drawing.Point(338, 155);
            this.rdbSpanish.Name = "rdbSpanish";
            this.rdbSpanish.Size = new System.Drawing.Size(125, 36);
            this.rdbSpanish.TabIndex = 6;
            this.rdbSpanish.TabStop = true;
            this.rdbSpanish.Text = "Español";
            this.rdbSpanish.UseVisualStyleBackColor = true;
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.AutoSize = true;
            this.rdbEnglish.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnglish.Location = new System.Drawing.Point(338, 212);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(102, 36);
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
            this.btnAtras.Size = new System.Drawing.Size(49, 36);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(67, 360);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(57, 22);
            this.lblAtras.TabIndex = 19;
            this.lblAtras.Text = "Atrás";
            // 
            // btnAceptarIdioma
            // 
            this.btnAceptarIdioma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptarIdioma.Font = new System.Drawing.Font("Lucida Sans Unicode", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarIdioma.Location = new System.Drawing.Point(329, 276);
            this.btnAceptarIdioma.Name = "btnAceptarIdioma";
            this.btnAceptarIdioma.Size = new System.Drawing.Size(116, 40);
            this.btnAceptarIdioma.TabIndex = 21;
            this.btnAceptarIdioma.Text = "Cambiar";
            this.btnAceptarIdioma.UseVisualStyleBackColor = false;
            this.btnAceptarIdioma.Click += new System.EventHandler(this.btnAceptarIdioma_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.ptbBarVader);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 55);
            this.panel1.TabIndex = 24;
            // 
            // ptbBarVader
            // 
            this.ptbBarVader.Image = ((System.Drawing.Image)(resources.GetObject("ptbBarVader.Image")));
            this.ptbBarVader.Location = new System.Drawing.Point(2, 0);
            this.ptbBarVader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbBarVader.Name = "ptbBarVader";
            this.ptbBarVader.Size = new System.Drawing.Size(75, 55);
            this.ptbBarVader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBarVader.TabIndex = 27;
            this.ptbBarVader.TabStop = false;
            // 
            // FormIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAceptarIdioma);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.rdbEnglish);
            this.Controls.Add(this.rdbSpanish);
            this.Controls.Add(this.lblAjustes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.FormIdioma_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.RadioButton rdbSpanish;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Button btnAceptarIdioma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbBarVader;
    }
}