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
      int[] Z = program.NumbersParser("56, второй - 23, третьей и четвертой 25, 30, 88, 30");
      Display(Z);


    }
    //*****************************************************************************
    int[] NumbersParser(string text, int expected_qty = 4)
    {
      text += " ";
      string temp = "";
      bool Flag = false;
      int qty = 0;
      int[] result = new int[expected_qty];
      foreach(var i in text)
      {
        if(!"1234567890".Contains(i) && Flag == false){continue;}
        if("1234567890".Contains(i)){temp += i; Flag = true;}
        if(!"1234567890".Contains(i) && Flag == true)
        {
          Flag = false;
          result[qty] = int.Parse(temp);
          temp = "";
          qty++;
        }
        if(qty == expected_qty) return result;
      }WriteLine("Warning! The quantity of numbers is less then expected.\nPlease, check your input.");
      return result;
      
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
