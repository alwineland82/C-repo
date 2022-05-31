using System;
using static System.Console;


class Program {
  static void Main() {
    Program program = new Program();
    int[,] x = Generator(2, 3);
    DisplayArray(x);
    WriteLine();
    x = program.ColumnsBecomeRows(x);
    DisplayArray(x);
  }
//*****************************************************************************
  int[,] ColumnsBecomeRows(int[,] arr)
  {
    if(arr.GetLength(0) != arr.GetLength(1)){WriteLine("Matrix is not square! " + 
                                                       "Transformation failed."); return arr;}  
    int[,] result = new int[arr.GetLength(0), arr.GetLength(0)];
      for(int i = 0; i < arr.GetLength(0); i++)
      {
          for(int j = 0; j < arr.GetLength(1); j++)
          {
              result[i, j] = arr[j, i];
              
          }
      }return result;
  }
//********************************************************************************
  static int[,] Generator(int m, int n)
  {
      int[,] result = new int[m, n];
      int counter = 1;
      for(int i = 0; i < m; i++)
      {
          for(int j = 0; j < n; j++)
          {
              result[i, j] = counter;
              counter++;
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
