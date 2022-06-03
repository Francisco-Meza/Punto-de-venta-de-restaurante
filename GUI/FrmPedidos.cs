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

namespace GUI
{
    public partial class FrmPedidos : Form
    {
        private readonly FrmMenu menu;
        private int idPuesto;
        private ClsPedidoLocal_N local;
        private DataTable datos;
        private const int mesero = 1;
        private const int cajero = 3;
        public FrmPedidos(FrmMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            datos = new DataTable();
            IniciarDatos();
            dgvListaPedidos.Columns[0].Visible = false;
        }
        private void IniciarDatos()
        {
            this.idPuesto = menu.IdPuesto;
            switch (idPuesto)
            {
                case mesero:
                    {
                        local = new ClsPedidoLocal_N();
                        datos = local.Read();
                        dgvListaPedidos.DataSource = datos;
                        break;
                    }
                default:
                    break;
            }
        }
        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmDetallePedidos(menu, idPuesto));
        }
    }
}
