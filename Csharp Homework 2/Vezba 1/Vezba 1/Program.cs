using System;

namespace Vezba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Vnesi broj");
                string num = Console.ReadLine();
                bool checkParrsed = int.TryParse(num, out int convertedNum);
                if (checkParrsed)
                {
                    arrayOne[i] = convertedNum;
                }
                else
                {
                    Console.WriteLine("Vnesovte Pogrsen broj ptobaj povtorno");
                    i--;
                }
            }


            int sumEven = 0;
            foreach (int i in arrayOne)
            {
                if(i % 2 == 0)
                {
                    sumEven += i;
                }
            }
            Console.WriteLine("\n Sumata na parnite broevi na nizata e " + sumEven);

        }
    }
}
