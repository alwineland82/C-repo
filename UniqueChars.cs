//Посчитать количество различных знаков в тексте, количество в процентах.


using System;
using static System.Console;
using System.Linq;

class Program {
  public static void Main (string[] args) 
  {
    string x = "aaaaaaaaaaabbbbbbbbbbbbbbccccccccccccccccccyyyyyyyyyyyyyyy";
    var res = Unique(x);
    var numbersAndchars = res.Item1.Zip(res.Item2, (n, character) => new {  character , n  });
    foreach(var i in numbersAndchars)
    {
        Console.WriteLine($"{Persantage(x, i.n)} % of chars in text = '{i.character}'" );
  } 
  //****************************************************************************
  static (int[], string) Unique(string str)
  {
      int[] result = new int[Counter(str)];
      int index = 0;
      string check = String.Empty;
      foreach(var i in str)
      {
          if(Contains(check, i)){continue;}
          foreach(var j in str)
          {
            if(i == j)
            {
                result[index]++;
            }
          }check += i;
          index++;
      }
      return (result, check);
  }
  //****************************************************************************
  static int Counter(string str)
  {
      string check = String.Empty;
      foreach(var i in str)
      {
          if(Contains(check, i)){continue;}
          else{check+= i;}
      }
      return check.Length;
  }
  //____________________________________________________________________________
  static bool Contains(string str, char c)
  {
      foreach(var i in str)
      {
          if(c == i){return true;}
      }return false;
  }
  //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  static double Persantage(string str, int num)
  {
      double pers = Math.Round(100 / (double)str.Length * num, 2); 
      return pers;
  }
}  
