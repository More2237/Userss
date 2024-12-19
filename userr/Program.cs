using System;

namespace userr
{
    class Users

    { 
        private string username = "noor";
        public int age = 23;
        string gender="male";
        public string address = "bokhtar";
        protected double phone = 0877777777;

        public void setUsername()
        {
            Console.WriteLine("username: "+ username);
        }

        private void age1()
        {
            Console.WriteLine("age: "+age);
        }

        public void setgender()
        {
            Console.WriteLine("gender: "+ gender);
        }

        public void setphone()
        {
            Console.WriteLine("phone: "+phone);
        }

        private void setaddress()
        {
            Console.WriteLine("address: "+address);
        }

        public void all()
        {
            age1();
            setaddress();
        }

        



    }

    class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users();
            users.setUsername();
            users.setgender();
            users.setphone();
            users.all();
        }
        
        
        
    }
}