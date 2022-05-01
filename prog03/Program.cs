void IsEven(int num)
{
    if(num % 2 == 0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
int num = int.Parse(Console.ReadLine());
IsEven(num);
