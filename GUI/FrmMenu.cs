using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        //---------------Metodo para arrastrar en form-----------------//
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RelaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        //--------------Eventos de minimizar,restaurar,Maximizar y cerrar------//
        private void IconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaurar.Visible = true;
            IconMaximizar.Visible = false;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void PanelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            RelaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            abrirFHijo(new FrmPersonal(this));
        }
        private Form frmHijo = null;
        public void abrirFHijo(Form Hijo)
        {
            if (frmHijo != null)
                frmHijo.Close();
            frmHijo = Hijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(frmHijo);
            PanelPadre.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            abrirFHijo(new FrmProductos(this));
        }

        private void BtnPedidoDomi_Click(object sender, EventArgs e)
        {
            abrirFHijo(new FrmPedidosDomicilio(this));
        }

        private void BtnCajero_Click(object sender, EventArgs e)
        {
            abrirFHijo(new FrmPedidos(this));
        }
    }
}
