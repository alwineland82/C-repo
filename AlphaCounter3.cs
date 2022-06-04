using System;
using static System.Console;


class Program {
  public static void Main (string[] args) 
  {
    
    string text = args[0];
    var res = AlphaCounter(text);
    for(int i = 0; i < res.Item2.Length; i++)
    {
        Console.WriteLine($"{Persantage(res.Item3, res.Item1[i])} % of chars = {res.Item2[i]}"); 
    } 
  } 
  //****************************************************************************
  static (int[], string, int) AlphaCounter(string str)
  {
      str = AlphaFilter(str.ToLower());
      int[] qtyOfChars = new int[Counter(str)];
      int index = 0;
      string listOfchars = String.Empty;
      int totalCountofChars = 0;
      foreach(var i in str)
      {
          totalCountofChars++;
          if(Contains(listOfchars, i)){continue;}
          foreach(var j in str)
          {
            if(i == j)
            {
                qtyOfChars[index]++;
            }
          }listOfchars += i;
          index++;
      }
      return (qtyOfChars, listOfchars, totalCountofChars);
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
  static double Persantage(int qty, int num)
  {
      return Math.Round(100 / (double)qty * num, 2); 
  }
  //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  static string AlphaFilter(string str)
  {
    string result = String.Empty;
    foreach(var i in str)
    {
      if(Contains("abcdefghjkilmnopqrstxywz", i)){result += i;}
    }
     
    return result;
  }
}  
