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
    public class ClsMesa_N
    {
        ClsMesa_D Datos = new ClsMesa_D();
        ClsMesa obj = new ClsMesa();
        public DataTable Read()
        {
            return Datos.Read();
        }
        public DataTable Read(string valor)
        {
            if (Validaciones.WithForCompareAsciiValue(valor)) return Datos.Read(valor);
            else return null;
        }
        public DataTable Read(int id)
        {
            return Datos.Read(id);
        }
        public string Create(string numeroMesa, string descripcion, string numeroComensales)
        {
            if (Validaciones.SoloNumero(numeroMesa)) obj.NumeroMesa = int.Parse(numeroMesa);
            else return "El numero de mesa no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            if (Validaciones.SoloNumero(numeroComensales)) obj.NumeroComensales = int.Parse(numeroComensales);
            else return "El numero de comensales no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Create(obj);

        }
        public string Update(int id, string numeroMesa, string descripcion, string numeroComensales)
        {
            obj.Id = id;
            if (Validaciones.SoloNumero(numeroMesa)) obj.NumeroMesa = int.Parse(numeroMesa);
            else return "El numero de mesa no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            if (Validaciones.SoloNumero(numeroComensales)) obj.NumeroComensales = int.Parse(numeroComensales);
            else return "El numero de comensales no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Update(obj);
        }
        public string Delete(int id)
        {
            return Datos.Delete(id);
        }
    }
}
