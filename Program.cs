using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[6];

            Console.WriteLine("Vnesi go prviot Broj");
            arrayOne[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi go Vtoriot broj");
            arrayOne[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi go Tretijot broj");
            arrayOne[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi go Cetvrtiot broj");
            arrayOne[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi go Petiot Broj");
            arrayOne[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi go sestiot broj");
            arrayOne[5] = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] % 2 == 0)
                {
                    sum += arrayOne[i];

                }


            }
            Console.WriteLine(sum);


        }
    }
}
