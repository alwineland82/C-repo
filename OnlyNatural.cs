using System;
class Program {
  static void Main() 
  {
    Natural one = new Natural();
    one.Number = 8;
    var ex = one.Range(14);
    foreach(var i in ex)
    {
      Console.WriteLine(i);
    }
  }
}

public class Natural
{
    int num;
    public int Number
    {
      set
    {
      if (value > 0){num = value;}
      else{Console.WriteLine("Natural numbers only!");}
    }
    get{return num;}   
    }
  public int[] Range(int x)
  {
    if(x < this.num){Console.WriteLine("Range must be positive!"); return new int[0];}
    int[] arr = new int[(x - this.num) + 1];
    int next = this.num;
    for(var i = 0; i < arr.Length; i++)
    {
      arr[i] = next;
      next++;
    }
    return arr;
  }
}
