using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ACCESO_A_DATOS
{
    public class ClsDomicilio
    {
        //Atributos
        public string calle { get; set; }

        public string colonia { get; set; }

        public string localidad { get; set; }

        public int numeroCasa { get; set; }

        ClsDataBase M = new ClsDataBase(Constantes.david);

        //Create 

        public string AGREGAR_DOMICILIO()
        {
            string msj = "";
            List<ClsParametros> List = new List<ClsParametros>();
            try
            {
                List.Add(new ClsParametros("@calle", calle));
                List.Add(new ClsParametros("@colonia", colonia));
                List.Add(new ClsParametros("@localidad", localidad));
                List.Add(new ClsParametros("@numeroCasa", numeroCasa));

                M.EjecutarSP("SP_AGREGAR_DOMICILIO", List);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }
        //Mostrar
        //public DataTable ListaDomicilio()
        //{
        //    //return M
             
        //}


    }
}
