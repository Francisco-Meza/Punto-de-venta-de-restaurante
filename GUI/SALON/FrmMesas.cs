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

       // padreMenu.AbrirFHijo(new FrmDetallePedidos());

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmAddMesas());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmAddMesas());
        }
    }
}
