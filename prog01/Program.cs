float x = float.Parse(Console.ReadLine()), y = float.Parse(Console.ReadLine());
string[] reply = {"NO", "YES"};
Console.WriteLine(reply[Convert.ToInt32(y == x / y)]); 