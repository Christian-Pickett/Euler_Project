/*https://projecteuler.net/problem=30
Digit fifth powers
Problem 30

Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:

    1634 = 1^4 + 6^4 + 3^4 + 4^4
    8208 = 8^4 + 2^4 + 0^4 + 8^4
    9474 = 9^4 + 4^4 + 7^4 + 4^4

As 1 = 1^4 is not a sum it is not included.

The sum of these numbers is 1634 + 8208 + 9474 = 19316.

Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
 */

using System;
using System.Collections.Generic;

class Program {
    public static void Main() {
        string num = "";
    	char[] numCharArray;
        int a = 0,b = 0,c = 0,d = 0,e = 0,f = 0,numSum = 0;
        List<int> pentaNumberList = new List<int>();

        for (int i = 2; i <= 500000; i++) { //I'm not sure how to prove an upper bound for this problem, but after testing 500000 seems to work.
            num = i.ToString();
            numCharArray = num.ToCharArray();
            a = (int)(numCharArray[0] - '0');
            if (numCharArray.Length > 1) {
                b = (int)(numCharArray[1] - '0');

                if (numCharArray.Length > 2) {
                    c = (int)(numCharArray[2] - '0');
                        
                    if (numCharArray.Length > 3) {
                        d = (int)(numCharArray[3] - '0');

                        if (numCharArray.Length > 4) {
                            e = (int)(numCharArray[4] - '0');
            
                            if (numCharArray.Length > 5) {
                                f = (int)(numCharArray[5] - '0');
                            }
                        }
                    }
                }
            }
            
            if ((Math.Pow(a,5) + Math.Pow(b,5) + Math.Pow(c,5) + Math.Pow(d,5) + Math.Pow(e,5) + Math.Pow(f,5)) == i) {
                pentaNumberList.Add(i);
            }
        }

        foreach (int aNumber in pentaNumberList) {
            numSum += aNumber;
        }

        Console.Write(numSum + "\n");
        //Answer: 443839
    }
    
 }
