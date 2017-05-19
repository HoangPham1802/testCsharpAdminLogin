using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace demoCsharpException
{
    class AdminModel
    {
        private MySqlConnection connect;
        private MySqlCommand command;

        public void Show()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Admin ad = new Admin();
            ad.MenuConsole();
            //Console.WriteLine("Please enter your account: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter your password: ");
            //string pass = Console.ReadLine();

            if (ad.name == "" || ad.pass == "")
            {
                Console.WriteLine("Đăng nhập thất bại");
            }
            else
            {
                try
                {
                    string slt = "SELECT * FROM admins WHERE username = '" + ad.name + "' AND password = '" + ad.pass + "'";
                    connect = ConnectionHandle.getConnection();
                    connect.Open();
                    command = new MySqlCommand(slt, connect);
                    command.ExecuteNonQuery();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string username = reader.GetString(0);
                        string password = reader.GetString(1);
                        int status = reader.GetInt32(2);

                        if (status != 1)
                        {
                            Console.WriteLine("Tài khoản không có quyền admin");
                        }
                        else if (username != ad.name || password != ad.pass)
                        {
                            Console.WriteLine("Đăng nhập thất bại");
                        }
                        else
                        {
                            Console.WriteLine("Đăng nhập thành công");
                            Console.ReadKey();
                            Console.WriteLine("NameUser = {0} , Password = {1}, Status = {2}", username, password, status);
                        }
                    }
                    connect.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
