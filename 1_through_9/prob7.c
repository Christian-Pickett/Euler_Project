//10001st prime
//https://projecteuler.net/problem=7

//Problem description:
//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//What is the 10001st prime number?

#include <stdio.h>
#include <stdbool.h>

int main() {

	int i = 5;
	int p = 2;
	bool flag = false;

	while(p != 10001) {
		flag = false;
		for(int n = 3; n < i/2; n++) {
			
			if(i % n == 0){

				i = i + 2;
				flag = true;
			}
		}
			if(flag == false) {

				p++;

				if(p == 10001) {
				printf("answer: %i\n", i);
				//Answer: 104743
				}

				i = i + 2;
			}
		}
}

