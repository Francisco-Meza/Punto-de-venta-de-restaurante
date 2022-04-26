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
        string francisco = "Data Source=DESKTOP-4MR4OFL\\MSSQLSERVER00;User ID=Master;Password=MAFRAD2;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string marlene = "Data Source=DESKTOP-D8E6BU1;User ID=Master Mayi;Password=MAFRAD2;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection();
        //-------------------- Cambien su conexion-----------------//
        public Conexion()
        {
            connection.ConnectionString = marlene;
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
