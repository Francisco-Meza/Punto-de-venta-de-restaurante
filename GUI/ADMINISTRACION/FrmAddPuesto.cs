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
        private string _nombre, _descripcion, msj;
        private FrmMenu menu;

        public FrmAddPuesto(FrmMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtNombre.Text != "" && TxtDescripcion.Text != ""){
                _nombre = TxtNombre.Text;
                _descripcion = TxtDescripcion.Text;
                msj = ClsPuesto_N.Create(_nombre,_descripcion);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu.AbrirFHijo(new FrmPuesto(menu));
                    this.Dispose();
                }
                else if (msj.Equals("NO"))
                {
                    MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmPuesto(menu));
        }

        private void Validar()
        {
            if (TxtDescripcion.Text != "" && TxtNombre.Text != "")
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
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
        }
    }
}
