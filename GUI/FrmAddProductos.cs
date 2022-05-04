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

namespace GUI
{
    public partial class FrmAddProductos : Form
    {
        private string Nombre, Descripcion, Clasificacion, Precio;
        
        public FrmAddProductos()
        {
            InitializeComponent();
            BtnGuardarPro.Enabled = false;
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtApeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar();
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar();
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Nombre = TxtNombrePro.Text;
            Descripcion = TxtDescriPro.Text;
            Clasificacion = TxtClaPro.Text;
            Precio = TxtPrecioPro.Text;
            

        }
        public void Validar()
        {
            if (TxtNombrePro.Text != String.Empty && TxtDescriPro.Text != String.Empty && TxtClaPro.Text != String.Empty && TxtPrecioPro.Text != String.Empty)
            {
                BtnGuardarPro.Enabled = true;
            }
            else
            {
                BtnGuardarPro.Enabled = false;
            }
        }
    }
}
