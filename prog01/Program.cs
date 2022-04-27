float x = float.Parse(Console.ReadLine()), y = float.Parse(Console.ReadLine());
string[] reply = new string[2];
reply = new[] {"NO", "YES"};
Console.WriteLine(reply[Convert.ToInt32(y == x / y)]); 