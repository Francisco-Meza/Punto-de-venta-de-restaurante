using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ENTIDADES
{
    public class ClsTipoPuesto
    {
        int _id;
        string _nombrePuesto;
        string _descripcion;

        public int Id { get => _id; set => _id = value; }
        public string NombrePuesto { get => _nombrePuesto; set => _nombrePuesto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
