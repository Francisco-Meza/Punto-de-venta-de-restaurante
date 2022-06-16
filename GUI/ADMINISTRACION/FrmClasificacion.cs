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
    public partial class FrmClasificacion : Form
    {
        private readonly FrmMenu menu;
        private DataTable datos;
        private ClsClasificacion_N clasificacion;
        private int id;
        public FrmClasificacion(FrmMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            clasificacion = new ClsClasificacion_N();
            IniciarDatos();
            dgvClasificacion.Columns[0].Visible = false;
        }
        private void IniciarDatos()
        {
            datos = new DataTable();
            datos = clasificacion.Read();
            if (datos != null)
            {
                dgvClasificacion.DataSource = datos;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCla_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmAddClasificacion(menu));
        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            int row = dgvClasificacion.CurrentRow.Index;
            id = Convert.ToInt32(dgvClasificacion.Rows[row].Cells[0].Value);
            menu.AbrirFHijo(new FrmAddClasificacion(menu,id));
        }

        private void btnElimiCla_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Seguro que quieres eliminar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                int row = dgvClasificacion.CurrentRow.Index;
                id = Convert.ToInt32(dgvClasificacion.Rows[row].Cells[0].Value);
                string msj = clasificacion.Delete(id);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se elimino la clasificacion con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IniciarDatos();
                }
                else if (msj.Equals("NO"))
                {
                    MessageBox.Show("Error al eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
