using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESO_A_DATOS;
using ENTIDADES;
using LOGICA_DE_NEGOCIOS;

namespace LOGICA_DE_NEGOCIOS
{
    public class ClsClasificacion_N
    {
        ClsClasificacion_D Datos;
        ClsClasificacion obj;
        public ClsClasificacion_N()
        {
            Datos = new ClsClasificacion_D();
            obj = new ClsClasificacion();
        }
        public DataTable Read()
        {
            return Datos.Read();
        }
        public DataTable Buscar(string valor)
        {
            return Datos.BUSCAR(valor);
        }
        public DataTable Read(int id)
        {
            return Datos.Read(id);
        }
        public string Create(string nombre, string descripcion)
        {
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            return Datos.Create(obj);
        }
        public string Update(int id, string nombre, string descripcion)
        {
            obj.Id = id;
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "Intente no usar caracteres especiales solo letras";
            return Datos.Update(obj);
        }
        public string Delete(int id)
        {
            return Datos.Delete(id);
        }
    }
}
