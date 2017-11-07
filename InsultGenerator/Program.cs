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

        }
        private static void GenerateInsult(string name)
        {
            Console.WriteLine(name + ", you are " + GetAdjective() + GetCompoundAdjective() + GetObject());
        }
    }
}       
