using System;

int Powering(int A, int B)
{
    int result = A;
    for(int i = 1 ; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.WriteLine(Powering(4, 3));