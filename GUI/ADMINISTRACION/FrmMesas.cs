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
    public partial class FrmMesas : Form
    {
        private readonly FrmMenu menu;
        private int id;
        private ClsMesa_N mesa = new ClsMesa_N();
        private DataTable datos = new DataTable();
        public FrmMesas(FrmMenu padreMenu)
        {
            this.menu = padreMenu;
            InitializeComponent();
            Read();
        }
        public void Read()
        {
            try
            {
                datos = mesa.Read();
                if (datos != null)
                {
                    dgvListaMesas.DataSource = datos;
                    dgvListaMesas.Columns[0].Visible = false;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmAddMesas(menu));
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int row = dgvListaMesas.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaMesas.Rows[row].Cells[0].Value);
            menu.AbrirFHijo(new FrmAddMesas(menu,id));
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int row = dgvListaMesas.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaMesas.Rows[row].Cells[0].Value);
            string msj = mesa.Delete(id);
            if (msj.Equals("OK"))
            {
                MessageBox.Show("Se elimino con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Read();
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
}
