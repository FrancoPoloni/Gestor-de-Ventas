
namespace CapaUI
{
    partial class VisorCliente
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorCliente));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSCliente = new CapaUI.DSCliente();
            this.DTClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTClienteTableAdapter = new CapaUI.DSClienteTableAdapters.DTClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSCliente";
            reportDataSource2.Value = this.DTClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaUI.RP1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSCliente
            // 
            this.DSCliente.DataSetName = "DSCliente";
            this.DSCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTClienteBindingSource
            // 
            this.DTClienteBindingSource.DataMember = "DTCliente";
            this.DTClienteBindingSource.DataSource = this.DSCliente;
            // 
            // DTClienteTableAdapter
            // 
            this.DTClienteTableAdapter.ClearBeforeFill = true;
            // 
            // VisorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Cliente";
            this.Load += new System.EventHandler(this.VisorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DTClienteBindingSource;
        private DSCliente DSCliente;
        private DSClienteTableAdapters.DTClienteTableAdapter DTClienteTableAdapter;
    }
}