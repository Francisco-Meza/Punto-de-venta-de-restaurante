using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ClsPedidoDomicilio
    {
        int _id;
        int _numeroTelefono;
        string _nombre;

        //Llave foranea:
        int _idDomicilio;

        public int Id { get => _id; set => _id = value; }
        public int NumeroTelefono { get => _numeroTelefono; set => _numeroTelefono = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        //Llave foranea
        public int IdDomicilio { get => _idDomicilio; set => _idDomicilio = value; }
    }
}
