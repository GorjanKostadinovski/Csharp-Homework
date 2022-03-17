using System;

namespace Csharp_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = Console.ReadLine();
            var operators = Console.ReadLine();
            var numTwo = Console.ReadLine();
            string operatorCase = operators;
            int.TryParse(numOne,out int numOneInt);
            int.TryParse(numTwo,out int numTwoInt);
            

            switch (operatorCase) {
                case "+":
                    Console.WriteLine(numTwoInt + numTwoInt);
                    break;
                case "-":
                    Console.WriteLine(numOneInt - numTwoInt);
                    break;
                case "*":
                    Console.WriteLine(numOneInt * numTwoInt);
                    break;
                case "/":
                    Console.WriteLine(numOneInt / numTwoInt);
                    break;

                default:
                    Console.WriteLine("Invalid operator input");
                    break;
            }
        }
    }
}
