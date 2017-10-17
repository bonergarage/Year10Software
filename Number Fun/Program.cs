using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Fun
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("Please Enter Number 1");
           float Num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number 2");
            float Num2 = float.Parse(Console.ReadLine());


            //output
            //addition
            Console.WriteLine("Number 1 plus Number 2 =" + (Num1 + Num2));
            //subtraction
            Console.WriteLine("Number 1 minus Number 2 =" + (Num1 - Num2));
            //multiplication
            Console.WriteLine("Number 1 times Number 2 =" + (Num1 * Num2));
            //divison
            Console.WriteLine("Number 1 divided by Number 2 =" + (Num1 / Num2));
            

            //wait
            Console.ReadKey();
        }
    }
}

