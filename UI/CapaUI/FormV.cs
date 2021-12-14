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
    public partial class FormV : Form
    {
        private Venta objeto;
        public FormV()
        {
            InitializeComponent();
            btnDetalle.Enabled = false;
            CargarCombo();
            pnlDatos.Enabled = false;
            Buscar();
        }
        #region E

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            objeto = new Venta();
            CargarDatos();
            btnNuevo.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
            btnDetalle.Enabled = true;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvventa.CurrentRow != null)
                {
                    objeto = dgvventa.CurrentRow.DataBoundItem as Venta;
                    objeto.TraerDetalles();
                    CargarDatos();
                    pnlDatos.Enabled = true;
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnDetalle.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvventa.CurrentRow != null)
                {
                    Venta p = dgvventa.CurrentRow.DataBoundItem as Venta;
                    p.Eliminar();
                    Buscar();
                    MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            SetDatos();
            objeto.Guardar();
            MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlDatos.Enabled = false;
            btnDetalle.Enabled = false;
            btnNuevo.Enabled = true;
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            Buscar();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            btnNuevo.Enabled = true;
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            btnDetalle.Enabled = false;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente t = new FormCliente();
            t.ShowDialog();
            CargarCombo();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
        }
        private void btnVerVenta_Click(object sender, EventArgs e)
        {
            try
            {
                objeto = dgvventa.CurrentRow.DataBoundItem as Venta;
                FormDTV f = new FormDTV(objeto);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            SetDatos();
            FormDT f = new FormDT(objeto);
            f.ShowDialog();
            nudtotal.Value = (decimal)objeto.CalcTotal();
            btnguardar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
        #region M
        private void CargarDatos()
        {

            cmbcliente.SelectedItem = objeto.Cliente;
            dtpfecha.Value = objeto.Fecha;
            nudtotal.Value = Convert.ToDecimal(objeto.Total);
        }
        private void SetDatos()
        {
            objeto.Cliente = cmbcliente.SelectedItem as Cliente;
            objeto.Fecha = dtpfecha.Value;
            objeto.Total = (double)nudtotal.Value;
        }

        private void Buscar()
        {
            dgvventa.DataSource = Venta.Buscar(txtbusventa.Text);
        }
        private void CargarCombo()
        {
            cmbcliente.DataSource = null;
            cmbcliente.DataSource = Cliente.Buscar();

        }

        #endregion

        private void btnmasClientes_Click(object sender, EventArgs e)
        {
            FormCliente m = new FormCliente();
            m.ShowDialog();
            cmbcliente.DataSource = null;
            cmbcliente.DataSource = Cliente.Buscar();
        }
    }
}
