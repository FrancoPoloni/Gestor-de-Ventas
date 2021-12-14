
namespace CapaUI
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.numDocu = new System.Windows.Forms.NumericUpDown();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnmasClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDocu)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 49);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(510, 150);
            this.dgvClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "N° Documento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 41);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(197, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(95, 64);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(197, 21);
            this.cmbTipo.TabIndex = 8;
            // 
            // numDocu
            // 
            this.numDocu.Location = new System.Drawing.Point(95, 89);
            this.numDocu.Name = "numDocu";
            this.numDocu.Size = new System.Drawing.Size(197, 20);
            this.numDocu.TabIndex = 9;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos.Controls.Add(this.btncancelar);
            this.pnlDatos.Controls.Add(this.btnguardar);
            this.pnlDatos.Controls.Add(this.btnmasClientes);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.numDocu);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.cmbTipo);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.txtApellido);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.label5);
            this.pnlDatos.Location = new System.Drawing.Point(12, 237);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(510, 151);
            this.pnlDatos.TabIndex = 10;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(68, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(273, 20);
            this.txtBuscar.TabIndex = 10;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::CapaUI.Properties.Resources.informe_medico;
            this.btnReport.Location = new System.Drawing.Point(456, 201);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(31, 30);
            this.btnReport.TabIndex = 32;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::CapaUI.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(347, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscar.Size = new System.Drawing.Size(20, 20);
            this.btnBuscar.TabIndex = 31;
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
            this.btneliminar.Location = new System.Drawing.Point(85, 201);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btneliminar.Size = new System.Drawing.Size(30, 30);
            this.btneliminar.TabIndex = 30;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Image = global::CapaUI.Properties.Resources.editar1;
            this.btnmodificar.Location = new System.Drawing.Point(49, 201);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnmodificar.Size = new System.Drawing.Size(30, 30);
            this.btnmodificar.TabIndex = 29;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::CapaUI.Properties.Resources.nuevo_241;
            this.btnNuevo.Location = new System.Drawing.Point(13, 201);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNuevo.Size = new System.Drawing.Size(30, 30);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::CapaUI.Properties.Resources.cancelar1;
            this.btncancelar.Location = new System.Drawing.Point(262, 115);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncancelar.Size = new System.Drawing.Size(30, 30);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::CapaUI.Properties.Resources.doble_verificacion1;
            this.btnguardar.Location = new System.Drawing.Point(226, 115);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnguardar.Size = new System.Drawing.Size(30, 30);
            this.btnguardar.TabIndex = 33;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnmasClientes
            // 
            this.btnmasClientes.FlatAppearance.BorderSize = 0;
            this.btnmasClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmasClientes.Image = global::CapaUI.Properties.Resources.mas;
            this.btnmasClientes.Location = new System.Drawing.Point(298, 64);
            this.btnmasClientes.Name = "btnmasClientes";
            this.btnmasClientes.Size = new System.Drawing.Size(19, 23);
            this.btnmasClientes.TabIndex = 61;
            this.btnmasClientes.UseVisualStyleBackColor = true;
            this.btnmasClientes.Click += new System.EventHandler(this.btnmasTipos_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(535, 404);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(551, 443);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDocu)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown numDocu;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnmasClientes;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnReport;
    }
}