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
    public partial class FrmAddPersonal : Form
    {
        string nombre, ApePa, ApeMa, Correo, Puesto, Contra, Telefono, FechaN;
        
        Validaciones val = new Validaciones();
        public FrmAddPersonal()
        {
            InitializeComponent();
            BtnGuardar.Enabled = false;
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtApeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar();
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtFechaN_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar();
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar();
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            nombre = TxtNombreP.Text;
            ApePa = TxtApeP.Text;
            ApeMa = TxtApeM.Text;
            FechaN = TxtFechaN.Text;
            Contra = TxtContra.Text;
            Puesto = TxtNombreP.Text;
            Correo = TxtCorreo.Text;
            Telefono = TxtTelefonoPersonal.Text;
            if (!val.VerificarTelefono(Telefono))
            {
                MessageBox.Show("El formato del telefono es incorrecto");
            }
            if (!val.VerificarCorreo(Correo))
            {
                MessageBox.Show("El formato del correo es incorrecto");
            }
            if (!val.VerificarContrasena(Contra))
            {
                MessageBox.Show("El formato de la contraseña es incorrecto");
            }

        }
        public void validar()
        {
            if (TxtNombreP.Text != String.Empty && TxtApeP.Text != String.Empty && TxtApeM.Text != String.Empty && TxtFechaN.Text != String.Empty && TxtTelefonoPersonal.Text != String.Empty && TxtCorreo.Text != String.Empty && TxtContra.Text != String.Empty && TxtPuesto.Text != String.Empty)
            {
                BtnGuardar.Enabled = true;
            }
            else
            {
                BtnGuardar.Enabled = false;
            }
        }

    }
}
