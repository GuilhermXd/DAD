using MySql.Data.MySqlClient;

namespace Dados
{
    internal class Conexao
    {
        public static string conexString = "server=143.106.241.4;database=cl203237;user=cl203237;password=cl*31012008;";
        public static MySqlConnection SqlCon = new MySqlConnection();

        public static void getConnection()
        {
            try
            {

                if (Conexao.SqlCon.State == System.Data.ConnectionState.Closed)
                {
                    Conexao.SqlCon.ConnectionString = conexString;
                    Conexao.SqlCon.Open();
                }

            }


            catch (MySqlException ex)
            {


                throw;
            }

        }
    }
}
