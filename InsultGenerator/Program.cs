using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for your name
            string name = GetName();

            // Generate a random insult
            GenerateInsult(name);
        }
        private static string GetName()
        {
            Console.WriteLine("Welcome to your Insult Generator. What is your name ?");
            return Console.ReadLine();
        }
        private static void GenerateInsult(string name)
        {
            Console.WriteLine(name + ", you are " + GetAdjective() + GetCompoundAdjective() + GetObject());
            menu(name);
        }
        private static void menu(string name)
        {

        }
        private static string GetAdjective()
        {
            string[] Adjectives = { "small nut", "a smelly cunt", "nigga-faggot", "tiny penis", "jigantic pussy", "four-eyes looking mothafcker" };
        }
        private static string GetCompoundAdjective()
        {
            string[] CompoundAdjectives = { "trump-loving", "cum slurpin", "slut shaming", "woman bashing", "transgender-loving" };
        }
        private static void GetObject()
        {
            string[] Objects = { "thot", "rat", "fuckwit", "asian", "CHINAMAN"};
        }

    }
}       
