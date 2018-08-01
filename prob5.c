//Smallest multiple
//https://projecteuler.net/problem=5

//Problem description:
//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


#include <stdio.h>

int main() {

	int n = 2500;
	int flag = 0;

	while(flag != 20) {

		n = n + 20;
		flag = 0;
	
		for(int i = 1; i <= 20; i++) {
			if(n % i == 0)
				flag++;
		}
	}

	printf("%i\n", n);
	//Answer: 232792560 (after a few minutes...)
}
