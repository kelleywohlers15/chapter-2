using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;
            string wordEst;
            string bodyPartPlural;
            string anAnimal;
            string noun;
            string pluralNoun;
            int a; 
            int b;
            int c;
            Console.WriteLine("What is your favorite color>>>");
            color = Console.ReadLine();

            Console.WriteLine("Enter a word ending in EST >>>");
            wordEst = Console.ReadLine();

            Console.WriteLine("Enter a body part plural >>>");
            bodyPartPlural = Console.ReadLine();

            Console.WriteLine("Enter an animal >>>");
            anAnimal = Console.ReadLine();

            Console.WriteLine("Enter a noun >>>");
            noun = Console.ReadLine();

            Console.WriteLine("Enter a plural noun >>>");
            pluralNoun= Console.ReadLine();

            Console.WriteLine("Enter a number >>>");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number but smaller than the first >>>");
            b = Convert.ToInt32(Console.ReadLine());




            c = a - b;

            Console.WriteLine($"The {color} Dragon is the," +
                $"{wordEst} Dragon of all. It has {c} {bodyPartPlural}, and a {anAnimal}" +
                $"shaped like a {noun}. It loves to eat {pluralNoun}, " +
                " although it will feast on nearly anything.");

         



        }
    }
}
