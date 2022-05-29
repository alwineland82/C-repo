// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// x = (b1 - b2)/(k1 - k2)
// y = k2 * x + b2

using System;
using System.Text.RegularExpressions;
using System.Threading;


class Program {
  static void Main() {
//_____________________________________________________________________________
    // Action:
    float x, y;
    Console.WriteLine("Insert 4 numbers to determine coefs:");
    TwoLinesCrossing(Console.ReadLine(), out x, out y);
//_____________________________________________________________________________
  }
 
//*****************************************************************************
  // Function definition 
  static void TwoLinesCrossing(string coef, out float x, out float y) {
    x = 0;
    y = 0;
    Regex regex = new Regex(@"\d+");
    MatchCollection match = regex.Matches(coef);
    try
    {
        if (match.Count < 4)
        {
            throw new Exception("INSUFFICIENT NUMBERS FOUND!");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"{e.Message}");
        Console.Beep();
        Thread.Sleep(100);
        Console.Beep();
        Thread.Sleep(100);
        Console.Beep();
        return;
    }
    x = (float.Parse(match[0].Value) - float.Parse(match[2].Value)) / 
        (float.Parse(match[1].Value) - float.Parse(match[3].Value));
    y = float.Parse(match[3].Value) * x + float.Parse(match[2].Value);
    Console.Write($"Coordinate X = {x}" + "    ");
    Console.Write($"Coordinate Y = {y}");
//___________________________________________________________________________      
  }
}
