using System;
using static System.Console;
using System.Linq;

int[] Massive21()
{
    int[] arr = new int[21];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
        Write(arr[i] + " | ");
    }WriteLine();
    int[] res = {arr.Where(i => i % 2 == 0).Count(),
                 arr.Where(i => i % 2 != 0).Count()};
    return res;
}
int[] x = Massive21();
WriteLine(x[0]);
WriteLine(x[1]);

