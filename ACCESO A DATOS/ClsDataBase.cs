using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACCESO_A_DATOS
{
    public class ClsDataBase
    {
        #region Variables privadas
        private SqlConnection conexion;
        #endregion

        #region Constructores
        public ClsDataBase(string cadenaConexion)
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        #endregion

        #region Metodos privados
        private void ConectarDB()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        private void DesconectarDB()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        #endregion

        #region Metodos publicos
        public void EjecutarSP(string nombreSP, List<ClsParametros> parametros)
        {
            try
            {
                ConectarDB();
                SqlCommand cmd = new SqlCommand(nombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        if (parametro.Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
                        }
                        if (parametro.Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(parametro.Nombre,parametro.TipoDato,parametro.Tamanio).Direction = ParameterDirection.Output;
                        }
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < parametros.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                        {
                            parametros[i].Valor = cmd.Parameters[i].Value.ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            DesconectarDB();
        }

       

        #endregion
    }
}
