// Maximum path sum I - Problem 18
// https://projecteuler.net/problem=18
// Problem Description: Find the maximum total from top to bottom of the triangle below.

using System;

static class Program
{
    static int Sum;
    static int[][] jaggedArray = new int[15][];

    public static int Recursive(int x, int y)
    {
        int DownRight = 0;
        int DownLeft = 0;

        if (x == 14)
            DownLeft = jaggedArray[x][y];
        else
            DownLeft += jaggedArray[x][y] + Recursive(x + 1, y);

        if (y == 14 | x == 14)
            DownRight = jaggedArray[x][y];
        else
            DownRight += jaggedArray[x][y] + Recursive(x + 1, y + 1);

        if (DownRight > DownLeft)
            return DownRight;
        else
            return DownLeft;
    }

    public static void Main()
    {
	jaggedArray[0] = new int[] {75};
	jaggedArray[1] = new int[] {95, 64};
	jaggedArray[2] = new int[] {17, 47, 82};
	jaggedArray[3] = new int[] {18, 35, 87, 10};
	jaggedArray[4] = new int[] {20, 04, 82, 47, 65};
	jaggedArray[5] = new int[] {19, 01, 23, 75, 03, 34};
	jaggedArray[6] = new int[] {88, 02, 77, 73, 07, 63, 67};
	jaggedArray[7] = new int[] {99, 65, 04, 28, 06, 16, 70, 92};
	jaggedArray[8] = new int[] {41, 41, 26, 56, 83, 40, 80, 70, 33};
	jaggedArray[9] = new int[] {41, 48, 72, 33, 47, 32, 37, 16, 94, 29};
	jaggedArray[10] = new int[] {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14};
	jaggedArray[11] = new int[] {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57};
	jaggedArray[12] = new int[] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48};
	jaggedArray[13] = new int[] {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31};
	jaggedArray[14] = new int[] {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23};

        Sum = Recursive(0, 0);
        Console.Write(Sum + "\n");
	//Answer: 1074
    }
}

