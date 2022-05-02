using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Ado.dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;          
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            Console.WriteLine("Connection Successful.");
            Console.ReadKey();
        }
    }
}
