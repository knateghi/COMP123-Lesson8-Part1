using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson8_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age,theNumber;
            double result;

            try
            {
                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You said your age is {age}");
                result= DivideAge(age);
                Console.WriteLine($"The result is {result} ");

            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("incorrect input=====> " + error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine();
                Console.WriteLine("wrong input======> " + error.Message);
            }
            Console.WriteLine("finalltltt");
            Console.ReadKey();
        }

        private static int DivideAge(int age)
        {
            int theNumber;
            Console.Write("Enter a number to divide your age by: ");
            theNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the number you entered is {theNumber} ");
            
           
            return (age / theNumber);
        }
    }
}
