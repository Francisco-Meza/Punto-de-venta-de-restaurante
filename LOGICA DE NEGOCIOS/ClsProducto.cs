using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ACCESO_A_DATOS;

namespace LOGICA_DE_NEGOCIOS
{
    public class ClsProducto
    {
        //Atributos
        public string nombreProducto { get; set; }
        public string descripcion { get; set; }
        public string id_clasificacion { get; set; }
        public int precio { get; set; }

        ClsDataBase Combinacion = new ClsDataBase(Constantes.marlene);

        //Registrar
        public string Registro_Productos()
        {
            string Msj = "";
            List<ClsParametros> CombinacionList = new List<ClsParametros>();
            try
            {
                CombinacionList.Add(new ClsParametros("@nombre", nombreProducto));
                CombinacionList.Add(new ClsParametros("@descripcion", descripcion));
                CombinacionList.Add(new ClsParametros("@id_clasificacion", id_clasificacion));
                CombinacionList.Add(new ClsParametros("@precio", precio));

                Combinacion.EjecutarSP("SP_AGREGAR_PRODUCTO", CombinacionList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Msj;
        }
       
    }
}
