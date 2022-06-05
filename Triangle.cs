using static System.Console;

class Program {

  public static void Main (string[] args) 
  {
    int[][] x = new int[10][];
    for(int i = 0; i < 10; i++){x[i] = new int[i + 1];}
    for(int i = 0; i < 10; i++)
    {
      for(int j = 0; j < i + 1; j++)
      {
        if(j == 0) { x[i][0] = 1; }
        else if(j == i) { x[i][^1] = 1; }
        else { x[i][j] = x[i-1][j - 1] + x[i - 1][j]; } 
      }
    }
    foreach(var i in x)
    {
      foreach(var j in i)
      {
        Write(j + " ");
      }WriteLine();
    }
