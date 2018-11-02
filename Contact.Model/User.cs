using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Model
{
    public sealed class User
    {
        //Id UserName    Password Name    Email Mobile  Mobile1 Address Birthday

        public static int Id { get; set; }
        public static string UserName { get; set; }
        public static string Name { get; set; }
        public static string Email { get; set; }
        public static string Mobile { get; set; }
        public static string Mobile1 { get; set; }
        public static string Address { get; set; }
        public static DateTime Birthday { get; set; }

        private static readonly object locker = new object();
        private static User instance = null;

        public static User Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(locker)
                    {
                        if(instance == null)
                        {
                            instance = new User();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
