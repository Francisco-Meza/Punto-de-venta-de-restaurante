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
    public partial class FrmPedidos : Form
    {
        private readonly FrmMenu padreMenu;
        public FrmPedidos(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
