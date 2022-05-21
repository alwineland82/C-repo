using System;

int OnlyEven(int num)
{
    if(num % 10 % 2 == 0) return num * num * num;
    else {Console.WriteLine("Wrong number"); return 0;}
}
Console.WriteLine(OnlyEven(8));