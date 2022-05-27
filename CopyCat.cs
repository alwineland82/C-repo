using System;
using System.Linq;

class Program {
  static void Main() {
      float[] x = {1, 2, 3};
      float[] y = CopyCat(x);
      x[0] = 100;
      foreach(var i in x) Console.WriteLine(i);
      foreach(var i in y) Console.WriteLine(i);
  }
  static int[] CopyCat(int[] arg) => (from i in arg select i).ToArray();
  static string[] CopyCat(string[] arg) => (from i in arg select i).ToArray();
  static float[] CopyCat(float[] arg) => (from i in arg select i).ToArray();
  static double[] CopyCat(double[] arg) => (from i in arg select i).ToArray();
  static char[] CopyCat(char[] arg) => (from i in arg select i).ToArray();
  static long[] CopyCat(long[] arg) => (from i in arg select i).ToArray();
  static decimal[] CopyCat(decimal[] arg) => (from i in arg select i).ToArray();
  
}
