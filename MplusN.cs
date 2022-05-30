using System;
using static System.Console;


class ArrayArray {
  static void Main() {
    DisplayArray(MplusN(3, 4));
    
  }
  static int[,] MplusN(int m, int n)
  {
      int[,] result = new int[m, n];
      for(int i = 0; i < m; i++)
      {
          for(int j = 0; j < n; j++)
          {
              result[i, j] = m + n;
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
