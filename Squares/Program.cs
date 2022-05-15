using System;

namespace Squares
{
    class Program
    {
        static void Main()
        {
            bool IsSquare(float num1, float num2)
            {
                if(num1 / num2 == num2){return true;}
                else if(num2 / num1 == num1){return true;}
                else{return false;}
            }
            Console.WriteLine(IsSquare(9, 6));

        }
    }
}

