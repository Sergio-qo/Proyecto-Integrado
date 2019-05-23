namespace ProyectoIntegrado
{
    partial class FormPostre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostre));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSiguienteDisponible = new System.Windows.Forms.Button();
            this.lblFinalizar = new System.Windows.Forms.Label();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.btnEliArt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbBarVader = new System.Windows.Forms.PictureBox();
            this.lblAtras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem,
            this.dgvCantidad,
            this.dgvPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 246);
            this.dataGridView1.TabIndex = 22;
            // 
            // dgvItem
            // 
            this.dgvItem.HeaderText = "Item";
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.HeaderText = "Cantidad";
            this.dgvCantidad.Name = "dgvCantidad";
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.HeaderText = "Precio";
            this.dgvPrecio.Name = "dgvPrecio";
            // 
            // cmbItems
            // 
            this.cmbItems.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Items.AddRange(new object[] {
            "Fondie 3.8€",
            "Fresas 3.8€"});
            this.cmbItems.Location = new System.Drawing.Point(432, 218);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(172, 36);
            this.cmbItems.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(630, 218);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(32, 36);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDisponible.Image")));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(278, 400);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(45, 38);
            this.btnSiguienteDisponible.TabIndex = 29;
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            this.btnSiguienteDisponible.Click += new System.EventHandler(this.btnSiguienteDisponible_Click);
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizar.Location = new System.Drawing.Point(185, 406);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(87, 22);
            this.lblFinalizar.TabIndex = 31;
            this.lblFinalizar.Text = "Finalizar";
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(137, 73);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 32;
            this.pcbCarrito.TabStop = false;
            // 
            // btnEliArt
            // 
            this.btnEliArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliArt.Location = new System.Drawing.Point(668, 218);
            this.btnEliArt.Name = "btnEliArt";
            this.btnEliArt.Size = new System.Drawing.Size(32, 36);
            this.btnEliArt.TabIndex = 33;
            this.btnEliArt.Text = "-";
            this.btnEliArt.UseVisualStyleBackColor = true;
            this.btnEliArt.Click += new System.EventHandler(this.btnEliArt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.ptbBarVader);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 61);
            this.panel1.TabIndex = 53;
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
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.Location = new System.Drawing.Point(61, 406);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(57, 22);
            this.lblAtras.TabIndex = 27;
            this.lblAtras.Text = "Atrás";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 57);
            this.label1.TabIndex = 59;
            this.label1.Text = "Elige tu postre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(339, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 396);
            this.panel3.TabIndex = 60;
            // 
            // FormPostre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliArt);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.lblFinalizar);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPostre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postres";
            this.Load += new System.EventHandler(this.FormPostre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.Label lblFinalizar;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Button btnEliArt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbBarVader;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}