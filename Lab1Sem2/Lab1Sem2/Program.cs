using System;

namespace Lab1Sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("'First' ");
            Console.ResetColor();
            Console.Write("or ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("'Second' ");
            Console.ResetColor();
            Console.Write("question: ");
            switch (Console.ReadLine())
            {
                case "First" :
                    {
                        int Number = 0, Result = 0, Degree = 0;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter the begining number: ");                       
                        Number = Convert.ToInt32(Console.ReadLine());
                        Result = Number;
                        Console.WriteLine("Enter degree for number: ");
                        Degree = Convert.ToInt32(Console.ReadLine());

                        while (Degree != 1)
                        {

                            --Degree;
                            Result *= Number;
                        }
                        Console.WriteLine("Result power is: " + Result);
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    }
                case "Second" :
                    {
                        string NumberN = "50", Temp1, Temp2, Temp3, NumberX;
                        Console.ForegroundColor = ConsoleColor.Red;
                        while (Convert.ToInt32(NumberN) <= 100)
                        {

                            Console.WriteLine("Enter number n > 100: ");
                            NumberN = Console.ReadLine();
                        }
                        Temp1 = NumberN.Substring(0, 1);                        
                        Temp2 = NumberN.Substring(2, NumberN.Length-2);                        
                        Temp3 = NumberN.Substring(1, 1);                        
                        NumberX = Temp1 + Temp2 + Temp3;

                        Console.WriteLine("Result: " + NumberX);
                        Console.ResetColor();

                        Console.ReadKey();
                        break; 
                    }
            }
        }
    }
}