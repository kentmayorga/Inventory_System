using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Invent_coffee.Resources;

class connSql
{
    private string connSqlString;
    private MySqlConnection conn;

    public MySqlConnection connectSql()
    {
        try{
            connSqlString = "server=localhost;database=trialdb;user=root;pwd=Matero#92002;";

            conn = new MySqlConnection(connSqlString);

            Console.WriteLine(conn == null ? "Database connection failed!" : "Database Connection successful");

            return conn;
        } catch (Exception ex) {
            Console.WriteLine("Error connecting to database: " + ex.Message);
            return null;
        }
        
    }
    
}
