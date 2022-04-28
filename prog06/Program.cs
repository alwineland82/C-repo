char Greater_Digit(string num)
{
    if (Convert.ToInt32(num[0]) > Convert.ToInt32(num[1]))
    {
        return num[0];
    }else
    {
        return num[1];
    }
}
string x = Console.ReadLine();
Console.WriteLine(Greater_Digit(x));
