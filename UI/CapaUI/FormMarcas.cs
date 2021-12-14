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
    public partial class FormMarcas : Form
    {
        private Marca objeto;
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
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
                MessageBox.Show( "Campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            objeto = new Marca();
            CargarDatos();
            pnlDatos.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvMarcas.CurrentRow != null)
                {
                    objeto = dgvMarcas.CurrentRow.DataBoundItem as Marca;
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
                if (dgvMarcas.CurrentRow != null)
                {
                    Marca m = dgvMarcas.CurrentRow.DataBoundItem as Marca;
                    if (Producto.BuscarPorIdMarca(m.Id))
                    {
                        MessageBox.Show("No se pudo Eliminar Porque hay productos con esa Marca", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dgvMarcas.DataSource = Marca.Buscar(txtBuscar.Text);
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
