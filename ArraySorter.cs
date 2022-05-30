//Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива.

using System;
using static System.Console;


class ArrayArray {
  static void Main() {
    
    int[,] x = Generator(7, 3);
    DisplayArray(x);
    WriteLine();
    x = ArraySorter(x);
    DisplayArray(x);
  }
//*****************************************************************************
 static int[,] ArraySorter(int[,] arr, int index = 0)
 {
     int temp;
     if(index == arr.GetLength(0))
     {
         return arr;
     }
     for(int i = 0; i < arr.GetLength(1); i++)
     {
         for(int j = 0; j < arr.GetLength(1) - 1; j++)
         {
             if(arr[index, j] < arr[index, j + 1])
             {
                 temp = arr[index, j];
                 arr[index, j] = arr[index, j + 1];
                 arr[index, j + 1] = temp;
             }
         }
     }index++;
     return ArraySorter(arr, index);
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
