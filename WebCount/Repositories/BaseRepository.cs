using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebCount.Repositories
{
    public abstract class BaseRepository
	{
        private IDbConnection connection = 
            new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        

        public IDbConnection GetConnection()
        {
            return connection;
        }
    }
}