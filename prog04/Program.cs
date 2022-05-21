void Even_Numbers(int number)
{
    for(int i = 2; i <= number; i += 2)
    {
        Console.Write(i);
        Console.Write(" ");
    }
}
int x = int.Parse(Console.ReadLine() ?? "");
Even_Numbers(x);
