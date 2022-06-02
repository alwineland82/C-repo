using System;
using static System.Console;

class Program {
  public static void Main (string[] args) 
  {
    int[,] x = Generator(2, 3);
    DisplayArray(x);
    WriteLine();
    int[,] y = Generator(3, 2);
    DisplayArray(y);
    WriteLine();
    DisplayArray(MatrixMultiplier(x, y));
    


  }
//__________________________________________________________________________
  static int[,] MatrixMultiplier(int[,] matrix1, int[,] matrix2)
  {
    int[,] result = new int[Math.Max(matrix1.GetLength(0), matrix2.GetLength(0)), 
                            Math.Max(matrix1.GetLength(1), matrix2.GetLength(1))];
    if(matrix1.GetLength(0) != matrix2.GetLength(1))
    {
      throw new IndexOutOfRangeException("Matrices do not fit!");
    }
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
      for(int j = 0; j < matrix2.GetLength(1); j++)
      {
        for(int q = 0; q < matrix1.GetLength(1); q++)
        {
          result[i, j] += matrix1[i, q] * matrix2[q, j];
        }
      }
    } 
    return result;
  }
  
//___________________________________________________________________________
   static int[,] Generator(int m, int n)
  { 
     int[,] result = new int[m, n];
      Random rand = new Random();
      for(int i = 0; i < m; i++)
      {
          for(int j = 0; j < n; j++)
          {
              result[i, j] = rand.Next(1, 10);
          }
      }return result;
  }
  static void DisplayArray(int[,] arr)
  {
      int counter = 0;
      foreach(var i in arr)
      {
          Write(i + "   ");
          counter++;
          if(counter == arr.GetLength(1)) {WriteLine(); counter = 0;}
      }
  }
}
