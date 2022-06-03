//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.

using System;
using static System.Console;

class Program {
  public static void Main (string[] args) 
  {
    int[,,] x = Generator(3, 3, 3);
    DisplayArray(x);
    
  }
//*****************************************************************************
  
//*****************************************************************************
   static int[,,] Generator(int m, int n, int o)
  { 
      int[] used = new int[m * n * o];
      int index = 0;
      int[,,] result = new int[m, n, o];
      Random rand = new Random();
      int randNum = rand.Next(10, 99);
      for(int i = 0; i < m; i++)
      {
        for(int j = 0; j < n; j++)
        {
            for(int k = 0; k < o; k++)
            {
                while(UniqueChecker(used, randNum))
                {
                  randNum = rand.Next(10, 99);
                }  
                result[i, j, k] = randNum;
                used[index] = randNum;
                index++;
            }
        }
      }
     return result;
  }
 //__________________________________________________________________________
  
 //__________________________________________________________________________
  static bool UniqueChecker(int[] array, int num)
  {
      for(var i = 0; i < array.Length; i++)
      {
          if(array[i] == num){return true;}
      }return false;
  }
 //_________________________________________________________________________ 
  static void DisplayArray(int[,,] arr)
  {
      for(int i = 0; i < arr.GetLength(0); i++)
      {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                Write($"Index[{i}, {j}, {k}] = {arr[i, j, k].ToString().PadRight(5)}");
            }
            WriteLine();
        }    
      }
}
}
