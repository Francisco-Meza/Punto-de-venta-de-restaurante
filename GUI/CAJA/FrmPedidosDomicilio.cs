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
    public partial class FrmPedidosDomicilio : Form
    {
        private readonly FrmMenu padreMenu;
        public FrmPedidosDomicilio(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
        }

        private void BtnAceptarDomicilio_Click(object sender, EventArgs e)
        {
            if (TxtNombreCliente.Text != "" && TxtTelefonoCliente.Text != "" && txtCalleCliente.Text !="" 
                && txtNumCasaCliente.Text != "" && txtColoniaCliente.Text != "" && txtLocalidadCliente.Text != "")// al poner datos en los textbox se habre el menu
            {
                padreMenu.AbrirFHijo(new FrmDetallePedidos());
            }
            else //si los textbox estan vacios muestra el mensaje
            {
                MessageBox.Show("Por favor llena los datos");
                this.Show();
            }
            
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtCalleCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtColoniaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtLocalidadCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar numeros
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }
    }
}
