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
{
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
            IniciarDatos();
            this.SetStyle(ControlStyles.ResizeRedraw, true);//Elimina los parpadeos
            this.DoubleBuffered = true;
            
        }
        
        private void IniciarDatos()//Verifica si que tipo de usuario entro
        {
            lblNombrePersona.Text = "Bienvenido "+_nombrePersona;
            switch (_idPuesto)
            {
                case 1://Para administrador
                    {
                        BtnProductos.Enabled = true;
                        BtnProductos.Visible = true;
                        BtnPedidosG.Enabled = true;
                        BtnPedidosG.Visible = true;
                        BtnPuesto.Enabled = true;
                        BtnPuesto.Visible = true;
                        BtnMesas.Enabled = true;
                        BtnMesas.Visible = true;
                        BtnClasificacion.Enabled = true;
                        BtnClasificacion.Visible = true;
                        BtnCuentas.Enabled = true;
                        BtnCuentas.Visible = true;

                        lblAdministrador.Enabled = true;
                        lblAdministrador.Visible = true;
                        lblAdministrador.Location = new Point(this.Top);
                        lblAdministrador.Top = 25;
                        BtnPuesto.Location = new Point(0, lblAdministrador.Location.Y+lblAdministrador.Height+10);
                        BtnCuentas.Location = new Point(0, BtnPuesto.Location.Y + BtnPuesto.Height);
                        BtnProductos.Location = new Point(0, BtnCuentas.Location.Y+BtnCuentas.Height);
                        BtnClasificacion.Location = new Point(0, BtnProductos.Location.Y+BtnProductos.Height);
                        BtnMesas.Location = new Point(0, BtnClasificacion.Location.Y+BtnClasificacion.Height);
                        BtnPedidosG.Location = new Point(0, BtnMesas.Location.Y + BtnMesas.Height);
                        break;
                    }
                case 2://Para Cajero
                    {
                        BtnPedidosG.Enabled = true;
                        BtnPedidosG.Visible = true;
                        lblCajero.Enabled = true;
                        lblCajero.Visible = true;
                        lblCajero.Location = new Point(this.Top);
                        BtnPedidosG.Location = new Point(0, lblCajero.Location.Y + lblCajero.Height);
                        break;
                    }
                case 3://Para Mesero
                    {
                        lblMesero.Location = new Point(0, 0);
                        BtnPedidosLocal.Location = new Point(0,lblMesero.Height);
                        BtnPedidosLocal.Enabled = true;
                        BtnPedidosLocal.Visible = true;

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

        public int IdCuenta { get => _idCuenta; }
        public int IdPuesto { get => _idPuesto; }
        public string NombrePuesto { get => _nombrePuesto; }
        public string NombrePersona { get => _nombrePersona; }

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
        //Administrador-----
        
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmProductos(this));
            
        }
        private void BtnPuesto_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmPuesto(this));
            
        }

        private void BtnCuentas_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmCuentas(this));
        }

        private void BtnClasificacion_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmClasificacion(this));
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmPerfilPersonal(this));
        }

        private void PanelPadre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMesas_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmMesas(this));
        }
        //Cajero-----------------------------
        private void BtnPedidoDomi_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmPedidosDomicilio(this));
        }
        private void BtnPedidosG_Click(object sender, EventArgs e)
        {

            AbrirFHijo(new FrmPedidos(this));
        }
        //Mesero-----------

        private void BtnPedidosLocal_Click(object sender, EventArgs e)
        {
            AbrirFHijo(new FrmMesas(this));
        }
    }
}
