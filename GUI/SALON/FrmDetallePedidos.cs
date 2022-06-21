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
        int cantidad, idPedido, idCuenta, idMesa, idPuesto;
        private FrmMenu menu;
        private ClsPedidoLocal_N local;
        private ClsPedidoDomicilio_N domicilio;
        private const int admin = 1;
        private const int cajero = 2;
        private const int mesero = 3;
        private const int cocinero = 4;
        private DataTable datos, dg;
        private string msj;
        private int idDetalle;
        private int i;
        private string nombre, telefono, calle, numero, colonia, localidad;
        private bool estado;
        public FrmDetallePedidos(FrmMenu menu, int idCuenta, int idPuesto)
        {
            InitializeComponent();
            this.menu = menu;
            idPedido = 0;
            this.idCuenta = idCuenta;
            this.idPuesto = idPuesto;
            local = new ClsPedidoLocal_N();
            datos = new DataTable();
            dg = new DataTable();
            IniciarCombos();
        }
        public FrmDetallePedidos(FrmMenu menu, int idCuenta, int idPuesto, string nombre, string telefono, string calle, string numero, string colonia, string localidad)
        {
            InitializeComponent();
            this.menu = menu;
            idPedido = 0;
            this.idCuenta = idCuenta;
            this.idPuesto = idPuesto;
            this.nombre = nombre;
            this.telefono = telefono;
            this.calle = calle;
            this.numero = numero;
            this.colonia = colonia;
            this.localidad = localidad;
            domicilio = new ClsPedidoDomicilio_N();
            datos = new DataTable();
            dg = new DataTable();
            IniciarDatosDomicilio();
        }
        public FrmDetallePedidos(FrmMenu menu, int idCuenta, int idPedido, int idPuesto, bool estado)
        {
            InitializeComponent();
            this.menu = menu;
            this.idPedido = idPedido;
            this.idCuenta = idCuenta;
            this.idPuesto = idPuesto;
            this.estado = estado;
            local = new ClsPedidoLocal_N();
            datos = new DataTable();
            dg = new DataTable();
            IniciarCombos(this.idPedido);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (idPedido == 0)
            {
                if (idPuesto == mesero || idPuesto == admin)
                {
                    idMesa = Convert.ToInt32(cbMesa.SelectedValue);
                    msj = local.Create(idCuenta, idMesa, datos);
                    if (msj.Equals("OK"))
                    {
                        MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Regresar();
                    }
                    else if (msj.Equals("NO"))
                    {
                        MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Regresar();
                    }
                    else
                    {
                        MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Regresar();
                    }
                }
                else if (idPuesto == cajero)
                {
                    msj = domicilio.Create(idCuenta, telefono, nombre, calle, numero, colonia, localidad, datos);
                    if (msj.Equals("OK"))
                    {
                        MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Regresar();
                    }
                    else if (msj.Equals("NO"))
                    {
                        MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Regresar();
                    }
                    else
                    {
                        MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Regresar();
                    }
                }
            }
            else
            {
                msj = local.Update(idPedido, datos);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Regresar();
                }
                else if (msj.Equals("NO"))
                {
                    MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Regresar();
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Regresar();
                }
            }
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmPedidos(menu));
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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
        private void IniciarDatosDomicilio()
        {
            cbMesa.Enabled = false;
            cbMesa.Visible = false;
            label5.Enabled = false;
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
        private void IniciarCombos(int idPedido)
        {
            datos = local.Read2(idPedido);
            if(idPuesto != cajero)
            {
                cbMesa.DataSource = local.ReadMesas();
                cbMesa.Enabled = false;
                cbMesa.DisplayMember = "NOMBRE";
                cbMesa.ValueMember = "ID";
            }
            else
            {
                label5.Enabled = false;
                cbMesa.Enabled = false;
                cbMesa.Visible = false;
            }
            if (idPuesto == cocinero)
            {
                btnAgregar.Enabled = false;
                btnAgregar.Visible = false;
                btnEliminar.Enabled = false;
                btnEliminar.Visible = false;
                btnGuardar.Enabled = false;
                btnGuardar.Visible = false;
            }
            dg = local.Read(idPedido);
            dgvProductosPedido.DataSource = dg;
            if (!estado)
            {
                btnAgregar.Enabled = false;
                btnAgregar.Visible = false;
                btnEliminar.Enabled = false;
                btnEliminar.Visible = false;
                btnGuardar.Enabled = false;
                btnGuardar.Visible = false;
                MessageBox.Show("Este pedido se encuentra terminado, solo podra ver la informacion","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (idPedido == 0)
            {
                FrmAgregarProductoDetalle a = new FrmAgregarProductoDetalle(this);
                a.ShowDialog();
            }
            else
            {
                idDetalle = dgvProductosPedido.Rows.Count;
                Console.WriteLine(idDetalle);
                FrmAgregarProductoDetalle a = new FrmAgregarProductoDetalle(this, idDetalle);
                a.ShowDialog();
            }
        }

        public void añadir(int idDetalle, int idProducto, string nombre, int cantidad, int precio)
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
        public bool Comparar(int idPedido)
        {
            for(i = 0; i < dgvProductosPedido.Rows.Count; i++)
            {
                if (Convert.ToInt32(datos.Rows[i][1]) == idPedido)
                {
                    return false;
                }
            }
            return true;
        }
        public void añadir(int cantidad)
        {
            datos.Rows[i][2] = cantidad;
            dg.Rows[i][2] = cantidad;
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
        public int GetRows()
        {
            return dgvProductosPedido.Rows.Count;
        }
        public void Regresar()
        {
            menu.AbrirFHijo(new FrmPedidos(menu));
            this.Dispose();
        }
    }
}
//Data Source=DANNY;Initial Catalog=Restaurante;User ID=MaestroCatalogo;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
