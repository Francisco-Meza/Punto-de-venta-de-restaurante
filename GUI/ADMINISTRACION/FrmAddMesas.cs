using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using LOGICA_DE_NEGOCIOS;
>>>>>>> 42fcb316eff604bf2573bfce97cf8a06b3ddbf26

namespace GUI.ADMINISTRACION
{
    public partial class FrmAddMesas : Form
    {
<<<<<<< HEAD
=======
        private string _id, _numeroMesa, _numeroComensales, _descripcion;
>>>>>>> 42fcb316eff604bf2573bfce97cf8a06b3ddbf26
        public FrmAddMesas()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======
        private void TxtNumeroMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                Validar();
                e.Handled = true;//-- Decimos que si se controlo el evento
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
        
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (TxtID.Text != "" && TxtNumeroMesa.Text != "" && TxtNumCom.Text != "" && txtDesc.Text != "")
            {
                _id = TxtID.Text;
                _numeroComensales = TxtNumCom.Text;
                _descripcion = txtDesc.Text;
                _numeroMesa = TxtNumeroMesa.Text;
                ClsMesa_N.Create(_id, _numeroMesa, _numeroComensales, _descripcion);
            }
            else
            {
                MessageBox.Show("Es obligatorio llenar la descripcion");
                Limpiar();
            }
        }

        private void Validar()
        {
            if (TxtID.Text != "" && TxtNumeroMesa.Text != "")
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
            TxtNumeroMesa.Text = "";
            txtDesc.Text = "";
            TxtNumCom.Text = "";
        }


>>>>>>> 42fcb316eff604bf2573bfce97cf8a06b3ddbf26
    }
}
