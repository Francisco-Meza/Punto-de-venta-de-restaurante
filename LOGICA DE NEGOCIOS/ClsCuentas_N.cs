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
        public ClsCuentas_N()
        {
            Datos = new ClsCuentas_D();
            obj = new ClsCuentas();
        }
        public DataTable Read()
        {
            return Datos.Read();
        }
        public DataTable Read(string valor)
        {
            return Datos.Read(valor);
        }
        public static string Create(string id, string idTipoPuesto, string idPersonal, string correo, string contrasena)
        {
            ClsCuentas_D Datos = new ClsCuentas_D();
            ClsCuentas obj = new ClsCuentas();
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
            if (Validaciones.WithForCompareAsciiValue(fechaNacimiento)) obj.FechaNacimiento = DateTime.Parse(fechaNacimiento);
            else return "La fecha de nacimiento no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Create(obj);
        }
        public static string Update(string id, string idTipoPuesto, string idPersonal, string correo, string contrasena)
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
            if (Validaciones.WithForCompareAsciiValue(fechaNacimiento)) obj.FechaNacimiento = DateTime.Parse(fechaNacimiento);
            else return "La fecha de nacimiento no tiene un formato correcto, intente no usar caracteres especiales";
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
    }
}
