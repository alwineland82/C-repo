using System;
using static System.Console;
using System.Linq;

int[] Massive12()
{
    int[] arr = new int[12];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-9, 10);
        Write(arr[i] + " | ");
    }WriteLine();
    int[] res = {arr.Where(i => i > 0).Sum(),
                 arr.Where(i => i < 0).Sum()};
    return res;
}
int[] x = Massive12();
WriteLine(x[0]);
WriteLine(x[1]);

