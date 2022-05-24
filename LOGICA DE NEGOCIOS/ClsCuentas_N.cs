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
        public static DataTable Read()
        {
            ClsCuentas_D Datos = new ClsCuentas_D();
            return Datos.Read();
        }
        public static DataTable Read(string valor)
        {
            ClsCuentas_D Datos = new ClsCuentas_D();
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
            return Datos.Create(obj);
        }
        public static string Update(string id, string idTipoPuesto, string idPersonal, string correo, string contrasena)
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
            return Datos.Update(obj);
        }
        public static string Delete(string id)
        {
            ClsCuentas_D Datos = new ClsCuentas_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del ID es incorrecto";
        }
    }
}
