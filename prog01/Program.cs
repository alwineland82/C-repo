string IsItPower(int num1, int num2)
{
    if(Math.Pow(num2, 2) == num1)
    {
        return "YEEEES";
    } else
    {
        return "NOOOOO";
    }
}
Console.WriteLine(IsItPower(9, 3));
