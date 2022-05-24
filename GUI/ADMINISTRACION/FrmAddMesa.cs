using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_DE_NEGOCIOS;

namespace GUI.ADMINISTRACION
{
    public partial class FrmAddMesa : Form
    {
        private string _id, _numeroMesa, _numeroComensales, _descripcion;
        public FrmAddMesa()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtNumMesa.Text != "" && txtNumCom.Text != "" && txtDesc.Text != "")
            {
                _id = txtId.Text;
                _numeroMesa = txtNumMesa.Text;
                _numeroComensales = txtNumCom.Text;
                _descripcion = txtDesc.Text;
                ClsMesa_N.Create(_id, _numeroMesa, _numeroComensales, _descripcion);
            }
            else
            {
                MessageBox.Show("Es obligatorio llenar la descripcion");
                Limpiar();
            }
        }
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                Validar();
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                Validar();
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void Validar()
        {
            if (TxtID.Text != "" && TxtNombre.Text != "")
            {
                BtnGuardar.Enabled = true;
            }
            else
            {
                BtnGuardar.Enabled = false;
            }
        }
        private void Limpiar()
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
        }
    }
}
