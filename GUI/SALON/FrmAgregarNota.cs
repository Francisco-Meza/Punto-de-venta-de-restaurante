using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.SALON
{
    public partial class FrmAgregarNota : Form
    {
        private FrmDetallePedidos menu;
        public FrmAgregarNota(FrmDetallePedidos menu)
        {
            InitializeComponent();
            this.menu = menu;
            if(this.menu.Nota != null)
            {
                txtNota.Text = menu.Nota;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("¿Seguro que quieres guardar?","ADVERTENCIA",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(a == DialogResult.OK)
            {
                menu.Nota = txtNota.Text;
            }
        }
    }
}
