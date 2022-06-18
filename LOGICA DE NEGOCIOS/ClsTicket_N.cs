using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESO_A_DATOS;

namespace LOGICA_DE_NEGOCIOS
{
    public class ClsTicket_N
    {
        private ClsTicket_D Ticket;
        private DataTable datos;
        private DataTable datos2;
        private int idPedido;
        private DateTime fecha;
        private string nombre;
        private int numero;
        private string producto;
        private int cantidad;
        private int precio;
        private int suma;
        public ClsTicket_N(int id)
        {
            Ticket = new ClsTicket_D();
            Read(id);
            suma = 0;
        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public DataTable Datos { get => datos; set => datos = value; }

        private void Read(int id)
        {
            Datos = Ticket.ReadProductos(id);
            Numero = Convert.ToInt32(Datos.Rows[0][0]);
            Producto = Datos.Rows[0][1].ToString();
            Cantidad = Convert.ToInt32(Datos.Rows[0][2]);
            Precio = Convert.ToInt32(Datos.Rows[0][3]);
            datos2 = Ticket.Read(id);
            Fecha = Convert.ToDateTime(datos2.Rows[0][1]);
            Nombre = datos2.Rows[0][2].ToString();
        }

        public int PrecioTotal()
        {
            for(int i = 0; i < datos.Rows.Count; i++)
            {
                suma += (Convert.ToInt32(Datos.Rows[i][3])) * (Convert.ToInt32(Datos.Rows[i][2]));
            }
            return suma;
        }
    }
}
