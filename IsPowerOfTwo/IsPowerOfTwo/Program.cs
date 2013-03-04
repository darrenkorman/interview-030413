using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsPowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int power = 1; power < 10; power++)
            {
                for (int number = -1; number <= 30; number++)
                {
                    Console.WriteLine(number + " is power of " + power + "? " + isPowerOf(number, power));
                }                
            }

            for (int number = -1; number <= 32; number++)
            {
                Console.WriteLine(number + " is power of two? " + isPowerOfTwo(number));
            }
        }

        public static bool isPowerOf(int number, int powerOf)
        {
            if (number < 1 || powerOf < 2)
            {
                // only allow positive numbers and bases of 2 or greater.
                return false;
            }

            if (number % powerOf == 0) 
            {
                // number is divisible by base. make recursive call.
                return isPowerOf(number / powerOf, powerOf);
            }
            else
            {
                // number is odd. if == to 1, this was a power of the base.
                if(number == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool isPowerOfTwo(int number)
        {
            if (number < 1)
            {
                // make sure number is positive.
                return false;
            }

            if(number % 2 == 0) 
            {
                // number is even. make recursive call.
                return isPowerOfTwo(number/2);
            }
            else
            {
                // number is odd. if == to 1, this was a power of two.
                if(number == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
