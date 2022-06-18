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
    public class ClsPedidoDomicilio_D
    {
        public DataTable Read()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_PEDIDOS_DOMICILIO", sqlCon);
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
        public DataTable Read(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_PEDIDO_DOMICILIO", sqlCon);
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
        public string Create(ClsPedidoDomicilio obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_CREATE_PEDIDO_DOMICILIO", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idCuenta", SqlDbType.Int).Value = obj.IdCuenta;
                cmd.Parameters.Add("@numeroTelefono", SqlDbType.VarChar).Value = obj.NumeroTelefono;
                cmd.Parameters.Add("@nombrePersona", SqlDbType.VarChar).Value = obj.Nombre;
                cmd.Parameters.Add("@calle", SqlDbType.VarChar).Value = obj.Calle;
                cmd.Parameters.Add("@numero", SqlDbType.Int).Value = obj.Numero;
                cmd.Parameters.Add("@colonia", SqlDbType.VarChar).Value = obj.Colonia;
                cmd.Parameters.Add("@localidad", SqlDbType.VarChar).Value = obj.Localidad;
                cmd.Parameters.Add("@detalles", SqlDbType.Structured).Value = obj.Detalle;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() >= 1) ? "OK" : "NO";
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

        public string Update(ClsPedidoDomicilio obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_PEDIDO_DOMICILIO", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idCuenta", SqlDbType.Int).Value = obj.IdCuenta;
                cmd.Parameters.Add("@numeroTelefono", SqlDbType.VarChar).Value = obj.NumeroTelefono;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                cmd.Parameters.Add("@calle", SqlDbType.VarChar).Value = obj.Calle;
                cmd.Parameters.Add("@numero", SqlDbType.Int).Value = obj.Numero;
                cmd.Parameters.Add("@colonia", SqlDbType.VarChar).Value = obj.Colonia;
                cmd.Parameters.Add("@localidad", SqlDbType.VarChar).Value = obj.Localidad;
                cmd.Parameters.Add("@detalle", SqlDbType.Structured).Value = obj.Detalle;
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
        }
        public string Delete(int id)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_DELETE_PEDIDO_DOMICILIO", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() >= 1) ? "OK" : "No se pudo insertar el pedido a domicilio";
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
        public string Cerrar(int id)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_CERRAR_PEDIDO", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() >= 1) ? "OK" : "NO";
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
