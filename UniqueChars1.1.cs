using System;
using static System.Console;


class Program {
  public static void Main (string[] args) 
  {
      
    string text = @"Nec vi, nec clam, nec praecario. Nemo debet bis puniri pro uno delicto. Nemo inauditus condemnari debet, si non sit contumax.
    Nemo iudex in propria causa. Nemo pluris iuris ad alium transfere potest, quam ipse haberet. Nemo praesens nisi intelligat. 
    Nemo praesumitur malus. Non bis in idem. Non efficit affectus nisi sequatur effectus. Non obligat lex, nisi promulgata. Non omne, quod licet, 
    honestum est. Non progredi est regredi. Non videtur vim facere, qui iure suo utitur. Nullum crimen, nulla poena sine lege.";
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
          if(Contains("abcdefghjkilmnopqrstxywz", i)){count++;}
          if(Contains(check, i) || !Contains("abcdefghjkilmnopqrstxywz", i)){continue;}
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
