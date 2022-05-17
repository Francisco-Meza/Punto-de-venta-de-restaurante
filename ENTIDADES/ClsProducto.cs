using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ClsProducto
    {
        private int _idProducto,_idClasificacion,_precio;
        private string _nombreProducto, _descripcion;

        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int IdClasificacion { get => _idClasificacion; set => _idClasificacion = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public string Nombre { get => _nombreProducto; set => _nombreProducto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
