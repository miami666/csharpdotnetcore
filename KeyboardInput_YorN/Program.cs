using System;
namespace KeyboardInput_YorN
{
    class Program
    {
        static void Main(string[] args)
        {
            
                 
            bool response = GetYorN();
            do {
                Console.WriteLine("hellooo");
            }while(Console.ReadKey().Key
            != ConsoleKey.Y);                    
        }
        static bool GetYorN()
        {
            ConsoleKey response;
             do
            {
                while (Console.KeyAvailable) 
                    Console.ReadKey();
 
                Console.Write("Y or N? "); 
                response = Console.ReadKey().Key;
                Console.WriteLine();
            } while (response != ConsoleKey.Y && response != ConsoleKey.N); 
            return response == ConsoleKey.Y;
        }
    }
}
