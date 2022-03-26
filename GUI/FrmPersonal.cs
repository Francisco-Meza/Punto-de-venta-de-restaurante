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
    public partial class FrmPersonal : Form
    {
        private FrmMenu padreMenu;
        public FrmPersonal(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            padreMenu.abrirFHijo(new FrmAddPersonal());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            padreMenu.abrirFHijo(new FrmAddPersonal());
        }
    }
}
