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
    public class ClsPedidoLocal_N
    {
        public static DataTable Read()
        {
            ClsPedidoLocal_D Datos = new ClsPedidoLocal_D();
            return Datos.Read();
        }
        public static DataTable Read(string valor)
        {
            ClsPedidoLocal_D Datos = new ClsPedidoLocal_D();
            return Datos.Read(valor);
        }
        public static string Create(string idCuenta, string idMesa, string fecha, string estado)
        {
            ClsPedidoLocal_D Datos = new ClsPedidoLocal_D();
            ClsPedidoLocal obj = new ClsPedidoLocal();
            if (Validaciones.SoloNumero(idCuenta)) obj.IdCuenta = int.Parse(idCuenta);
            else return "El ID ingresado de cuneta no es valido";
            if (Validaciones.SoloNumero(idMesa)) obj.IdMesa = int.Parse(idMesa);
            else return "El ID ingresado de mesa no es valido";
            if (Validaciones.SoloNumero(fecha)) obj.Fecha = DateTime.Parse(fecha);
            else return "La fecha no tiene el formato correcto";
            if (Validaciones.WithForCompareAsciiValue(estado)) obj.Estado = estado;
            else return "El estado no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Create(obj);
        }
        public static string Update(string idCuenta, string idMesa, string fecha, string estado)
        {
            ClsPedidoLocal_D Datos = new ClsPedidoLocal_D();
            ClsPedidoLocal obj = new ClsPedidoLocal();
            if (Validaciones.SoloNumero(idCuenta)) obj.IdCuenta = int.Parse(idCuenta);
            else return "El ID ingresado de cuneta no es valido";
            if (Validaciones.SoloNumero(idMesa)) obj.IdMesa = int.Parse(idMesa);
            else return "El ID ingresado de mesa no es valido";
            if (Validaciones.SoloNumero(fecha)) obj.Fecha = DateTime.Parse(fecha);
            else return "La fecha no tiene el formato correcto";
            if (Validaciones.WithForCompareAsciiValue(estado)) obj.Estado = estado;
            else return "El estado no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Update(obj);
        }
        public static string Delete(string id)
        {
            ClsPedidoLocal_D Datos = new ClsPedidoLocal_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del ID es incorrecto";
        }
    }
}
