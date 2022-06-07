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
        private ClsProducto_D Datos = new ClsProducto_D();
        ClsProducto obj = new ClsProducto();
        public DataTable Read()
        {
            return Datos.Read();
        }
        //pendinte
        public DataTable Read(string Valor)
        {
            return Datos.Read(Valor);
        }
        public DataTable Read(int id)
        {
            return Datos.Read(id);
        }
        public string Create(int idClas,string precio,string nombre,string descrip)
        {
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracterese especiales";
            if (Validaciones.WithForCompareAsciiValue(descrip)) obj.Descripcion = descrip;
            else return "Intente no usar caracterese especiales, solo letras";
            obj.IdClasificacion = idClas;
            if (Validaciones.SoloNumero(precio)) obj.Precio = int.Parse(precio);
            else return "Solo numeros";
            return Datos.Create(obj);
        }
        public string Update(int idProduc, int idClas, string precio, string nombre, string descrip)
        {
            obj.IdProducto = idProduc;
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracterese especiales";
            if (Validaciones.WithForCompareAsciiValue(descrip)) obj.Descripcion = descrip;
            else return "Intente no usar caracterese especiales, solo letras";
            obj.IdClasificacion = idClas;
            if (Validaciones.SoloNumero(precio)) obj.Precio = int.Parse(precio);
            else return "Solo numeros";
            return Datos.Update(obj);
        }
        public string Delete(int id)
        {
            return Datos.Delete(id);
        }
        public DataTable ReadClasificacion()
        {
            return Datos.ReadClasificacion();
        }
    }
}
