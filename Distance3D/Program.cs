using System;

namespace Distance3D
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 3 coordinates for the first point.\nUse 'space' in between the numbers" + 
            "\nEnter only 2 coordinates, if you want 2D points calculation.");
            var firstpoint = (Console.ReadLine() ?? "0").Split(' ');
            double x1 = Convert.ToDouble(firstpoint[0]);
            double y1 = Convert.ToDouble(firstpoint[1]);
            double z1 = 0;
            try
            {
                z1 = Convert.ToDouble(firstpoint[2]);
            }
            catch (Exception){}
            Console.WriteLine("Please, enter 3 coordinates for the second point.\nUse 'space' in between the numbers." + 
            "\nEnter only 2 coordinates, if you want 2D points calculation.");
            var secondpoint = (Console.ReadLine() ?? "0").Split(' ');
            double x2 = Convert.ToDouble(secondpoint[0]);
            double y2 = Convert.ToDouble(secondpoint[1]);
            double z2 = 0;
            try
            {
                z2 = Convert.ToDouble(secondpoint[2]);
            }
            catch (Exception){}
            Point one = new (x1, y1, z1);
            Point two = new (x2, y2, z2);
            Console.WriteLine($"Distance between 2 points = {two.Distance(one)}");
        }
    
    }
}

