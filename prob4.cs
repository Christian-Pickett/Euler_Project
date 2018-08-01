/*Largest palindrome product
https://projecteuler.net/problem=4

Problem description:
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.*/

using System;

static class Program
{
    private static bool exitFlag = false;

    public static string Reverse( string s ) {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
    }

    public static void Main()
    {
        for (int i = 998001; i >= 9801; i += -1)
        {
            if (Reverse(System.Convert.ToString(i)) == System.Convert.ToString(i) & exitFlag == false)
            {
                for (int j = 100; j <= 999; j++)
                {
                    if ((i % j) == 0 & exitFlag == false)
                    {
                        for (int k = 100; k <= 999; k++)
                        {
                            if ((j * k) == i & exitFlag == false)
                            {
                                Console.Write("Largest palindromic number of 2 3-digit factors: " + System.Convert.ToString(i) + "\n" + "Factors: " + System.Convert.ToString(j) + " * " + System.Convert.ToString(k) + "\n");
                                exitFlag = true;
				//Answer: 906609
                            }
                        }
                    }
                }
            }
        }
    }
}
