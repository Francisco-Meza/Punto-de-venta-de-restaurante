using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESO_A_DATOS
{
    public class ClsClasificacion_D
    {
        #region Variables privadas
        private int _id;
        private ClsDataBase m;
        private string _nombre,_descripcion;
        #endregion

        #region Constructor
        public  ClsClasificacion_D()
        {
            m = new ClsDataBase(Constantes.marlene);
        }
        #endregion

        #region Varaibles Publicas
        public int Id{ get => _id; set => _id = value;}
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        #endregion

        #region Metodo Publico
        public string Cread()
        {
            string Msj = "";
            List<ClsParametros> CombinacionList = new List<ClsParametros>();
            try
            {
                CombinacionList.Add(new ClsParametros("@nombre", Nombre));
                CombinacionList.Add(new ClsParametros("@descripcion", Descripcion));
                CombinacionList.Add(new ClsParametros("@id_clasificacion", Id));
                CombinacionList.Add(new ClsParametros("@Mensaje", System.Data.SqlDbType.VarChar, 100));
                m.EjecutarSP("SP_AGREGAR_CLASIFICACION", CombinacionList);
                Msj = CombinacionList[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Msj;
        }
        public DataTable Read()
        {
            return m.Ejecutar_Lectura("SP_MOSTRAR_CLASIFICACION", null);   
        }
        public void Update()
        {

        }
        
        #endregion

    }
}
