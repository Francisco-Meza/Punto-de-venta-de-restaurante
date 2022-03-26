using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmAddPersonal : Form
    {
        public FrmAddPersonal()
        {
            InitializeComponent();
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtApeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtFechaN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }
    }
}
