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
        private string _id, _numeroMesa, _numeroComensales, _descripcion;
        public FrmAddMesas()
        {
            InitializeComponent();
        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (TxtID.Text != "" && TxtNumeroMesa.Text != "" && TxtNumCom.Text != "" && txtDesc.Text != "")
            {
                _id = TxtID.Text;
                _numeroComensales = TxtNumCom.Text;
                _descripcion = txtDesc.Text;
                _numeroMesa = TxtNumeroMesa.Text;
                ClsMesa_N.Create(_id, _numeroMesa, _numeroComensales, _descripcion);
            }
            else
            {
                MessageBox.Show("Es obligatorio llenar la descripcion");
                //Limpiar();
            }
        }

        

    }
}
