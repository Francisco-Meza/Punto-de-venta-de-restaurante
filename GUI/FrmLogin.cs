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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();//se cierra la aplicacion
        }

        private void VtnAceptar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text!="" && txtContrasena.Text!="")// al poner datos en los textbox se habre el menu
            {
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();
            }
            else //si los textbox estan vacios muestra el mensaje
            {
                MessageBox.Show("Por favor llena los datos");
                this.Show();
            }
        }
    }
}
