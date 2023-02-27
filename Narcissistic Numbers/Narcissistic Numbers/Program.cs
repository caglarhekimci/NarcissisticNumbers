using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissistic_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool _isNarcissistic = isNarcissistic(153);
            Console.WriteLine($"is your number Narcissistic? : {_isNarcissistic}");
            Console.ReadKey();
        }

        public static bool isNarcissistic(int value)
        {
            double isNarcissistic = FindResult(value);

            if (value == ((int)isNarcissistic)) return true;
            else return false;
        }

        public static double FindResult(int value)
        {
            var numbers = new List<int>();
            int basamak = 1;
            decimal decTemp = value;
            int tempValue2 = value;

            double sum = 0;

            while (tempValue2 >= 10) // 153
            {
                decTemp = decTemp / 10; //dec 15,3 USING MOD BETTER
                decTemp = Math.Floor(decTemp); //dec 15
                int myNumber = (tempValue2 - (((int)decTemp) * 10)); //153-150
                numbers.Add(myNumber); // 3 last number
                tempValue2 = ((int)decTemp);//int 153
                basamak++; // 2
            }
            numbers.Add(tempValue2);

            foreach (var item in numbers)
            {
                sum = sum + Math.Pow(item, basamak);
            }
            Console.WriteLine(value + " - " + sum);
            return sum;
        }
    }
}
