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
    public partial class FormCliente : Form
    {
        private Cliente objeto;
        public FormCliente()
        {
            InitializeComponent();
            CargarCombos();
            Buscar();
            pnlDatos.Enabled = false;
        }

      
        #region E
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "" && numDocu.Value != 0 && cmbTipo.Text != "")
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
            objeto = new Cliente();
            CargarDatos();
            pnlDatos.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    objeto = dgvClientes.CurrentRow.DataBoundItem as Cliente;
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

                if (dgvClientes.CurrentRow != null)
                {
                    Cliente p = null;
                    p = Cliente.BuscarPorId((int)dgvClientes.CurrentRow.Cells["Id"].Value);//busca por id el cliente seleccionado
                    if (Venta.BuscarPorIdCliente(p.Id))
                    {
                        MessageBox.Show("No se puede eliminar el cliente, tiene ventas cargadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        p.Eliminar();//llama a la funcion eliminar
                        Buscar();//actualiza el form
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

        private void btnmasTipos_Click(object sender, EventArgs e)
        {
            FormTipoDoc m = new FormTipoDoc();
            m.ShowDialog();
            cmbTipo.DataSource = null;
            cmbTipo.DataSource = TipoDocumento.Buscar();
        }
        #endregion
        #region M
        public void CargarCombos()
        {
            cmbTipo.DataSource = null;
            cmbTipo.DataSource = TipoDocumento.Buscar();
        }
        private void Buscar()
        {
            dgvClientes.DataSource = Cliente.Buscar(txtBuscar.Text);
        }
        private void CargarDatos()
        {
            txtNombre.Text = objeto.Nombre;
            txtApellido.Text = objeto.Apellido;
            numDocu.Value = (decimal)objeto.NumDoc;
            if (objeto.Doc != null)
            {
                cmbTipo.Text = objeto.Doc.Nombre;
            }
        }
        private void SetDatos()
        {
            objeto.Nombre = txtNombre.Text;
            objeto.Apellido = txtApellido.Text;
            objeto.NumDoc = (int)numDocu.Value;
            objeto.Doc = cmbTipo.SelectedItem as TipoDocumento;
        }
        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            VisorCliente v = new VisorCliente();
            v.ShowDialog();
        }
    }
}
