using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 Output
            Console.WriteLine(Reversal("my heart will go on"));

            // Problem 2 Output
            Console.WriteLine(Problem2("tony", "april"));

            // Problem 3 Output

            string capitalize = YourName("tony", "winters"); //create variable to hold input name
            // add globalization namespace
            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(capitalize); //create variable and apply Title Casing to input name
            Console.WriteLine(titleCase);            

            // Problem 4 Output
            Console.WriteLine(RemoveZero("Is there a zero?"));
        }

        // Problem 1 Input
        // Write a method that has one string parameter
        // The method should take in a phrase and print to the console the phrase reversed.                                   

        static string Reversal(string input)
        {
            string[] output = input.Split();
            Array.Reverse(output);
            string inputReverse = String.Join(" ", output);
            return inputReverse;
        }

        // Problem 2 Input
        // Write a method that has two string parameters.
        // The first parameter should be for the user's name.
        // The second parameter should be for the user's birth month.
        // The method should print to the console: [name] is a/an [birth month] baby! 

        static string Problem2(string name, string month)
        {
            if (name.Length > 1) //uppercase first letter of name
            {
                name = char.ToUpper(name[0]) + name.Substring(1);
            }
            else
            {
                name.ToUpper();
            }

            if (month.Length > 1) //uppercase first letter of month
            {
                month = char.ToUpper(month[0]) + month.Substring(1);
            }
            else
            {
                month.ToUpper();
            }

            string sentence;
            if (month == "January" || month == "February" || month == "March" || month == "May" || month == "June" || month == "July" || month == "September" || month == "November" || month == "December")
            {
                sentence = (name + " is a " + month + " baby!");
                return sentence;
            }

            else
            {
                sentence = (name + " is an " + month + " baby!");
                return sentence;
            }

        }

        // Problem 3 Input
        // Write a Method with 2 parameters (first name, last name)
        // Assume when the method is called, both first and last names are completely lower case.
        // Your method should return the full name of the user with the first letter of each name being capitalized to a variable in Main.
        // Using the variable in main, print the full name to the console.

        static string YourName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }


        // Problem 4 Input
        // Write a method that finds and removes the randomly placed 0 in the string
        // The method has 1 string parameter for the string that will be searched.
        // If there is no 0 in the string, the method should print to the console: "This string is okay!"

        static string RemoveZero(string sentence)
        {
            if (sentence.Contains("0") == true)
            {
                string byeByeZero = sentence.Replace("0", "");
                return byeByeZero;
            }
            else
            {
                string byeByeZero = "This string is okay!";
                return byeByeZero;
            }
        }
    }
}
