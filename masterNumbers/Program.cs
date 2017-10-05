using System;

namespace masterNumbers
{
    class Program
    {
        static bool SumOfDigits(int num)
        {
            bool isDivisible = false;
            int testNum = num;
            int sum = 0;
            while (testNum > 0)
            {
                int lastDigit = testNum % 10;
                testNum = testNum / 10;
                sum += lastDigit;
            }
            if (sum % 7 == 0)
            {
                isDivisible = true;
            }
            return isDivisible;
        }
        static bool IsPalindrome(int num)
        {
            bool isSymmetric = false;
            char[] testNum =num.ToString().ToCharArray();
            for (int i = 0; i < testNum.Length - 1; i++)
            {
                if (testNum[i] == testNum[testNum.Length - i - 1])
                {
                    isSymmetric = true;
                }
                else
                {
                    return false;
                    
                }
            }
            return isSymmetric;
        }
        static bool EvenDigit(int num)
        {
            
            bool result = false;
            while (num > 0)
            {
                int lastDigit = num % 10;
                num = num / 10;
                if (lastDigit % 2 == 0)
                {
                    result = true;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (SumOfDigits(i) && IsPalindrome(i) && EvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
