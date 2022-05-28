using System;

class Program {
  static void Main() {
    int[,] x = {{1, 2}, {3, 4}, {5, 6}, {7, 8}};
    Zoom(x, 2);
    }
//_____________________________________________________________________________ 
//*****************************************************************************
  // Function definition 
  
  static void Zoom(int[,] args, float change, int index = 0)
  {
     if(index == args.GetLength(0) - 1) 
     {
         Console.WriteLine($"Coordinate x = {args[index, 0] * change}");
         Console.WriteLine($"Coordinate y = {args[index, 1] * change}");
     }
     else 
     {
         Console.WriteLine($"Coordinate x = {args[index, 0] * change}"); 
         Console.WriteLine($"Coordinate y = {args[index, 1] * change}");
         index++;
         Zoom(args, change, index);
     }
  }
}
