using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ACCESO_A_DATOS
{
    public class Conexion
    {
        //-------------------- Cambien su conexion-----------------//
        string cadenaConexion = "Data Source=DESKTOP-4MR4OFL\\MSSQLSERVER00;User ID=Master;Password=MAFRAD2;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection();
        
        public Conexion()
        {
            connection.ConnectionString = cadenaConexion;
        }

        public void Conectar()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error"+e.Message);
                throw;
            }
        }
        public void Desconectar()
        {
            connection.Close();
        }
    }
}
