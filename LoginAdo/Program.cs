using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LoginAdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserDataDBEntities()) 
            { 
                Console.WriteLine("Enter username:");
                var name = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                var pass = Console.ReadLine();

                var acc = new User { Username = name, Password = pass , UserId = 4341341};

                db.Users.Add(acc);
                db.SaveChanges();

                var query = from b in db.Users
                            orderby b.Username
                            select b;

                Console.WriteLine("All users in the database:");
                foreach (var item in query) 
                {
                    Console.WriteLine(item.Username);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
