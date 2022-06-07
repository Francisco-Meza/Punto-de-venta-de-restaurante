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
            if (Validaciones.WithForCompareAsciiValue(valor)) return Datos.Read(valor);
            else return null;
        }
        public  string Create(int idTipoPuesto, string correo, string contrasena,string nombrePersona,string apelPat,string apelMat,DateTime fechaNacimiento, string telefono)
        {
            obj.IdTipoPuesto = idTipoPuesto;
            if (Validaciones.VerificarCorreo(correo)) obj.Correo = correo;
            else return "El correo no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.VerificarContrasena(contrasena)) obj.Contrasena = contrasena;
            else return "La contraseña no tiene un formato correcto, intente no usar caracteres especiales";            
            if (Validaciones.WithForCompareAsciiValue(nombrePersona)) obj.NombrePersona = nombrePersona;
            else return "El nombre de persona no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelPat)) obj.ApelPat = apelPat;
            else return "El apellido paterno no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelMat)) obj.ApelMat = apelMat;
            else return "El apellido materno no tiene un formato correcto, intente no usar caracteres especiales";
            obj.FechaNacimiento = fechaNacimiento;
            obj.Telefono = telefono;
            return Datos.Create(obj);
        }
        public string Update(int id, int idTipoPuesto, string correo, string contrasena, string nombrePersona, string apelPat, string apelMat, DateTime fechaNacimiento, string telefono)
        {
            obj.Id = id;
            obj.IdTipoPuesto = idTipoPuesto;
            if (Validaciones.VerificarCorreo(correo)) obj.Correo = correo;
            else return "El correo no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.VerificarContrasena(contrasena)) obj.Contrasena = contrasena;
            else return "La contraseña no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(nombrePersona)) obj.NombrePersona = nombrePersona;
            else return "El nombre de persona no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelPat)) obj.ApelPat = apelPat;
            else return "El apellido paterno no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(apelMat)) obj.ApelMat = apelMat;
            else return "El apellido materno no tiene un formato correcto, intente no usar caracteres especiales";
            obj.FechaNacimiento = fechaNacimiento;
            obj.Telefono = telefono;
            return Datos.Update(obj);
        }
        public string Delete(int id)
        {
            return Datos.Delete(id);
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
