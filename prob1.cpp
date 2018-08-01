//Multiples of 3 and 5
//https://projecteuler.net/problem=1

//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
// find the sum of all the multiples below 1000.

#include <iostream>

using namespace std;

int sumMults() {

	int sum = 0;

		for (int i = 0; i < 1000; i++) {

		//	sum = (i % 3 == 0 || i % 5 == 0) ? (sum + i) : sum;
			if (i % 3 == 0) {
				sum = sum + i;
			} else if (i % 5 == 0) {
				sum = sum + i;
			}
		}	
	return sum;
	}	 

int main () {
	cout << sumMults() << endl;
	//Answer: 233168
}

