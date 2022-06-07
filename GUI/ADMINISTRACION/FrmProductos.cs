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
    public partial class FrmProductos : Form
    {
        private readonly FrmMenu menu;
        private int id;
        private ClsProducto_N producto;
        private DataTable datos;
        public FrmProductos(FrmMenu padreMenu)
        {
            this.menu = padreMenu;
            InitializeComponent();
            producto = new ClsProducto_N();
            datos = new DataTable();
            Read();
        }
        private void Read()
        {
            try
            {
                datos = producto.Read();
                if (datos != null)
                {
                    dgvListaPedidos.DataSource = datos;
                    dgvListaPedidos.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error contactarse con el administrador detalle del error:\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmAddProductos(menu));
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int row = dgvListaPedidos.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaPedidos.Rows[row].Cells[0].Value);
            menu.AbrirFHijo(new FrmAddProductos(menu, id));
            this.Dispose();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            int row = dgvListaPedidos.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaPedidos.Rows[row].Cells[0].Value);
            string msj = producto.Delete(id);
            if (msj.Equals("OK"))
            {
                MessageBox.Show("Se elimino el usuario con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Read();
            }
            else
            {
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
