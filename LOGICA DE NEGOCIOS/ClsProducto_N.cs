using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ACCESO_A_DATOS;
using ENTIDADES;

namespace LOGICA_DE_NEGOCIOS
{
    public class ClsProducto_N
    {
        public static DataTable Read()
        {
            ClsProducto_D Datos = new ClsProducto_D();
            return Datos.Read();
        }
        //pendinte
        public static DataTable Read(string Valor)
        {
            ClsProducto_D Datos = new ClsProducto_D();
            return Datos.Read(Valor);
        }
        public static string Create(string idProduc,string idClas,string precio,string nombre,string descrip)
        {
            ClsProducto_D Datos = new ClsProducto_D();
            ClsProducto obj = new ClsProducto();
            obj.IdProducto = int.Parse(idProduc);
            obj.Nombre = nombre;
            obj.Descripcion = descrip;
            obj.IdClasificacion = int.Parse(idClas);
            obj.Precio = int.Parse(precio);
            return Datos.Create(obj);
        }
        public static string Update(string idProduc, string idClas, string precio, string nombre, string descrip)
        {
            ClsProducto_D Datos = new ClsProducto_D();
            ClsProducto obj = new ClsProducto();
            obj.IdProducto = int.Parse(idProduc);
            obj.Nombre = nombre;
            obj.Descripcion = descrip;
            obj.IdClasificacion = int.Parse(idClas);
            obj.Precio = int.Parse(precio);
            return Datos.Update(obj);
        }
        public static string Delete(int id)
        {
            ClsProducto_D Datos = new ClsProducto_D();
            return Datos.Delete(id);
        }
    }
}
