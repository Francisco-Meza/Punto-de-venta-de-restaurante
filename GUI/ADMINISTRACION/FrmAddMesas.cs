using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ADMINISTRACION
{
    public partial class FrmAddMesas : Form
    {
        private string numeroMesa, descripcion, numeroComensales;
        public FrmAddMesas(FrmMenu menu)
        {
            InitializeComponent();

        }

        public FrmAddMesas(FrmMenu menu, int id)
        {

        }
    }
}
