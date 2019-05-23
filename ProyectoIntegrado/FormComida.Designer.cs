namespace ProyectoIntegrado
{
    partial class FormComida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComida));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSiguienteDisponible = new System.Windows.Forms.Button();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.btnEliArt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbBarVader = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinalizar = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 246);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(630, 194);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(33, 33);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbItems
            // 
            this.cmbItems.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Items.AddRange(new object[] {
            "Paella 3.8€",
            "Fideua 3.8€"});
            this.cmbItems.Location = new System.Drawing.Point(458, 192);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(156, 36);
            this.cmbItems.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 38);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDisponible.Image")));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(266, 400);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(57, 38);
            this.btnSiguienteDisponible.TabIndex = 22;
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            this.btnSiguienteDisponible.Click += new System.EventHandler(this.btnSiguienteDisponible_Click);
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(136, 74);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 27;
            this.pcbCarrito.TabStop = false;
            // 
            // btnEliArt
            // 
            this.btnEliArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliArt.Location = new System.Drawing.Point(669, 194);
            this.btnEliArt.Name = "btnEliArt";
            this.btnEliArt.Size = new System.Drawing.Size(30, 34);
            this.btnEliArt.TabIndex = 51;
            this.btnEliArt.Text = "-";
            this.btnEliArt.UseVisualStyleBackColor = true;
            this.btnEliArt.Click += new System.EventHandler(this.btnEliArt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.ptbBarVader);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 58);
            this.panel1.TabIndex = 52;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(337, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 401);
            this.panel3.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 57);
            this.label1.TabIndex = 58;
            this.label1.Text = "Elige tu plato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Atrás";
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizar.Location = new System.Drawing.Point(161, 406);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(99, 25);
            this.lblFinalizar.TabIndex = 59;
            this.lblFinalizar.Text = "Finalizar";
            // 
            // FormComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFinalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliArt);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarVader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Button btnEliArt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbBarVader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinalizar;
    }
}