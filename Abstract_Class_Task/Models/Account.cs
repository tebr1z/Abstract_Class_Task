using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Task.Models
{
    using System;

    public class Account
    {
        public void Login(string username, string password)
        {
            if (username == "Admin" && password == "Admin")
            {
                Console.WriteLine("Girish Ugurlu oldu!.");
            }
            else
            {
                Console.WriteLine("Email ve ya password sehvdir.");
            }
        }
    }

}
