using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUI
{
    public partial class VisorFiltrado : Form
    {
        public VisorFiltrado()
        {
            InitializeComponent();
        }

        private void VisorFiltrado_Load(object sender, EventArgs e)
        {
            cmbMarca.DataSource = Marca.Buscar();
        }

        private void Cargar()
        {
            if (cmbMarca.SelectedItem != null)
            {
                int idMarca = (cmbMarca.SelectedItem as Marca).Id;
                this.DataTable1TableAdapter.Connection.ConnectionString = ConexionNeg.StrConexion();
                this.DataTable1TableAdapter.Fill(this.DSFiltrado.DataTable1, idMarca);

                this.reportViewer1.RefreshReport();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
