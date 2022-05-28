using System;
using System.Linq;

class Program {
  static void Main() {
      float[] x = {1, 2, 3};
      float[] y = CopyArray(x);
      x[0] = 100;
      foreach(var i in x) Console.WriteLine(i);
      foreach(var i in y) Console.WriteLine(i);
  }
  static int[] CopyArray(int[] arg) => (from i in arg select i).ToArray();
  static string[] CopyArray(string[] arg) => (from i in arg select i).ToArray();
  static float[] CopyArray(float[] arg) => (from i in arg select i).ToArray();
  static double[] CopyArray(double[] arg) => (from i in arg select i).ToArray();
  static char[] CopyArray(char[] arg) => (from i in arg select i).ToArray();
  static long[] CopyArray(long[] arg) => (from i in arg select i).ToArray();
  static decimal[] CopyArray(decimal[] arg) => (from i in arg select i).ToArray();
  
}
