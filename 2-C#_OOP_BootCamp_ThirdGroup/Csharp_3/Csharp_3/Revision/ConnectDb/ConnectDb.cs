using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Csharp_3.Revision.RevisionOnOOP;

namespace Csharp_3.Revision.ConnectDb
{
     class ConnectDb
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Server=DESKTOP-LRMPGLQ;Database=Group3;User Id=sa ;Password=123 ";
            string Query = "Select * from Students";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
              SqlDataReader reader =  cmd.ExecuteReader();
                while ((reader.Read()))
                {
                    //int id = Convert.ToInt32(reader["Id"]);
                    Console.WriteLine("The Student Id is "+reader["Id"] +"\n Student Name is "+ reader["FullName"] +"\n Student Grade is : "+ reader["Grade"]);
                }
                
            }
        }

    }
}
