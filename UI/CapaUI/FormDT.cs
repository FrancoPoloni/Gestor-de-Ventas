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
    public partial class FormDT : Form
    {
        private Detalle_Venta objeto;
        private Venta dt;
        public FormDT(Venta dt)
        {
            InitializeComponent();
            pnlDatos.Enabled = false;
            this.dt = dt;
            ComboLoad();
            DGVLoad();
        }
        #region Eventos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            objeto = null;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool N = (objeto == null);
            if (N)
                objeto = new Detalle_Venta();

            setDatos();
            if (dt.Dv == null)
            {
                dt.Dv = new List<Detalle_Venta>();
            }

            if (N)
                dt.Dv.Add(objeto);

            DGVLoad();
            MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            pnlDatos.Enabled = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

            Detalle_Venta p;
            pnlDatos.Enabled = true;
            p = dgvProductos.CurrentRow.DataBoundItem as Detalle_Venta;
            objeto = p;
            cmbProducto.Text = p.Productos.ToString();
            nudCantidad.Value = p.Cantidad;
            nudPrecio.Value = (decimal)p.PrecioUni;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
                Detalle_Venta d = dgvProductos.CurrentRow.DataBoundItem as Detalle_Venta;
                if (dt.Bo == null)
                {
                    dt.Bo = new List<Detalle_Venta>();
                }
                dt.Bo.Add(d);
                dt.Dv.Remove(d);
                MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVLoad();
            

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            pnlDatos.Enabled = false;
        }


        #endregion
        #region M


        public void ComboLoad()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = Producto.Buscar();
        }
        public void DGVLoad()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = dt.Dv.ToArray();
        }

        private void setDatos()
        {
            objeto.PrecioUni = (double)nudPrecio.Value;
            objeto.Productos = cmbProducto.SelectedItem as Producto;
            objeto.Venta = dt;
            objeto.Cantidad = (int)nudCantidad.Value;
        }



        public void clear()
        {
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
            cmbProducto.Text = "";
        }
        #endregion
    }
}
