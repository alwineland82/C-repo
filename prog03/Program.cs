void Even(int num)
{
    string[] reply = {"NO", "YES"};
    Console.WriteLine(reply[Convert.ToInt32(num % 2 == 0)]);
}
int num = int.Parse(Console.ReadLine());
Even(num);
