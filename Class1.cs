using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public List<string> Values { get; set; }

        public Class1()
        {
            Values = new List<string>();
            Username = string.Empty;
            Email = "test";
        }
        public string GetEmail()
        {
            Console.WriteLine(Email);
            return Email;
        }
        public string GetUsername()
        {
            Console.WriteLine(Username);
            return Username;
        }
        public void SetUsername(string name)
        {
            Username = name;
            
        }
        public void AddValue(string str)
        {
            Values.Add(str);
        }
        public void PrintVals()
        {
            foreach(var val in Values)
            {
                Console.WriteLine(val);
            }
        }
    }
}
