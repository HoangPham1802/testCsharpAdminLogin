using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoCsharpException
{
    public class Admin
    {
        public string name;
        public string pass;

        public void MenuConsole()
        {
            Console.WriteLine("Please enter your account: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            pass = Console.ReadLine();
        }
    }
}
