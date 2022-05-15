using System;

namespace DaysOff;

class Program
{
    static void Main()
    {
        void Day(int number)
        {
            while( number < 1 || number > 7){
                Console.WriteLine("Insert valid number");
                int.TryParse(Console.ReadLine() ?? "0", out number);}
            var dayz = new Dictionary<int, string> {
                        {1, "Working day"},
                        {2, "Working day"},
                        {3, "Working day"},
                        {4, "Working day"},
                        {5, "Working day"},
                        {6, "Day-off"},
                        {7, "Day-off"},};
            Console.WriteLine(dayz[number]);}
        int.TryParse(Console.ReadLine() ?? "0", out int day);
        Day(day);    
    }
}