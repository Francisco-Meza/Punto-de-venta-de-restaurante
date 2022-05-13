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
    public partial class FrmAddPuesto : Form
    {//Falta agregar para que actualicen
        private string _id, _nombre, _descripcion;

        public FrmAddPuesto()
        {
            InitializeComponent();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtID.Text != "" && TxtNombre.Text != "" && TxtDescripcion.Text != ""){
                _id = TxtID.Text;
                _nombre = TxtNombre.Text;
                _descripcion = TxtDescripcion.Text;
                ClsPuesto_N.Create(_id,_nombre,_descripcion);
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
