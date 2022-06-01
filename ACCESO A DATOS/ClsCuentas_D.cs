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
    public class ClsCuentas_D
    {
        public DataTable Read()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_CUENTAS", sqlCon);
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
                SqlCommand cmd = new SqlCommand("SP_READ_CUENTAS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public string Create(ClsCuentas obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_CREATE_CUENTAS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idPuesto", SqlDbType.VarChar).Value = obj.IdTipoPuesto;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = obj.Correo;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.Contrasena;
                cmd.Parameters.Add("@nombrePersona", SqlDbType.VarChar).Value = obj.NombrePersona;
                cmd.Parameters.Add("@apelPat", SqlDbType.VarChar).Value = obj.ApelPat;
                cmd.Parameters.Add("@apelMat", SqlDbType.VarChar).Value = obj.ApelMat;
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.FechaNacimiento;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() >= 1) ? "OK" : "No se pudo insertar la cuenta";
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

        public string Update(ClsCuentas obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_CUENTAS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idCuenta", SqlDbType.Int).Value = obj.Id;
                cmd.Parameters.Add("@idPuesto", SqlDbType.VarChar).Value = obj.IdTipoPuesto;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = obj.Correo;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.Contrasena;
                cmd.Parameters.Add("@nombrePersona", SqlDbType.VarChar).Value = obj.NombrePersona;
                cmd.Parameters.Add("@apelPat", SqlDbType.VarChar).Value = obj.ApelPat;
                cmd.Parameters.Add("@apelMat", SqlDbType.VarChar).Value = obj.ApelMat;
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.FechaNacimiento;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.Telefono;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() >= 1) ? "OK" : "No se pudo actualizar la cuenta";
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
                SqlCommand cmd = new SqlCommand("SP_DELETE_CUENTAS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idCuenta", SqlDbType.Int).Value = id;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() >= 1) ? "OK" : "No se pudo insertar la cuenta";
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

        public DataTable Login(string correo, string clave)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_LOGIN_CUENTAS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
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
        public DataTable ReadPuesto()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_CUENTAS_PUESTO", sqlCon);
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
        public DataTable Read(int id)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_CUENTAS_ID", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
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