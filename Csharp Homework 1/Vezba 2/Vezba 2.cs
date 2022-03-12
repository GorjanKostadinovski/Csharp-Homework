using System;

namespace Vezba_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi Cetiri Broja");
            var numOne = Console.ReadLine();
            var numTwo = Console.ReadLine();
            var numThree = Console.ReadLine();
            var numFour = Console.ReadLine();

            double firstNum = int.Parse(numOne);
            double secondNum = int.Parse(numTwo);
            double thirdNum = int.Parse(numThree);
            double fourthNum = int.Parse(numFour);

            double result = (firstNum + secondNum + thirdNum + fourthNum) / 4;
            Console.WriteLine(result);
        }
    }
}
