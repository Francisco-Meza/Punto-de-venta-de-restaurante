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
    public partial class FrmCuentas : Form        
    {
        private readonly FrmMenu padreMenu;
        public FrmCuentas(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
            Read();
        }

        public void Read()
        {
            try
            {
                dgvListaCuentas.DataSource = ClsCuentas_N.Read();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            padreMenu.AbrirFHijo(new FrmAddCuentas());
        }
    }
}
