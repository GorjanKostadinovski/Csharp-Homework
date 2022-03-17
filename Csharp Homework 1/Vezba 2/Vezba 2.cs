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

            double.TryParse(numOne,out double firstNum);
            double.TryParse(numTwo,out double secondNum);
            double.TryParse(numThree,out double thirdNum);
            double.TryParse(numFour,out double fourthNum);

            double result = (firstNum + secondNum + thirdNum + fourthNum) / 4;
            Console.WriteLine(result);
        }
    }
}
