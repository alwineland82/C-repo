using System;
using static System.Console;

class Program {
  public static void Main (string[] args) 
  {
    int[,] x = Generator(7, 7);
    DisplayArray(x);
    WriteLine();
    DisplayArray(MinNumberColumnLineDeleter(x));
  }
//__________________________________________________________________________
  static int[,] MinNumberColumnLineDeleter(int[,] array)
  {            // Finds the min number and is location.
      int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
      var minLine = (0, 0);
      int min = int.MaxValue;
      for(int i = 0; i < array.GetLength(0); i++)
      {
          for(int j = 0; j < array.GetLength(1); j++)
          {
              if(array[i, j] < min){min = array[i, j]; minLine = (i, j);}
          }
      }
             // Removes lines and columns from resulting matrix.
      var index = (0, 0);
      for(int i = 0; i < array.GetLength(0); i++)
      {
          if(minLine.Item1 == i){continue;}
          for(int j = 0; j < array.GetLength(1); j++)
          {
            if(minLine.Item2 == j){continue;}
            else{result[index.Item1, index.Item2] = array[i, j]; index.Item2++;}
          } 
          index.Item2 = 0;
          index.Item1++;
      }   
      return result;
  }
//___________________________________________________________________________
   static int[,] Generator(int m, int n)
  { 
      int[] used = new int[m * n];
      int index = 0;
      int[,] result = new int[m, n];
      Random rand = new Random();
      int randNum = rand.Next(10, 99);
      for(int i = 0; i < m; i++)
      {
          for(int j = 0; j < n; j++)
          {
              while(UniqueChecker(used, randNum))
              {
                randNum = rand.Next(10, 99);
              }  
              result[i, j] = randNum;
              used[index] = randNum;
              index++;
          }
      }return result;
  }
 //__________________________________________________________________________
  // Provides unique numbers for matrix generator.
  static bool UniqueChecker(int[] array, int num)
  {   
      for(var i = 0; i < array.Length; i++)
      {
          if(array[i] == num){return true;}
      }return false;
  }
 //_________________________________________________________________________ 
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
