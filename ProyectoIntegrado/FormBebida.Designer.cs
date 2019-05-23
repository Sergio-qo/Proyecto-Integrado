namespace ProyectoIntegrado
{
    partial class FormBebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBebida));
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliArt = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.Label();
            this.lblFinalizar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbBarVader = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(140, 65);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 52);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 38;
            this.pcbCarrito.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 40);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(12, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(311, 243);
            this.dataGridView2.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(270, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 40);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "patata",
            "Beicon y huevo 3.8€"});
            this.comboBox1.Location = new System.Drawing.Point(449, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 36);
            this.comboBox1.TabIndex = 44;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(640, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 36);
            this.button4.TabIndex = 43;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliArt
            // 
            this.btnEliArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliArt.Location = new System.Drawing.Point(692, 211);
            this.btnEliArt.Name = "btnEliArt";
            this.btnEliArt.Size = new System.Drawing.Size(30, 36);
            this.btnEliArt.TabIndex = 50;
            this.btnEliArt.Text = "-";
            this.btnEliArt.UseVisualStyleBackColor = true;
            this.btnEliArt.Click += new System.EventHandler(this.btnEliArt_Click);
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(74, 395);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(57, 22);
            this.lblAtras.TabIndex = 51;
            this.lblAtras.Text = "Atrás";
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizar.Location = new System.Drawing.Point(177, 395);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(87, 22);
            this.lblFinalizar.TabIndex = 52;
            this.lblFinalizar.Text = "Finalizar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.ptbBarVader);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 61);
            this.panel1.TabIndex = 54;
            // 
            // ptbBarVader
            // 
            this.ptbBarVader.Image = ((System.Drawing.Image)(resources.GetObject("ptbBarVader.Image")));
            this.ptbBarVader.Location = new System.Drawing.Point(2, 0);
            this.ptbBarVader.Margin = new System.Windows.Forms.Padding(2);
            this.ptbBarVader.Name = "ptbBarVader";
            this.ptbBarVader.Size = new System.Drawing.Size(75, 61);
            this.ptbBarVader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBarVader.TabIndex = 26;
            this.ptbBarVader.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(343, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 396);
            this.panel3.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 57);
            this.label1.TabIndex = 62;
            this.label1.Text = "Elige tu bebida";
            // 
            // FormBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFinalizar);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.btnEliArt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bebidas";
            this.Load += new System.EventHandler(this.FormBebida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliArt;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Label lblFinalizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbBarVader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}