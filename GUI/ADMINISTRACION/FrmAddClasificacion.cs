﻿using System;
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
    public partial class FrmAddClasificacion : Form
    {
        private FrmMenu frmMenu;

        public FrmAddClasificacion()
        {
            InitializeComponent();
        }

        public FrmAddClasificacion(FrmMenu frmMenu)
        {
            this.frmMenu = frmMenu;
        }
        public void Validar()
        {
            if (TxtNombreClasificacion.Text != String.Empty && TxtDescripcionClas.Text != String.Empty)
            {
              BtnGuardarCla.Enabled = true;
            }
            else
            {
               BtnGuardarCla.Enabled = false;
            }
        }

        private void TxtDescripcionClas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar();
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void GrupClasificacion_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
