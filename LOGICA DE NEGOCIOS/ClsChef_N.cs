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
        public ClsChef_N()
        {
            datos = new ClsChef_D();
        }

        public DataTable Read(int id)
        {
            return datos.Read();
        }

        public string Update(int id, string estadoActual, string nuevoEstado)
        {
            if (estadoActual.Equals(nuevoEstado))
            {
                return "Ya se encuentra en este estado";
            }
            else
            {
                return "";
            }
        }
    }
}
