﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            string name = "Ricky Bobbie", realName;
            bool again = true;
            string answer;

            Console.WriteLine("Hello!  What is your name?");
            realName = Console.ReadLine();
            Console.WriteLine("Hi " + realName + ", I'm going to call you " + name + " anyway...");
            Console.WriteLine();
            while (again)
            {
                Console.WriteLine(name + ", please enter an integer between 1-100.");
                input = int.Parse(Console.ReadLine());

                    if (input < 1 || input > 100)
                    {
                        Console.WriteLine("Sorry, {0}, but that number is out of range.  Please enter a different number between 1-100.", name);
                        input = int.Parse(Console.ReadLine());
                    }
                    else if ((input % 2) != 0)
                    {
                        Console.WriteLine(name + ", your input of " + input + " is an odd number.");
                    }
                    else if (input >= 2 && input < 25)
                    {
                        Console.WriteLine(name + ", your input is even and less than 25.");
                    }
                    else if (input >= 26 && input <= 60)
                    {
                        Console.WriteLine(name + ", your input of is even.");
                    }
                    else
                    {
                        Console.WriteLine(name + ", your input of " + input + " is even.");
                    }
                         
                Console.WriteLine(name + ", would you like to check another number? (Y/N)");
                answer = Console.ReadLine();
                if (answer!="y" && answer!="Y")
                {
                    again = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
