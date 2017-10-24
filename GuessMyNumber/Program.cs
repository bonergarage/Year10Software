﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 101);
            int count = 0;
            int guess = -1;

            while (guess != rand)
            {
                count++;
                Console.Write("Guess: ");
                guess = int.Parse(Console.ReadLine());
                if (guess < rand)
                {
                    Console.WriteLine("Too Low");
                }
                else if (guess > rand)
                {
                    Console.WriteLine("Too High");
                } 
                else
                {
                    Console.WriteLine($"You Got it, it took {count} tries!");
                    Console.ReadLine();
                }
                        
            }   

        }   
    }         


}           
