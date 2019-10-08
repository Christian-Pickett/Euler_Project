/*Longest Collatz sequence
https://projecteuler.net/problem=14

Problem description:
The following iterative sequence is defined for the set of positive integers:
n → n/2 (n is even)
n → 3n + 1 (n is odd)
Using the rule above and starting with 13, we generate the following sequence:
13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
Which starting number, under one million, produces the longest chain?
NOTE: Once the chain starts the terms are allowed to go above one million.*/

using System;

static class Program
{
    public static void Main()
    {
        int chainSize;
        double seq = 0;
        int largestCollatzSeq = 0;
        int largestCurrentChain = 0;

        for (int i = 1000000; i >= 1; i += -1)
        {
            chainSize = 0;
            seq = i;

            while (seq != 1)
            {
                if ((seq % 2) == 0)
                    seq = seq / 2;
                else
                    seq = (3 * seq) + 1;

                chainSize += 1;
            }

            if (chainSize > largestCurrentChain)
            {
                largestCurrentChain = chainSize;
                largestCollatzSeq = i;
            }
        }
	Console.Write(largestCollatzSeq + "\n");
	//Answer: 837799
    }
}

