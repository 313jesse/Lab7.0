using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7._0
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Name between 1,30 characters, First letter capital. 
            //(^[A-Z][^A-Z]{1,30}$)

            //2. Email validation
            //\w{5,30}@\w{5,10}.\w{2,3}$

            //3. Phone numbers
            //^\d{3}-\d{3}-\d{4}$

            //4. Date format dd/mm/yyyy
            //\d{ 0,3}\d{ 0,9}\/\d{ 2}\/\d{ 4}$

            // write a program that validates zip codes 
            Console.WriteLine("Please enter a valid zip code");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, @"^\d{5}$"))
            {
                Console.WriteLine("You entered a valid zip code!");
            }
            //else
            //{
            //    Console.WriteLine("Nice try! next time please do it right!");
            //}

            while (!Regex.IsMatch(input, @"^\d{5}$"))
            {
                Console.WriteLine("Nice try! next time please do it right!");
                input = Console.ReadLine();

            }

            //Console.WriteLine("You entered a valid zip code!");


        }
    }
}
        
    

