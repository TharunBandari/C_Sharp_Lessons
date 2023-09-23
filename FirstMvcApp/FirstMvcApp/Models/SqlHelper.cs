using Microsoft.Data.SqlClient;

    namespace FirstMvcApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2868\SQLEXPRESS; database=Testdb; integrated security=true;Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
