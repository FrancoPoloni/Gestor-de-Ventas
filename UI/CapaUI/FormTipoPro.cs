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
    public partial class FormTipoPro : Form
    {
        private TipoProducto objeto;
        public FormTipoPro()
        {
            InitializeComponent();
        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                SetDatos();
                objeto.Guardar();
                MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlDatos.Enabled = false;
                Buscar();
            }
            else
            {
             MessageBox.Show("Campos vacios compa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            objeto = new TipoProducto();
            CargarDatos();
            pnlDatos.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvTipoPro.CurrentRow != null)
                {
                    objeto = dgvTipoPro.CurrentRow.DataBoundItem as TipoProducto;
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoPro.CurrentRow != null)
                {
                    TipoProducto m = dgvTipoPro.CurrentRow.DataBoundItem as TipoProducto;
                    if (Producto.BuscarPorIdTipo(m.Id))
                    {
                        MessageBox.Show("No se pudo eliminar porque hay un producto con ese tipo de producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                        m.Eliminar();
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
        private void Buscar()
        {
            dgvTipoPro.DataSource = TipoProducto.Buscar(txtBuscar.Text);
        }

        private void CargarDatos()
        {
            txtNombre.Text = objeto.Nombre;

        }

        private void SetDatos()
        {
            objeto.Nombre = txtNombre.Text;

        }
    }
}
