using System;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace TestingStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=mydatabase.ccmbppmoohlj.eu-central-1.rds.amazonaws.com,3306;database=mydb;uid=admin;pwd=lenovoy720;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.Write("Connection Open ! ");

                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.Write("Can not open connection ! " + ex);
            }
        }
    }
}
