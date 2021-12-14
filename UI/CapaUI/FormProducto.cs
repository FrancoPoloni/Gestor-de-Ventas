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
    public partial class FormProducto : Form
    {
        private Producto objeto;
        public FormProducto()
        {
            InitializeComponent();
        }

        public void CargarCombos()
        {
            cmbMarca.DataSource = null;
            cmbMarca.DataSource = Marca.Buscar();

            cmbTipo.DataSource = null;
            cmbTipo.DataSource = TipoProducto.Buscar();
        }
        private void Buscar()
        {
            dgvProductos.DataSource = Producto.Buscar(txtBuscar.Text);
        }
        private void CargarDatos()
        {
            txtNombre.Text = objeto.Nombre;
            numPrecio.Value = (decimal)objeto.Precio;
            if (objeto.Marca != null && objeto.Tipo != null)
            {
                cmbMarca.Text = objeto.Marca.Nombre;
                cmbTipo.Text = objeto.Tipo.Nombre;
            }
        }
        private void SetDatos()
        {
            objeto.Nombre = txtNombre.Text;
            objeto.Precio = (double)numPrecio.Value;
            objeto.Marca = cmbMarca.SelectedItem as Marca;
            objeto.Tipo = cmbTipo.SelectedItem as TipoProducto;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SetDatos();
            objeto.Guardar();
            MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlDatos.Enabled = false;
            Buscar();
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
            objeto = new Producto();
            CargarDatos();
            pnlDatos.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvProductos.CurrentRow != null)
                {
                    objeto = dgvProductos.CurrentRow.DataBoundItem as Producto;
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
                if (dgvProductos.CurrentRow != null)
                {
                    Producto m = dgvProductos.CurrentRow.DataBoundItem as Producto;
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

        private void btnmasMarcas_Click(object sender, EventArgs e)
        {
            FormMarcas m = new FormMarcas();
            m.ShowDialog();
            cmbMarca.DataSource = null;
            cmbMarca.DataSource = Marca.Buscar();
        }

        private void bntmasTipo_Click(object sender, EventArgs e)
        {
            FormTipoPro t = new FormTipoPro();
            t.ShowDialog();
            cmbTipo.DataSource = null;
            cmbTipo.DataSource = TipoProducto.Buscar();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            VisorFiltrado f = new VisorFiltrado();
            f.ShowDialog();
        }
    }

}

