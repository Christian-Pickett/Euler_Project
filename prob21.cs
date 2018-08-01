/*Amicable Numbers
https://projecteuler.net/problem=21

Problem Description:
Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
Evaluate the sum of all the amicable numbers under 10000.*/

using System;
using System.Collections.Generic;

static class Module1
{
    private static int finalSum = 0;
    private static SortedList<int, int> propDivisorSumList = new SortedList<int, int>();
    private static List<int> amicableNumberList = new List<int>();

    public static int GetDivisorsSum(int i)
    {
        int Sum = 0;

        for (int n = 1; n <= i / 2; n++)
        {
            if (i % n == 0)
                Sum += n;
        }
        return Sum;
    }

    public static void Main()
    {
        for (int i = 1; i <= 10000; i++)
            propDivisorSumList.Add(i, GetDivisorsSum(i));

        foreach (var Item in propDivisorSumList)
        {
            if (GetDivisorsSum(Item.Value) == Item.Key)
            {
                if (Item.Value != Item.Key)
                {
                    if ((!amicableNumberList.Contains(Item.Value)))
                        amicableNumberList.Add(Item.Value);

                    if ((!amicableNumberList.Contains(Item.Key)))
                        amicableNumberList.Add(Item.Key);
                }
            }
        }

        foreach (int Item in amicableNumberList)
            finalSum += Item;

        Console.Write(finalSum + "\n");
	//Answer: 31626
    }
}

