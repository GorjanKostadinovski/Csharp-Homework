using System;

namespace Vezba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsGOne = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsGTwo = new string[5] { "Zoki", "Mile", "Brus", "Petko", "Vele" };
            Console.WriteLine("Odberi grupa 1 ili 2");
            string gChoice = Console.ReadLine();
            bool choiceParssed = int.TryParse(gChoice, out int chosenNum);
            
            if (choiceParssed)
            {
                switch (chosenNum)
                {
                    case 1:
                        Console.WriteLine($"The students in G1 are:\n{studentsGOne[0]}\n{studentsGOne[1]}\n{studentsGOne[2]}\n{studentsGOne[3]}\n{studentsGOne[4]}");
                        break;
                    case 2:
                        Console.WriteLine($"The students in G1 are:\n{studentsGTwo[0]}\n{studentsGTwo[1]}\n{studentsGTwo[2]}\n{studentsGTwo[3]}\n{studentsGTwo[4]}");
                        break;
                    default:
                        {
                            Console.WriteLine("Vnesovte pogresen broj");
                        }
                        break;


                }
            }
            else
            {
                Console.WriteLine("Invali Input");
            }
        }
    }
}
