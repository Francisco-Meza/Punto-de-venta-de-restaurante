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
            if (Validaciones.WithForCompareAsciiValue(valor)) return Datos.Read(valor);
            else return null;
        }
        public static string Create(string nombre,string descripcion)
        {
            ClsPuesto_D Datos = new ClsPuesto_D();
            ClsPuesto obj = new ClsPuesto();
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            return Datos.Create(obj);
        }
        public static string Update(string id, string nombre, string descripcion)
        {
            ClsPuesto_D Datos = new ClsPuesto_D();
            ClsPuesto obj = new ClsPuesto();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El id ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            return Datos.Update(obj);
        }
        public static string Delete(string id)
        {
            ClsPuesto_D Datos = new ClsPuesto_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del id es incorrecto";
        }
    }
}
