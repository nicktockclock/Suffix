using System;

namespace Suffix
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number. To exit enter q.");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                    try
                    {
                        Console.WriteLine("suffixWithUnit("+input+") => " + suffixWithUnit(Convert.ToDouble(input)));
                    }
                    catch
                    {
                        Console.WriteLine("I don't think that was a number.");
                    }
                }
            }
            Console.WriteLine("Bye");
        }

        static string suffixWithUnit(double number)
        {
            //This is done to ensure the calculation still works when there is a decimal point
            int length = Convert.ToInt64(number).ToString().Length;
            switch (length)
            {
                case var n when n > 3 && n < 7:
                    return (number / 1000).ToString() + " Kilo";
                case var n when n > 6 && n < 10:
                    return (number / 1000000).ToString() + " Mega";
                case var n when n > 9 && n < 13:
                    return (number / 1000000000).ToString() + " Giga";
                case var n when n > 12 && n < 16:
                    return (number / 1000000000000).ToString() + " Tera";
                default:
                    return number.ToString();
            }
        }
    }
}
