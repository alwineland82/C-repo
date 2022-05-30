using System;
using static System.Console;


class ArrayArray {
  static void Main() {
    DisplayArray(MplusN(17, 23));
    
  }
  static int[,] MplusN(int m, int n)
  {
      int[,] result = new int[m, n];
      for(int i = 0; i < m; i++)
      {
          for(int j = 0; j < n; j++)
          {
              result[i, j] = m + n;
              if(i % 2 == 0 && j % 2 == 0) result[i, j] *= result[i, j];
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
