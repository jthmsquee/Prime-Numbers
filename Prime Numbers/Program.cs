using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a Number");

            try
            {
                int numberEntered = Convert.ToInt32(Console.ReadLine());
                List<int> primeNumbers = new List<int>();
                for (int i = numberEntered - 1; i > 1; i--)
                {
                    if (isItPrime(i) == true)
                    {
                        primeNumbers.Add(i);
                    }
                }
                string myList = String.Join(",", primeNumbers);
                Console.WriteLine(myList);
            }
            catch
            {
                Console.WriteLine("Exception Caught");
            }
            Console.ReadLine();
        }
        private static bool isItPrime(int aNumber)
        {
            int largestDivisableNumber = aNumber / 2;
            for (int i = 2; i <= largestDivisableNumber; i++)
            {
                if (aNumber % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
