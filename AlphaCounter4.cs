using System;
using static System.Console;
using  System.IO;

class Program 
{
  char letter;
  int qty;
  static int total;
  static int dif;
  string abc = ""abcdefghjkilmnopqrstxywz";
  
  public static void Main (string[] args) 
  {
    var path = Path.Combine(Environment.CurrentDirectory, args[0]);
    var lines = File.ReadAllLines(path);
    string text = String.Empty;
    foreach(var i in lines){text += i;}
    var result = AlphaCounter(text);
    foreach(var i in result)
    {
      WriteLine($"{Persantage(i.qty)} % = {i.letter} ({i.qty})");
    }
  } 
  //****************************************************************************
  static Program[] AlphaCounter(string str)
  {
      str = AlphaFilter(str.ToLower());
      Program[] res = new Program[dif];
      for(int i = 0; i < dif; i++)
      {
        res[i] = new Program{letter = ' ', qty = 0};
      }
      int index = 0;
      foreach(var i in str)
      {
          if(Contains(res, i)){continue;}
          foreach(var j in str)
          {
            if(i == j)
            {
                res[index].qty++;
            }
          }res[index].letter = i;
          index++;
      }
      return (res);
  }
  //****************************************************************************
 
  //____________________________________________________________________________
  static bool Contains(Program[] arr, char c)
  {
      foreach(var i in arr)
      {
          if(i.letter == c){return true;}
      }return false;
  }
  static bool Contains(string str, char c)
  {
      foreach(var i in str)
      {
          if(c == i){return true;}
      }return false;
  }
  //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  static double Persantage(int num)
  {
      return Math.Round(100 / (double)total * num, 2); 
  }
  //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  static string AlphaFilter(string str)
  {
    string check = String.Empty;
    string result = String.Empty;
    foreach(var i in str)
    {
      if(Contains(abc, i)){total++; result += i; if(!Contains(check, i)){check += i;}}
    }
    dif = check.Length;
    return result;
  }
}  
