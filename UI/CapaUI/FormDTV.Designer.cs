
namespace CapaUI
{
    partial class FormDTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDTV));
            this.lblIdMostrar = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalMostrar = new System.Windows.Forms.Label();
            this.lblFechaMostrar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblClienteMostrar = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdMostrar
            // 
            this.lblIdMostrar.AutoSize = true;
            this.lblIdMostrar.Location = new System.Drawing.Point(496, 74);
            this.lblIdMostrar.Name = "lblIdMostrar";
            this.lblIdMostrar.Size = new System.Drawing.Size(13, 13);
            this.lblIdMostrar.TabIndex = 23;
            this.lblIdMostrar.Text = "_";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(468, 74);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "N°:";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Location = new System.Drawing.Point(12, 100);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.Size = new System.Drawing.Size(574, 275);
            this.dgvdetalle.TabIndex = 21;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(221, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 29);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Ventas";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(468, 387);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalMostrar
            // 
            this.lblTotalMostrar.AutoSize = true;
            this.lblTotalMostrar.Location = new System.Drawing.Point(505, 387);
            this.lblTotalMostrar.Name = "lblTotalMostrar";
            this.lblTotalMostrar.Size = new System.Drawing.Size(13, 13);
            this.lblTotalMostrar.TabIndex = 16;
            this.lblTotalMostrar.Text = "_";
            // 
            // lblFechaMostrar
            // 
            this.lblFechaMostrar.AutoSize = true;
            this.lblFechaMostrar.Location = new System.Drawing.Point(511, 43);
            this.lblFechaMostrar.Name = "lblFechaMostrar";
            this.lblFechaMostrar.Size = new System.Drawing.Size(13, 13);
            this.lblFechaMostrar.TabIndex = 15;
            this.lblFechaMostrar.Text = "_";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(468, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // lblClienteMostrar
            // 
            this.lblClienteMostrar.AutoSize = true;
            this.lblClienteMostrar.Location = new System.Drawing.Point(31, 68);
            this.lblClienteMostrar.Name = "lblClienteMostrar";
            this.lblClienteMostrar.Size = new System.Drawing.Size(13, 13);
            this.lblClienteMostrar.TabIndex = 13;
            this.lblClienteMostrar.Text = "_";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(31, 55);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente";
            // 
            // FormDTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(598, 424);
            this.Controls.Add(this.lblIdMostrar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalMostrar);
            this.Controls.Add(this.lblFechaMostrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblClienteMostrar);
            this.Controls.Add(this.lblCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(614, 463);
            this.MinimumSize = new System.Drawing.Size(614, 463);
            this.Name = "FormDTV";
            this.Text = "Ver ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdMostrar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalMostrar;
        private System.Windows.Forms.Label lblFechaMostrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblClienteMostrar;
        private System.Windows.Forms.Label lblCliente;
    }
}