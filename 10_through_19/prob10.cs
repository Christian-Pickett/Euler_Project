//Summation of Primes
//https://projecteuler.net/problem=10

//Problem Description:
//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
		static void Main()
		{
			const int LIMIT = 2000000;
			Boolean[] primeList = new Boolean[LIMIT];
			int n = 0;
			long sum = 0;

			for (int i = 0; i < LIMIT; i++)
			{
				primeList[i] = true;
			}

			for (int i = 2; i < Math.Sqrt(LIMIT); i++)
			{
				if (primeList[i] == true)
				{
					n = 0;
					for (int j = (i * i); j < LIMIT; j = (i * i) + (n * i))
					{
						primeList[j] = false;
						n += 1;
					}
				}
			}

			for (int i = 2; i < LIMIT; i++)
			{
				if (primeList[i] == true)
				{
					sum += i;
				}
			}

			Console.Write(sum + "\n");
			//Answer: 142913828922
		}
}
 
