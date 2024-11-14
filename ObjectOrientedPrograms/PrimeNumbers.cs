using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    internal class PrimeNumbers
    {
        //Sum of prime number in array
        
        public static bool isPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            for(int i=2; i<number;i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        
        //static void Main(string[] args)
        //{
        //    int[] number = { 22, 13, 26, 45, 97, 96 ,2,11,17};
        //    int sum = 0;
            
        //    for(int i=0; i <number.Length; i++)
        //    {
        //        if (isPrime(number[i]))
        //        {
        //            Console.WriteLine("Prime numbers: " + number[i]);
        //            sum = sum + number[i];
        //        }
        //    }

        //    Console.WriteLine("Sum of Prime numbers: " + sum);
        //}
    }
}
