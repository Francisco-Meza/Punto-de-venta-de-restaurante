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
using Guna.UI.WinForms;

namespace GUI.SALON
{
    public partial class PedidosChef : Form
    {
        private ClsChef_N datos;
        private GunaDataGridView[] dg;
        public PedidosChef()
        {
            InitializeComponent();
            datos = new ClsChef_N();
            IniciarDatos();
            GunaDataGridView[] dg = { gunaPedido1, gunaPedido2, gunaPedido3, gunaPedido4};
            this.dg = dg;
        }

        private void IniciarDatos()
        {
            for(int i = 0; i < dg.Length; i++)
            {
                dg[i].
            }
        }
    }
}
