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
    public partial class FrmLogin : Form
    {
        private ClsCuentas_N cuenta;
        private string correo, clave;
        public FrmLogin()
        {
            InitializeComponent();
            cuenta = new ClsCuentas_N();
        }



        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();//se cierra la aplicacion
        }

        private void VtnAceptar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "" && txtContrasena.Text != "")// al poner datos en los textbox se habre el menu
            {
                correo = txtUsuario.Text.Trim();
                clave = txtContrasena.Text.Trim();
                Login(correo,clave);
                
            }
            else //si los textbox estan vacios muestra el mensaje
            {
                MessageBox.Show("Por favor llena los datos");
                this.Show();
            }
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login(string correo, string clave)
        {
            try
            {
                DataTable datos = new DataTable();
                datos = cuenta.Login(correo,clave);
                if(datos.Rows.Count <= 0)
                {
                    MessageBox.Show("No existe el usuario","ACCESO AL SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    FrmMenu frm = new FrmMenu(datos);
                    frm.Show();
                    this.Hide();
                }              
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
