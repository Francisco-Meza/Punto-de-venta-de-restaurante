using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESO_A_DATOS
{
    class ClsModulo_D
    {
        #region Variables privadas
        private int _id;
        private string _nombre;
        #endregion

        #region Variables publicas
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        #endregion
    }
}
