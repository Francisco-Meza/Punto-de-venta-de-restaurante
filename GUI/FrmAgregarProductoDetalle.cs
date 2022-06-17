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
    public partial class FrmAgregarProductoDetalle : Form
    {
        FrmDetallePedidos obj;
        ClsProducto_N productos;
        DataTable datos;
        private int idDetalle, idProducto, cantidad, precio;
        private string nombre;
        private int n;

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (obj.GetRows() > 3)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Ocupas agregar minimo 3 productos","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public FrmAgregarProductoDetalle(FrmDetallePedidos obj)
        {
            InitializeComponent();
            productos = new ClsProducto_N();
            this.obj = obj;
            datos = new DataTable();
            idDetalle = 0;
            IniciarDatos();
            dgvProductos.Columns[0].Visible = false;
        }

        private void FrmAgregarProductoDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                obj.Regresar();
            }
        }

        public FrmAgregarProductoDetalle(FrmDetallePedidos obj, int idDetalle)
        {
            InitializeComponent();
            productos = new ClsProducto_N();
            this.obj = obj;
            datos = new DataTable();
            this.idDetalle = idDetalle;
            IniciarDatos();
            dgvProductos.Columns[0].Visible = false;
        }
        private void IniciarDatos()
        {
            datos = productos.Read();
            if(datos != null)
            {
                dgvProductos.DataSource = datos;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int row = dgvProductos.CurrentRow.Index;
            idDetalle++;
            idProducto = Convert.ToInt32(dgvProductos.Rows[row].Cells[0].Value);
            nombre = dgvProductos.Rows[row].Cells[1].Value.ToString();
            cantidad = Convert.ToInt32(NumCantidad.Value);
            precio = Convert.ToInt32(dgvProductos.Rows[row].Cells[4].Value);
            obj.añadir(idDetalle,idProducto,nombre,cantidad,precio);
        }
    }
}
