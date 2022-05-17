using System;
using System.Collections.Generic;
using System.Data;
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
        public static DataTable Read(string valor)
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            return Datos.Read(valor);
        }
        public static string Create(string id, string nombre, string descripcion)
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            ClsClasificacion obj = new ClsClasificacion();
            obj.Id = int.Parse(id);
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return Datos.Create(obj);
        }
        public static string Update(int id, string nombre, string descripcion)
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            ClsClasificacion obj = new ClsClasificacion(); 
            obj.Id = id;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return Datos.Update(obj);
        }
        public static string Delete(int id)
        {
            ClsClasificacion_D Datos = new ClsClasificacion_D();
            return Datos.Delete(id);
        }
    }
}
