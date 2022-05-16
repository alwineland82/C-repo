using System;

Console.WriteLine("Insert values for the quarter # from 1 to 4");
int x = int.Parse(Console.ReadLine() ?? "0");
Quarter one = new(x);
Console.WriteLine($"The range of available coordinates for this quarter is {one.range}");
