using System.Configuration;
using System.Data.SqlClient;

namespace TicketsControl.dao {

    public class DaoFactory {

        public static SqlConnection Connection() {
            var connectionConfig = ConfigurationManager.ConnectionStrings["db_ticketscontrol"].ConnectionString;

            return new SqlConnection(connectionConfig);
        }
    }
}
