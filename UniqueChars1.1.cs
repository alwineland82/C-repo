using System;
using static System.Console;


class Program {
  public static void Main (string[] args) 
  {
      
    string text = @"Блин. Подъезды, конопля, водка без закуски, постоянная дача, пот, комары, картошка в мешках. Наше поколение более приспособлено к тому, что нас ждёт. Может поэтому среди нас не так много людей, кто против СВО.";
    var res = Unique(text);
    for(int i = 0; i < res.Item2.Length; i++)
    {
        Console.WriteLine($"{Persantage(res.Item3, res.Item1[i])} % of chars = {res.Item2[i]}"); 
    }
    
    
  } 
  //****************************************************************************
  static (int[], string, int) Unique(string str)
  {
      int[] result = new int[Counter(str)];
      int index = 0;
      str = str.ToLower();
      string check = String.Empty;
      int count = 0;
      foreach(var i in str)
      {
          if(!Contains(",.-;'!?/()»>«<|][}{=+\"\n\t , i))", i)){count++;}
          if(Contains(check, i) || Contains(",.-;'!?/()»>«<|][}{=+\"\n\t , i))", i)){continue;}
          foreach(var j in str)
          {
            if(i == j)
            {
                result[index]++;
            }
          }check += i;
          index++;
      }
      return (result, check, count);
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
}  
