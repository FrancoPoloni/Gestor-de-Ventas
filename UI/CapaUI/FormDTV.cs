using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUI
{
    public partial class FormDTV : Form
    {
        private Venta objeto;
        public FormDTV(Venta v)
        {
            InitializeComponent();
            this.objeto = v;
            cargar();
            llenar();
        }


        #region Metodos
        public void cargar()
        {
            dgvdetalle.DataSource = null;
            objeto.TraerDetalles();
            dgvdetalle.DataSource = objeto.Dv;
        }
        public void llenar()
        {
            lblClienteMostrar.Text = objeto.Cliente.ToString();
            lblFechaMostrar.Text = objeto.Fecha.ToString();
            lblIdMostrar.Text = objeto.Id.ToString();
            lblTotalMostrar.Text = objeto.Total.ToString();
        }
        #endregion

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
