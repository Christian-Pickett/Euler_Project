/*https://projecteuler.net/problem=28
Number spiral diagonals
Problem 28

Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:

21 22 23 24 25
20  7  8  9 10
19  6  1  2 11
18  5  4  3 12
17 16 15 14 13

It can be verified that the sum of the numbers on the diagonals is 101.
What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?*/

using System;
using System.IO;
using System.Collections.Generic;

class program {
    public static void Main() {
        int num = 2;
        int sum = 0;
        int[,] matrix = new int[1001,1001];

        /*First we need to create the matrix in order to add the diagonals.The center most cell of 
        this matrix will be at index [500,500], so we will start there. In a 1001x1001 matrix, 
        to populate every cell of the matrix in a spiral fashion there will need to be a total of 500 spirals, 
        where i = 0 will be the iteration where the cell @ [500,500] will be populated as "1". 
        
        From there we will sequentially add sets of numbers whose size will equal to (n + 2(n-1) + (n-2)), 
        where n = (2i + 1). For example, with i = 1, we will add the sequential ordered set of size (3 + 2(3-1) + (3-2)) = 8, 
        i.e. {2,3,4,5,6,7,8,9}. This will surround the first cell in a clockwise fashion like so:

            7  8  9
            6  1  2
            5  4  3
        
        If we take [500,500] as our origin cell, we can know that each new sequence will start at cell
        [500+i,500+(1-i)]. Like so: [500,500] -> [501,499] -> [502,498], ... 
        All we have to do next is add the numbers from our current set in a clockwise fashion starting from the 
        cell defined at [500+i,500+(1-i)]. */

        matrix[500,500] = 1;

        for (int i = 1; i <= 500; i++) {

            //Since we know that n = (2i + 1) and the size of each spiral will be (n + 2(n-1) + (n-2)) = 4n - 4 = 4(2i + 1) - 4 = 8i
            //We can split each spiral into four directions which are each of size 2i.

            //first populate downwards from [500+i,500+(1-i)], for 2i iterations
            for (int j = 1; j <= 2*i; j++) {
                matrix[500+i, 500+(j-i)] = num;
                num++;  
            }
            //next populate leftwards  from [500+i,500+i], for 2i iterations
            for (int j = 1; j <= 2*i; j++) {
                matrix[500+(i-j),500+i] = num;
                num++;
            }   
            //next populate upwards from [500-i,500+i], for 2i iterations
            for (int j = 1; j <= 2*i; j++) {
                matrix[500-i,500+(i-j)] = num;
                num++;
            }
            //next populate rightwards from [500-i,500-i], for 2i iterations
            for (int j = 1; j <= 2*i; j++) {
                matrix[500+(j-i),500-i] = num;
                num++;
            }
        }
        
        //next we need to add up the diagonals.
        for(int i = 0; i <= 1000; i++) {
            sum += matrix[i,1000-i]; //bottom left to top right
            sum += matrix[1000-i,1000-i];//bottom right to top left
        }
            sum--; //subtract 1 because we hit the center twice 

        Console.Write(sum + "\n");
        //Answer: 669171001
    } 
}
