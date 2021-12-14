
namespace CapaUI
{
    partial class FormV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormV));
            this.dgvventa = new System.Windows.Forms.DataGridView();
            this.txtbusventa = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.nudtotal = new System.Windows.Forms.NumericUpDown();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerVenta = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnmasClientes = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudtotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvventa
            // 
            this.dgvventa.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventa.Location = new System.Drawing.Point(12, 32);
            this.dgvventa.Name = "dgvventa";
            this.dgvventa.Size = new System.Drawing.Size(425, 128);
            this.dgvventa.TabIndex = 24;
            // 
            // txtbusventa
            // 
            this.txtbusventa.Location = new System.Drawing.Point(71, 6);
            this.txtbusventa.Name = "txtbusventa";
            this.txtbusventa.Size = new System.Drawing.Size(197, 20);
            this.txtbusventa.TabIndex = 23;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(25, 9);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 22;
            this.lblbuscar.Text = "Buscar";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnmasClientes);
            this.pnlDatos.Controls.Add(this.cmbcliente);
            this.pnlDatos.Controls.Add(this.lblClientes);
            this.pnlDatos.Controls.Add(this.btncancelar);
            this.pnlDatos.Controls.Add(this.btnguardar);
            this.pnlDatos.Controls.Add(this.nudtotal);
            this.pnlDatos.Controls.Add(this.lbltotal);
            this.pnlDatos.Controls.Add(this.dtpfecha);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Location = new System.Drawing.Point(12, 199);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(425, 157);
            this.pnlDatos.TabIndex = 29;
            // 
            // cmbcliente
            // 
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(96, 20);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(160, 21);
            this.cmbcliente.TabIndex = 11;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(12, 23);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(44, 13);
            this.lblClientes.TabIndex = 10;
            this.lblClientes.Text = "Clientes";
            // 
            // nudtotal
            // 
            this.nudtotal.DecimalPlaces = 2;
            this.nudtotal.Location = new System.Drawing.Point(96, 93);
            this.nudtotal.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudtotal.Name = "nudtotal";
            this.nudtotal.ReadOnly = true;
            this.nudtotal.Size = new System.Drawing.Size(160, 20);
            this.nudtotal.TabIndex = 18;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltotal.Location = new System.Drawing.Point(12, 95);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 17;
            this.lbltotal.Text = "Total";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtpfecha.Location = new System.Drawing.Point(96, 58);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(159, 20);
            this.dtpfecha.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha";
            // 
            // btnVerVenta
            // 
            this.btnVerVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerVenta.FlatAppearance.BorderSize = 0;
            this.btnVerVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVenta.Image = global::CapaUI.Properties.Resources.ver;
            this.btnVerVenta.Location = new System.Drawing.Point(343, 166);
            this.btnVerVenta.Name = "btnVerVenta";
            this.btnVerVenta.Size = new System.Drawing.Size(43, 30);
            this.btnVerVenta.TabIndex = 32;
            this.btnVerVenta.UseVisualStyleBackColor = true;
            this.btnVerVenta.Click += new System.EventHandler(this.btnVerVenta_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Image = global::CapaUI.Properties.Resources.detalle;
            this.btnDetalle.Location = new System.Drawing.Point(382, 166);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(55, 30);
            this.btnDetalle.TabIndex = 31;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::CapaUI.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(273, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscar.Size = new System.Drawing.Size(20, 20);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::CapaUI.Properties.Resources.eliminar__1_1;
            this.btneliminar.Location = new System.Drawing.Point(87, 163);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btneliminar.Size = new System.Drawing.Size(30, 30);
            this.btneliminar.TabIndex = 27;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Image = global::CapaUI.Properties.Resources.editar1;
            this.btnmodificar.Location = new System.Drawing.Point(51, 163);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnmodificar.Size = new System.Drawing.Size(30, 30);
            this.btnmodificar.TabIndex = 26;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::CapaUI.Properties.Resources.nuevo_241;
            this.btnNuevo.Location = new System.Drawing.Point(15, 163);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNuevo.Size = new System.Drawing.Size(30, 30);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnmasClientes
            // 
            this.btnmasClientes.FlatAppearance.BorderSize = 0;
            this.btnmasClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmasClientes.Image = global::CapaUI.Properties.Resources.mas;
            this.btnmasClientes.Location = new System.Drawing.Point(262, 18);
            this.btnmasClientes.Name = "btnmasClientes";
            this.btnmasClientes.Size = new System.Drawing.Size(19, 23);
            this.btnmasClientes.TabIndex = 60;
            this.btnmasClientes.UseVisualStyleBackColor = true;
            this.btnmasClientes.Click += new System.EventHandler(this.btnmasClientes_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::CapaUI.Properties.Resources.cancelar1;
            this.btncancelar.Location = new System.Drawing.Point(225, 119);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncancelar.Size = new System.Drawing.Size(30, 30);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::CapaUI.Properties.Resources.doble_verificacion1;
            this.btnguardar.Location = new System.Drawing.Point(189, 119);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnguardar.Size = new System.Drawing.Size(30, 30);
            this.btnguardar.TabIndex = 20;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // FormV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(450, 371);
            this.Controls.Add(this.btnVerVenta);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvventa);
            this.Controls.Add(this.txtbusventa);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.pnlDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(466, 410);
            this.MinimumSize = new System.Drawing.Size(466, 410);
            this.Name = "FormV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudtotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerVenta;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvventa;
        private System.Windows.Forms.TextBox txtbusventa;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.NumericUpDown nudtotal;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmasClientes;
    }
}