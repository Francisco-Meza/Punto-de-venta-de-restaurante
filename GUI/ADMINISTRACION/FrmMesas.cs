using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_DE_NEGOCIOS;

namespace GUI.ADMINISTRACION
{
    public partial class FrmMesas : Form
    {
        private readonly FrmMenu padreMenu;
        public FrmMesas(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
            Read();
        }
        public void Read()
        {
            try
            {
                dgvListaMesas.DataSource = ClsMesa_N.Read();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
