using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BasicCrud.DAL
{
    class ConnectionDAL
    {
        public static SqlConnection GetConnection()
        {
            string url = "Data Source=MILO-JUAREZ\\SERVER; Initial Catalog=catalogo_autos; Integrated Security=true";
            try
            {
                SqlConnection connection = new SqlConnection(url);
                return connection;
            } catch
            {
                return null;
            }
        }
    }
}
