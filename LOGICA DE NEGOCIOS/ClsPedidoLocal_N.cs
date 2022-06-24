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
        public string Create(int idCuenta, int idMesa, DataTable detalles, string nota)
        {
            obj.IdCuenta = idCuenta;
            obj.IdMesa = idMesa;
            obj.Detalles = detalles;
            if (nota != string.Empty)
            {
                obj.Nota = nota;
            }
            else
            {
                obj.Nota = null;
            }
            return Datos.Create(obj);
        }
        public string Update(int idPedido, DataTable detalles, string nota)
        {
            obj.IdPedido = idPedido;
            obj.Detalles = detalles;
            if (nota != string.Empty)
            {
                obj.Nota = nota;
            }
            else
            {
                obj.Nota = null;
            }
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
        public DataTable Read(int id)
        {
            return Datos.Read(id);
        }
        public DataTable Read2(int id)
        {
            return Datos.Read2(id);
        }
    }
}
