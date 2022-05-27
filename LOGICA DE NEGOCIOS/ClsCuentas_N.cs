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
    public class ClsCuentas_N
    {
        ClsCuentas_D Datos;
        ClsCuentas obj;
        
        public static DataTable Read()
        {
            ClsCuentas_D Datos = new ClsCuentas_D();
            return Datos.Read();
        }
        public DataTable Read(string valor)
        {
            ClsCuentas_D Datos = new ClsCuentas_D();
            if (Validaciones.WithForCompareAsciiValue(valor)) return Datos.Read(valor);
            else return null;
        }
        public  string Create(string id, string idTipoPuesto, string idPersonal, string correo, string contrasena, string nombrePuesto, string descripcion,string nombrePersona,string apelPat,string apelMat,DateTime fechaNacimiento)
        {
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(idTipoPuesto)) obj.IdTipoPuesto = int.Parse(idTipoPuesto);
            else return "El ID Tipo Puesto ingresado no es valido";
            if (Validaciones.SoloNumero(idPersonal)) obj.IdPersonal = int.Parse(idPersonal);
            else return "El ID Personal no es valido";
            if (Validaciones.WithForCompareAsciiValue(correo)) obj.Correo = correo;
            else return "El correo no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(contrasena)) obj.Contrasena = contrasena;
            else return "La contraseña no tiene un formato correcto, intente no usar caracteres especiales";            
            if (Validaciones.WithForCompareAsciiValue(nombrePuesto)) obj.NombrePuesto = nombrePuesto;
            else return "El nombre del puesto no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "La descripcion no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(nombrePersona)) obj.NombrePersona = nombrePersona;
            else return "El nombre de persona no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelPat)) obj.ApelPat = apelPat;
            else return "El apellido paterno no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelMat)) obj.ApelMat = apelMat;
            else return "El apellido materno no tiene un formato correcto, intente no usar caracteres especiales";
            obj.FechaNacimiento = fechaNacimiento;
            return Datos.Create(obj);
        }
        public string Update(string id, string idTipoPuesto, string idPersonal, string correo, string contrasena, string nombrePuesto, string descripcion, string nombrePersona, string apelPat, string apelMat, DateTime fechaNacimiento)
        {
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(idTipoPuesto)) obj.IdTipoPuesto = int.Parse(idTipoPuesto);
            else return "El ID Tipo Puesto ingresado no es valido";
            if (Validaciones.SoloNumero(idPersonal)) obj.IdPersonal = int.Parse(idPersonal);
            else return "El ID Personal no es valido";
            if (Validaciones.WithForCompareAsciiValue(correo)) obj.Correo = correo;
            else return "El correo no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(contrasena)) obj.Contrasena = contrasena;
            else return "La contraseña no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(nombrePuesto)) obj.NombrePuesto = nombrePuesto;
            else return "El nombre del puesto no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(descripcion)) obj.Descripcion = descripcion;
            else return "La descripcion no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(nombrePersona)) obj.NombrePersona = nombrePersona;
            else return "El nombre de persona no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelPat)) obj.ApelPat = apelPat;
            else return "El apellido paterno no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelMat)) obj.ApelMat = apelMat;
            else return "El apellido materno no tiene un formato correcto, intente no usar caracteres especiales";
            obj.FechaNacimiento = fechaNacimiento;
            return Datos.Update(obj);
        }
        public string Delete(string id)
        {
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del ID es incorrecto";
        }
        public DataTable Login(string correo,string clave)
        {
            return Datos.Login(correo,clave);
        }
        public DataTable ReadPuesto()
        {
            return Datos.ReadPuesto();
        }
        public DataTable Read(int id)
        {
            return Datos.Read(id);
        }
    }
}
