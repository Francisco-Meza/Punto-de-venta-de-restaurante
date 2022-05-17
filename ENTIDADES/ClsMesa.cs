using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ClsMesa
    {
        private int _id, _numeroMesa, _numeroComensales;
        private string _descripcion;

        public int Id { get => _id; set => _id = value; }
        public int NumeroMesa { get => _numeroMesa; set => _numeroMesa = value; }
        public int NumeroComensales { get => _numeroComensales; set => _numeroComensales = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
