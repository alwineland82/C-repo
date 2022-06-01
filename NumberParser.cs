//Number parser in text.

using System;
using static System.Console;


class Program
{
    static void Main()
    {
      int[] x = { 1, 2, 3, 4, 5 };
      WriteLine();
      Program program = new Program();
      int[] Z = program.NumbersParser("ыва546крп543р п у цк=78в овп");
      Display(Z);


    }
    //*****************************************************************************
    int[] NumbersParser(string text)
    {
      string temp = "";
      bool Flag = false;
      int qty = 0;
      int[] result = new int[4];
      foreach(var i in text)
      {
        if(!"1234567890".Contains(i) && Flag == false)
        {
          continue;
        }
        if("1234567890".Contains(i))
        {
          temp += i;
          Flag = true;
        }
        if(!"1234567890".Contains(i) && Flag == true)
        {
          Flag = false;
          result[qty] = int.Parse(temp);
          temp = "";
          qty++;
        }
      }return result;
      
    }
    //********************************************************************************
   static void Display(int[] arr)
   {
     foreach(var i in arr) 
     {
       Write(i + "   ");
      
     } WriteLine();
   }
    
  }
