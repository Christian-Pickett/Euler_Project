/*https://projecteuler.net/problem=9
Special Pythagorean triplet
Problem 9

A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a^2 + b^2 = c^2

For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.*/

using System;

class Program {
	public static void Main() {

		bool found = false;
		
		//Use the fact that the three factors must all be less than 500, because 500 * 2 = 1000.
		for (int a = 0; a <= 499; a++) {
			if(found)
				break;
			for (int b = 0; b <= 499; b++) {
				if(found)
					break;
				for (int c = 0; c <= 499; c++) {
					if(found)
						break;
					if (a + b + c == 1000) {
						if ((a*a) + (b*b) == (c*c)) {
							Console.Write("a = " + a.ToString() + " b = " + b.ToString() + " c = " + c.ToString() + "\n");
							found = true;
							//Answer: a = 200, b = 375, c = 425		
						}
					}
				}
			}
		}
	}		
}
