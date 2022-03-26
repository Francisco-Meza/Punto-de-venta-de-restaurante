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
            this.SetStyle(ControlStyles.ResizeRedraw, true);//Elimina los parpadeos
            this.DoubleBuffered = true;
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

        int Lx, Ly;
        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            Lx = this.Location.X;
            Ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location=Screen.PrimaryScreen.WorkingArea.Location;
            IconMaximizar.Visible = true;
            IconRestaurar.Visible=false;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(950, 600);
            this.Location = new Point(Lx, Ly);
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
        public void abrirFHijo(object FormHijo)
        {
            
            if (this.PanelPadre.Controls.Count > 0)
                this.PanelPadre.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelPadre.Controls.Add(fh);
            this.PanelPadre.Tag = fh;
            fh.Show();
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

        private void BtnPedidosLocal_Click(object sender, EventArgs e)
        {
            abrirFHijo(new FrmMesas(this));
        }
       
    }
}
