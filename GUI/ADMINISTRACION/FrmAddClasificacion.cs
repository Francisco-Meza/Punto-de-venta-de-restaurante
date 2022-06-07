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
    public partial class FrmAddClasificacion : Form
    {
        private FrmMenu menu;
        private int id;
        private ClsClasificacion_N clasificacion;
        private DataTable datos;
        private string nombre, des;
        private string msj;
        public FrmAddClasificacion(FrmMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            clasificacion = new ClsClasificacion_N();
            id = 0;
        }
        public FrmAddClasificacion(FrmMenu menu, int id)
        {
            this.menu = menu;
            InitializeComponent();
            clasificacion = new ClsClasificacion_N();
            this.id = id;
            datos = new DataTable();
            datos = clasificacion.Read(id);
            nombre = datos.Rows[0][0].ToString();
            des = datos.Rows[0][1].ToString();
            TxtNombreClasificacion.Text = nombre;
            TxtDescripcionClas.Text = des;
        }
        private void ObtenerTextos()
        {
            nombre = TxtNombreClasificacion.Text;
            des = TxtDescripcionClas.Text;
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

        private void BtnGuardarCla_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                ObtenerTextos();
                msj = clasificacion.Create(nombre,des);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu.AbrirFHijo(new FrmClasificacion(menu));
                    this.Dispose();
                }
                else if (msj.Equals("NO"))
                {
                    MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ObtenerTextos();
                msj = clasificacion.Update(id,nombre, des);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se actualizo con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu.AbrirFHijo(new FrmClasificacion(menu));
                    this.Dispose();
                }
                else if (msj.Equals("NO"))
                {
                    MessageBox.Show("No se pudo actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmClasificacion(menu));
        }
    }
}
