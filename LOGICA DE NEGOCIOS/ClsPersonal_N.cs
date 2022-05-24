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
    public class ClsPersonal_N
    {
        public static DataTable Read()
        {
            ClsPersonal_D Datos = new ClsPersonal_D();
            return Datos.Read();
        }
        public static DataTable Read(string valor)
        {
            ClsPersonal_D Datos = new ClsPersonal_D();
            return Datos.Read(valor);
        }
        public static string Create(string id, string nombrePersona, string apelPat, string apelMat, string fechaNacimiento)
        {
            ClsPersonal_D Datos = new ClsPersonal_D();
            ClsPersonal obj = new ClsPersonal();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombrePersona)) obj.NombrePersona = nombrePersona;
            else return "El nombre de la persona no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelPat)) obj.ApelPat = apelPat;
            else return "El apellido paterno no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelMat)) obj.ApelMat = apelMat;
            else return "El apellido materno no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(fechaNacimiento)) obj.FechaNacimiento = DateTime.Parse(fechaNacimiento);
            else return "La fecha de nacimiento no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Create(obj);
        }
        public static string Update(string id, string nombrePersona, string apelPat, string apelMat, string fechaNacimiento)
        {
            ClsPersonal_D Datos = new ClsPersonal_D();
            ClsPersonal obj = new ClsPersonal();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombrePersona)) obj.NombrePersona = nombrePersona;
            else return "El nombre de la persona no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelPat)) obj.ApelPat = apelPat;
            else return "El apellido paterno no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelMat)) obj.ApelMat = apelMat;
            else return "El apellido materno no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(fechaNacimiento)) obj.FechaNacimiento = DateTime.Parse(fechaNacimiento);
            else return "La fecha de nacimiento no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Update(obj);
        }
        public static string Delete(string id)
        {
            ClsPersonal_D Datos = new ClsPersonal_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del ID es incorrecto";
        }
    }
}
