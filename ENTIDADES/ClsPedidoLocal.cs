using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ClsPedidoLocal
    {
        string _nota;
        DateTime _fecha;
        string _estado;

        //llave foranea
        int _idCuenta;
        int _idMesa;
        DataTable detalles;
        int _idPedido;

        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Nota { get => _nota; set => _nota = value; }

        //llave foranea 
        public int IdCuenta { get => _idCuenta; set => _idCuenta = value; }
        public int IdMesa { get => _idMesa; set => _idMesa = value; }
        public DataTable Detalles { get => detalles; set => detalles = value; }
        public int IdPedido { get => _idPedido; set => _idPedido = value; }
    }
}
