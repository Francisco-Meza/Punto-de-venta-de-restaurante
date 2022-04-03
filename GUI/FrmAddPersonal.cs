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
        string nombre, apePa, apeMa, correo, puesto, contra, telefono, fechaN;
        readonly Validaciones val = new Validaciones();
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
            Validar();
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtFechaN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar();
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar();
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            nombre = TxtNombreP.Text;
            apePa = TxtApeP.Text;
            apeMa = TxtApeM.Text;
            fechaN = TxtFechaN.Text;
            contra = TxtContra.Text;
            puesto = TxtNombreP.Text;
            correo = TxtCorreo.Text;
            telefono = TxtTelefonoPersonal.Text;
            if (!val.VerificarTelefono(telefono))
            {
                MessageBox.Show("El formato del telefono es incorrecto");
            }
            if (!val.VerificarCorreo(correo))
            {
                MessageBox.Show("El formato del correo es incorrecto");
            }
            if (contra.Length >= 6)
            {
                if (!val.VerificarContrasena(contra))
                {
                    MessageBox.Show("La contraseña debe llevar por lo menos un numero y un caracter especial");
                }
            }
            else MessageBox.Show("La contraseña debe llevar por lo menos 6 caracteres");

        }
        public void Validar()
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
