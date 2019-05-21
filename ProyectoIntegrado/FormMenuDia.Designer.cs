namespace ProyectoIntegrado
{
    partial class FormMenuDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuDia));
            this.grbBarraSuperior = new System.Windows.Forms.GroupBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.grpBarraInferior = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrimerPlato = new System.Windows.Forms.Label();
            this.lblSegundoPlato = new System.Windows.Forms.Label();
            this.lblBebida = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSiguienteDisponible = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAtras = new System.Windows.Forms.Label();
            this.lblFinalizar = new System.Windows.Forms.Label();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.grbPrimerPlato = new System.Windows.Forms.GroupBox();
            this.cmbPrimer = new System.Windows.Forms.ComboBox();
            this.grbSegundoPlato = new System.Windows.Forms.GroupBox();
            this.cmbSegundo = new System.Windows.Forms.ComboBox();
            this.grbBebida = new System.Windows.Forms.GroupBox();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.grbBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            this.grbPrimerPlato.SuspendLayout();
            this.grbSegundoPlato.SuspendLayout();
            this.grbBebida.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBarraSuperior
            // 
            this.grbBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBarraSuperior.Controls.Add(this.btnMinimizar);
            this.grbBarraSuperior.Controls.Add(this.btnCerrar);
            this.grbBarraSuperior.Location = new System.Drawing.Point(-2, -1);
            this.grbBarraSuperior.Name = "grbBarraSuperior";
            this.grbBarraSuperior.Size = new System.Drawing.Size(802, 41);
            this.grbBarraSuperior.TabIndex = 3;
            this.grbBarraSuperior.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(759, 12);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(17, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 26;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(780, 12);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // grpBarraInferior
            // 
            this.grpBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpBarraInferior.Location = new System.Drawing.Point(-1, 409);
            this.grpBarraInferior.Name = "grpBarraInferior";
            this.grpBarraInferior.Size = new System.Drawing.Size(802, 41);
            this.grpBarraInferior.TabIndex = 3;
            this.grpBarraInferior.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(339, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 388);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblPrimerPlato
            // 
            this.lblPrimerPlato.AutoSize = true;
            this.lblPrimerPlato.Location = new System.Drawing.Point(3, 15);
            this.lblPrimerPlato.Name = "lblPrimerPlato";
            this.lblPrimerPlato.Size = new System.Drawing.Size(63, 13);
            this.lblPrimerPlato.TabIndex = 10;
            this.lblPrimerPlato.Text = "Primer Plato";
            // 
            // lblSegundoPlato
            // 
            this.lblSegundoPlato.AutoSize = true;
            this.lblSegundoPlato.Location = new System.Drawing.Point(0, 15);
            this.lblSegundoPlato.Name = "lblSegundoPlato";
            this.lblSegundoPlato.Size = new System.Drawing.Size(77, 13);
            this.lblSegundoPlato.TabIndex = 11;
            this.lblSegundoPlato.Text = "Segundo Plato";
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Location = new System.Drawing.Point(6, 15);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(40, 13);
            this.lblBebida.TabIndex = 12;
            this.lblBebida.Text = "Bebida";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(431, 300);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(148, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSiguienteDisponible
            // 
            this.btnSiguienteDisponible.BackColor = System.Drawing.Color.White;
            this.btnSiguienteDisponible.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteDisponible.Image")));
            this.btnSiguienteDisponible.Location = new System.Drawing.Point(260, 358);
            this.btnSiguienteDisponible.Name = "btnSiguienteDisponible";
            this.btnSiguienteDisponible.Size = new System.Drawing.Size(53, 38);
            this.btnSiguienteDisponible.TabIndex = 21;
            this.btnSiguienteDisponible.UseVisualStyleBackColor = false;
            this.btnSiguienteDisponible.Click += new System.EventHandler(this.btnSiguienteDisponible_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem,
            this.dgvCantidad,
            this.dgvPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 221);
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
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Location = new System.Drawing.Point(80, 371);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(31, 13);
            this.lblAtras.TabIndex = 23;
            this.lblAtras.Text = "Atras";
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Location = new System.Drawing.Point(205, 371);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(45, 13);
            this.lblFinalizar.TabIndex = 24;
            this.lblFinalizar.Text = "Finalizar";
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrito.Image")));
            this.pcbCarrito.Location = new System.Drawing.Point(133, 46);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(62, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 25;
            this.pcbCarrito.TabStop = false;
            // 
            // grbPrimerPlato
            // 
            this.grbPrimerPlato.Controls.Add(this.cmbPrimer);
            this.grbPrimerPlato.Controls.Add(this.lblPrimerPlato);
            this.grbPrimerPlato.Location = new System.Drawing.Point(431, 48);
            this.grbPrimerPlato.Name = "grbPrimerPlato";
            this.grbPrimerPlato.Size = new System.Drawing.Size(134, 69);
            this.grbPrimerPlato.TabIndex = 26;
            this.grbPrimerPlato.TabStop = false;
            // 
            // cmbPrimer
            // 
            this.cmbPrimer.FormattingEnabled = true;
            this.cmbPrimer.Items.AddRange(new object[] {
            "patata",
            "Beicon y huevo 3.8€"});
            this.cmbPrimer.Location = new System.Drawing.Point(0, 40);
            this.cmbPrimer.Name = "cmbPrimer";
            this.cmbPrimer.Size = new System.Drawing.Size(121, 21);
            this.cmbPrimer.TabIndex = 45;
            // 
            // grbSegundoPlato
            // 
            this.grbSegundoPlato.Controls.Add(this.cmbSegundo);
            this.grbSegundoPlato.Controls.Add(this.lblSegundoPlato);
            this.grbSegundoPlato.Location = new System.Drawing.Point(431, 132);
            this.grbSegundoPlato.Name = "grbSegundoPlato";
            this.grbSegundoPlato.Size = new System.Drawing.Size(134, 68);
            this.grbSegundoPlato.TabIndex = 27;
            this.grbSegundoPlato.TabStop = false;
            // 
            // cmbSegundo
            // 
            this.cmbSegundo.FormattingEnabled = true;
            this.cmbSegundo.Items.AddRange(new object[] {
            "patata",
            "Beicon y huevo 3.8€"});
            this.cmbSegundo.Location = new System.Drawing.Point(0, 41);
            this.cmbSegundo.Name = "cmbSegundo";
            this.cmbSegundo.Size = new System.Drawing.Size(121, 21);
            this.cmbSegundo.TabIndex = 46;
            // 
            // grbBebida
            // 
            this.grbBebida.Controls.Add(this.cmbBebida);
            this.grbBebida.Controls.Add(this.lblBebida);
            this.grbBebida.Location = new System.Drawing.Point(431, 216);
            this.grbBebida.Name = "grbBebida";
            this.grbBebida.Size = new System.Drawing.Size(134, 58);
            this.grbBebida.TabIndex = 28;
            this.grbBebida.TabStop = false;
            // 
            // cmbBebida
            // 
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Items.AddRange(new object[] {
            "patata",
            "Beicon y huevo 3.8€"});
            this.cmbBebida.Location = new System.Drawing.Point(0, 31);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(121, 21);
            this.cmbBebida.TabIndex = 47;
            // 
            // FormMenuDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbBebida);
            this.Controls.Add(this.grbSegundoPlato);
            this.Controls.Add(this.grbPrimerPlato);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.lblFinalizar);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.btnSiguienteDisponible);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpBarraInferior);
            this.Controls.Add(this.grbBarraSuperior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú del día";
            this.Load += new System.EventHandler(this.FormMenuDia_Load);
            this.grbBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            this.grbPrimerPlato.ResumeLayout(false);
            this.grbPrimerPlato.PerformLayout();
            this.grbSegundoPlato.ResumeLayout(false);
            this.grbSegundoPlato.PerformLayout();
            this.grbBebida.ResumeLayout(false);
            this.grbBebida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBarraSuperior;
        private System.Windows.Forms.GroupBox grpBarraInferior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrimerPlato;
        private System.Windows.Forms.Label lblSegundoPlato;
        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSiguienteDisponible;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.Label lblAtras;
        private System.Windows.Forms.Label lblFinalizar;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox grbPrimerPlato;
        private System.Windows.Forms.GroupBox grbSegundoPlato;
        private System.Windows.Forms.GroupBox grbBebida;
        private System.Windows.Forms.ComboBox cmbPrimer;
        private System.Windows.Forms.ComboBox cmbSegundo;
        private System.Windows.Forms.ComboBox cmbBebida;
    }
}