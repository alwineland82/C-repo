using System;

int CountDigits(int num)
{
    int counter = 0;
    while(num != 0){num /= 10; counter += 1;} return counter;
}

Console.WriteLine(CountDigits(100));
