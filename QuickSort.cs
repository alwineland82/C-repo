//Quicksort in C#

using System;
using static System.Console;
using System.Linq;

class Program
{
    static void Main()
    {
      int[] array = {2, 5, 7, 3, 6, 8, 3, 4, 7, 6, 8, 3};
      array = QuickSort(array);
      Display(x);
      
    } //*****************************************************************************
    static int[] QuickSort(int[] x)
    {
      if(x.Length > 1)
      {
        var bigger = (from i in x where i > x[^1] select i).ToArray();
        var smaller = (from i in x where i < x[^1] select i).ToArray();
        var equal = (from i in x where i == x[^1] select i).ToArray();
        return Unify(QuickSort(bigger), equal, QuickSort(smaller));
      }else return x;
    }
    //********************************************************************************
   static void Display(int[] array)
   {foreach(var i in array) {Write(i + "   ");} WriteLine();}
//______________________________________________________________________________________
   static int[] Unify (int[] a, int[] b, int[] c)
   {
     int[] sum = new int[a.Length + b.Length + c.Length];
     for(int i = 0; i < a.Length; i++)
        sum[i] = a[i];
     for(int j = 0; j < b.Length; j++)
        sum[a.Length + j] = b[j];
     for(int k = 0; k < c.Length; k++)
        sum[a.Length + b.Length + k] = c[k];
     return sum;
   }
   
}

