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
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracterese especiales";
            if (Validaciones.WithForCompareAsciiValue(descrip)) obj.Descripcion = descrip;
            else return "Intente no usar caracterese especiales, solo letras";
            if (Validaciones.SoloNumero(idClas)) obj.IdClasificacion = int.Parse(idClas);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(precio)) obj.Precio = int.Parse(precio);
            else return "Solo numeros";
            return Datos.Create(obj);
        }
        public static string Update(string idProduc, string idClas, string precio, string nombre, string descrip)
        {
            ClsProducto_D Datos = new ClsProducto_D();
            ClsProducto obj = new ClsProducto();
            obj.IdProducto = int.Parse(idProduc);
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracterese especiales";
            if (Validaciones.WithForCompareAsciiValue(descrip)) obj.Descripcion = descrip;
            else return "Intente no usar caracterese especiales, solo letras";
            if (Validaciones.SoloNumero(idClas)) obj.IdClasificacion = int.Parse(idClas);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(precio)) obj.Precio = int.Parse(precio);
            else return "Solo numeros";
            return Datos.Update(obj);
        }
        public static string Delete(int id)
        {
            ClsProducto_D Datos = new ClsProducto_D();
            return Datos.Delete(id);
        }
    }
}
