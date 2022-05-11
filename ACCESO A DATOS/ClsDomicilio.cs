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
        private string _calle, _colonia, _localidad;
        private int _numeroCasa;
        //Atributos
        

        ClsDataBase M = new ClsDataBase(Constantes.david);

        public string Calle { get => _calle; set => _calle = value; }
        public string Colonia { get => _colonia; set => _colonia = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public int NumeroCasa { get => _numeroCasa; set => _numeroCasa = value; }

        //Create 

        public string AgregarDomicilio(string calle, string colonia, string localidad, int numeroCasa)
        {
            Calle = calle;
            Colonia = colonia;
            Localidad = localidad;
            NumeroCasa = numeroCasa;
            string msj = "";
            List<ClsParametros> List = new List<ClsParametros>();
            try
            {
                List.Add(new ClsParametros("@calle", Calle));
                List.Add(new ClsParametros("@colonia", Colonia));
                List.Add(new ClsParametros("@localidad", Localidad));
                List.Add(new ClsParametros("@numeroCasa", NumeroCasa));

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
