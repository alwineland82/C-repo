string Weekday(int num){
    num--;
    string[] days = {"Monday", "Tuesday", "Wendnesday", 
                  "Thursday", "Friday", "Saturday", "Sunday"};
    return days[num];               
} 

int num = int.Parse(Console.ReadLine());
Console.WriteLine(Weekday(num));
