string Weekday(int num){
    num--;
    string[] days = new string[7];
    days = new[] {"Monday", "Tuesday", "Wendnesday", 
                  "Thursday", "Friday", "Saturday", "Sunday"};
    return days[num];               
} 

int num = int.Parse(Console.ReadLine());
Console.WriteLine(Weekday(num));