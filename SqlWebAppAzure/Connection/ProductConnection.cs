using System.Data.SqlClient;

namespace SqlWebAppAzure.Connection
{
    public class ProductConnection
    {
        private static string db_source = "webappserver7.database.windows.net";
        private static string db_username = "UTarannum";
        private static string db_password = "Loveyouallah@73";
        private static string db_databsename = "webappdb";

        public SqlConnection GetConnectionstring()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = db_source;
            builder.UserID = db_username;
            builder.Password = db_password;
            builder.InitialCatalog = db_databsename;
            return new SqlConnection(builder.ConnectionString);
        }
    }

    
}
