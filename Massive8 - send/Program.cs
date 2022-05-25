using System;
using static System.Console;

int[] Massive8()
{
    int[] arr = new int[8];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
        Write(arr[i] + " ");
    }return arr;
}
int [] x = Massive8();
WriteLine(x);
