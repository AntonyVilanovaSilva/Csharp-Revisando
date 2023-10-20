using System.Data.SqlClient;

namespace Concessonária.DAL
{
    public class ConexaoBD
    {
        public static SqlConnection banco;

        public static SqlConnection getconexao()
        {
            if (banco == null) // classe da conexão
            {
                banco = new SqlConnection(@"Server=PC03LAB1560\SENAI; Database=Concessionaria; User Id =sa; Password=senai.123;");
            }
            return banco;
        }
    }
}
