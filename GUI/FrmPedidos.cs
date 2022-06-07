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
        private int idCuenta;
        private ClsPedidoLocal_N local;
        private DataTable datos;
        private const int mesero = 1;
        private const int cajero = 3;
        private int idPedido;
        private string msj;
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
            this.idCuenta = menu.IdCuenta;
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
            menu.AbrirFHijo(new FrmDetallePedidos(menu, idCuenta));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int row = dgvListaPedidos.CurrentRow.Index;
            idPedido = Convert.ToInt32(dgvListaPedidos.Rows[row].Cells[0].Value);
            msj = local.Delete(idPedido);
            if (msj.Equals("OK"))
            {
                MessageBox.Show("Se elimino con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IniciarDatos();
            }
            else if (msj.Equals("NO"))
            {
                MessageBox.Show("No se pudo eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int row = dgvListaPedidos.CurrentRow.Index;
            idPedido = Convert.ToInt32(dgvListaPedidos.Rows[row].Cells[0].Value);
            msj = local.Cerrar(idPedido);
            if (msj.Equals("OK"))
            {
                MessageBox.Show("Se finalizo con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu.AbrirFHijo(new FrmPedidos(menu));
                this.Dispose();
            }
            else if (msj.Equals("NO"))
            {
                MessageBox.Show("No se finalizar eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
