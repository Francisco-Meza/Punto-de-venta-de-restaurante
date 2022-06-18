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
    public partial class FrmTicket : Form
    {
        ClsTicket_N ticket;
        public FrmTicket(int id)
        {
            InitializeComponent();
            ticket = new ClsTicket_N(id);
            iniciarDatos();
        }
        private void iniciarDatos()
        {
            dgvTiket.DataSource = ticket.Datos;
            lblFecha.Text = ticket.Fecha.ToString();
            lblPersonal.Text = ticket.Nombre;
            lblSubtotal.Text = ticket.PrecioTotal().ToString();
            lblTotal.Text = (ticket.PrecioTotal() * 1.16).ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
