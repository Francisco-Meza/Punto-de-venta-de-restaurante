using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace ACCESO_A_DATOS
{
    public class ClsProducto_D
    {
        public DataTable Read()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cdm = new SqlCommand("SP_LISTAR_PRODUCTO", sqlCon);
                cdm.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cdm.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        public DataTable Read(string Valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cdm = new SqlCommand("SP_BUSCAR_PRODUCTO", sqlCon);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                sqlCon.Open();
                resultado = cdm.ExecuteReader();
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
        public string Create(ClsProducto obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cdm = new SqlCommand("SP_CREATE_PRODUCTO", sqlCon);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                cdm.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                cdm.Parameters.Add("@idClsificacion", SqlDbType.Int).Value = obj.IdClasificacion;
                cdm.Parameters.Add("@precio", SqlDbType.Int).Value = obj.Precio;
                sqlCon.Open();
                msj = (cdm.ExecuteNonQuery() == 1) ? "OK" : "NO";
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
        public string Update(ClsProducto obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cdm = new SqlCommand("SP_UPDATE_PRODUCTO", sqlCon);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.Parameters.Add("@idProducto", SqlDbType.Int).Value = obj.IdProducto;
                cdm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                cdm.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                cdm.Parameters.Add("@idClsificacion", SqlDbType.Int).Value = obj.IdClasificacion;
                cdm.Parameters.Add("@precio", SqlDbType.Int).Value = obj.Precio;
                sqlCon.Open();
                msj = (cdm.ExecuteNonQuery() == 1) ? "OK" : "NO";
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
        public DataTable Read(int id)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_PRODUCTO_ID", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
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
        public string Delete(int id)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_DELETE_PRODUCTO", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 1) ? "OK" : "NO";
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
        public DataTable ReadClasificacion()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_PRODUCTOS_CLASIFICACION", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {
                return null;
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
    }

}

