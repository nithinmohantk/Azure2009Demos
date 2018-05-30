using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace SQLAzureWebDemo.Utils
{
    public class SqlUtil
    {

        public static SqlConnection GetConnection(string name)
        {

            SqlConnection objConn = new SqlConnection(WebConfigurationManager.ConnectionStrings[name].ConnectionString);
            //objConn.Open(); 

            return objConn;  
        }
    }
}
