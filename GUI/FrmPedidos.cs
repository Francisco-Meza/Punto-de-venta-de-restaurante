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
        private ClsPedidoDomicilio_N domicilio;
        private DataTable datos;
        private const int admin = 1;
        private const int cajero = 2;
        private const int mesero = 3;
        private const int cocinero = 4;
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
                case admin:
                    {
                        local = new ClsPedidoLocal_N();
                        datos = local.Read();
                        dgvListaPedidos.DataSource = datos;
                        btnFinalizar.Enabled = true;
                        btnFinalizar.Visible = true;
                        break;
                    }
                case cajero:
                    {
                        domicilio = new ClsPedidoDomicilio_N();
                        datos = domicilio.Read();
                        dgvListaPedidos.DataSource = datos;
                        btnFinalizar.Enabled = true;
                        btnFinalizar.Visible = true;
                        break;
                    }
                case mesero:
                    {
                        local = new ClsPedidoLocal_N();
                        datos = local.Read();
                        dgvListaPedidos.DataSource = datos;
                        btnFinalizar.Enabled = true;
                        btnFinalizar.Visible = true;
                        break;
                    }
                case cocinero:
                    {
                        BtnAgregar.Enabled = false;
                        BtnAgregar.Visible = false;
                        btnEliminar.Enabled = false;
                        btnEliminar.Visible = false;
                        local = new ClsPedidoLocal_N();
                        datos = local.Read();
                        dgvListaPedidos.DataSource = datos;
                        btnEditar.Text = "Ver";
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
            if (idPuesto == cajero)
            {
                FrmPedidosDomicilio pedido = new FrmPedidosDomicilio(menu,idCuenta,idPuesto);
                menu.AbrirFHijo(pedido);
            }
            else
            {
                FrmDetallePedidos pedido = new FrmDetallePedidos(menu, idCuenta, idPuesto);
                menu.AbrirFHijo(pedido);
                FrmAgregarProductoDetalle a = new FrmAgregarProductoDetalle(pedido);
                a.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Seguro que quieres eliminar?", "Advertencia", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
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
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int row = dgvListaPedidos.CurrentRow.Index;
            bool estado = (dgvListaPedidos.Rows[row].Cells[3].Value.ToString().Equals("ACTIVO"));
            if (estado)
            {
                idPedido = Convert.ToInt32(dgvListaPedidos.Rows[row].Cells[0].Value);
                FrmTicket ticket = new FrmTicket(idPedido);
                ticket.ShowDialog();
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
            else
            {
                MessageBox.Show("Este pedido se encuentra terminado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int row = dgvListaPedidos.CurrentRow.Index;
            bool estado = (dgvListaPedidos.Rows[row].Cells[3].Value.ToString().Equals("ACTIVO"));
            idPedido = Convert.ToInt32(dgvListaPedidos.Rows[row].Cells[0].Value);
            menu.AbrirFHijo(new FrmDetallePedidos(menu, idCuenta,idPedido,idPuesto,estado));
        }
    }
}
