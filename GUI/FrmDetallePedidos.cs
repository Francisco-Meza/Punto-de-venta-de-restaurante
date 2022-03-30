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
        public FrmDetallePedidos()
        {
            InitializeComponent();
            
            cbClasificacion.KeyDown += new KeyEventHandler(Control_KeyDown);
            cbProductos.KeyDown += new KeyEventHandler(Control_KeyDown);
            NumCantidad.KeyDown += new KeyEventHandler(Control_KeyDown);
            btnAgregar.KeyDown += new KeyEventHandler(Control_KeyDown);
            
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
