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
    public partial class FrmCuentas : Form        
    {
    private readonly FrmMenu padreMenu;
        public FrmCuentas(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
