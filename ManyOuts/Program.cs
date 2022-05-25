using System;

void mymethod(int num, out int param1, out string param2)
{
    param1 = 10 + num;
    param2 = (20 + num).ToString();
}

int x;
string y;

mymethod(40, out x, out y);
Console.WriteLine(x);
Console.WriteLine(y);
