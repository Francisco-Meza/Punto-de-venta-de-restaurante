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
    public class ClsPedidoDomicilio_N
    {
        public static DataTable Read()
        {
            ClsPedidoDomicilio_D Datos = new ClsPedidoDomicilio_D();
            return Datos.Read();
        }
        public static DataTable Read(string valor)
        {
            ClsPedidoDomicilio_D Datos = new ClsPedidoDomicilio_D();
            return Datos.Read(valor);
        }
        public static string Create(string id, string numeroTelefono, string nombre, string idDomicilio)
        {
            ClsPedidoDomicilio_D Datos = new ClsPedidoDomicilio_D();
            ClsPedidoDomicilio obj = new ClsPedidoDomicilio();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(numeroTelefono)) obj.NumeroTelefono = int.Parse(numeroTelefono);
            else return "El numero ingresado no es correcto";
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre de la colonia no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(idDomicilio)) obj.IdDomicilio = int.Parse(idDomicilio);
            else return "El ID no es valido";
            return Datos.Create(obj);
        }
        public static string Update(string id, string numeroTelefono, string nombre, string idDomicilio)
        {
            ClsPedidoDomicilio_D Datos = new ClsPedidoDomicilio_D();
            ClsPedidoDomicilio obj = new ClsPedidoDomicilio();
            if (Validaciones.SoloNumero(id)) obj.Id = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(numeroTelefono)) obj.NumeroTelefono = int.Parse(numeroTelefono);
            else return "El numero ingresado no es correcto";
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre de la colonia no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(idDomicilio)) obj.IdDomicilio = int.Parse(idDomicilio);
            else return "El ID no es valido";
            return Datos.Update(obj);
        }
        public static string Delete(string id)
        {
            ClsPedidoDomicilio_D Datos = new ClsPedidoDomicilio_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del ID es incorrecto";
        }

    }
}
