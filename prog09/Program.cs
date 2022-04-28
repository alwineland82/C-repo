string Third_Number(string num)
{
    if (num.Length >= 3)
    {
        return Convert.ToString(num[2]); 
    }else
    {
        return $"In number {num} there is no third digit";
    }
}
string x = Console.ReadLine();
Console.WriteLine(Third_Number(x));