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
        private int _id, _numeroCasa;
        //Atributos
        

        ClsDataBase M = new ClsDataBase(Constantes.david);

        public int Id { get => _id; set => _id = value; }
        public string Calle { get => _calle; set => _calle = value; }
        public string Colonia { get => _colonia; set => _colonia = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public int NumeroCasa { get => _numeroCasa; set => _numeroCasa = value; }

        //Create 

        public string Create(string calle, string colonia, string localidad, int numeroCasa)
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

        public string Delete(int id)
        {
            string msj = "";
            Id = id;

            List<ClsParametros> List = new List<ClsParametros>();
            try
            {
                List.Add(new ClsParametros("@idDomicilio", Id));
                List.Add(new ClsParametros("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("SP_DELETE_DOMICILIO", List);
                msj = List[1].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }

        public string Update(string calle, string colonia, string localidad, int numeroCasa)
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
                List.Add(new ClsParametros("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("SP_UPDATE_DOMICILIO", List);
                msj = List[4].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }

        public string UpdateCalle(string calle)
        {
            Calle = calle;
            string msj = "";
            List<ClsParametros> List = new List<ClsParametros>();
            try
            {
                List.Add(new ClsParametros("@calle", Calle));
                List.Add(new ClsParametros("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("SP_UPDATE_DOMICILIO", List);
                msj = List[1].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }

        public string UpdateColonia(string colonia)
        {
            Colonia = colonia;
            string msj = "";
            List<ClsParametros> List = new List<ClsParametros>();
            try
            {
                List.Add(new ClsParametros("@colonia", Colonia));
                List.Add(new ClsParametros("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("SP_UPDATE_DOMICILIO", List);
                msj = List[1].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }

        public string UpdateLocalidad(string localidad)
        {
            Localidad = localidad;
            string msj = "";
            List<ClsParametros> List = new List<ClsParametros>();
            try
            {
                List.Add(new ClsParametros("@localidad", Localidad));
                List.Add(new ClsParametros("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("SP_UPDATE_DOMICILIO", List);
                msj = List[1].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }
        public string UpdateNumeroCasa(int numeroCasa)
        {
            NumeroCasa = numeroCasa;
            string msj = "";
            List<ClsParametros> List = new List<ClsParametros>();
            try
            {
                List.Add(new ClsParametros("@calle", Calle));
                List.Add(new ClsParametros("@Mensaje", SqlDbType.VarChar, 100));
                M.EjecutarSP("SP_UPDATE_DOMICILIO", List);
                msj = List[1].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }
        // public bool Read()
        //{

        //}



    }
}
