/*Sum square difference
https://projecteuler.net/problem=6

Problem Description:
The sum of the squares of the first ten natural numbers is,
12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.*/

#include<stdio.h>

int square(int x) {
    return (x * x);
}

int sumS = 0;
int squareS = 0;

int main() {

    for(int i = 1; i <= 100; i++)
        sumS = square(i) + sumS;
    
    for(int a = 1; a <= 100; a++)
        squareS = a + squareS;
        
    squareS = square(squareS);
    
    printf("sum of squares: %i\n", sumS);
    printf("square of sums: %i\n", squareS);
    
    printf("difference: %i\n", (squareS - sumS));
    //Answer: 25164150
}

