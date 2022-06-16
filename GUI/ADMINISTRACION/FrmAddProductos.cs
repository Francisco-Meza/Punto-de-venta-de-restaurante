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

namespace GUI
{
    public partial class FrmAddProductos : Form
    {
        private string _precio, _descrip, _nombre;
        private FrmMenu menu;
        private int id, _idCla;
        private string msj;
        private ClsProducto_N productos;
        
        public FrmAddProductos(FrmMenu menu)
        {
            InitializeComponent();
            BtnGuardarPro.Enabled = false;
            this.menu = menu;
            id = 0;
            productos = new ClsProducto_N();
            IniciarDatos();
        }
        public FrmAddProductos(FrmMenu menu, int id)
        {
            InitializeComponent();
            BtnGuardarPro.Enabled = false;
            this.menu = menu;
            this.id = id;
            productos = new ClsProducto_N();
            IniciarDatos(id);
        }

        private void BtnCerrarHijo_Click(object sender, EventArgs e)
        {
            menu.AbrirFHijo(new FrmProductos(menu));
        }

        private void TxtApeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar();
            if (e.KeyChar > 47 && e.KeyChar < 58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar();
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                ObtenerTextos();
                msj = productos.Create(_idCla,_precio,_nombre,_descrip);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se dio de alta el producto con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Regresar();
                }else if (msj.Equals("NO"))
                {
                    MessageBox.Show("Error al registrar el producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Regresar();
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Regresar();
                }
            }
            else
            {
                ObtenerTextos();
                msj = productos.Update(id, _idCla, _precio,_nombre,_descrip);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se actualizo el producto", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Regresar();
                }
                else if (msj.Equals("NO"))
                {
                    MessageBox.Show("Error al registrar el producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Regresar();
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Regresar();
                }
            }

        }
        private void ObtenerTextos()
        {
            _idCla = Convert.ToInt32(ComboBoxClasi.SelectedValue);
            _precio = TxtPrecioPro.Text;
            _nombre = TxtNombrePro.Text;
            _descrip = TxtDescriPro.Text;
        }
        public void Validar()
        {
            if (TxtNombrePro.Text != String.Empty && TxtDescriPro.Text != String.Empty &&  TxtPrecioPro.Text != String.Empty)
            {
                BtnGuardarPro.Enabled = true;
            }
            else
            {
                BtnGuardarPro.Enabled = false;
            }
        }

        private void IniciarDatos()
        {
            try
            {
                BtnGuardarPro.Enabled = true;
                ComboBoxClasi.DataSource = productos.ReadClasificacion();
                ComboBoxClasi.DisplayMember = "NOMBRE";
                ComboBoxClasi.ValueMember = "ID";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void IniciarDatos(int id)
        {
            try
            {
                BtnGuardarPro.Enabled = true;
                ComboBoxClasi.DataSource = productos.ReadClasificacion();
                ComboBoxClasi.DisplayMember = "NOMBRE";
                ComboBoxClasi.ValueMember = "ID";
                DataTable datos = new DataTable();
                datos = productos.Read(id);
                _nombre = datos.Rows[0][0].ToString();
                _descrip = datos.Rows[0][1].ToString();
                _idCla = Convert.ToInt32(datos.Rows[0][2]);
                _precio = datos.Rows[0][3].ToString();
                ComboBoxClasi.SelectedValue = _idCla;
                TxtNombrePro.Text = _nombre;
                TxtDescriPro.Text = _descrip;
                TxtPrecioPro.Text = _precio;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Regresar()
        {
            menu.AbrirFHijo(new FrmProductos(menu));
            this.Dispose();
        }
    }
}
