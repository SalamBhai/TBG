using System;
using MySql.Data.MySqlClient;
using System.IO;
namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionaccesstomysql = "server=localhost;user=root;database=SchoolApp;password=Salamb#@!_%saula>";

            using (MySqlConnection Primus = new MySqlConnection(connectionaccesstomysql))
            {
                Primus.Open();
  
                var result = anothercmd.ExecuteNonQuery();
                MySqlCommand Commands = new MySqlCommand("Select * from student", Primus);
                var datareader = Commands.ExecuteReader();
                while (datareader.Read())
                {
                    Console.WriteLine("{0}, {1},{2}, {3},{4},{5}", datareader["firstname"], datareader["lastname"], datareader["Gender"], datareader["email"], datareader["phonenumber"], datareader["RegNumber"]);
                }


            }
        }
    }
}
