using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;
using System.Data;

namespace ACCESO_A_DATOS
{
    public class ClsChef_D
    {
        public DataTable Read()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_NOTAS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
   /* public string Update(ClsPedidoLocal obj)
    {
        string msj = "";
        SqlConnection sqlCon = new SqlConnection();
        try
        {
            sqlCon = ClsConexion.GetInstancia().CreateConnection();
            SqlCommand cmd = new SqlCommand("SP_UPDATE_NOTAS", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idPedido", SqlDbType.Int).Value = obj.IdPedido;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
            cmd.Parameters.Add("@notas", SqlDbType.VarChar).Value = obj.Nota;
            sqlCon.Open();
            msj = (cmd.ExecuteNonQuery() == 1) ? "OK" : "No se pudo actualizar el pedido a domicilio";
        }
        catch (Exception e)
        {
            msj = e.Message;
        }
        finally
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        return msj;
    }*/
}
