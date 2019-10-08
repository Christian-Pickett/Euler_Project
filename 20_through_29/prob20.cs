/*Factorial digit sum
https://projecteuler.net/problem=20

Problem Description:
n! means n × (n − 1) × ... × 3 × 2 × 1
For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
Find the sum of the digits in the number 100!
NOTE: This program must be compiled with the following option when using mono: -reference:/usr/lib/mono/4.5/System.Numerics.dll*/ 


using System;
using System.Numerics;

static class Program 
{
    private static int Sum;
    private static string theBigNum;
    private static char[] numCharArray;

    public static BigInteger fac(int i)
    {
        if (i == 0 | i == 1)
            return 1;
        else
            return i * fac(i - 1);
    }

    public static void Main()
    {
        theBigNum = fac(100).ToString();
	numCharArray = theBigNum.ToCharArray();

        foreach (var numChar in numCharArray)
		Sum += (int)(numChar - '0');

        Console.Write(Sum + "\n");
	//Answer: 648 
    }
}

