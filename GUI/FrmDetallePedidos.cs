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
    public partial class FrmDetallePedidos : Form
    {
        private string clasificacion, producto;
        int cantidad;
        public FrmDetallePedidos()
        {
            InitializeComponent();
            
            cbClasificacion.KeyDown += new KeyEventHandler(Control_KeyDown);
            cbProductos.KeyDown += new KeyEventHandler(Control_KeyDown);
            NumCantidad.KeyDown += new KeyEventHandler(Control_KeyDown);
            btnAgregar.KeyDown += new KeyEventHandler(Control_KeyDown);
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
