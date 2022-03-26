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
    public partial class FrmAddProductos : Form
    {
        public FrmAddProductos()
        {
            InitializeComponent();
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
