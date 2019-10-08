using System;
using System.IO;

class Program {
    
    static int[,] aGrid = new int[20,20];
    
    static string stringReader;
    
    static string[] stringArray;
    
    static int LargestProduct = 0;
    
    static int product;
    
    public static void Main() {
        using (StreamReader fileReader = File.OpenText("/home/christian/Documents/CS/Programs/Euler/prob11.txt"))
        while (!fileReader.EndOfStream) {
            for (int i = 0; (i <= 19); i++) {
                stringReader = fileReader.ReadLine();
                stringArray = stringReader.Split(null);
                for (int j = 0; (j <= 19); j++) {
                    aGrid[i, j] = int.Parse(stringArray[j]);
                }   
            }
        }

        for (int i = 0; (i <= 16); i++) {
            // Down right diagonal
            for (int j = 0; (j <= 16); j++) {
                product = (aGrid[i, j] 
                            * (aGrid[(i + 1), (j + 1)] 
                            * (aGrid[(i + 2), (j + 2)] * aGrid[(i + 3), (j + 3)])));
                if (product > LargestProduct) {
                    LargestProduct = product;
                }   
            }

            // Down left diagonal
            for (int j = 3; (j <= 19); j++) {
                product = (aGrid[i, j] 
                            * (aGrid[(i + 1), (j - 1)] 
                            * (aGrid[(i + 2), (j - 2)] * aGrid[(i + 3), (j - 3)])));
                if (product > LargestProduct) {
                    LargestProduct = product;
                }
            }

            // Vertical
            for (int j = 0; (j <= 19); j++) {
                product = (aGrid[i, j] 
                            * (aGrid[(i + 1), j] 
                            * (aGrid[(i + 2), j] * aGrid[(i + 3), j])));
                if (product > LargestProduct) {
                    LargestProduct = product;
                }   
            }

            // Horizontal
            for (int j = 0; (j <= 16); j++) {
                product = (aGrid[i, j] 
                            * (aGrid[i, (j + 1)] 
                            * (aGrid[i, (j + 2)] * aGrid[i, (j + 3)])));
                if (product > LargestProduct) {
                    LargestProduct = product;
                }       
            }
        }

        // Finish Horizontal
        for (int i = 17; (i <= 19); i++) {
            for (int j = 0; (j <= 16); j++) {
                product = (aGrid[i, j] 
                            * (aGrid[i, (j + 1)] 
                            * (aGrid[i, (j + 2)] * aGrid[i, (j + 3)])));
                if (product > LargestProduct) {
                    LargestProduct = product;
                }   
            }      
        }

        Console.Write(LargestProduct + "\n");
	//Answer: 70600674
    }
}
