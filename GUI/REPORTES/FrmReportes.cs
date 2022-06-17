using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.REPORTES
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReporteVentas a = new FrmReporteVentas();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReporteMesas a = new FrmReporteMesas();
            a.ShowDialog();
        }
    }
}
