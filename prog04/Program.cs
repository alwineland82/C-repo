void Even_Numbers(int number)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
}
int x = int.Parse(Console.ReadLine());
Even_Numbers(x);
