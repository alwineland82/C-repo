using System;

int Sum_of_Nums(int num)
{
    int result = 0;
    for(int i = 1; i < num + 1; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine(Sum_of_Nums(3));