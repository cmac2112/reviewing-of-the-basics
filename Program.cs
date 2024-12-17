// See https://aka.ms/new-console-template for more information
using System;
using System.Windows.Markup;

namespace ConsoleApp1
{
    class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Class1 user = new Class1();
            user.AddValue("some val");
            user.AddValue("another val");

            user.PrintVals();
            
        }
    }
}