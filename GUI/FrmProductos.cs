﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmProductos : Form
    {
        private FrmMenu padreMenu;
        public FrmProductos(FrmMenu padreMenu)
        {
            this.padreMenu = padreMenu;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            padreMenu.abrirFHijo(new FrmAddProductos());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            padreMenu.abrirFHijo(new FrmAddProductos());
        }
    }
}
