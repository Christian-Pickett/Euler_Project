using System;
using System.IO;

class bigSum {
	public static void Main() {
		double sum = 0;
		string line;  

		// Read the file and display it line by line.  
		System.IO.StreamReader file = new System.IO.StreamReader((@"/home/christian/Documents/CS/Programs/Euler/prob13.txt"));  
		while((line = file.ReadLine()) != null) {
    			sum += Convert.ToDouble(line);
		}  

		file.Close();  

		Console.Write("Final sum: " + sum.ToString() + "\n");
		//Answer: 5537376230
	}
}
