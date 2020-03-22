using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        public static string SayHello(string name)
        {
            name = "John";
            return "Hello " + name + "!";
        }

        public static int Sum(int i1, int i2)
        {
            i1 = 10;
            i2 = 12;
            return i1 + i2;
        }

        public static decimal Divide(decimal d1, decimal d2)
        {
            d1 = 10;
            d2 = 5;
            return d1 / d2;
        }
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age >= 18)
                return true;
            else 
                return false;
        }
        
        public static string GetFirstName(string fullName)
        {
            var names = fullName.Split(' ');
            string firstName = names[0];
            return firstName;
        }

        public static string ReverseStringHard(string quote)
        {
            char[] arr = quote.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string ReverseStringEasy(string quote)
        {
            char[] arr = quote.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string PrintTimesTable(int number)
        {
            string table = "";
            for (int i = 1; i < 10; i++)
            {
                int total = number * i;
                table += $"{number} * {i} = {total}\r\n";
            }
            table += $"{number} * 10 = {number * 10}";
            return table;
        }

        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            double a = kelvin - 273.15;
            double b = a * 1.8;
            double c = b + 32;
            double fahrenheit = Math.Round(c, 2);
            return fahrenheit;
        }

        public static double GetAverageHard(int[] value)
        {
            double total = 0;
            int x = value.Length;
            for (int i = 0; i < x; i++)
            {
                total += value[i];
            }
            return total / x;
        }

        public static double GetAverageEasy(int[] value)
        {
            double total = 0;
            foreach (int number in value)
            {
                total += number;
            }
            return total / value.Length;
        }

        public static string DrawTriangle(int number, int width)
        {
            string triangle = "";
            int y = width;
            for (int i = 0; i < width - 1; i++)
            {
                string line = "";
                for (int x = 0; x < y; x++)
                {
                    line += number;
                }
                triangle += $"{line}\r\n";
                y--;
            }
            triangle += number;
            return triangle;
        }

        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {
            double time = hours + (minutes/60d) + ((seconds/60d)/60d);
            double mph = Math.Round(distance/time);
            return $"{mph}MPH";
        }

        public static bool IsVowel (char hello)
        {
            if (hello == 'a' || hello == 'e' || hello == 'i' || hello == 'o' || hello == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsConsonant(char goodbye)
        {
            if (goodbye == 'a' || goodbye == 'e' || goodbye == 'i' || goodbye == 'o' || goodbye == 'u')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int CollatzConjecture(int number)
        {
            int steps = 0;
            int temporary = 0;
            int final(int number)
            {  
                steps++;
                if (number == 1)
                {
                    return steps;
                }
                if (number % 2 != 0)
                {
                    temporary = (number * 3) + 1;
                    final(temporary);
                }
                if (number % 2 == 0)
                {
                    temporary = number / 2;
                    final(temporary);
                }
                return steps - 1;
            }
            return final(number);
        }

        public static DateTime[] GetNext7Days(DateTime example)
        {
            int day = example.Day;
            int two = day + 1;
            int three = two + 1;
            int four = three + 1;
            int five = four + 1;
            int six = five + 1;
            int seven = six + 1;
            DateTime[] list = { new DateTime(2016, 8, day), new DateTime(2016, 8, two), new DateTime(2016, 8, three), new DateTime(2016, 8, four), new DateTime(2016, 8, five), new DateTime(2016, 8, six), new DateTime(2016, 8, seven) };
            return list;
        }

        public static bool IsInLeapYear(int date)
        {
            int year = date;
            bool leap = false;
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                leap = true;
            else
                leap = false;
            return leap;
        }

        public static double MortgageCalculator(double balance, double rate, int termYears, int paymentPeriod)
        {
            int months = termYears * 12;
            System.Console.WriteLine(months);
            double r = rate / 1200;
            System.Console.WriteLine(r);
            double top = r * Math.Pow((1 + r), months);
            System.Console.WriteLine(top);
            double bottom = Math.Pow((1 + r), months) - 1;
            System.Console.WriteLine(bottom);
            double payment = (balance * (top / bottom));
            System.Console.WriteLine(payment);
            string str = payment.ToString("0.00");
            System.Console.WriteLine(str);
            double pay = Convert.ToDouble(str);
            System.Console.WriteLine(pay);
            return pay;
        }

        public static string DuckGoose(int number)
        {
            string duckDuckGoose = "";
            for (int i = 1; i < number + 1; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    duckDuckGoose += "DuckGoose";
                }
                else if (i % 5 == 0)
                {
                    duckDuckGoose += "Goose";
                }
                else if (i % 3 == 0)
                {
                    duckDuckGoose += "Duck";
                }
                else
                {
                    duckDuckGoose += $"{i}";
                }
                if (i != number)
                {
                    duckDuckGoose += $"\r\n";
                }
            }
            return duckDuckGoose;
        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
    }
}