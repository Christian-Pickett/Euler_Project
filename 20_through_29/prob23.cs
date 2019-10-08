/*Non-abundant sums - Problem 23
https://projecteuler.net/problem=23

Problem Description:
A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For 'example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a 'perfect number.
A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if 'this sum exceeds n.
As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the 'sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than '28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any 'further by analysis even though it is known that the greatest number that cannot be expressed as the sum of 'two abundant numbers is less than this limit.
Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.*/

using System;
using System.Collections.Generic;

class Program {
    public static void Main() {
	    int sum;
	    const int LIMIT = 20161;   
        List<int> abundants = new List<int>();
	    bool[] isSumOfTwoAbundants = new bool[LIMIT + 1];
        
 	for (int i = 0; i <= LIMIT; i++) {
            
            sum = 0;
            for (int j = 1; j <= (i / 2); j++) {

                if (i % j == 0)
                    sum += j;
            }
	        
            if (sum > i) 
		        abundants.Add(i); 
    }

        for (int i = 0; i < abundants.Count; i++)
        {
            for (int j = 0; j < abundants.Count; i++) 
            {
                //mark the sum of every abundant that could be added to the current one.
                if (!((abundants[i] + abundants[j]) > LIMIT))   
                    isSumOfTwoAbundants[abundants[i] + abundants[j]] = true;
                
                //any abundants after the first which is over the limit will also be greater than the limit, so break.
                else 
                    break;
            }
        }

        sum = 0;

        for (int i = 1; i <= LIMIT; i++)
        {
            if (!isSumOfTwoAbundants[i])
                sum += i;
        }
        Console.Write(sum + "\n");
    }
}

