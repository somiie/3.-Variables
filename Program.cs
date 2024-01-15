using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variable
            string name;
            int age;

            //initialize variables
            name = "John";
            age = 10;

            Console.WriteLine("Hi "+name);
            Console.WriteLine("You are "+ age + " years of age.");
            Console.WriteLine("Next year you will be " + (age + 1));

            age = 10+10;

            Console.WriteLine("In ten years time you will be " + age);


            //Declare and initialise same time!

            string lastName = "Thomas";

            Console.WriteLine("Your last name is " + lastName);

            //freeze console
            Console.ReadLine();
        }
    }
}
