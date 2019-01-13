using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ConnectionManager
    {
        public static SqlConnection DbConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-4NBCF29\\SQLEXPRESS;Initial Catalog=Restaurant;User ID=sa;Password=123");
        }
    }
}