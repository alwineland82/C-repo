using System;

Console.WriteLine("Insert values for x & y coordinates to know the quarter they belong to.");
int x = int.Parse(Console.ReadLine() ?? "0");
int y = int.Parse(Console.ReadLine() ?? "0");

Quarter one = new(x, y);
Console.WriteLine($"The above coordinates belong to quarter: {one.quarterNumber}");
