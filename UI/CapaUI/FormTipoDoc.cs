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
    public partial class FormTipoDoc : Form
    {
        private TipoDocumento objeto;
        public FormTipoDoc()
        {
            InitializeComponent();
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
                MessageBox.Show("Campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            objeto = new TipoDocumento();
            CargarDatos();
            pnlDatos.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvTipoDoc.CurrentRow != null)
                {
                    objeto = dgvTipoDoc.CurrentRow.DataBoundItem as TipoDocumento;
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
                if (dgvTipoDoc.CurrentRow != null)
                {

                    TipoDocumento m = dgvTipoDoc.CurrentRow.DataBoundItem as TipoDocumento;
                    if (Cliente.BuscarPorIdDocumento(m.Id))
                    {
                        MessageBox.Show("No se pudo eliminar porque hay un cliente con ese tipo de documento", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        m.Eliminar();
                        Buscar();
                        MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            dgvTipoDoc.DataSource = TipoDocumento.Buscar(txtBuscar.Text);
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
