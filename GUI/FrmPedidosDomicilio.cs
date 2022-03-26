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
    public partial class FrmPedidosDomicilio : Form
    {
        private FrmMenu padreMenu;
        public FrmPedidosDomicilio(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
        }

        private void BtnAceptarDomicilio_Click(object sender, EventArgs e)
        {
            padreMenu.abrirFHijo(new FrmDetallePedidos());
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
