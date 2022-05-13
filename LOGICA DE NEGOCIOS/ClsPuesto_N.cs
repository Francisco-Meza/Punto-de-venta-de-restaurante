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
    public class ClsPuesto_N
    {

        public static DataTable Read()
        {
            ClsPuesto_D Datos = new ClsPuesto_D();
            return Datos.Read();
        }
        public static DataTable Read(string valor)
        {
            ClsPuesto_D Datos = new ClsPuesto_D();
            return Datos.Read(valor);
        }
        public static string Create(string id,string nombre,string descripcion)
        {
            ClsPuesto_D Datos = new ClsPuesto_D();
            ClsPuesto obj = new ClsPuesto();
            obj.Id = int.Parse(id);
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return Datos.Create(obj);
        }
        public static string Update(int id, string nombre, string descripcion)
        {
            ClsPuesto_D Datos = new ClsPuesto_D();
            ClsPuesto obj = new ClsPuesto();
            obj.Id = id;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return Datos.Update(obj);
        }
        public static string Delete(int id)
        {
            ClsPuesto_D Datos = new ClsPuesto_D();
            return Datos.Delete(id);
        }
    }
}
