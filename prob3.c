//Largest prime factor
//https://projecteuler.net/problem=3

//Problem description:
//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <math.h>

const long NUM = 600851475143;
int n = 3;
bool pFlag = true; 
int lpF = 3;   

int main() {

	int sqrtNUM = (int)sqrt(NUM);
	
	while(n < (sqrtNUM)) {

		int i = 3;
		while(i < (n/2) && pFlag == true) {

			i += 2;

			///If this is true, then n is not a prime number.
			if(n % i == 0) {                 
			        pFlag = false;
			}
		}
   
		///If this is true, then n is a factor of NUM and n is prime.   
  		if (pFlag == true && NUM % n == 0) {  
   
	                lpF = n;
			printf("prime factor: %i \n", lpF);
			}

			n = n + 2;
			pFlag = true;
	}  
	printf("lpf is: %i", lpF);
	//Answer: 6857
}
