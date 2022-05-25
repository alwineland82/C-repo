using System;
using static System.Console;

void Pairs(int[] arr)
{
    for(int i = 0, j = 1; i < arr.Length / 2; i++, j++)
    {
        Write(arr[i] + arr[^j] + " | ");
    }
}

int[] array = {1, 2, 3, 4, 5, 6, 4};
Pairs(array);