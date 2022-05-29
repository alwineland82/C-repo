using System;

void TableOfNumbers(int num, string power)
{
    
    int Foo1(int num) => num * num;
    int Foo2(int num) => num * num * num;
    var Func = Foo1;
    string pow = String.Empty;
    if(power == "2") {Func = Foo1; pow = "\xB2";}
    if(power == "3") {Func = Foo2; pow = "\xB3";}
    int WidthOfCell = (Func(num)).ToString().Length + num.ToString().Length + 4;
    int NumberOfCells = (Console.WindowWidth - 45) / WidthOfCell;
    int counter_of_cells = 0;
    Console.WriteLine(LineWriter(Console.WindowWidth, "*"));
    Console.Write("|");
    for(int i = 1; i < num + 1; i++)
    {
        Console.Write($" {i}{pow} = {Func(i)}" + LineWriter(WidthOfCell - (Func(i)).ToString().Length - $"{i}\xB2 =".Length) + "|");
        counter_of_cells += 1;
        if(counter_of_cells == NumberOfCells)
        {
            Console.WriteLine();
            Console.Write("|");
            for(int j = 0; j < NumberOfCells; j++)
            {
                Console.Write(LineWriter(WidthOfCell + 2, "_") + "|");
            } 
            Console.WriteLine();
            Console.Write("|");
            for(int j = 0; j < NumberOfCells; j++)
            {
                Console.Write(LineWriter(WidthOfCell + 2, " ") + "|");
            }         
            counter_of_cells = 0; 
            Console.WriteLine();
            if(i != num) Console.Write("|");
            }
    }
    Console.WriteLine();
    Console.WriteLine(LineWriter(Console.WindowWidth, "*"));
    Console.WriteLine();
}
//-----------------------------------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("Please, insert any number from 1 to 46340.");
int input = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Please, specify if you want power of 2 or power of 3");  // User interface 
string Power = Console.ReadLine() ?? "";
TableOfNumbers(input, Power);
//______________________________________________________________________________________________________________
string LineWriter(int num, string sign = " ")
{                                         /* Small function to print lines between rows */
    string res = String.Empty;              
    for(int i = 0; i < num; i++)
    {                                   
        res += sign;
    }
    return res;
}
//______________________________________________________________________________________________________________
