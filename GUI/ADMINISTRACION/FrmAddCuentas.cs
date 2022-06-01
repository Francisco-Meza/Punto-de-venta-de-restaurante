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
        private string nombre, apePa, apeMa, correo, clave, telefono, claveConfirmar;
        private DateTime fechaN;
        private int puesto;
        private int id;
        public FrmAddPersonal()
        {
            InitializeComponent();
            BtnGuardar.Enabled = false;
            cuenta = new ClsCuentas_N();
            fechaN = new DateTime();
            id = 0;
            IniciarDatos();
        }
        public FrmAddPersonal(int id)
        {
            InitializeComponent();
            BtnGuardar.Enabled = true;
            cuenta = new ClsCuentas_N();
            fechaN = new DateTime();
            IniciarDatos(id);
        }
        private void IniciarDatos()
        {
            try
            {
                BtnGuardar.Enabled = true;
                cmbPuesto.DataSource = cuenta.ReadPuesto();
                cmbPuesto.DisplayMember = "NOMBRE";
                cmbPuesto.ValueMember = "ID";
                DtpFecha.Value = DateTime.Today;
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
                fechaN = (DateTime)datos.Rows[0][3];
                telefono = datos.Rows[0][4].ToString();
                correo = datos.Rows[0][5].ToString();
                clave = datos.Rows[0][6].ToString();
                puesto = Convert.ToInt32(datos.Rows[0][7]);
                TxtNombre.Text = nombre;
                TxtApelPat.Text = apePa;
                TxtApelMat.Text = apeMa;
                DtpFecha.Value = fechaN;
                TxtTelefonoPersonal.Text = telefono;
                TxtCorreo.Text = correo;
                TxtContra.Text = clave;
                cmbPuesto.SelectedValue = puesto;
                this.id = id;
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                fechaN = DtpFecha.Value.Date;
                if (fechaN.AddYears(18) <= DateTime.Today)
                {
                    clave = TxtContra.Text;
                    claveConfirmar = txtConfirContra.Text;
                    if (claveConfirmar.Equals(clave))
                    {
                        nombre = TxtNombre.Text;
                        apePa = TxtApelPat.Text;
                        apeMa = TxtApelMat.Text;
                        puesto = Convert.ToInt32(cmbPuesto.SelectedValue);
                        correo = TxtCorreo.Text;
                        telefono = TxtTelefonoPersonal.Text;
                        string msj = cuenta.Create(puesto, correo, clave, nombre, apePa, apeMa, fechaN);
                        if (msj.Equals("OK"))
                        {
                            MessageBox.Show("Se dio de alta el usuario con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("La fecha no es adecuada para poder trabajar", "No es mayor de edad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                fechaN = DtpFecha.Value.Date;
                if (fechaN.AddYears(18) <= DateTime.Today)
                {
                    clave = TxtContra.Text;
                    claveConfirmar = txtConfirContra.Text;
                    if (claveConfirmar.Equals(clave))
                    {
                        nombre = TxtNombre.Text;
                        apePa = TxtApelPat.Text;
                        apeMa = TxtApelMat.Text;
                        puesto = Convert.ToInt32(cmbPuesto.SelectedValue);
                        correo = TxtCorreo.Text;
                        telefono = TxtTelefonoPersonal.Text;
                        string msj = cuenta.Update(this.id,puesto, correo, clave, nombre, apePa, apeMa, fechaN, telefono);
                        if (msj.Equals("OK"))
                        {
                            MessageBox.Show("Se actualizo el usuario con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("La fecha no es adecuada para poder trabajar", "No es mayor de edad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void Validar()
        {
            if (TxtNombre.Text != String.Empty && TxtApelPat.Text != String.Empty && TxtApelMat.Text != String.Empty && TxtTelefonoPersonal.Text != String.Empty && TxtCorreo.Text != String.Empty && TxtContra.Text != String.Empty)
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
