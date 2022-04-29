using System;
using System.Data;
using System.Data.SqlClient;

namespace ACCESO_A_DATOS.DataBase
{
    public class ClsDataBase
    {
        #region Variables privadas
        private SqlConnection _objSqlConnection;
        private SqlDataAdapter _objSqlDataAdapter;
        private SqlCommand _objSqlCommand;
        private DataSet _dsResultado;
        private DataTable _dtParametros;
        private string _nombreTabla, _nombreSP, _mensajeErrorDB, _valorScalar, _nombreDB;
        private bool _scalar;
        #endregion

        #region Variables publicas
        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public DataSet DsResultado { get => _dsResultado; set => _dsResultado = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string NombreSP { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorDB { get => _mensajeErrorDB; set => _mensajeErrorDB = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public string NombreDB { get => _nombreDB; set => _nombreDB = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }
        #endregion

        #region Constructores
        public ClsDataBase()
        {
            DtParametros = new DataTable("Parametros");
            DtParametros.Columns.Add("Nombre");
            DtParametros.Columns.Add("TipoDato");
            DtParametros.Columns.Add("Valor");
            NombreDB = "";
        }
        #endregion

        #region Metodos privados
        private void CrearConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            switch (ObjDataBase.NombreDB)
            {
                case "Restaurante":
                    ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConexion_DB_Restaurante);
                    break;
                default:
                    break;
            }
        }
        private void ValidarConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            if(ObjDataBase.ObjSqlConnection.State == ConnectionState.Closed)
            {
                ObjDataBase.ObjSqlConnection.Open();
            }
            else
            {
                ObjDataBase.ObjSqlConnection.Close();
                ObjDataBase.ObjSqlConnection.Dispose();
            }
        }
        private void AgregarParametros(ref ClsDataBase ObjDataBase)
        {
            if(ObjDataBase.DtParametros != null)
            {
                SqlDbType TipoDatoSql = new SqlDbType();
                foreach (DataRow item in ObjDataBase.DtParametros.Rows)
                {
                    switch (item[1])
                    {
                        case "1":
                            TipoDatoSql = SqlDbType.Bit;
                            break;
                        case "2":
                            TipoDatoSql = SqlDbType.TinyInt;
                            break;
                        case "3":
                            TipoDatoSql = SqlDbType.SmallInt;
                            break;
                        case "4":
                            TipoDatoSql = SqlDbType.Int;
                            break;
                        case "5":
                            TipoDatoSql = SqlDbType.BigInt;
                            break;
                        case "6":
                            TipoDatoSql = SqlDbType.Decimal;
                            break;
                        case "7":
                            TipoDatoSql = SqlDbType.SmallMoney;
                            break;
                        case "8":
                            TipoDatoSql = SqlDbType.Money;
                            break;
                        case "9":
                            TipoDatoSql = SqlDbType.Float;
                            break;
                        case "10":
                            TipoDatoSql = SqlDbType.Real;
                            break;
                        case "11":
                            TipoDatoSql = SqlDbType.Date;
                            break;
                        case "12":
                            TipoDatoSql = SqlDbType.Time;
                            break;
                        case "13":
                            TipoDatoSql = SqlDbType.SmallDateTime;
                            break;
                        case "14":
                            TipoDatoSql = SqlDbType.Date;
                            break;
                        case "15":
                            TipoDatoSql = SqlDbType.Char;
                            break;
                        case "16":
                            TipoDatoSql = SqlDbType.NChar;
                            break;
                        case "17":
                            TipoDatoSql = SqlDbType.VarChar;
                            break;
                        case "18":
                            TipoDatoSql = SqlDbType.NVarChar;
                            break;
                        default:
                            break;
                    }
                    if (ObjDataBase.Scalar)
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSql).Value = DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSql).Value = item[2].ToString();
                        }
                    }
                    else
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSql).Value = DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSql).Value = item[2].ToString();
                        }
                    }
                }
            }
        }
        private void PreparaConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            CrearConexionBaseDatos(ref ObjDataBase);
            ValidarConexionBaseDatos(ref ObjDataBase);
        }
        private void EjecutarDataAdapter(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PreparaConexionBaseDatos(ref ObjDataBase);
                ObjDataBase.ObjSqlDataAdapter = new SqlDataAdapter(ObjDataBase.NombreSP, ObjDataBase.ObjSqlConnection);
                ObjDataBase.ObjSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametros(ref ObjDataBase);
                ObjDataBase.DsResultado = new DataSet();
                ObjDataBase.ObjSqlDataAdapter.Fill(ObjDataBase.DsResultado, ObjDataBase.NombreTabla);
            }
            catch (Exception ex)
            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();
            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref ObjDataBase);
                }
            }
        }
        private void EjecutarCommand(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PreparaConexionBaseDatos(ref ObjDataBase);
                ObjDataBase.ObjSqlCommand = new SqlCommand(ObjDataBase.NombreSP, ObjDataBase.ObjSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                AgregarParametros(ref ObjDataBase);
                if (ObjDataBase.Scalar)
                {
                    ObjDataBase.ValorScalar = ObjDataBase.ObjSqlCommand.ExecuteScalar().ToString().Trim();
                }
                else
                {
                    ObjDataBase.ObjSqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                ObjDataBase.MensajeErrorDB = e.Message.ToString();
            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref ObjDataBase);
                }
            }
        }
        #endregion

        #region Metodos publicos
        public void CRUD(ref ClsDataBase ObjDatabase)
        {
            if (ObjDatabase.Scalar)
            {
                EjecutarCommand(ref ObjDatabase);
            }
            else
            {
                EjecutarDataAdapter(ref ObjDatabase);
            }
        }
        #endregion
    }
}
