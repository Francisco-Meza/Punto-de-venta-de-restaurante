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

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO") //Al dar clic en el textbox se borra el texto
            {
                txtUsuario.Text = "";//Se limpia el textbox
                txtUsuario.ForeColor = Color.Black; //Al escribir en la caja de texto cambia su color
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") //Al quitar el cursor en el textbox se coloca la palabar usuario
            {
                txtUsuario.Text = "USUARIO";//Se colocala la palabra usuario
                txtUsuario.ForeColor = Color.LightGray; //Al escribir en la caja de texto cambia su color al original
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA") //Al dar clic en el textbox se borra el texto
            {
                txtContrasena.Text = "";//Se limpia el textbox
                txtContrasena.ForeColor = Color.Black; //Al escribir en la caja de texto cambia su color
                txtContrasena.UseSystemPasswordChar = true; //Se oculta lo que se introduce con un carcater 
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "") //Al quitar el cursor en el textbox se coloca la palabar usuario
            {
                txtContrasena.Text = "CONTRASEÑA";//Se colocala la palabra usuario
                txtContrasena.ForeColor = Color.LightGray; //Al escribir en la caja de texto cambia su color al original
                txtContrasena.UseSystemPasswordChar = false; //Se visualiza lo que se introduce
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text==""  && txtContrasena.Text=="")
            {
                MessageBox.Show("Por favor llena los datos");
                this.Show();               
            }
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
