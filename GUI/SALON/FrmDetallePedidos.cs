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
    public partial class FrmDetallePedidos : Form
    {
        private string clasificacion, producto;
        int cantidad, idPedido, idCuenta, idMesa;
        private FrmMenu menu;
        private ClsPedidoLocal_N local;
        private const int mesero = 1;
        private const int cajero = 3;
        private DataTable datos, dg;
        private string msj;
        public FrmDetallePedidos(FrmMenu menu, int idCuenta)
        {
            InitializeComponent();
            this.menu = menu;
            idPedido = 0;
            this.idCuenta = idCuenta;
            local = new ClsPedidoLocal_N();
            datos = new DataTable();
            dg = new DataTable();
            IniciarCombos();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            idMesa = Convert.ToInt32(cbMesa.SelectedValue);
            msj = local.Create(idCuenta, idMesa, datos);
            if (msj.Equals("OK"))
            {
                MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu.AbrirFHijo(new FrmPedidos(menu));
                this.Dispose();
            }
            else if (msj.Equals("NO"))
            {
                MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IniciarCombos()
        {
            cbMesa.DataSource = local.ReadMesas();
            cbMesa.DisplayMember = "NOMBRE";
            cbMesa.ValueMember = "ID";
            dg.Columns.Add("NUMERO");
            dg.Columns.Add("NOMBRE");
            dg.Columns.Add("CANTIDAD");
            dg.Columns.Add("PRECIO");
            
            //
            datos.Columns.Add("ID_DETALLE");
            datos.Columns.Add("ID_PRODUCTO");
            datos.Columns.Add("NOMBRE_PRODUCTO");
            datos.Columns.Add("CANTIDAD");
            datos.Columns.Add("PRECIO");
            dgvProductosPedido.DataSource = dg;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProductoDetalle a = new FrmAgregarProductoDetalle(this);
            a.Show();
        }

        public void añadir(int idDetalle, int idProducto, string nombre, int cantidad,int precio)
        {
            DataRow filas = dg.NewRow();
            filas["NUMERO"] = idDetalle;
            filas["NOMBRE"] = nombre;
            filas["CANTIDAD"] = cantidad;
            filas["PRECIO"] = precio;
            dg.Rows.Add(filas);
            //
            DataRow filas2 = datos.NewRow();
            filas2["ID_DETALLE"] = idDetalle;
            filas2["ID_PRODUCTO"] = idProducto;
            filas2["NOMBRE_PRODUCTO"] = nombre;
            filas2["CANTIDAD"] = cantidad;
            filas2["PRECIO"] = precio;
            datos.Rows.Add(filas2);
        }

        public void Control_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctr = (Control)sender;
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                    ctr.Parent.SelectNextControl(ctr, true, true, true, true);
                    e.Handled = true;               
            }
        }
    }
}
//Data Source=DANNY;Initial Catalog=Restaurante;User ID=MaestroCatalogo;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
