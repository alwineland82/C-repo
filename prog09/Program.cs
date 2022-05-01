string Third_Number(string num)
{
    if (num.Length == 3)
    {
        return Convert.ToString(int.Parse(num) / 10 % 10); 
    }else
    {
        return $"In number {num} there is incorrect number of digits";
    }
}
string x = Console.ReadLine();
Console.WriteLine(Third_Number(x));