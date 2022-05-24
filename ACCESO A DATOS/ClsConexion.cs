using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESO_A_DATOS
{
    class ClsConexion
    {
        private string _base;
        private string _servidor;
        private string _usuario;
        private string _clave;
        private bool _seguridad;
        private static ClsConexion con = null;

        private ClsConexion()
        {
            this._base = "Restaurante";
            this._servidor = "DESKTOP-D8E6BU1";
            this._usuario = "Master";
            this._clave = "MAFRAD2";
            this._seguridad = true;
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this._servidor + "; Database=" + this._base + ";";
                if (_seguridad)
                {
                    cadena.ConnectionString += "Integrated Security = SSPI;";
                }
                else
                {
                    cadena.ConnectionString += "User Id =" + this._usuario + "; Password=" + this._clave + ";";
                }
                return cadena;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        public static ClsConexion GetInstancia()
        {
            if (con == null)
            {
                con = new ClsConexion();
            }
            return con;
        }
    }
}
