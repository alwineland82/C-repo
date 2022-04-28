string Is_Divisor(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        return $"{num1} is dividable by {num2}";
    } else
    {
        return $"{num1} is not dividable by {num2}, the remainder is {num1 % num2}";
    }
}
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
Console.WriteLine(Is_Divisor(x, y));
