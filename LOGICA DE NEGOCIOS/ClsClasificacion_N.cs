using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESO_A_DATOS;
using ENTIDADES;

namespace LOGICA_DE_NEGOCIOS
{
    public class ClsClasificacion_N
    {
        public static DataTable Read()
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            return Datos.Read();
        }
        public static DataTable Buscar(string valor)
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            return Datos.BUSCAR(valor);
        }
        public static string Create(string id, string nombre, string descripcion)
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            ClsClasificacion obj = new ClsClasificacion();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El id ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            return Datos.Create(obj);
        }
        public static string Update(string id, string nombre, string descripcion)
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            ClsClasificacion obj = new ClsClasificacion();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El id ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            return Datos.Update(obj);
        }
        public static string Delete(int id)
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            return Datos.Delete(id);
        }
    }
}
