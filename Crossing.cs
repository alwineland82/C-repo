// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// x = (b1 - b2)/(k1 - k2)
// y = k2 * x + b2

using System;
using System.Text.RegularExpressions;
using System.Threading;
using  static System.Console;


class Program {
  static void Main() {
//_____________________________________________________________________________
    // Action:
    float x, y;
    WriteLine("Insert 4 numbers to determine coefs:");
    TwoLinesCrossing(ReadLine() ?? "", out x, out y);
    WriteLine(x);
    WriteLine(y);
//_____________________________________________________________________________
  }
 
//*****************************************************************************
  // Function definition 
  static void TwoLinesCrossing(string coef, out float x, out float y) {
    x = 0;
    y = 0;
    Regex regex = new Regex(@"\d+");
    MatchCollection match = regex.Matches(coef);
    if (match.Count < 4)
    {
      WriteLine("Not enough numbers to calculate");
      Beep();
      Thread.Sleep(100);
      Beep();
      Thread.Sleep(100);
      Beep();
      TwoLinesCrossing(ReadLine() ?? "", out x, out y);
    }
    try
    {
      x = (float.Parse(match[0].Value) - float.Parse(match[2].Value)) / 
          (float.Parse(match[1].Value) - float.Parse(match[3].Value));
      y = float.Parse(match[3].Value) * x + float.Parse(match[2].Value);
      Write($"Coordinate X = {x}" + "    ");
      Write($"Coordinate Y = {y}\n");
    }
    catch{}
//___________________________________________________________________________      
  }
}
