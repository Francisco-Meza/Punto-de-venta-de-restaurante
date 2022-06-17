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
        ClsPedidoDomicilio_D Datos = new ClsPedidoDomicilio_D();
        ClsPedidoDomicilio obj = new ClsPedidoDomicilio();
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
        public  string Create(string idCuenta, string numeroTelefono, string nombre, string calle, string numero, string colonia, string localidad, DataTable detalle)
        {
            if (Validaciones.SoloNumero(idCuenta)) obj.IdCuenta = int.Parse(idCuenta);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(numeroTelefono)) obj.NumeroTelefono = int.Parse(numeroTelefono);
            else return "El numero ingresado no es correcto";
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre de la  persona no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(colonia)) obj.Colonia = nombre;
            else return "El nombre de la colonia no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(calle)) obj.Calle = calle;
            else return "El nombre de la calle no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.SoloNumero(numero)) obj.Numero = int.Parse(numero);
            else return "El numero ingresado no es correcto";
            if (Validaciones.WithForCompareAsciiValue(localidad)) obj.Localidad = localidad;
            else return "El nombre de la localidad no tiene un formato correcto, intente no usar caracteres especiales";
            obj.Detalle = detalle;
            return Datos.Create(obj);
        }
        public  string Update(string id, string idCuenta, string numeroTelefono, string nombre, string calle, string numero, string colonia, string localidad, DataTable detalle)
        {
            
            if (Validaciones.SoloNumero(id)) obj.IdP = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(idCuenta)) obj.IdCuenta = int.Parse(idCuenta);
            else return "El ID ingresado no es valido";
            if (Validaciones.SoloNumero(numeroTelefono)) obj.NumeroTelefono = int.Parse(numeroTelefono);
            else return "El numero ingresado no es correcto";
            if (Validaciones.WithForCompareAsciiValue(nombre)) obj.Nombre = nombre;
            else return "El nombre de la persona no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(calle)) obj.Calle = calle;
            else return "El nombre de la calle no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.SoloNumero(numero)) obj.Numero = int.Parse(numero);
            else return "El numero ingresado no es correcto";
            if (Validaciones.WithForCompareAsciiValue(colonia)) obj.Colonia = colonia;
            else return "El nombre de la colonia no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(localidad)) obj.Localidad = localidad;
            else return "El nombre de la localidad no tiene un formato correcto, intente no usar caracteres especiales";
            obj.Detalle = detalle;
            return Datos.Update(obj);
        }
        /*public string Delete(string id)
        {
           // return Datos.Delete(id);
        }*/
        public string Cerrar(int id)
        {
           return Datos.Cerrar(id);
        }

    }
}
