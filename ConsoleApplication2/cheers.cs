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
            System.Console.WriteLine("What is your name?");
            System.Console.ReadKey();
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Welcome, " + name);
            string upperName = name.ToUpper();
            

            foreach (char letter in name.ToLower())
            {
                string article = "a";
                if ("halfnorsemix".IndexOf(letter) >= 0)
                {
                    article = "an";
                }
                System.Console.WriteLine("Give me " + article + ".. " + letter);
            }

            System.Console.WriteLine(upperName + " is.. GRAND!");
            System.Console.WriteLine("When is your birthday?(ex: 8 12");
            System.Console.ReadKey();
            int birthday = System.Console.ReadLine();
            System.Console.WriteLine("Your birthday is " + birthday)


            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
