using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESO_A_DATOS
{
    class ClsCuentas_D
    {
        #region Variables Privadas
        private int _id;
        private ClsTipoPuesto_D _puesto;
        private int _idPuesto;
        private string _correo, _contrasena;
        private ClsPersonal_D _pesona;
        private ClsDataBase m = new ClsDataBase(Constantes.francisco);
        #endregion

        #region Variables publicas
        public string Correo { get => _correo; set => _correo = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public int Id { get => _id; set => _id = value; }
        public ClsPersonal_D Pesona { get => _pesona; set => _pesona = value; }
        internal ClsTipoPuesto_D Puesto { get => _puesto; set => _puesto = value; }
        public int IdPuesto { get => _idPuesto;}
        #endregion

        #region Metodos publicos
        public bool Login(string correo, string contrasena)
        {
            Correo = correo;
            Contrasena = contrasena;
            List<ClsParametros> parametros = new List<ClsParametros>();
            parametros.Add(new ClsParametros("@correo",correo));
            parametros.Add(new ClsParametros("@contrasena",contrasena));
            parametros.Add(new ClsParametros("@mensaje",SqlDbType.Int,1));
            m.EjecutarSP("SP_LOGIN",parametros);
            bool retorno=false;
            if ((int)parametros[2].Valor == 1)
            {
                Puesto = new ClsTipoPuesto_D();
                Puesto.Read();//*****************9
                retorno = true;
            }else if ((int)parametros[2].Valor == 0)
            {
                retorno = false;
            }
            return retorno;
        }
        #endregion
    }
}
