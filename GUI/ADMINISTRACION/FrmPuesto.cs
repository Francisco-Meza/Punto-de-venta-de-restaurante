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
    public partial class FrmPuesto : Form
    {
        private readonly FrmMenu menu;
        public FrmPuesto(FrmMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            Read();
        }
        public void Read()
        {
            try
            {
                dgvListaPuestos.DataSource = ClsPuesto_N.Read();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmAddPuesto(menu));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
