using System;

namespace Vezba_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi Go A");
            string numOne = Console.ReadLine();
            bool numOneParssed = int.TryParse(numOne, out int firstNum);
            if (!numOneParssed)
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Vnesi go B");
            string numTwo = Console.ReadLine();
          
            bool numTwoParssed = int.TryParse(numTwo, out int secondNum);
        
            if (!numTwoParssed)
            {
                Console.WriteLine("Invalid Input");
            }
           
            
                int extraVar = firstNum;
              
                firstNum = secondNum;
                secondNum = extraVar;
                Console.WriteLine($"A= {firstNum}");
                Console.WriteLine($"B= {secondNum}");
            
            
        }
    }
}
