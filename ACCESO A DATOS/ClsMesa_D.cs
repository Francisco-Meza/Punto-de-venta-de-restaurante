using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESO_A_DATOS
{
    class ClsMesa_D
    {
        #region Variables privadas
        private int _id, _numMesa, _numComensales;
        private string _descripcion;
        private ClsDataBase m;
        #endregion

        #region Constructor
        public ClsMesa_D()
        {
            m = new ClsDataBase(Constantes.danny);
        }
        #endregion


        #region Variables publicas
        public int Id { get => _id; set => _id = value; }
        public int NumeroMesa { get => _numMesa; set => _numMesa = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int NumeroComensales{ get => _numComensales; set => _numComensales = value; }
        #endregion


        #region Metodos publicos
        public bool Read(int idMesa)
        {
            bool retornar;
            try
            {
                List<ClsParametros> parametros = new List<ClsParametros>();
                parametros.Add(new ClsParametros("@idMesa", idMesa));
                DataTable dtTable = m.Ejecutar_Lectura("SP_READ_MESA", parametros);
                foreach (DataRow row in dtTable.Rows)
                {
                    Id = Convert.ToInt32(row["id_mesa"]);
                    NumeroMesa = Convert.ToInt32( row["numeroMesa"]);
                    Descripcion = row["descripcion"].ToString();
                    NumeroComensales = Convert.ToInt32(row["numeroComensales"]);
                }
                Console.WriteLine(NumeroMesa);
                retornar = true;
            }
            catch (Exception)
            {
                retornar = false;
                throw;
            }
            return retornar;
        }

        public DataTable Read()
        {
            return m.Ejecutar_Lectura("SP_READ_MESA", null);
        }
        #endregion
    }
}
