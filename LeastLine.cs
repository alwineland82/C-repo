//В прямоугольной матрице найти строку с наименьшей суммой элементов.

using System;
using static System.Console;


class Program {
  static void Main() {
    Program program = new Program();
    int[,] x = Generator(6, 4);
    DisplayArray(x);
    WriteLine();

    MinorLine(x);
  }
//___________________________________________________________________________________
  static void MinorLine(int[,] arr)
  {
      int counter = 0;
      int line_number = 0;
      int Min_Line = 0;
      double min = double.PositiveInfinity;
      int temp_min = 0;
      foreach(var i in arr)
      {
          counter++;
          temp_min += i;
          if(counter == arr.GetLength(1)) 
          {
            if(temp_min < min) {min = temp_min; Min_Line = line_number;}
            counter = 0; 
            line_number++;
            temp_min = 0;
          }
      }WriteLine($"Line {Min_Line + 1}");
  }
//______________________________________________________________________________________
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
