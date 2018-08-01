/*Names scores - Problem 22
https://projecteuler.net/problem=22

Problem Description:
Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand 'first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each 'name, multiply this value by its alphabetical position in the list to obtain a name score.
For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = '53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
What is the total of all the name scores in the file?*/

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualBasic;

static class Module1
{
    private static List<string> NameList = new List<string>();
    private static int sum, WordSum;
    private static string Filename = @"/home/christian/Documents/CS/Programs/Euler/txt/Names.txt"; // insert real path here
    private static System.IO.StreamReader sr;
    private static string aLine;
    private static string[] LineArray;
    private static byte[] encodedBytes;

    public static void Main()
    {
        if (System.IO.File.Exists(Filename))
        {
            sr = new System.IO.StreamReader(Filename);

            while (sr.Peek() > 0)
            {
		aLine = sr.ReadLine();
	    	aLine = aLine.Replace("\"", "");
                LineArray = aLine.Split(',');
                foreach (string item in LineArray)
                    NameList.Add(item);
            }

            NameList.Sort();
	    sum = 0;

            for (int i = 0; i <= NameList.Count - 1; i++)
            {
                encodedBytes = Encoding.ASCII.GetBytes(NameList[i]);
                
		foreach (byte b in encodedBytes)  {
		    WordSum = 0;
                    WordSum += (b - 64);
                sum += (i + 1) * WordSum;
                }
            }
            Console.Write(System.Convert.ToString(sum) + "\n");
	    //Answer: 871198282
    	}
    }
}

