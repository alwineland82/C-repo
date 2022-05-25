using System;
using static System.Console;
using System.Linq;

int Massive123()
{
    int[] arr = new int[123];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 1000);
        Write(arr[i] + " | ");
    }WriteLine();
    int res = arr.Where(i => i > 10 && i < 99).Count();
    return res;
}
int x = Massive123();
WriteLine(x);