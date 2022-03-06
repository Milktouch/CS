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
            connetionString = "RandomConnectionString";
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
