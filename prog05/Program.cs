int Second_Number(int number)
{
    return number  / 10 % 10;
}
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Second_Number(num));
