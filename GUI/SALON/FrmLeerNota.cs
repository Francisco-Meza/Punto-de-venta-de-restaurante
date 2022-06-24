using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.SALON
{
    public partial class FrmLeerNota : Form
    {
        public FrmLeerNota(string nota)
        {
            InitializeComponent();
            txtNota.Text = nota;
        }
    }
}
