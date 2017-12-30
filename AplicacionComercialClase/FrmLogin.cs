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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text =="")
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar un usuario");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txtUsuario, "");

            if(txtClave.Text == "")
            {
                errorProvider1.SetError(txtClave, "Debe ingresar una Clave");
                txtClave.Focus();
                return;
            }
            errorProvider1.SetError(txtClave, "");

            if (!CADUsuario.ValidarUsuario(txtUsuario.Text, txtClave.Text))
                {
                MessageBox.Show("USUARIO o CLAVE no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtUsuario.Focus();
                return;
                }
            frmPrincipal miForm = new frmPrincipal();
            miForm.Show();
            this.Hide();
        }
    }
}
