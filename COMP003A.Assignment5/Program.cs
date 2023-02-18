/*
 * Author: Aaron Abramson
 * Course: COMP-003A
 * Purpose: Week 5 Assignment
*/

using System.Collections.Generic;
using System.Drawing;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator();
            PrintSeparator("Triangle");
            PrintSeparator();
            Console.WriteLine("\n");
            Console.Write("Enter a single character: ");
            char inputChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a positive whole number: ");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            IsoscelesTriangleBuilder(inputChar, inputInt);


            PrintSeparator();
            PrintSeparator("Favorite Characters");
            PrintSeparator();
        }// Main() close
        
        /// <summary>
        /// 
        /// </summary>
        static void PrintSeparator() 
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        static void PrintSeparator(string name)
        {
            Console.WriteLine($"\t{name} Section"); 
        }

        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            string output = Convert.ToString(inputCharacter);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(output);
                output += Convert.ToString(inputCharacter);                           
            }
            
            for (int i = size-1; i > 0; i--)
            {
                output output.Substring(i, 1);
            }
            
        }
    }
}