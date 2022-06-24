using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESO_A_DATOS;

namespace LOGICA_DE_NEGOCIOS
{
    public class ClsChef_N
    {
        private ClsChef_D datos;
        private DataTable pedidosDt;
        private int[] pedidos;
        private string[] atendio;
        private string[] nota;
        private string[] estado;

        public int[] Pedidos { get => pedidos;}
        public string[] Atendio { get => atendio;}
        public string[] Nota { get => nota;}

        public ClsChef_N()
        {
            datos = new ClsChef_D();
            IniciarDatos();
        }

        public DataTable Read(int id)
        {
            return datos.Read(id);
        }
        public void IniciarDatos()
        {
            pedidosDt = datos.ReadPedidos();
            pedidos = new int[pedidosDt.Rows.Count];
            atendio = new string[pedidosDt.Rows.Count];
            nota = new string[pedidosDt.Rows.Count];
            estado = new string[pedidosDt.Rows.Count];
            for (int i = 0; i < pedidosDt.Rows.Count; i++)
            {
                //- Guardar la Columna Nombre el el Arreglo
                pedidos[i] = Convert.ToInt32(pedidosDt.Rows[i]["ID"]);
                atendio[i] = pedidosDt.Rows[i]["ATENDIO"].ToString();
                nota[i] = pedidosDt.Rows[i]["NOTA"].ToString();
                estado[i] = pedidosDt.Rows[i]["ESTADO"].ToString();
            }
        }

        public string Update(int id, string estado)
        {
            if (this.estado[id].Equals(estado))
            {
                return "Este pedido ya esta en este estado";
            }
            else if((this.estado[id].Equals("PROCESO") && estado.Equals("REALIZADO")) || (this.estado[id].Equals("ACTIVO") && estado.Equals("PROCESO")))
            {
                this.estado[id] = estado;
                return datos.Update(pedidos[id], estado);
            }
            else
            {
                return "No se puede terminar si no has empezado";
            }
        }
    }
}
