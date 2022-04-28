string Second_Number(string num)
{
    return Convert.ToString(num[0] + Convert.ToString(num[2]));
}
string x = Console.ReadLine();
Console.WriteLine(Second_Number(x));
