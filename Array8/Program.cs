using System;

int[] ReturnArray()
{
    int[] x = new int[8];
    Random rnd = new Random();
    for(int i = 0; i < 8; i++)
    {
        x[i] = rnd.Next(0, 2);
        Console.Write(x[i] + " ");
    }return x;   
}

int[] arr = ReturnArray();
Console.WriteLine(arr);
