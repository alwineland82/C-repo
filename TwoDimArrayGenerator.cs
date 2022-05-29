//Показать двумерный массив размером m×n заполненный вещественными числами

using System;
using  static System.Console;


class Program {
  static void Main() {
//_____________________________________________________________________________
    // Action:
    var x = TwoDimArrayGenerator(4, 6);
    DisplayArray(x);
    
//_____________________________________________________________________________
  }
 
//*****************************************************************************
  // Function definition 
  static double[,] TwoDimArrayGenerator(int row, int col)
  {
      double[,] result = new double[row, col];
      Random rnd = new Random();
      for(int i = 0; i < row; i++)
      {
          for(int j = 0; j < col; j++)
          {
              result[i, j] = rnd.Next(1, 100) + Math.Round(rnd.NextDouble(), 2);
          }
      }return result;
  }//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  static void DisplayArray(double[,] arr)
  {
      int counter = 0;
      foreach(var i in arr)
      {
          Write(i + "   ");
          counter++;
          if(counter == arr.GetLength(1)) {WriteLine(); counter = 0;}
          
      }
  }
  
//___________________________________________________________________________      
  
}
