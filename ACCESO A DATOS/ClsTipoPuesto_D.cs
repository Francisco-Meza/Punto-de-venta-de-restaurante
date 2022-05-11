using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESO_A_DATOS
{
    public class ClsTipoPuesto_D
    {
        #region Variables privadas
        private int _id;
        private ClsDataBase m;
        private string _nombre, _descripcion;
        #endregion

        #region Constructor
        public ClsTipoPuesto_D()
        {
            m = new ClsDataBase(Constantes.francisco);
        }
        #endregion

        #region Variables publicas
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        #endregion

        #region Metodos publicos
        public bool Read(int idPuesto)
        {
            bool retornar;
            try
            {
                List<ClsParametros> parametros = new List<ClsParametros>();
                parametros.Add(new ClsParametros("@idPuesto", idPuesto));
                DataTable dtTable = m.Ejecutar_Lectura("SP_READ_CUENTA_TIPO_PUESTO", parametros);
                foreach (DataRow row in dtTable.Rows)
                {
                    Id = Convert.ToInt32(row["id_tipoPuesto"]);
                    Nombre = row["nombrePuesto"].ToString();
                    Descripcion = row["descripcion"].ToString();
                }
                Console.WriteLine(Nombre);
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
            return m.Ejecutar_Lectura("SP_READ_TIPO_PUESTO",null);
        }
        #endregion
    }
}
