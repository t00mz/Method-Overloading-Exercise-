using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 2;
            var b = 5;
            var answer1 = Add(a, b);

            var c = 3.1m;
            var d = 2.7m;
            var answer2 = Add(c, d);

            var answer3 = Add(0, 0, true);

            Console.WriteLine($"first answer = {answer1}, second answer = {answer2}, third answer = {answer3}");
        }

        //Create a method named Add, that accepts two integers and returns the sum of those two integers

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //Now create an overload of the Add method to account for being able to add two decimals together

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean

        public static string Add(int num1, int num2, bool a)
        {

            var sum = num1 + num2;

            if(a == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(a == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(a == true && sum <1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
  
        //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” 
        //at the end of the string.
        //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
    }

}
