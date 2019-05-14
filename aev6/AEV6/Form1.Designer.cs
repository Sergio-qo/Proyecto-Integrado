namespace AEV6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.lblReloj = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.dgvInicial = new System.Windows.Forms.DataGridView();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpleadoAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblNIF = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(1113, 124);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(464, 77);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            this.btnSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(1113, 234);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(464, 77);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            // 
            // btnPresencia
            // 
            this.btnPresencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPresencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(1113, 345);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(464, 77);
            this.btnPresencia.TabIndex = 2;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = true;
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPermanencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(1113, 476);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(464, 77);
            this.btnPermanencia.TabIndex = 3;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = true;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMantenimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(1113, 602);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(464, 77);
            this.btnMantenimiento.TabIndex = 4;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(12, 9);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(425, 166);
            this.lblReloj.TabIndex = 5;
            this.lblReloj.Text = "Reloj";
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Tick += new System.EventHandler(this.TmrReloj_Tick);
            // 
            // dgvInicial
            // 
            this.dgvInicial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInicial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIF,
            this.FechaInicio,
            this.FechaFin,
            this.Administrador,
            this.EmpleadoAlta});
            this.dgvInicial.Location = new System.Drawing.Point(22, 445);
            this.dgvInicial.Name = "dgvInicial";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInicial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInicial.RowHeadersWidth = 48;
            this.dgvInicial.RowTemplate.Height = 28;
            this.dgvInicial.Size = new System.Drawing.Size(1277, 459);
            this.dgvInicial.TabIndex = 6;
            // 
            // NIF
            // 
            this.NIF.FillWeight = 150F;
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            this.NIF.Width = 165;
            // 
            // FechaInicio
            // 
            this.FechaInicio.FillWeight = 150F;
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 165;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha Salida";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 165;
            // 
            // Administrador
            // 
            this.Administrador.HeaderText = "Administrador";
            this.Administrador.Name = "Administrador";
            this.Administrador.Width = 165;
            // 
            // EmpleadoAlta
            // 
            this.EmpleadoAlta.HeaderText = "Empleado Alta";
            this.EmpleadoAlta.Name = "EmpleadoAlta";
            this.EmpleadoAlta.Width = 165;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(22, 360);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(595, 44);
            this.dtpFechaInicio.TabIndex = 7;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(33, 234);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(76, 37);
            this.lblNIF.TabIndex = 8;
            this.lblNIF.Text = "NIF:";
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(133, 234);
            this.txtNIF.Multiline = true;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(221, 36);
            this.txtNIF.TabIndex = 9;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(441, 233);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(192, 37);
            this.lblContraseña.TabIndex = 10;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(639, 232);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(221, 38);
            this.txtContraseña.TabIndex = 11;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(33, 311);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(200, 37);
            this.lblFechaInicio.TabIndex = 12;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(476, 311);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(191, 37);
            this.lblFechaFinal.TabIndex = 13;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Location = new System.Drawing.Point(715, 360);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(584, 44);
            this.dtpFechaFinal.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 826);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dgvInicial);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.DataGridView dgvInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
    }
}

