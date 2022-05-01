int Second_Number(int num)
{
    return num / 100 * 10 + num % 10 ;
}
int x = int.Parse(Console.ReadLine());
Console.WriteLine(Second_Number(x));
