using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESO_A_DATOS
{
    class ClsPuestoOperacion_D
    {
        #region Variables privadas
        private int _idPuesto, _idOperacion;
        private string _nombrePuesto, _nombreOperacion;
        private ClsOperacion_D _operacion;
        #endregion

        #region Variables privadas
        public int IdPuesto { get => _idPuesto; set => _idPuesto = value; }
        public int IdOperacion { get => _idOperacion; set => _idOperacion = value; }
        public string NombrePuesto { get => _nombrePuesto; set => _nombrePuesto = value; }
        public string NombreOperacion { get => _nombreOperacion; set => _nombreOperacion = value; }
        public ClsOperacion_D Operacion { get => _operacion; set => _operacion = value; }
        #endregion
    }
}
