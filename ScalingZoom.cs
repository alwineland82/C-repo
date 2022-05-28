using System;
using System.Text.RegularExpressions;
using System.Threading;
//using System.Linq;


class Program {
  static void Main() {
    //string arg = Console.ReadLine() ?? "";
    Zoom( "(0,0) (2,0) (2,2) (0,2)", "2.8");
  }
//_____________________________________________________________________________ 
//*****************************************************************************
  // Function definition 
  
  static float[,] Zoom(string arg, string change)
  {
    Regex regex = new Regex(@"[0-9]+");
    MatchCollection matches = regex.Matches(arg);
    //----------------------------------------------------------
    float buffer;
    float[,] result = new float[4,2];
    int counterRow = 0, counterColumn = 0;
    string axis = "x";
    Console.WriteLine($"New coordinates scaled by {change} = ");
    //-----------------------------------------------------------
    foreach (Match match in matches)
    {
        if(counterColumn == 1) axis = "y";
        if(counterColumn > 1) counterColumn = 0;
        if(counterColumn == 0) axis = "x";
        buffer = int.Parse(match.Value) * float.Parse(change);
        Console.Write($"{axis} = {buffer}" + "   ");
        if(counterColumn == 1) Console.WriteLine();
        result[counterRow, counterColumn] = buffer;
        if(counterColumn == 1) {counterRow++;}
        counterColumn++;
        
    }
    //------------------------------------------------------------
    Console.Beep();
    Thread.Sleep(100);
    Console.Beep();
    Thread.Sleep(100);
    Console.Beep();
    return result;
  }//___________________________________________________________________________
}
