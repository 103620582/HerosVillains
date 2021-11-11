using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace GameAPI
{
    public abstract class DatabaseHandler 
    {
        public static string GetConnectionString() {
            try {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "SwinJoy.mssql.somee.com";
                builder.UserID = "JA103620582_SQLLogin_1";
                builder.Password = "wvof9j1kup";
                builder.InitialCatalog = "SwinJoy";
                return builder.ConnectionString;
            }
            catch(Exception e) {
                throw new Exception("500 - INTERNAL SERVER ERROR - Error in GetConnectionStrings() " + e.Message);
            }           
        }        
    }
}



