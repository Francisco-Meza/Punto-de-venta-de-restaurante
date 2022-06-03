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
    public partial class FrmDetallePedidos : Form
    {
        private string clasificacion, producto;
        int cantidad, idPedido, id;
        private FrmMenu menu;
        private ClsPedidoLocal_N local;
        private const int mesero = 1;
        private const int cajero = 3;
        public FrmDetallePedidos(FrmMenu menu, int id)
        {
            InitializeComponent();
            this.menu = menu;
            idPedido = 0;
            this.id = id;
            cbClasificacion.KeyDown += new KeyEventHandler(Control_KeyDown);
            cbProductos.KeyDown += new KeyEventHandler(Control_KeyDown);
            NumCantidad.KeyDown += new KeyEventHandler(Control_KeyDown);
            btnAgregar.KeyDown += new KeyEventHandler(Control_KeyDown);
            IniciarCombos();
        }
        private void IniciarCombos()
        {
            switch (id)
            {
                case mesero:
                    {
                        local = new ClsPedidoLocal_N();
                        cbMesa.DataSource = local.ReadMesas();
                        cbMesa.DisplayMember = "NUMERO";
                        cbMesa.ValueMember = "ID";
                        //
                        cbClasificacion.DataSource = local.ReadClasificacion();
                        cbClasificacion.DisplayMember = "NOMBRE";
                        cbClasificacion.ValueMember = "ID";
                        //
                        cbProductos.DataSource = local.ReadProducto();
                        cbProductos.DisplayMember = "NOMBRE";
                        cbProductos.ValueMember = "ID";
                        break;
                    }
                default:
                    break;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            clasificacion = cbClasificacion.Text;
            producto = cbProductos.Text;
            cantidad = int.Parse(NumCantidad.Text);
            Validar();
        }

        public void Validar()
        {
            if (cbClasificacion.Text != String.Empty && cbProductos.Text != String.Empty && NumCantidad.Text != String.Empty )
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        public void Control_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctr = (Control)sender;
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                    ctr.Parent.SelectNextControl(ctr, true, true, true, true);
                    e.Handled = true;               
            }
        }
    }
}
//Data Source=DANNY;Initial Catalog=Restaurante;User ID=MaestroCatalogo;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
