using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("what is your name?");
            System.Console.ReadKey();
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Welcome, " + name);
            string nameUpper = name.ToUpper();
            System.Console.WriteLine(name + " is... GRAND!");

            ////foreach (char letter in name.ToLower())
            //{
            //    string article = "a";
            //    if ("halfnorsemix")

            ////}

            

        }
    }
}
