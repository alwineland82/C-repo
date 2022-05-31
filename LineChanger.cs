//Написать программу, которая обменивает элементы первой строки и последней строки

using System;
using static System.Console;


class ArrayArray {
  static void Main() {
    int[,] x = Generator(3, 3);
    DisplayArray(x);
    WriteLine();
    LineChanger(x);
    DisplayArray(x);
    
    
  }
//*****************************************************************************
  static void LineChanger(int[,] arr)
  {
      for(int i = 0; i < arr.GetLength(1); i++)
      {
          int buffer = arr[0, i];
          arr[0, i] = arr[arr.GetLength(0) - 1, i];
          arr[arr.GetLength(0) - 1, i] = buffer;
      }
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
