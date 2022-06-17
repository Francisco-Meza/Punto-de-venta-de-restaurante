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
        public DataTable Read()
        {
            return Datos.Read();
        }
        public DataTable Read(string valor)
        {
            return Datos.Read(valor);
        }
        public  string Create(int idCuenta, string numeroTelefono, string nombre, string calle, string numero, string colonia, string localidad, DataTable detalle)
        {
            obj.IdCuenta = idCuenta;
            obj.NumeroTelefono = numeroTelefono;
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
        public  string Update(int idPedido, int idCuenta, string numeroTelefono, string nombre, string calle, string numero, string colonia, string localidad, DataTable detalle)
        {

            obj.IdP = idPedido;
            obj.IdCuenta = idCuenta;
            obj.NumeroTelefono = numeroTelefono;
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
        public string Delete(int id)
        {
           return Datos.Delete(id);
        }
        public string Cerrar(int id)
        {
           return Datos.Cerrar(id);
        }

    }
}
