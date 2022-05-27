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
        ClsCuentas_N cuenta;
        private string nombre, apePa, apeMa, correo, clave, telefono, fechaN;
        private int puesto;
        public FrmAddPersonal()
        {
            InitializeComponent();
            BtnGuardar.Enabled = false;
            cuenta = new ClsCuentas_N();
            IniciarDatos();
        }
        public FrmAddPersonal(int id)
        {
            InitializeComponent();
            BtnGuardar.Enabled = false;
            cuenta = new ClsCuentas_N();
            IniciarDatos(id);
        }
        private void IniciarDatos()
        {
            try
            {
                cmbPuesto.DataSource = cuenta.ReadPuesto();
                cmbPuesto.DisplayMember = "NOMBRE";
                cmbPuesto.ValueMember = "ID";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error contactarse con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void IniciarDatos(int id)
        {
            try
            {
                cmbPuesto.DataSource = cuenta.ReadPuesto();
                cmbPuesto.DisplayMember = "NOMBRE";
                cmbPuesto.ValueMember = "ID";
                DataTable datos = new DataTable();
                datos = cuenta.Read(id);
                nombre = datos.Rows[0][0].ToString();
                apePa = datos.Rows[0][1].ToString();
                apeMa = datos.Rows[0][2].ToString();
                fechaN = datos.Rows[0][3].ToString();
                telefono = datos.Rows[0][4].ToString();
                correo = datos.Rows[0][5].ToString();
                clave = datos.Rows[0][6].ToString();
                puesto = Convert.ToInt32(datos.Rows[0][7]);
                TxtNombre.Text = nombre;
                TxtApelPat.Text = apePa;
                TxtApelMat.Text = apeMa;
                //fecha
                TxtTelefonoPersonal.Text = telefono;
                TxtCorreo.Text = correo;
                TxtContra.Text = clave;
                cmbPuesto.SelectedValue = puesto;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error contactarse con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
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
            nombre = TxtNombre.Text;
            apePa = TxtApelPat.Text;
            apeMa = TxtApelMat.Text;
            fechaN = TxtFechaN.Text;
            clave = TxtContra.Text;
            puesto = int.Parse(TxtNombre.Text);
            correo = TxtCorreo.Text;
            telefono = TxtTelefonoPersonal.Text;
            /**/

        }
        public void Validar()
        {
            if (TxtNombre.Text != String.Empty && TxtApelPat.Text != String.Empty && TxtApelMat.Text != String.Empty && TxtFechaN.Text != String.Empty && TxtTelefonoPersonal.Text != String.Empty && TxtCorreo.Text != String.Empty && TxtContra.Text != String.Empty)
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
