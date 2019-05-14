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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.lblFinalizar = new System.Windows.Forms.Label();
            this.lblAtras = new System.Windows.Forms.Label();
            this.btnSiguienteDisponible = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(329, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 421);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem,
            this.dgvCantidad,
            this.dgvPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 231);
            this.dataGridView1.TabIndex = 31;
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
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(127, 53);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 52);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 38;
            this.pcbCarrito.TabStop = false;
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Location = new System.Drawing.Point(205, 359);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(45, 13);
            this.lblFinalizar.TabIndex = 37;
            this.lblFinalizar.Text = "Finalizar";
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Location = new System.Drawing.Point(80, 359);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(31, 13);
            this.lblAtras.TabIndex = 36;
            this.lblAtras.Text = "Atras";
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDisponible.Image")));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(270, 344);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(53, 40);
            this.btnSiguienteDisponible.TabIndex = 35;
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 40);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Location = new System.Drawing.Point(-1, -5);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 43);
            this.grbBarraSuperior.TabIndex = 28;
            this.grbBarraSuperior.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(-1, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 43);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Items.AddRange(new object[] {
            "Chivito 3.8€",
            "Beicon y huevo 3.8€"});
            this.cmbItems.Location = new System.Drawing.Point(441, 44);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(121, 21);
            this.cmbItems.TabIndex = 33;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(568, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(20, 25);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(329, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 419);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(12, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(311, 229);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Finalizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Atras";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(270, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 38);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 38);
            this.button3.TabIndex = 45;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.btnMinimizar);
            this.groupBox4.Controls.Add(this.btnCerrar);
            this.groupBox4.Location = new System.Drawing.Point(-1, -3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(802, 41);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox5.Location = new System.Drawing.Point(-1, 409);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(802, 41);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chivito 3.8€",
            "Beicon y huevo 3.8€"});
            this.comboBox1.Location = new System.Drawing.Point(441, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(756, 14);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(17, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 50;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(777, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 51;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.lblFinalizar);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbBarraSuperior);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBebida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Label lblFinalizar;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}