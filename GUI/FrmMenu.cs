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
using GUI.ADMINISTRACION;

namespace GUI
{//
    public partial class FrmMenu : Form
    {
        private int _idCuenta, _idPuesto;
        private string _nombrePuesto, _nombrePersona;
        public FrmMenu(DataTable datos)
        {
            InitializeComponent();
            _idCuenta = Convert.ToInt32(datos.Rows[0][0]);
            _idPuesto = Convert.ToInt32(datos.Rows[0][1]);
            _nombrePuesto = datos.Rows[0][2].ToString();
            _nombrePersona = datos.Rows[0][3].ToString();
            this.SetStyle(ControlStyles.ResizeRedraw, true);//Elimina los parpadeos
            this.DoubleBuffered = true;
            IniciarDatos();
        }
        private void IniciarDatos()//Verifica si que tipo de usuario entro
        {
            lblNombrePersona.Text = "Bienvenido "+_nombrePersona;
            switch (_idPuesto)
            {
                case 1://Para administrador
                    {
                        BtnPersonal.Enabled = true;
                        BtnPersonal.Visible = true;
                        BtnProductos.Enabled = true;
                        BtnProductos.Visible = true;
                        BtnPedidos.Enabled = true;
                        BtnPedidos.Visible = true;
                        BtnPuesto.Enabled = true;
                        BtnPuesto.Visible = true;
                        BtnMesa.Enabled = true;
                        BtnMesa.Visible = true;
                        break;
                    }
                case 2://Para Cajero
                    {
                        break;
                    }
                case 3://Para Mesero
                    {
                        break;
                    }
                default:
                    break;
            }
        }
        //---------------Metodo para arrastrar en form-----------------//
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RelaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void IconCerrar_Click(object sender, EventArgs e)//----Finaliza el proyecto
        {
            DialogResult res;
            res = MessageBox.Show("¿Seguro que quieres salir de la aplicacion?","SALIR",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(res == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        int Lx, Ly;
        int sw, sh;
        private void PanelBarra_MouseDown(object sender, MouseEventArgs e) //---Se llama un  metodo para poder mover el formuario
        {
            RelaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        private void IconMaximizar_Click(object sender, EventArgs e) //-----------Evento de maximizar el formulario -------------
        {
            Lx = this.Location.X;
            Ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location=Screen.PrimaryScreen.WorkingArea.Location;
            IconMaximizar.Visible = false;
            IconRestaurar.Visible=true;
        }
       
        private void IconMinimizar_Click(object sender, EventArgs e)//------------Evento de minimizar el formulario --------------
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void IconRestaurar_Click(object sender, EventArgs e)//-------- Realiza el evento de poner el formulario a su tamaño normal
        {
            this.Size = new Size(sw, sh);
            this.Size = new Size(950, 600);
            this.Location = new Point(Lx, Ly);
            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }
        public void AbrirFHijo(object FormHijo) //Metodo que nos ayuda a abrir y llamar los formularios al padre

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
       
        //---------- Son los botones del menu que cada uno nos muestra un fromulario
        private void BtnPersonal_Click(object sender, EventArgs e) 
        {
            AbrirFHijo(new FrmPersonal(this));
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmProductos(this));
        }
        private void BtnPedidoDomi_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmPedidosDomicilio(this));
        }

        private void BtnPuesto_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmPuesto(this));
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmMesas(this));
        }

        private void BtnCajero_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmPedidos(this));
        }
        private void BtnPedidosLocal_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmMesas(this));
        }
    }
}
