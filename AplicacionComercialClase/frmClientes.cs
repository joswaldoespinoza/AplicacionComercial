using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CADAplicacionComercial; 

namespace AplicacionComercialClase
{
    public partial class frmClientes : Form
    {
        private int i = 0;
        private bool nuevo;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            dgvClientes.DataSource = CADCliente.GetData(); // Cargo todos los registros
            MostrarRegistro();
        }
        private void MostrarRegistro()
        {
            if (dgvClientes.Rows.Count == 0) return;

            txtIdCliente.Text = dgvClientes.Rows[i].Cells["IDCliente"].Value.ToString();
            cbTipoDocumento.SelectedValue= dgvClientes.Rows[i].Cells["IdTipoDocumento"].Value;
            txtDocumento.Text = dgvClientes.Rows[i].Cells["Documento"].Value.ToString();
            txtComercial.Text = dgvClientes.Rows[i].Cells["NombreComercial"].Value.ToString();
            txtNombres.Text = dgvClientes.Rows[i].Cells["NombresContacto"].Value.ToString();
            txtApellidos.Text = dgvClientes.Rows[i].Cells["ApellidosContacto"].Value.ToString();
            txtDireccion.Text = dgvClientes.Rows[i].Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgvClientes.Rows[i].Cells["Telefono1"].Value.ToString();
            txtCelular.Text = dgvClientes.Rows[i].Cells["Telefono2"].Value.ToString();
            txtCorreo.Text = dgvClientes.Rows[i].Cells["Correo"].Value.ToString();
            txtNotas.Text = dgvClientes.Rows[i].Cells["Notas"].Value.ToString();
            try
            {
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvClientes.Rows[i].Cells["Aniversario"].Value);
            }
            catch (Exception)
            {
                dtpFechaNacimiento.Value = DateTime.Now;

            }
        }

        private void HabilitarCampos()
        {
            tsbPrimero.Enabled = false;
            tsbUltimo.Enabled = false;
            tsbAnterior.Enabled = false;
            tsbSiguiente.Enabled = false;

            tsbModificar.Enabled = false;
            tsbNuevo.Enabled = false;
            tsbEliminar.Enabled = false;
            tsbBuscar.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;

            txtDocumento.ReadOnly = false;
            txtComercial.ReadOnly = false;
            txtNombres.ReadOnly = false;
            txtApellidos.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            txtNotas.ReadOnly = false;

            cbTipoDocumento.Enabled = true;
            dtpFechaNacimiento.Enabled = true;

            cbTipoDocumento.Focus();
        }

        private void DesHabilitarCampos()
        {
            tsbPrimero.Enabled = true;
            tsbUltimo.Enabled = true;
            tsbAnterior.Enabled = true;
            tsbSiguiente.Enabled = true;

            tsbModificar.Enabled = true;
            tsbNuevo.Enabled = true;
            tsbEliminar.Enabled = true;
            tsbBuscar.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;

            txtDocumento.ReadOnly = true;
            txtComercial.ReadOnly = true;
            txtNombres.ReadOnly = true;
            txtApellidos.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtNotas.ReadOnly = true;

            cbTipoDocumento.Enabled = true;
            dtpFechaNacimiento.Enabled = true;

            cbTipoDocumento.Focus();
        }

        private void LimpiarCampos()
        {
            txtIdCliente.Text = "";
            txtDocumento.Text = "";
            txtComercial.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = ""; ;
            txtTelefono.Text = ""; ;
            txtCelular.Text = ""; ;
            txtCorreo.Text = "";
            txtNotas.Text = "";

            cbTipoDocumento.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;

            cbTipoDocumento.Focus();
        }

        private bool ValidarCampos()
        {
            if (cbTipoDocumento.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbTipoDocumento, "Debe seleccionar un Tipo de Documento");
                cbTipoDocumento.Focus();
                return false;
            }
            errorProvider1.SetError(cbTipoDocumento, "");

            if (txtDocumento.Text == "")
            {
                errorProvider1.SetError(txtDocumento, "Debe Ingresar Documento");
                txtDocumento.Focus();
                return false;
            }
            errorProvider1.SetError(txtDocumento, "");

            if (txtComercial.Text == "")
            {
                errorProvider1.SetError(txtComercial, "Debe Ingresar nombre Comercial");
                txtComercial.Focus();
                return false;
            }
            errorProvider1.SetError(txtComercial, "");

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Debe Ingresar Nombre");
                txtNombres.Focus();
                return false;
            }
            errorProvider1.SetError(txtNombres, "");

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe Ingresar Apellidos");
                txtApellidos.Focus();
                return false;
            }
            errorProvider1.SetError(txtApellidos, "");

            return true;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (i >= dgvClientes.Rows.Count - 1) return;
            i++;
            MostrarRegistro();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i++;
            MostrarRegistro();
        }

        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            MostrarRegistro();
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            i = dgvClientes.Rows.Count - 1;
            MostrarRegistro();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            nuevo = false;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesHabilitarCampos();
            MostrarRegistro();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimpiarCampos();
            nuevo = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
           if (!ValidarCampos()) return;
           if (nuevo)
            {
                CADCliente.InsertCliente(
                    (int)cbTipoDocumento.SelectedValue,
                    txtDocumento.Text,
                    txtComercial.Text,
                    txtNombres.Text,
                    txtApellidos.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtCelular.Text,
                    txtCorreo.Text,
                    txtNotas.Text,
                    dtpFechaNacimiento.Value);
            }
            else
            {
                CADCliente.UpdateCliente(
                    (int)cbTipoDocumento.SelectedValue,
                    txtDocumento.Text,
                    txtComercial.Text,
                    txtNombres.Text,
                    txtApellidos.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtCelular.Text,
                    txtCorreo.Text,
                    txtNotas.Text,
                    dtpFechaNacimiento.Value,
                    Convert.ToInt32(txtIdCliente.Text));
            }
            DesHabilitarCampos();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = CADCliente.GetData();
            if (nuevo) tsbUltimo_Click(sender, e);
            MostrarRegistro();
        }

        public void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rpta = MessageBox.Show("¿Estas seguro de borrar el actual registro?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpta == DialogResult.No) return;
            CADCliente.DeleteCliente(Convert.ToInt32(txtIdCliente.Text));
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = CADCliente.GetData();
            //            if (nuevo) tsbUltimo_Click(sender, e);
            if (i != 0) i--;
            MostrarRegistro();
        }
    }
}
