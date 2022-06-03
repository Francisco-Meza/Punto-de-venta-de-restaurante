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
    public partial class FrmAddMesas : Form
    {
        private ClsMesa_N mesa;
        private string numeroMesa, descripcion, numeroComensales;
        private int id;
        private string msj;
        private DataTable Datos;

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                ObtenerTextos();
                msj = mesa.Create(numeroMesa,descripcion,numeroComensales);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se dio de alta la mesa con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se elimino la mesa con exito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                msj = mesa.Update(id,numeroMesa, descripcion, numeroComensales);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se dio de alta la mesa con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se elimino la mesa con exito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ObtenerTextos()
        {
            numeroMesa = TxtNumero.Text;
            descripcion = TxtDescripcion.Text;
            numeroComensales = TxtNumComensales.Text;
        }
        private void LimpiarTextos()
        {
            TxtNumero.Text = "";
            TxtDescripcion.Text = "";
            TxtNumComensales.Text = "";
        }

        public FrmAddMesas(FrmMenu menu)
        {
            InitializeComponent();
            numeroMesa = "";
            descripcion = "";
            numeroComensales = "";
            id = 0;
            mesa = new ClsMesa_N();
        }

        public FrmAddMesas(FrmMenu menu, int id)
        {
            InitializeComponent();
            this.id = id;
            mesa = new ClsMesa_N();
            Datos = new DataTable();
            Datos = mesa.Read(id);
            numeroMesa = Datos.Rows[0][0].ToString();
            descripcion = Datos.Rows[0][1].ToString();
            numeroComensales = Datos.Rows[0][2].ToString();
            TxtNumero.Text = numeroMesa;
            TxtDescripcion.Text = descripcion;
            TxtNumComensales.Text = numeroComensales;
        }
    }
}
