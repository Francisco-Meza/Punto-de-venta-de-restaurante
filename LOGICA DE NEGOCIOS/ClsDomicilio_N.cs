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
    public class ClsDomicilio_N
    {
        public static DataTable Read()
        {
            ClsDomicilio_D Datos = new ClsDomicilio_D();
            return Datos.Read();
        }
        public static DataTable Read(string valor)
        {
            ClsDomicilio_D Datos = new ClsDomicilio_D();
            return Datos.Read(valor);
        }
        public static string Create(string id, string calle, string colonia, string localidad, int numeroCasa)
        {
            ClsDomicilio_D Datos = new ClsDomicilio_D();
            ClsDomicilio obj = new ClsDomicilio();
            obj.Id = int.Parse(id);
            obj.Calle = calle;
            obj.Colonia = colonia;
            obj.Localidad = localidad;
            obj.NumeroCasa = numeroCasa;
            return Datos.Create(obj);
        }
        public static string Update(int id, string calle, string colonia, string localidad, int numeroCasa)
        {
            ClsDomicilio_D Datos = new ClsDomicilio_D();
            ClsDomicilio obj = new ClsDomicilio();
            obj.Id = id;
            obj.Calle = calle;
            obj.Colonia = colonia;
            obj.Localidad = localidad;
            obj.NumeroCasa = numeroCasa;
            return Datos.Update(obj);
        }
        public static string Delete(int id)
        {
            ClsDomicilio_D Datos = new ClsDomicilio_D();
            return Datos.Delete(id);
        }
    }
}
