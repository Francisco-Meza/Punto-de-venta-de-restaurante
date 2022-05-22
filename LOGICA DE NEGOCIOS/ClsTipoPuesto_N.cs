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
    public class ClsTipoPuesto_N
    {
        public static DataTable Read()
        {
            ClsTipoPuesto_D Datos = new ClsTipoPuesto_D();
            return Datos.Read();
        }
        public static DataTable Read(string valor)
        {
            ClsTipoPuesto_D Datos = new ClsTipoPuesto_D();
            return Datos.Read(valor);
        }
        public static string Create(string id, string nombrePuesto, string descripcion)
        {
            ClsTipoPuesto_D Datos = new ClsTipoPuesto_D();
            ClsTipoPuesto obj = new ClsTipoPuesto();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombrePuesto)) obj.NombrePuesto = nombrePuesto;
            else return "El nombre del puesto no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "La descripcion no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Create(obj);
        }
        public static string Update(string id, string nombrePuesto, string descripcion)
        {
            ClsTipoPuesto_D Datos = new ClsTipoPuesto_D();
            ClsTipoPuesto obj = new ClsTipoPuesto();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombrePuesto)) obj.NombrePuesto = nombrePuesto;
            else return "El nombre del puesto no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "La descripcion no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Update(obj);
        }
        public static string Delete(string id)
        {
            ClsTipoPuesto_D Datos = new ClsTipoPuesto_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del ID es incorrecto";
        }
    }
}
