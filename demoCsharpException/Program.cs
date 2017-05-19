using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoCsharpException
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminModel admin = new AdminModel();
            admin.Show();
            Console.ReadKey();
        }
    }
}
