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
        ClsPedidoLocal_D Datos;
        ClsPedidoLocal obj;
        public ClsPedidoLocal_N()
        {
            Datos = new ClsPedidoLocal_D();
            obj = new ClsPedidoLocal();
        }
        public DataTable Read()
        {
            return Datos.Read();
        }
        public DataTable Read(string valor)
        {
            return Datos.Read(valor);
        }
        public string Create(int idCuenta, int idMesa, DataTable detalles)
        {
            obj.IdCuenta = idCuenta;
            obj.IdMesa = idMesa;
            obj.Detalles = detalles;
            return Datos.Create(obj);
        }
        public string Update(int idCuenta, DataTable detalles)
        {
            obj.IdCuenta = idCuenta;
            obj.Detalles = detalles;
            return Datos.Update(obj);
        }
        public string Delete(int id)
        {
            return Datos.Delete(id);
        }
        public DataTable ReadMesas()
        {
            return Datos.ReadMesas();
        }
        public DataTable ReadClasificacion()
        {
            return Datos.ReadClasificacion();
        }
        public DataTable ReadProducto()
        {
            return Datos.ReadProducto();
        }
    }
}
