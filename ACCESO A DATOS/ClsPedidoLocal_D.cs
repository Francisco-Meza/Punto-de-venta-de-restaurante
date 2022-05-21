using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTIDADES;
using System.Data.SqlClient;

namespace ACCESO_A_DATOS
{
    public class ClsPedidoLocal_D
    {
        public DataTable Read()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_PEDIDO", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        public DataTable Read(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_PEDIDO_LOCAL", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        public string Create(ClsPedidoLocal obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_CREATE_PEDIDO_LOCAL", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha", SqlDbType.VarChar).Value = obj.Fecha;
                cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = obj.Estado;
                cmd.Parameters.Add("@idCuenta", SqlDbType.VarChar).Value = obj.IdCuenta;
                cmd.Parameters.Add("@idMesa", SqlDbType.VarChar).Value = obj.IdMesa;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 1) ? "OK" : "No se pudo insertar el pedido local";
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
        }
        public string Update(ClsPedidoLocal obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_PEDIDO_LOCAL", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha", SqlDbType.VarChar).Value = obj.Fecha;
                cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = obj.Estado;
                cmd.Parameters.Add("@idCuenta", SqlDbType.VarChar).Value = obj.IdCuenta;
                cmd.Parameters.Add("@idMesa", SqlDbType.VarChar).Value = obj.IdMesa;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 1) ? "OK" : "No se pudo actualizar el pedido local";
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
        }
        public string Delete(int id)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_DELETE_PEDIDO_LOCAL", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 1) ? "OK" : "No se pudo insertar el pedido local";
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
        }
    }
}
