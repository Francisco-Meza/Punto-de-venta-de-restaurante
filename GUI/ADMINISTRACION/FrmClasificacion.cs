using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ADMINISTRACION
{
    public partial class FrmClasificacion : Form
    {
        private readonly FrmMenu padreMenu;
        public FrmClasificacion(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCla_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmAddClasificacion());
        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmAddClasificacion());
        }
    }
}
