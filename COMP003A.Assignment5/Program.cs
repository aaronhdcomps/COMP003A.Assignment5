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
            //
            PrintSeparator("Triangle");
            Console.Write("Enter a single character: ");
            char inputChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a positive whole number: ");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            IsoscelesTriangleBuilder(inputChar, inputInt);
            //

            //
            PrintSeparator("Favorite Characters");
            CharacterInfo("Batman", 1939);
            CharacterInfo("Kermit the Frog", 1955);
            CharacterInfo("Solid Snake", 1972);
            CharacterInfo("Wolverine", 1974);
            CharacterInfo("Shrek", 1990);
            //

            //

        }// Main() close
        
        /// <summary>
        /// Prints character padding to seperate sections
        /// </summary>
        static void PrintSeparator() 
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// Prints section name
        /// </summary>
        /// <param name="name">Name of Section</param>
        static void PrintSeparator(string name)
        {
            PrintSeparator();
            Console.WriteLine($"\t{name} Section");
            PrintSeparator();
        }

        /// <summary>
        /// Builds isosceles triangle based on user input
        /// </summary>
        /// <param name="inputCharacter">Character Input</param>
        /// <param name="size">Size of triangle input</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            //string output = Convert.ToString(inputCharacter); <------------------do not need to convert char to string due to casting type.
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"".PadRight(i, inputCharacter));
            //  output += Convert.ToString(inputCharacter);  <---------------------do not need conversion or concantination                          
            }

            //for (int i = 0; i <= size; i++)   <----------------------------------do not need to use
            for (int i = size; i > 0; i--)
            {
                Console.WriteLine($"".PadRight(i, inputCharacter));
            //  Console.WriteLine(output.Substring(i));  <-------------------------no longer needed since using padding
            }
                 
        }
        /// <summary>
        /// Calculates age based on current year
        /// </summary>
        /// <param name="year">Year born input</param>
        static int AgeCalculator(int year)
        {
            int age = DateTime.Now.Year - year;
            return age;
        }

        /// <summary>
        /// Prints characters name and age.
        /// </summary>
        /// <param name="characterName">Character name input</param>
        /// <param name="birthYear">Birth year input</param>
        static void CharacterInfo(string characterName, int birthYear)
        {
            int characterAge = AgeCalculator(birthYear);
            Console.WriteLine($"{characterName} turns {characterAge} this year!");
        }
    }
}