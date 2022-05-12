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
    public partial class FrmMesas : Form
    {
        private readonly FrmMenu padreMenu;
        public FrmMesas(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
        }

        private void BtnMesa1_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmDetallePedidos());
        }

        private void BtnMesa2_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmDetallePedidos());
        }

        private void BtnMesa3_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmDetallePedidos());
        }

        private void BtnMesa4_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmDetallePedidos());
        }

        private void BtnMesa5_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmDetallePedidos());
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
