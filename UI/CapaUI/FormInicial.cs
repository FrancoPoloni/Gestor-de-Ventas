using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnGesMarcas_Click(object sender, EventArgs e)
        {
            FormMarcas m = new FormMarcas();
            m.ShowDialog();
        }

        private void btnGesProd_Click(object sender, EventArgs e)
        {
            FormProducto p = new FormProducto();
            p.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormV v = new FormV();
            v.ShowDialog();
        }

        private void btnGesClientes_Click(object sender, EventArgs e)
        {
            FormCliente c = new FormCliente();
            c.ShowDialog();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VisorFiltrado f = new VisorFiltrado();
            f.ShowDialog();
        }
    }
}
