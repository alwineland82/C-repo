int Greater_Digit(int num)
{
    if (num / 10 > num % 10)
    {
        return num / 10;
    }else
    {
        return num % 10;
    }
}
int x = new Random().Next(10, 99);
Console.WriteLine(x);
Console.WriteLine(Greater_Digit(x));
