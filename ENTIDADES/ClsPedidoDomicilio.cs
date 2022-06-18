using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ClsPedidoDomicilio
    {
        int _idP;
        int _id;
        string _numeroTelefono;
        string _nombrePersona;
        string _calle;
        int _numero;
        string _colonia;
        string _localidad;
        DataTable _detalle;

        public int IdCuenta { get => _id; set => _id = value; }
        public int IdP { get => _idP; set => _idP = value; }
        public string NumeroTelefono { get => _numeroTelefono; set => _numeroTelefono = value; }
        public string Nombre { get => _nombrePersona; set => _nombrePersona = value; }
        public string Calle { get => _calle; set => _calle = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public string Colonia { get => _colonia; set => _colonia = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public DataTable Detalle { get => _detalle; set => _detalle = value; }
    }
}
