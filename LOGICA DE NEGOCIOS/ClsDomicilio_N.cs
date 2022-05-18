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
        public static string Create(string id, string calle, string colonia, string localidad, string numeroCasa)
        {
            ClsDomicilio_D Datos = new ClsDomicilio_D();
            ClsDomicilio obj = new ClsDomicilio();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(calle)) obj.Calle = calle;
            else return "El nombre de la calle no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(colonia)) obj.Colonia = colonia;
            else return "El nombre de la colonia no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(localidad)) obj.Localidad = localidad;
            else return "El nombre de la localidad no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.SoloNumero(numeroCasa)) obj.NumeroCasa = int.Parse(numeroCasa);
            else return "El numero ingresado no es valido";
            return Datos.Create(obj);
        }
        public static string Update(string id, string calle, string colonia, string localidad, string numeroCasa)
        {
            ClsDomicilio_D Datos = new ClsDomicilio_D();
            ClsDomicilio obj = new ClsDomicilio();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(calle)) obj.Calle = calle;
            else return "El nombre de la calle no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(colonia)) obj.Colonia = colonia;
            else return "El nombre de la colonia no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(localidad)) obj.Localidad = localidad;
            else return "El nombre de la localidad no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.SoloNumero(numeroCasa))obj.NumeroCasa = int.Parse(numeroCasa);
            return Datos.Update(obj);
        }
        public static string Delete(string id)
        {
            ClsDomicilio_D Datos = new ClsDomicilio_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del ID es incorrecto";
        }
    }
}
