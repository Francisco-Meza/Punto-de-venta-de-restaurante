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
    class ClsMesa_N
    {
        public static DataTable Read()
        {
            ClsMesa_D Datos = new ClsMesa_D();
            return Datos.Read();
        }
        public static DataTable Read(string valor)
        {
            ClsMesa_D Datos = new ClsMesa_D();
            if (Validaciones.WithForCompareAsciiValue(valor)) return Datos.Read(valor);
            else return null;
        }
        public static string Create(string id, string numeroMesa, string descripcion, string numeroComensales)
        {
            ClsMesa_D Datos = new ClsMesa_D();
            ClsMesa obj = new ClsMesa();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El id ingresado no es valido";
            if (Validaciones.SoloNumero(numeroMesa)) obj.NumeroMesa = int.Parse(numeroMesa);
            else return "El numero de mesa no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            if (Validaciones.SoloNumero(numeroComensales)) obj.NumeroComensales = int.Parse(numeroComensales);
            else return "El numero de comensales no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Create(obj);

        }
        public static string Update(string id, string numeroMesa, string descripcion, string numeroComensales)
        {
            ClsMesa_D Datos = new ClsMesa_D();
            ClsMesa obj = new ClsMesa();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El id ingresado no es valido";
            if (Validaciones.SoloNumero(numeroMesa)) obj.NumeroMesa = int.Parse(numeroMesa);
            else return "El numero de mesa no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            if (Validaciones.SoloNumero(numeroComensales)) obj.NumeroComensales = int.Parse(numeroComensales);
            else return "El numero de comensales no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Update(obj);
        }
        public static string Delete(string id)
        {
            ClsMesa_D Datos = new ClsMesa_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del id es incorrecto";
        }
    }
}
