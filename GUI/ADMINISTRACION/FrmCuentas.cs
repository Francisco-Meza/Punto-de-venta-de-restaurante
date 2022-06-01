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
    public partial class FrmCuentas : Form
    {
        private FrmMenu menu;
        private DataTable datos;
        private ClsCuentas_N cuenta;
        private int id;
        public FrmCuentas(FrmMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            datos = new DataTable();
            cuenta = new ClsCuentas_N();
            IniciarDatos();
        }
        private void IniciarDatos()
        {
            try
            {
                datos = cuenta.Read();
                if(datos != null)
                {
                    dgvCuentas.DataSource = datos;
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error contactarse con el administrador detalle del error:\n"+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmAddPersonal());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmAddPersonal());
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int row = dgvCuentas.CurrentRow.Index;
            id = Convert.ToInt32(dgvCuentas.Rows[row].Cells[0].Value);
            string msj = cuenta.Delete(id);
            if (msj.Equals("OK"))
            {
                MessageBox.Show("Se elimino el usuario con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IniciarDatos();
            }
            else
            {
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            int row = dgvCuentas.CurrentRow.Index;
            id = Convert.ToInt32(dgvCuentas.Rows[row].Cells[0].Value);
            menu.AbrirFHijo(new FrmAddPersonal(id));
        }
    }
}
