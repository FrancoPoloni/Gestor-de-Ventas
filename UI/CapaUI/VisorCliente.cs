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
    public partial class VisorCliente : Form
    {
        public VisorCliente()
        {
            InitializeComponent();
        }

        private void VisorCliente_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'DSCliente.DTCliente' Puede moverla o quitarla según sea necesario.
            this.DTClienteTableAdapter.Connection.ConnectionString = ConexionNeg.StrConexion();
            this.DTClienteTableAdapter.Fill(this.DSCliente.DTCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
